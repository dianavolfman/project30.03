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

namespace project30._03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String login = textLogin.Text;
            String pass = textPass.Text;
            if (login == "admin" && pass == "admin")
            {
                CliemtList taskWindow = new CliemtList();
                taskWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
    }
}
