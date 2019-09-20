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

            double canvasSize = 400;
             
            double x1 = 20;
            double x2 = canvasSize;
            double y1 = 0;
            double y2 = 20;

            /*foxDraw.DrawLine(x, 0, canvasSize, y);
            foxDraw.DrawLine(x + 20, 0, canvasSize, y + 20);
            foxDraw.DrawLine(x + 40, 0, canvasSize, y + 40);*/

            for (int i = 0; i < 19; i++)
            {
                foxDraw.SetStrokeColor(Colors.Violet);
                foxDraw.DrawLine(x1, y1, x2, y2);
                foxDraw.SetStrokeColor(Colors.LawnGreen);
                foxDraw.DrawLine(y1, x1, y2, x2);
                x1 += 20;
                y2 += 20;
            }

        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}