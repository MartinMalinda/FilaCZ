using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

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

            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}
            List<Point> pointsList = new List<Point> { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290) };

            List<Point> pointsList1 = new List<Point> {new Point(50, 100), new Point(70, 70), new Point(80, 90),
                                    new Point(90, 90), new Point(100, 70), new Point(120, 100), new Point(85, 130), new Point(50, 100)};

                /*foxDraw.SetStrokeColor(Colors.Green);
                foxDraw.DrawLine(pointsList[0], pointsList[0 + 1]);
                foxDraw.DrawLine(pointsList[0 + 1], pointsList[0 + 2]);
                foxDraw.DrawLine(pointsList[0 + 2], pointsList[0 + 3]);
                foxDraw.DrawLine(pointsList[0], pointsList[0 + 3]);*/

            ConnectTheDots(foxDraw, pointsList); // box

            for (int i = 0; i < pointsList1.Count - 1; i++) // fox
            {
                foxDraw.DrawLine(pointsList1[i], pointsList1[i + 1]);
                if (i == pointsList1.Count - 1)
                {
                    
                    foxDraw.DrawLine(pointsList1[i - pointsList1.Count - 1], pointsList1[i + 1]);
                }
            }



        }

        public static void ConnectTheDots(FoxDraw foxDraw, List<Point> list)
        {
            list.Add(new Point(56, 80));

            //TODO to loop!!

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(list[0], list[0 + 1]);
            foxDraw.DrawLine(list[0 + 1], list[0 + 2]);
            foxDraw.DrawLine(list[0 + 2], list[0 + 3]);
            foxDraw.DrawLine(list[0], list[0 + 3]);

        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}