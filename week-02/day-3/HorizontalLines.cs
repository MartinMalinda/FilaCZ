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

            
            double startingPointX = 10;
            double startingPointY = 10;
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.

            /*for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(startingPointX, startingPointY, 50, startingPointY);
                startingPointY += 10;
            }*/
            Horizontal(foxDraw, startingPointX, startingPointY);


        }

        public static void Horizontal(FoxDraw foxDraw, double startingPointX, double startingPointY)
        {
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(startingPointX, startingPointY, 50, startingPointY);
                startingPointY += 10;
            }
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}