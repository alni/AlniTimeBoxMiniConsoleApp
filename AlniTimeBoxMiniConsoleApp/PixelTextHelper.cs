using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlniTimeBoxMiniConsoleApp
{
    class PixelTextHelper
    {
        // Characters and numbers based on the Pixel Text by Rosden Shadow found on DaFont
        // https://www.dafont.com/pixeltext.font

        const int TEXT_CHAR_HEIGHT = 5;

        public static readonly bool[][] TEXT_CHAR_A = new bool[][]
        {
            new bool[] { false,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_B = new bool[][]
        {
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_C = new bool[][]
        {
            new bool[] { false,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true, false, false },
            new bool[] {  true, false, false },
            new bool[] { false,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_D = new bool[][]
        {
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true, false }
        };

        // TODO: Finish writing the configuration for the rest of the characters and numbers

        public static readonly bool[][] TEXT_CHAR_E = new bool[][]
        {
            new bool[] {  true,  true, true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_F = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true, false, false }
        };

        public static readonly bool[][] TEXT_CHAR_G = new bool[][]
        {
            new bool[] { false,  true, false },
            new bool[] {  true, false, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_H = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_I = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] {  true,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_J = new bool[][]
        {
            new bool[] { false, false,  true },
            new bool[] { false, false,  true },
            new bool[] { false, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_K = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true,  true, false },
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_L = new bool[][]
        {
            new bool[] {  true, false, false },
            new bool[] {  true, false, false },
            new bool[] {  true, false, false },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_M = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_N = new bool[][]
        {
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_O = new bool[][]
        {
            new bool[] { false,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_P = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true, false, false }
        };

        public static readonly bool[][] TEXT_CHAR_Q = new bool[][]
        {
            new bool[] { false,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_R = new bool[][]
        {
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true,  true, false },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_S = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_T = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_U = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_V = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_W = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_X = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true, false },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_Y = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_Z = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] { false,  true, false },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_0 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_1 = new bool[][]
        {
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false },
            new bool[] { false,  true, false }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_2 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_3 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_4 = new bool[][]
        {
            new bool[] {  true, false,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] { false, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_5 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_6 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false, false },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_7 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] { false, false,  true },
            new bool[] { false, false,  true },
            new bool[] { false, false,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_8 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true }
        };

        public static readonly bool[][] TEXT_CHAR_NUM_9 = new bool[][]
        {
            new bool[] {  true,  true,  true },
            new bool[] {  true, false,  true },
            new bool[] {  true,  true,  true },
            new bool[] { false, false,  true },
            new bool[] {  true,  true,  true }
        };


        public static readonly bool[][] TEXT_CHAR_SPACE = new bool[][]
        {
            new bool[] { false },
            new bool[] { false },
            new bool[] { false },
            new bool[] { false },
            new bool[] { false }
        };

        public static readonly bool[][] TEXT_CHAR_LINE_BREAK = new bool[][]
        {
            new bool[] { false, false, false, false, false, false, false, false, false, false, false },
        };

        public static readonly Dictionary<string, bool[][]> TEXT_CHAR_SET;

        static PixelTextHelper()
        {
            TEXT_CHAR_SET = new Dictionary<string, bool[][]>();
            TEXT_CHAR_SET.Add("A", TEXT_CHAR_A);
            TEXT_CHAR_SET.Add("B", TEXT_CHAR_B);
            TEXT_CHAR_SET.Add("C", TEXT_CHAR_C);
            TEXT_CHAR_SET.Add("D", TEXT_CHAR_D);
            TEXT_CHAR_SET.Add("E", TEXT_CHAR_E);
            TEXT_CHAR_SET.Add("F", TEXT_CHAR_F);
            TEXT_CHAR_SET.Add("G", TEXT_CHAR_G);
            TEXT_CHAR_SET.Add("H", TEXT_CHAR_H);
            TEXT_CHAR_SET.Add("I", TEXT_CHAR_I);
            TEXT_CHAR_SET.Add("J", TEXT_CHAR_J);
            TEXT_CHAR_SET.Add("K", TEXT_CHAR_K);
            TEXT_CHAR_SET.Add("L", TEXT_CHAR_L);
            TEXT_CHAR_SET.Add("M", TEXT_CHAR_M);
            TEXT_CHAR_SET.Add("N", TEXT_CHAR_N);
            TEXT_CHAR_SET.Add("O", TEXT_CHAR_O);
            TEXT_CHAR_SET.Add("P", TEXT_CHAR_P);
            TEXT_CHAR_SET.Add("Q", TEXT_CHAR_Q);
            TEXT_CHAR_SET.Add("R", TEXT_CHAR_R);
            TEXT_CHAR_SET.Add("S", TEXT_CHAR_S);
            TEXT_CHAR_SET.Add("T", TEXT_CHAR_T);
            TEXT_CHAR_SET.Add("U", TEXT_CHAR_U);
            TEXT_CHAR_SET.Add("V", TEXT_CHAR_V);
            TEXT_CHAR_SET.Add("W", TEXT_CHAR_W);
            TEXT_CHAR_SET.Add("X", TEXT_CHAR_X);
            TEXT_CHAR_SET.Add("Y", TEXT_CHAR_Y);
            TEXT_CHAR_SET.Add("Z", TEXT_CHAR_Z);

            TEXT_CHAR_SET.Add("0", TEXT_CHAR_NUM_0);
            TEXT_CHAR_SET.Add("1", TEXT_CHAR_NUM_1);
            TEXT_CHAR_SET.Add("2", TEXT_CHAR_NUM_2);
            TEXT_CHAR_SET.Add("3", TEXT_CHAR_NUM_3);
            TEXT_CHAR_SET.Add("4", TEXT_CHAR_NUM_4);
            TEXT_CHAR_SET.Add("5", TEXT_CHAR_NUM_5);
            TEXT_CHAR_SET.Add("6", TEXT_CHAR_NUM_6);
            TEXT_CHAR_SET.Add("7", TEXT_CHAR_NUM_7);
            TEXT_CHAR_SET.Add("8", TEXT_CHAR_NUM_8);
            TEXT_CHAR_SET.Add("9", TEXT_CHAR_NUM_9);

            TEXT_CHAR_SET.Add("{SPACING}", TEXT_CHAR_SPACE); // Spacing between characters
            TEXT_CHAR_SET.Add(" ", TEXT_CHAR_SPACE); // Whitespace between words
            TEXT_CHAR_SET.Add("\n", TEXT_CHAR_LINE_BREAK);
        }

        /// <summary>
        /// Convert text to Pixel characters
        /// 
        /// Each Pixel character is defined as a bool[][] array
        /// </summary>
        /// <param name="text">The text to convert</param>
        /// <returns>Array of Pixel characters</returns>
        public static bool[][][] TextToPixelChars(string text)
        {
            List<bool[][]> pixelChars = new List<bool[][]>();
            char[] chars = text.ToArray();
            // Loop through each character of the text
            for (int i = 0; i < chars.Length; i++)
            {
                char _char = chars[i];

                // Convert the character to a Pixel character
                bool[][] pixelChar = TEXT_CHAR_SET[_char.ToString()];
                pixelChars.Add(pixelChar); // Add the pixel character to the list
                if (i < chars.Length - 1)
                {
                    // If not at the last character yet, add a spacing between the characters
                    pixelChars.Add(TEXT_CHAR_SET["{SPACING}"]);
                }
            }
            return pixelChars.ToArray(); // Return the list as an array
        }


        // TODO: Create function to translate the chars & numbers to Pixel Colors
        // (input: single "bool[][]" char var; "Color" char color var)

        /// <summary>
        /// Convert Pixel Character to Pixel Colors
        /// </summary>
        /// <param name="textChar">The Pixel Character to convert</param>
        /// <param name="color">The desired Color of the character</param>
        /// <returns>Array of Pixel Colors</returns>
        public static Color[][] CharToPixelColors(bool[][] textChar, Color color)
        {
            Color[][] pixelColors = new Color[textChar.Length][];
            for (int y = 0; y < textChar.Length; y++)
            {
                pixelColors[y] = new Color[textChar[y].Length];
                for (int x = 0; x < textChar[y].Length; x++)
                {
                    if (textChar[y][x])
                    {
                        pixelColors[y][x] = color;
                    }
                    else
                    {
                        pixelColors[y][x] = Color.Black;
                    }
                }
            }
            return pixelColors;
        }


        // TODO: Create function to combine the chars & numbers to Pixel Colors "word"
        // (input: multiple "bool[][]..." char vars; "Color" char color var. OR: multiple "Color[][]..." Pixel Color char vars)

        /// <summary>
        /// Convert Pixel Characters to Pixel Colors Word
        /// </summary>
        /// <param name="color">The desired color of the Pixel Colors Word</param>
        /// <param name="textChars">The Pixel Characters to convert</param>
        /// <returns>Array of Pixel Colors</returns>
        public static Color[][] CharsToPixelColorsWord(Color color, params bool[][][] textChars)
        {
            return CharsToPixelColorsWord(textChars, color);
        }
        /// <summary>
        /// Convert Pixel Characters to Pixel Colors Word
        /// </summary>
        /// <param name="textChars">The Pixel Characters to convert</param>
        /// <param name="color">The desired color of the Pixel Colors Word</param>
        /// <returns>Array of Pixel Colors</returns>
        public static Color[][] CharsToPixelColorsWord(bool[][][] textChars, Color color)
        {
            /* Pseudo-code logic:
             * A:        B:        " ":
             * 0 1 0     1 1 0     0
             * 1 0 1     1 0 1     0
             * 1 1 1     1 1 0     0
             * 1 0 1     1 0 1     0
             * 1 0 1     1 1 0     0
             * 
             * 
             * A B =
             *   charactersList = []
             *   y = 0
             *     _tmpRow = []
             *       i = 0 (A):
             *         A[0] = 0 1 0
             *         _tmpRow = 0 1 0
             *       i = 1 (" ")
             *         " " = 0
             *         _tpmRow = 0 1 0 0
             *       i = 2 (B)
             *         B[0] = 1 1 0
             *         _tmpRow = 0 1 0 0 1 1 0
             *     _tmpRow.Count > 0:
             *       charactersList = [
             *         0 1 0 0 1 1 0
             *       ]
             *    y = 1
             *     _tmpRow = []
             *       i = 0 (A):
             *         A[1] = 1 0 1
             *         _tmpRow = 1 0 1
             *       i = 1 (" ")
             *         " " = 0
             *         _tpmRow = 1 0 1 0
             *       i = 2 (B)
             *         B[1] = 1 0 1
             *         _tmpRow = 1 0 1 0 1 0 1
             *     _tmpRow.Count > 0:
             *       charactersList = [
             *         0 1 0 0 1 0 1,
             *         1 0 1 0 1 0 1
             *       ]
             *   y = N... etc
             */
            List<bool[]> charactersList = new List<bool[]>();

            // Loop through each row of a Pixel Character
            for (int y = 0; y < TEXT_CHAR_HEIGHT; y++)
            {
                List<bool> _tmpRow = new List<bool>(); // Create temporary row
                // Loop through each Pixel Character in the array
                for (int i = 0; i < textChars.Length; i++)
                {
                    bool[][] _char = textChars[i]; // Store the current character

                    // Check if the current character is in the textChars array
                    // AND that the current row (y) is within the current character height
                    if (i < textChars.Length && y < _char.Length)
                    {
                        // Some characters (like the line break, "\n") has less rows than the
                        // default Pixel character height

                        // Append the current pixel character row of to right of the previous pixel character row
                        _tmpRow.AddRange(_char[y]);
                        // The previous pixel character row might be from another character (loops through each
                        // character while looping through each row of default Pixel character height)
                    }
                }
                if (_tmpRow.Count > 0)
                {
                    // Only add the current row of pixels if it is not empty
                    charactersList.Add(_tmpRow.ToArray());
                }
            }
            bool[][] characters = charactersList.ToArray();
            return CharToPixelColors(characters, color);
        }

        /// <summary>
        /// Fill the empty spaces of the TimeBox device with Black Pixel Colors
        /// </summary>
        /// <param name="colors">The array of Pixel Colors to fill</param>
        /// <returns>Array of Pixel Colors with size that matches the dimensions of the TimeBox device</returns>
        public static Color[][] FillDimensions(Color[][] colors)
        {
            List<Color[]> colorsList = new List<Color[]>(colors);
            for (int i = 0; i < colors.Length; i++)
            {
                if (colorsList[i].Length < AlniTimeBoxDevice.MAX_DIMENSIONS_WIDTH)
                {
                    List<Color> _tmpList = new List<Color>(colorsList[i]);
                    for (int j = 0; j < AlniTimeBoxDevice.MAX_DIMENSIONS_WIDTH - colorsList[i].Length; j++)
                    {
                        _tmpList.Add(Color.Black);
                    }
                    colorsList[i] = _tmpList.ToArray();
                }
            }
            if (colors.Length < AlniTimeBoxDevice.MAX_DIMENSIONS_HEIGHT)
            {
                for (int k = 0; k < AlniTimeBoxDevice.MAX_DIMENSIONS_HEIGHT - colors.Length; k++)
                {
                    List<Color> _tmpList = new List<Color>();
                    for (int p = 0; p < AlniTimeBoxDevice.MAX_DIMENSIONS_WIDTH; p++)
                    {
                        _tmpList.Add(Color.Black);
                    }
                    colorsList.Add(_tmpList.ToArray());
                }
            }
            return colorsList.ToArray();
        }
    }

    class PixelTextCursor
    {
        private int x = 0;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        private int y = 0;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public PixelTextCursor(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public void Move(int x)
        {
            Move(x, Y);
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
