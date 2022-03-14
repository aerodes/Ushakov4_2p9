using Demo_Ushakov.AppData;
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

namespace Demo_Ushakov.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageButton.xaml
    /// </summary>
    public partial class PageButton : Page
    {
        public PageButton()
        {
            InitializeComponent();
        }
        private void btnCVT_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageCVT());
        }

        private void btnLVT_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageLVT());
        }
    }
}
