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
            double startingPoint = 0;

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(startingPoint, startingPoint, canvasSize, canvasSize);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(startingPoint, canvasSize, canvasSize, startingPoint);
            

        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}