using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EllipsePage212
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Ellipse ellipse;

        public Balloon()
        {
            CreateElipse();
            UpdateEllipse();
        }
        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }
        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            UpdateEllipse();
        }


        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(ellipse);
        }
        private void CreateElipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.StrokeThickness = 2;
        }
        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }   
    }
}
