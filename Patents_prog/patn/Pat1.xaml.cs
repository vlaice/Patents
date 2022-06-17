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

namespace Patents_prog.patn
{
    /// <summary>
    /// Логика взаимодействия для Pat1.xaml
    /// </summary>
    public partial class Pat1 : Page
    {
        

        public Pat1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new str.Prg());
            
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new patn.pat1skrin.Skrin1());
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new patn.pat1skrin.skrin2());
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new patn.pat1skrin.skrin3());
        }
    }
    
}
