using Knom.TimeBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlniTimeBoxMiniConsoleApp
{
    class AlniTimeBoxDevice : TimeBoxDevice
    {
        public const int MAX_DIMENSIONS_WIDTH = 11;
        public const int MAX_DIMENSIONS_HEIGHT = 11;

        public static byte[] ConvertColors(Color[][] colors)
        {
            var imageBytes = new List<byte>();
            imageBytes.Add(0);

            int counter = 0;

            bool uneven = true;
            for (int y = 0; y < colors.Length; y++)
            {
                for (int x = 0; x < colors[y].Length; x++)
                {
                    // get the color of the particular pixel of the image
                    var color = colors[y][x];

                    // Alpha channel < 32 --> drawn as black - "transparent"
                    if (color.A < 32)
                        color = Color.Black;

                    // Encode even / uneven differently
                    if (uneven)
                    {
                        int idx = imageBytes.Count - 1;
                        imageBytes[idx] = (byte)(((color.R & 0xf0) >> 4) + (color.G & 0xf0));
                        imageBytes.Add((byte)((color.B & 0xf0) >> 4));
                        uneven = false;
                    }
                    else
                    {
                        int idx = imageBytes.Count - 1;
                        imageBytes[idx] = (byte)(imageBytes[idx] + (byte)(color.R & 0xf0));
                        imageBytes.Add((byte)(((color.G & 0xf0) >> 4) + (color.B & 0xf0)));
                        imageBytes.Add(0);
                        uneven = true;
                    }
                }
            }
            return imageBytes.ToArray();
        }

        public void ShowPixelArt(Color[][] colors)
        {
            var header = new byte[] { 0xbd, 0x00, 0x44, 0x00, 0x0a, 0x0a, 0x04 };

            var imageData = ConvertColors(colors);

            var payload = header.Append(imageData);

            var message = BuildMessage(payload);

            _client.GetStream().Write(message, 0, message.Length);

            //data = data
            //ck1, ck2 = checksum(sum(head) + sum(data))

            //msg = [0x01] + head + mask(data) + mask([ck1, ck2]) + [0x02]
            //return msg
        }
    }
}
