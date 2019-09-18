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

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, canvasSize / 2, canvasSize / 2, canvasSize / 2);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(canvasSize / 2, canvasSize / 2, canvasSize / 2, 0);
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.
        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}