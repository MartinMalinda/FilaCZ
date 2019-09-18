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

            // draw four different size and color rectangles.
            // avoid code duplication.

            double startingPointX = 10;
            double startingPointY = 10;
            double squareWidth = 30;
            double squareHeight = 30;

            List<string> colorList = new List<string> { "Red", "Green", "Blue", "Yellow" };
            //foxDraw.DrawRectangle(startingPointX, startingPointY, squareWidth, squareHeight);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < colorList.Count; j++)
                {
                    string color = ;
                    foxDraw.SetFillColor(Colors.);
                }

                foxDraw.DrawRectangle(startingPointX, startingPointY, squareWidth, squareHeight);
                startingPointX += 60;
                squareWidth += 10;
                squareHeight += 10;

            }


        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}