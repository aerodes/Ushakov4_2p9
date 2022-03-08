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
using Demo_Ushakov.AppData;
using Demo_Ushakov.Pages;

namespace Demo_Ushakov.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageButton1.xaml
    /// </summary>
    public partial class PageButton1 : Page
    {
        public PageButton1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageButton2());
        }
    }
}
