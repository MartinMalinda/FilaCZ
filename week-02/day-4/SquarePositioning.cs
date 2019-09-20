using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

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
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            double startingPointX = 10;
            double startingPointY = 10;


            for (int i = 0; i < 3; i++)
            {
                Rectangle(foxDraw, startingPointX, startingPointY);
                startingPointX += 60;

            }
            

            /*for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawRectangle(startingPointX, startingPointY, rectangleSize, rectangleSize);
                startingPointX += rectangleSize;
                startingPointY += rectangleSize;

            }*/

        }

        public static void Rectangle(FoxDraw foxDraw, double startingPointX, double startingPointY)
        {
            double rectangleSize = 50;
            foxDraw.DrawRectangle(startingPointX, startingPointY, rectangleSize, rectangleSize);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}