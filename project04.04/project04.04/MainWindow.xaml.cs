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

namespace project04._04
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

        private void btnAvtorization_Click(object sender, RoutedEventArgs e)
        {
           // Avtorization project = projectEntities.getContext().Avtorizations();
            //if (textLogin.Text.Equals(project.Avtorizations.)) { }
            ClientWindow taskWindow = new ClientWindow();
            taskWindow.Show();
            this.Close();
        }
    }
}
