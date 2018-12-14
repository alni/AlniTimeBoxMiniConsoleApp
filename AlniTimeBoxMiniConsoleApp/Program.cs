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
        static void Main(string[] args)
        {
            AlniTimeBoxDevice box = new AlniTimeBoxDevice();

            box.Connect();

            //box.SetView(TimeBoxDevice.ViewType.Clock);
            box.SetTimeColor(Color.Orange);
            box.SetTime(DateTime.Now);

            //box.ShowPixelArt(COLOR_TEXT_MA);
            box.ShowPixelArt(COLOR_ART_PIZZA);

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
    }
}
