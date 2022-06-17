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

namespace Patents_prog.str
{
    /// <summary>
    /// Логика взаимодействия для Prg.xaml
    /// </summary>
    public partial class Prg : Page
    {
        public Prg()
        {
            InitializeComponent();
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new patn.Pat1());           
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\vladk\Desktop\Panents\Patents_prog\Patents_prog\MP3\prj_10622568_8c1189738d521a2a017cf045bfb52cbd_1643011807.wav");
            //player.Play();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new str.Page1());
        }
    }
}
