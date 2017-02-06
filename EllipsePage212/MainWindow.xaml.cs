using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EllipsePage212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Balloon balloon;
        private Balloon balloon2;

        public MainWindow()
        {
            
            InitializeComponent();
            balloon = new Balloon();
            balloon.DisplayOn(canvas);

            balloon2 = new Balloon();
            balloon2.DisplayOn(canvas);
        }

        private void Move_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveRight(20);
            balloon2.MoveRight(20);
        }

        private void Grow_Click(object sender, RoutedEventArgs e)
        {
            balloon.ChangeSize(10);
            balloon2.ChangeSize(10);
        }
    }
}
