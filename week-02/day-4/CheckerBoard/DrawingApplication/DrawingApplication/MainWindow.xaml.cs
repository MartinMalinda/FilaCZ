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

            double canvasSize = 400;
            double rectangleSize = 80;
            double startingPointX = 0;
            double startingPointY = 0;

            

            for (int i = 0, k = 0; k < (canvasSize / rectangleSize) * (canvasSize / rectangleSize); i++, k++)
            {
                if (i == 5)
                {
                    i = 0;
                    startingPointX = 0;
                    startingPointY = startingPointY + rectangleSize;
                }
                if (k % 2 == 0)
                {
                    foxDraw.SetFillColor(Colors.Black);
                }
                else
                {
                    foxDraw.SetFillColor(Colors.White);
                }
                
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