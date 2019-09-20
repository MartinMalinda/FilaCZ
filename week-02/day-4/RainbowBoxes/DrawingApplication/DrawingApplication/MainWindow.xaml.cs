using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            
            double startingPointX = 0;
            double startingPointY = 0;


            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            RainbowBox(foxDraw, startingPointX, startingPointY);

           /* for (int i = 0, k = 0; k < (canvasSize / rectangleSize) * (canvasSize / rectangleSize); i++, k++)
            {
                if (i == 5)
                {
                    i = 0;
                    startingPointX = 0;
                    startingPointY = startingPointY + rectangleSize;
                }

                foxDraw.SetFillColor(colorList[i]);
                foxDraw.DrawRectangle(startingPointX, startingPointY, rectangleSize, rectangleSize);
                startingPointX = startingPointX + rectangleSize;


            }*/

        }

        public static void RainbowBox(FoxDraw foxDraw, double startingPointX, double startingPointY)
        {
            double canvasSize = 400;
            double rectangleSize = 80;

            List<Color> colorList = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue };

            for (int i = 0, k = 0; k < (canvasSize / rectangleSize) * (canvasSize / rectangleSize); i++, k++)
            {
                if (i == 5)
                {
                    i = 0;
                    startingPointX = 0;
                    startingPointY = startingPointY + rectangleSize;
                }

                foxDraw.SetFillColor(colorList[i]);
                foxDraw.DrawRectangle(startingPointX, startingPointY, rectangleSize, rectangleSize);
                startingPointX = startingPointX + rectangleSize;
            }
        }

            private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}