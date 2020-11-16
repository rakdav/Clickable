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

namespace Clickable
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int n = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(parent);
            n++;
            if(n%2!=0)
            {
                TextBox t = new TextBox();
                t.Text = "Click";
                t.Width = 100;
                t.Height = 50;
                t.HorizontalAlignment = HorizontalAlignment.Left;
                t.VerticalAlignment = VerticalAlignment.Top;
                t.Background = Brushes.Red;
                t.Margin = new Thickness(p.X-t.Width, p.Y-t.Height,0,0);
                parent.Children.Add(t);
            }
            else
            {
                Button t = new Button();
                t.Content = "Click";
                t.Width = 100;
                t.Height = 50;
                t.HorizontalAlignment = HorizontalAlignment.Left;
                t.VerticalAlignment = VerticalAlignment.Top;
                t.Background = Brushes.Blue;
                t.Margin = new Thickness(p.X, p.Y, 0, 0);
                parent.Children.Add(t);
            }
            
        }
    }
}
