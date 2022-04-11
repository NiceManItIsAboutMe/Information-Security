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

namespace IB_4
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        string Log = ""; //поле пароля
        public Login()
        {
            InitializeComponent();
        }


        //войти в ЛК
        private void ToComeButton_Click(object sender, RoutedEventArgs e)
        {
            Log = LoginTextBox.Text;
            if(Log == "")
            {
                MessageBox.Show("Введите логин");
            }
            else
            {
                if(PasswordTextBox.Password == "")
                {
                    MessageBox.Show("Введите пароль");
                }
                else
                {
                    try
                    {
                        if (DB_operation.Authentication(Log, PasswordTextBox.Password))
                        {
                            string hello;
                            hello = "Добро пожаловать " + A_level_name(Convert.ToInt32(Work_sess.Access)) + " " + Log;
                            //передаем приветствие и открываем новую страницу
                            //NavigationService.Navigate(new Page1(hello, Log, Convert.ToInt32(Work_sess.Access)));
                            NavigationService.Navigate(new Page1());
                        }
                        else
                        {
                            MessageBox.Show("Доступ запрещён.");
                        }
                    } catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                    
                }
            }
            //MessageBox.Show(PasswordTextBox.Password);
            
        }

        public string A_level_name(int i)
        {
            string s = "";
            if (i == 0)
                s = "гость";
            if (i == 1)
                s = "пользователь";
            if (i == 2)
                s = "администратор";

            return s;
        }
    }
}
