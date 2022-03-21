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
using Urok2.Pages;
using Urok2.AppFile;

namespace Urok2.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageBtn.xaml
    /// </summary>
    public partial class PageBtn : Page
    {
        public PageBtn()
        {
            InitializeComponent();
        }

        private void btnCVT_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frame.Navigate(new PageCVT());
        }

        private void btnLVT_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frame.Navigate(new PageLU());
        }
    }
}
