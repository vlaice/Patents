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
using System.Windows.Shapes;
using Patents_prog.ClassPage;

namespace Patents_prog
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Class1.one = one;
            one.Navigate(new str.Kn());
            WindowState = WindowState.Maximized;
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void media1_MediaEnded(object sender, RoutedEventArgs e)
        {
            media1.Position = TimeSpan.FromSeconds(0);
            
        }

        private void media2_MediaEnded(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\vladk\Desktop\Кардонский\Panents\Patents_prog\Patents_prog\Music\660655ec5901fb8.wav");
            //player.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
