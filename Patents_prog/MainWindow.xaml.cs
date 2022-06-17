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
using Patents_prog.ClassPage;

namespace Patents_prog
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Class1.one = one;
            one.Navigate(new str.Page1());
        }
        private void stateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                FrameworkElement content = Content as FrameworkElement;
                ScaleTransform scale = new ScaleTransform();
                double ratio = SystemParameters.VirtualScreenWidth / SystemParameters.VirtualScreenHeight;
                scale.ScaleX = SystemParameters.VirtualScreenWidth / content.ActualWidth;
                scale.ScaleY = ratio * ratio * SystemParameters.VirtualScreenHeight / content.ActualHeight;
                content.LayoutTransform = scale;
            }
            else
            {
                (Content as FrameworkElement).ClearValue(LayoutTransformProperty);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new str.Page1());
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
