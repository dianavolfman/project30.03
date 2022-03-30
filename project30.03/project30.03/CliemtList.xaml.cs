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

namespace project30._03
{
    /// <summary>
    /// Логика взаимодействия для CliemtList.xaml
    /// </summary>
    public partial class CliemtList : Window
    {
        public CliemtList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CliemtList window = GetWindow(this) as CliemtList;
            window.FrameCenter.Navigate(new Pages.Page1());
        }
    }
}
