using project30._03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    public class Avtorizatsiya
    {

        public void chechAvtorizatsiya(String login, String pass)
        {
            if (login == "admin" && pass == "admin")
            {
                CliemtList taskWindow = new CliemtList();
                taskWindow.Show();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Close();
            }
            else {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
    }
}
