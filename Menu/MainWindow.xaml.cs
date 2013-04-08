using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            GameWindow G= new GameWindow();
            this.Close();
            G.Show();

        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow Help= new HelpWindow();
            Help.ShowDialog();
        }
        private void TBMouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void RectMouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (button1.IsMouseDirectlyOver == false && button2.IsMouseDirectlyOver == false && button3.IsMouseDirectlyOver == false && e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
