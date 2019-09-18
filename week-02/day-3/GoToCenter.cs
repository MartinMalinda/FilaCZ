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

            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.

            GoToCenter(foxDraw, 50, 40, 400);

            /*double canvasSize = 400;
            double startingPointX = canvasSize / 10;
            double startingPointY = canvasSize / 10;


            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(x1: startingPointX, y1: startingPointY, canvasSize / 2, canvasSize / 2);

                startingPointY += 20;
            }*/


        }

        public static void GoToCenter(FoxDraw foxDraw, double startingPointX, double startingPointY, double canvasSize)
        {
            
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(x1: startingPointX, y1: startingPointY, canvasSize / 2, canvasSize / 2);

                startingPointY += 20;
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}