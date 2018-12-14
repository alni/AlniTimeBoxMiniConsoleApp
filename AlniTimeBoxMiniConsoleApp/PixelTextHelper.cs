using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlniTimeBoxMiniConsoleApp
{
    class PixelTextHelper
    {
        // Characters and numbers based on the Pixel Text by Rosden Shadow found on DaFont
        // https://www.dafont.com/pixeltext.font

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



        // TODO: Create function to translate the chars & numbers to Pixel Colors
        // (input: single "bool[][]" char var; "Color" char color var)


        // TODO: Create function to combine the chars & numbers to Pixel Colors "word"
        // (input: multiple "bool[][]..." char vars; "Color" char color var. OR: multiple "Color[][]..." Pixel Color char vars)
    }
}
