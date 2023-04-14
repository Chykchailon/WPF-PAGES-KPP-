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

namespace CoLlegEAppLe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page1 page1 = new Page1();
        Page2 page2 = new Page2();
        Page3 page3 = new Page3();
        Page4 page4 = new Page4();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Btn_tabl1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = page1;
        }

        private void Btn_tabl2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = page2;
        }

        private void Btn_tabl3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = page3;
        }

        private void Btn_tabl4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = page4;
        }

    }
}
