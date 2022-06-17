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
    /// Логика взаимодействия для Kn.xaml
    /// </summary>
    public partial class Kn : Page
    {
        public Kn()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.one.Navigate(new str.Page1());
        }
    }
}
