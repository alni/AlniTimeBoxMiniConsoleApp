using Knom.TimeBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlniTimeBoxMiniConsoleApp
{
    class Program
    {
        public static readonly Color[][] COLOR_TEXT_TES = new Color[][]
        {
            //           | ----------------- T ----------------- |              | ----------------- E ----------------- |              | ----------------- S ----------------- |
            new Color[] {Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange},
            new Color[] {Color.Black,  Color.Orange, Color.Black,  Color.Black, Color.Orange, Color.Black,  Color.Black,  Color.Black, Color.Orange, Color.Black,  Color.Black},
            new Color[] {Color.Black,  Color.Orange, Color.Black,  Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange},
            new Color[] {Color.Black,  Color.Orange, Color.Black,  Color.Black, Color.Orange, Color.Black,  Color.Black,  Color.Black, Color.Black,  Color.Black,  Color.Orange},
            new Color[] {Color.Black,  Color.Orange, Color.Black,  Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange},

            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black}
        };

        public static readonly Color[][] COLOR_TEXT_HI = new Color[][]
        {
            //           | ----------------- H ----------------- |              | --- I --- |                           | --- ! --- |              | --- ! --- |
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black, Color.Black, Color.Orange, Color.Black, Color.Orange, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black, Color.Black, Color.Orange, Color.Black, Color.Orange, Color.Black},
            new Color[] {Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Black, Color.Black, Color.Orange, Color.Black, Color.Orange, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black, Color.Black, Color.Black,  Color.Black, Color.Black,  Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black, Color.Black, Color.Orange, Color.Black, Color.Orange, Color.Black},

            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black}
        };


        public static readonly Color[][] COLOR_TEXT_DAD = new Color[][]
        {
            //           | ----------------- D ----------------- |              | ----------------- A ----------------- | ¨            | ----------------- D ----------------- |
            new Color[] {Color.Orange, Color.Orange,  Color.Black, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},
            new Color[] {Color.Orange, Color.Orange,  Color.Black, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Black},

            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black}
        };

        public static readonly Color[][] COLOR_TEXT_MA = new Color[][]
        {
            //           | ------------------------------- M ------------------------------- |              | ----------------- A ----------------- |
            new Color[] {Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Black},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Black},

            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black}
        };

        public static readonly Color[][] COLOR_TEXT_MOM = new Color[][]
        {
            //           | ----------------- M ----------------- |              | ----------------- O ----------------- | ¨            | ----------------- M ----------------- |
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},
            new Color[] {Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},
            new Color[] {Color.Orange, Color.Black,  Color.Orange, Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Black, Color.Orange, Color.Black,  Color.Orange},

            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black}
        };


        public static readonly Color[][] COLOR_ART_PIZZA = new Color[][]
        {
            // Based on Pizza Emoji (scaled down to 11x11) from "twemoji-11.2.0" (16x16/1f355.png),

            new Color[] {Color.Black, Color.Black,  Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Yellow, Color.Yellow, Color.Yellow, Color.Orange, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Orange, Color.Yellow, Color.Red,    Color.Red,    Color.Yellow, Color.Yellow, Color.Yellow, Color.Orange, Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Orange, Color.Red,    Color.Red,    Color.Yellow, Color.Red,    Color.Red,    Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Orange, Color.Yellow, Color.Yellow, Color.Yellow, Color.Red,    Color.Red,    Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Red,    Color.Red,    Color.Orange, Color.Yellow, Color.Orange, Color.Black,  Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Red,    Color.Red,    Color.Orange, Color.Orange, Color.Orange, Color.Black,  Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Orange, Color.Yellow, Color.Red,    Color.Red,    Color.Black,  Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Orange, Color.Orange, Color.Red,    Color.Red,    Color.Black,  Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black,  Color.Orange, Color.Yellow, Color.Black,  Color.Black,  Color.Black,  Color.Black},
            new Color[] {Color.Black, Color.Black,  Color.Black,  Color.Black,  Color.Black,  Color.Orange, Color.Black,  Color.Black,  Color.Black,  Color.Black,  Color.Black}
        };


        public static bool[][][] PIXEL_TEXT_DAD = new bool[][][]
        {
            PixelTextHelper.TEXT_CHAR_D, PixelTextHelper.TEXT_CHAR_SPACE, PixelTextHelper.TEXT_CHAR_A, PixelTextHelper.TEXT_CHAR_SPACE, PixelTextHelper.TEXT_CHAR_D
        };

        static void Main(string[] args)
        {
            AlniTimeBoxDevice box = new AlniTimeBoxDevice();

            box.Connect();

            //box.SetView(TimeBoxDevice.ViewType.Clock);
            box.SetTimeColor(Color.Orange);
            box.SetTime(DateTime.Now);

            //box.ShowPixelArt(COLOR_TEXT_MOM);

            //box.ShowPixelArt(PixelTextHelper.CharToPixelColors(PixelTextHelper.TEXT_CHAR_A, Color.Green));
            //box.ShowPixelArt(PixelTextHelper.CharsToPizelColorsWord(Color.Green, PixelTextHelper.TEXT_CHAR_A));
            string testText = "DAD";
            testText = "abc";
            testText = "bbc";
            testText = "mom";
            Color testColor = Color.Green;
            testColor = Color.DarkRed;
            testColor = Color.Teal;
            testColor = Color.Gold;
            bool[][][] pixelCharText = PixelTextHelper.TextToPixelChars(testText.ToUpper());

            Color[][] pixelText = PixelTextHelper.CharsToPixelColorsWord(pixelCharText, testColor);


            pixelText = CreateMessage(
                "god \n jul".Split(' '), // Merry Christmas in Norwegian
                new Color[] { Color.White, Color.Black, Color.Red }
            );

            /*pixelText = CreateMessage(
                "pap \n pa".Split(' '), // Dad in Norwegian
                new Color[] { Color.Gray, Color.Black, Color.Gray }
            );

            pixelText = CreateMessage(
                "mam \n ma".Split(' '), // Mom in Norwegian
                new Color[] { Color.Magenta, Color.Black, Color.Magenta }
            );

            pixelText = CreateMessage(
                "dad \n".Split(' '),
                new Color[] { Color.Gray, Color.Black, Color.Gray }
            );

            pixelText = CreateMessage(
                "mom \n".Split(' '),
                new Color[] { Color.Magenta, Color.Black, Color.Magenta }
            );*/

            pixelText = CreateMessage(
                "123 \n 456".Split(' '),
                new Color[] { Color.DarkBlue, Color.Black, Color.DarkRed }
            );

            pixelText = CreateMessage(
                "789 \n 000".Split(' '),
                new Color[] { Color.DarkBlue, Color.Black, Color.DarkRed }
            );

            //Color[][] pixelText = PixelTextHelper.CharsToPixelColorsWord(PIXEL_TEXT_DAD, Color.Green);
            Color[][] pixelTextFilled = PixelTextHelper.FillDimensions(pixelText);
            box.ShowPixelArt(pixelTextFilled);
            //box.ShowPixelArt(COLOR_ART_PIZZA);

            //box.SetTempUnit(fahrenheit: false);
            //box.SetTempUnitAndColor(Color.Aqua, fahrenheit: false);

            //box.SetVolume(0);
            //box.SetVolume(16);

            //box.ShowImage("C:\\Work\\projects\\Knom.TimeBox\\src\\SampleApp\\testdata\\squares.png");
            //box.SetView(TimeBoxDevice.ViewType.Image);
            //Thread.Sleep(1000);
            //box.ShowImage("C:\\Users\\alexa\\Desktop\\1f355.png");

            //box.AnimateImages("C:\\Work\\projects\\Knom.TimeBox\\src\\SampleApp\\testdata\\exp");

            Thread.Sleep(Int32.MaxValue);
        }

        private static Color[][] CreateMessage(string[] text, Color[] colors)
        {
            bool[][][] pixelCharText = new bool[text.Length][][];

            Color[][] pixelText = null;
            for (int i = 0; i < text.Length;i++)
            {
                pixelCharText = PixelTextHelper.TextToPixelChars(text[i].ToUpper());
                if (i > 0)
                {
                    pixelText = pixelText.Concat(PixelTextHelper.CharsToPixelColorsWord(pixelCharText, colors[i])).ToArray();
                }
                else
                {
                    pixelText = PixelTextHelper.CharsToPixelColorsWord(pixelCharText, colors[i]);
                }
            }

            return pixelText;
        }
    }
}
