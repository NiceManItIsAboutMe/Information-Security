using System;
using System.Collections.Generic;
using System.Data;
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
using Npgsql;

namespace IB_4
{
    /// <summary>
    /// Логика взаимодействия для Page.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        //поступит строка приветствия + логин + уровень доступа
        public Page1()
        {
            InitializeComponent();
            //выводим приветствие
            //PersonalTextBlock.Text = hello;
            ModificateBdButton.IsEnabled = false;

            //Work_sess.login = log;
            //Work_sess.Access = (Param.Access_level)level;
        }


        //получить информацию из БД
        private void GetBdButton_Click(object sender, RoutedEventArgs e)
        {
            var db_op = DB_operation.show_db(); //загружаем БД
            ds.Reset(); //отчищаем все что было до этого
            db_op.Fill(ds); //обновляем строки в бд
            dt = ds.Tables[0];

            //Console.WriteLine();
            BdGrid.ItemsSource = dt.DefaultView;
            //BdGrid.DataContext = dt; // вывод таблицы

            switch (Work_sess.Access)
            {
                case Param.Access_level.l_2:
                    ModificateBdButton.IsEnabled = true; // активация кнопки для обновления БД для администратора
                    break;
            }
        }

        //изменение БД
        private void ModificateBdButton_Click(object sender, RoutedEventArgs e)
        {
            NpgsqlDataAdapter db_op;
            NpgsqlCommand com;

            var con = new NpgsqlConnection(Param.DB_CONN_PARAMETERS); //подключаемся к БД
            con.Open(); //открываем соединение

            //костылек (почистим бд)
            //com = new NpgsqlCommand("delete from university", con);

            db_op = new NpgsqlDataAdapter(Param.DB_USR_L1_2, con); //получаем всю БД
            

            NpgsqlCommandBuilder cmd = new NpgsqlCommandBuilder(db_op);
            
            db_op.UpdateCommand = cmd.GetUpdateCommand();
            DataView view = (DataView)BdGrid.ItemsSource;
            DataTable Table = view.ToTable();
            db_op.Fill(Table);
            db_op.Update(ds); // выполняем обновление БД

            con.Close();
        }

        //показать личную информацию
        private void PersonalDataButton_Click(object sender, RoutedEventArgs e)
        {
            string a_l = "";
            switch (Work_sess.Access)
            {
                case Param.Access_level.l_0:
                    a_l = "чтение только своих персональных данных.";
                    break;
                case Param.Access_level.l_1:
                    a_l = "чтение персональных данных всех пользователей.";
                    break;
                case Param.Access_level.l_2:
                    a_l = "чтение и модификация персональных данных всех пользователей.";
                    break;
            }
            DB_operation.Pesonal_data();
            MessageBox.Show("Имя: " + Work_sess.name + "\n" +
                            "Фамилия: " + Work_sess.s_name + "\n" +
                            "Должность: " + Work_sess.pos + "\n" +
                            "Права доступа: " + a_l);
        }

        //вернуться в главное меню
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }

        //о программе
        private void InfoProgrammButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение 'Терминал Базы Данных'\n" +
                            "Разработано в рамках образовательного курса:\n" +
                            "Информационная Безопасность\n" +
                            "Разработчики: Зяблицева Ульяна, Хайдаев Константин");
        }
    }
}
