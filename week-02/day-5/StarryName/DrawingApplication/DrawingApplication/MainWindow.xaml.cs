using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
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

            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            foxDraw.SetBackgroundColor(Colors.Black);


            double canvasSize = 400;
            double rectangleSize = 10;
            Random random = new Random();
            /*int x;
            double number = 10;

            x = (int)number;*/

            List<Color> colorList = new List<Color> { Colors.LightGray, Colors.Gray, Colors.DimGray, Colors.SlateGray, Colors.DarkSlateGray };


            /*random.Next((int)rectangleSize, (int)canvasSize - (int)rectangleSize);*/
            double startingPointStarX = (double)(random.Next((int)rectangleSize, (int)canvasSize - (int)rectangleSize));
            double startingPointStarY = (double)(random.Next((int)rectangleSize, (int)canvasSize - (int)rectangleSize));

            /*random.Next(colorList(Colors[0]), colorList(Colors[4]));*/

            

            for (int i = 0, j = 0; i < 100; i++, j++)
            {
                if (j == 4)
                {
                    j = 0;
                }
                foxDraw.SetFillColor(colorList[j]);
                foxDraw.DrawRectangle(startingPointStarX, startingPointStarY, rectangleSize, rectangleSize);
                startingPointStarX = (double)(random.Next((int)rectangleSize, (int)canvasSize - (int)rectangleSize));
                startingPointStarY = (double)(random.Next((int)rectangleSize, (int)canvasSize - (int)rectangleSize));

            }
        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}