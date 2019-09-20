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



            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            double canvasSize = 400;
            double squareWidth = 10;
            double squareHeight = 10;

            /*foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(canvasSize / 2 - squareWidth / 2, canvasSize / 2 - squareHeight / 2, squareWidth, squareHeight);*/

            
            for (int i = 0; i < 3; i++)
            {
                RectangleInCenter(foxDraw, squareWidth, squareHeight);
                squareWidth += 25;
                squareHeight += 25;
            }


        }

        public static void RectangleInCenter(FoxDraw foxDraw, double x, double y)
        {
            double canvasSize = 400;
            foxDraw.SetFillColor(Colors.Transparent);
            foxDraw.DrawRectangle(canvasSize / 2 - x / 2, canvasSize / 2 - y / 2, x, y);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}