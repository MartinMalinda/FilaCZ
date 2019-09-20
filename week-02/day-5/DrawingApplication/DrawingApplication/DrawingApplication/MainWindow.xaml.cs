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
            double x2 = canvasSize / 2;
            double y1 = canvasSize / 2;
            double y2 =  canvasSize / 2 - 20;

            foxDraw.DrawLine(0, canvasSize / 2, canvasSize, canvasSize / 2);
            foxDraw.DrawLine(canvasSize / 2, 0, canvasSize / 2, canvasSize);

            for (int i = 0; i < 9; i++)
            {
                
                foxDraw.SetStrokeColor(Colors.DarkOrange);
                
                foxDraw.DrawLine(x1, y1, x2, y2);

                x1 += 20;
                y2 -= 20;
            }

            for (int i = 0; i < 10; i++)
            {

                foxDraw.SetStrokeColor(Colors.DarkOrange);

                foxDraw.DrawLine(x1, y1, x2, y2);

                x1 += 20;
                y2 += 20;
            }





        }
        /*if (i == 8)
                {
                    i = 0;
                    x1 = 20;
                    y2 = canvasSize / 2 + 20;
                    foxDraw.SetStrokeColor(Colors.DarkOrange);
                    *//*foxDraw.DrawLine(20, 200, 200, 180);*//*
                    foxDraw.DrawLine(x1, y1, x2, y2);
                    x1 += 20;
                    y2 -= 20;
                }*/


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}