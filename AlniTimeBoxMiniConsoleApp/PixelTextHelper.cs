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

            TEXT_CHAR_SET.Add("{SPACING}", TEXT_CHAR_SPACE); // Spacing between characters
            TEXT_CHAR_SET.Add(" ", TEXT_CHAR_SPACE); // Whitespace between words
            TEXT_CHAR_SET.Add("\n", TEXT_CHAR_LINE_BREAK);
        }

        public static bool[][][] TextToPixelChars(string text)
        {
            List<bool[][]> pixelChars = new List<bool[][]>();
            char[] chars = text.ToArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char _char = chars[i];
                bool[][] pixelChar = TEXT_CHAR_SET[_char.ToString()];
                pixelChars.Add(pixelChar);
                if (i < chars.Length - 1)
                {
                    pixelChars.Add(TEXT_CHAR_SET["{SPACING}"]);
                }
            }
            return pixelChars.ToArray();
        }


        // TODO: Create function to translate the chars & numbers to Pixel Colors
        // (input: single "bool[][]" char var; "Color" char color var)
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

        public static Color[][] CharsToPixelColorsWord(Color color, params bool[][][] textChars)
        {
            return CharsToPixelColorsWord(textChars, color);
        }
        public static Color[][] CharsToPixelColorsWord(bool[][][] textChars, Color color)
        {
            List<bool[]> charactersList = new List<bool[]>();
            
            for (int y = 0; y < TEXT_CHAR_HEIGHT; y++)
            {
                List<bool> _tmpRow = new List<bool>();
                for (int i = 0; i < textChars.Length; i++)
                {
                    bool[][] _char = textChars[i];
                    if (i < textChars.Length && y < textChars[i].Length)
                    {
                        _tmpRow.AddRange(textChars[i][y]);
                    }
                }
                if (_tmpRow.Count > 0)
                {
                    charactersList.Add(_tmpRow.ToArray());
                }
            }
            bool[][] characters = charactersList.ToArray();
            return CharToPixelColors(characters, color);
        }

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
