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
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            double canvasSize = 400;
            double startingPointX = 0;
            double startingPointY = 0;

            //foxDraw.DrawLine(startingPointX, startingPointY, canvasSize / 2, canvasSize / 2);

            

            for (int i = 0; i <= canvasSize / 20; i++)
            {
                LinesToCenter(foxDraw, startingPointX, startingPointY);
                startingPointX += 20;
            }

        }

        private static void LinesToCenter(FoxDraw foxDraw,double x, double y)
        {
            double canvasSize = 400;
            foxDraw.DrawLine(x, y, canvasSize / 2, canvasSize / 2);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}