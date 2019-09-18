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

            // Draw a green 10x10 square to the canvas' center.

            double canvasSize = 400;
            double squareWidth = 10;
            double squareHeight = 10;

            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(canvasSize / 2 - squareWidth / 2, canvasSize / 2 - squareHeight / 2, squareWidth, squareHeight);



        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}