using Func;
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

namespace Urok2.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCVT.xaml
    /// </summary>
    public partial class PageCVT : Page
    {
        public PageCVT()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            if (double.TryParse(A.Text, out a) && double.TryParse(B.Text, out b) && double.TryParse(C.Text, out c))
            {
                ClassCVT.KV(a, b, c, out string messege);
                if (!string.IsNullOrEmpty(messege)) _ = txbRes.Text;
            }
        }
    }
}
