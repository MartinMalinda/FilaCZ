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

            DrawFourColoredRectangle(foxDraw, 1000);

            /*var x = 50;
            var y = 50;

            foxDraw.SetStrokeThicknes(2);
            //foxDraw.DrawLine(x, y, x*2, y);
            //foxDraw.DrawLine(x, y*2, x, y);
            //foxDraw.DrawLine(x*2, y, x*2, y*2);
            //foxDraw.DrawLine(x, y*2, x*2, y*2);
            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetStrokeColor(Colors.AliceBlue);
            foxDraw.DrawLine(canvasSize / 10, canvasSize / 10, (canvasSize / 10) * 2, canvasSize / 10);
            foxDraw.DrawLine(canvasSize / 10, (canvasSize / 10) * 2, canvasSize / 10, canvasSize / 10);
            foxDraw.DrawLine((canvasSize / 10) * 2, canvasSize / 10, (canvasSize / 10) * 2, (canvasSize / 10) * 2);
            foxDraw.DrawLine(canvasSize / 10, (canvasSize / 10) * 2, (canvasSize / 10) * 2, (canvasSize / 10) * 2);*/



        }

        public void DrawFourColoredRectangle(FoxDraw foxDraw, double canvasSize)
        {
            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetStrokeColor(Colors.DarkGreen);
            foxDraw.DrawLine(canvasSize / 10, canvasSize / 10, (canvasSize / 10) * 2, canvasSize / 10);
            foxDraw.SetStrokeColor(Colors.DarkOrange);
            foxDraw.DrawLine(canvasSize / 10, (canvasSize / 10) * 2, canvasSize / 10, canvasSize / 10);
            foxDraw.SetStrokeColor(Colors.DarkMagenta);
            foxDraw.DrawLine((canvasSize / 10) * 2, canvasSize / 10, (canvasSize / 10) * 2, (canvasSize / 10) * 2);
            foxDraw.SetStrokeColor(Colors.DarkViolet);
            foxDraw.DrawLine(canvasSize / 10, (canvasSize / 10) * 2, (canvasSize / 10) * 2, (canvasSize / 10) * 2);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}