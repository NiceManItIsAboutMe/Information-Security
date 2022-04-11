using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace IB_4
{
    public static class DB_operation
    {
        // функция аутентификации пользователя
        public static bool Authentication(string login, string password)
        {
            NpgsqlCommand db_op; // создаём экземпляр класса для выполнения SQL-запроса
            var hash = Crypto.SHA_512(Encoding.Default.GetBytes(password)); // хеш введенного пароля, должен быть равен тому, что в бд
            //переведем вычесленный хэш в строку
            var h = "";
            for(int i = 0; i< hash.Length; i++)
            {
                h += hash[i].ToString();
            }
            var con = new NpgsqlConnection(Param.DB_CONN_PARAMETERS); // задаём параметры соединения
            con.Open(); // соединяемя с БД

            db_op = new NpgsqlCommand("select pass_hash, a_level from pmib8606.passwords, pmib8606.login  where passwords.n_pass = login.n_pass and login.login = (@login)", con); // динамический SQL
            db_op.Parameters.AddWithValue("login", login); // указываем параметр, по которому получаем данные из запроса
            var reader = db_op.ExecuteReader(); // задаём экземпляр чтения данных

            
            if (!reader.Read()) 
                return false;

            var trueHash = reader.GetString(0); // берем строку из первого столбца результата
            
            trueHash = trueHash.Trim(' '); //удалим лишние пробелы
            var a_level = reader.GetInt32(1);
            con.Close();                        // подключение больше не нужно

            //string s_hash = "";
            //for (int i = 0; i < hash.Length; i++)
            //    s_hash += hash[i].ToString("x");
            //trueHash = trueHash.Trim(' ');

            for (int i = 0; i < trueHash.Length; i++) // сравниваем пароли
            {
                if (trueHash[i] != h[i])
                {
                    return false;
                }
            }

            Work_sess.Access = (Param.Access_level)a_level; // задаём уровень доступа
            Work_sess.login = login; // задаём логин
            return true;
        }

        // функция получения персональных данных 
        public static bool Pesonal_data()
        {
            NpgsqlCommand db_op;
            var con = new NpgsqlConnection(Param.DB_CONN_PARAMETERS);
            con.Open();

            db_op = new NpgsqlCommand(Param.DB_USR_L0, con); // динамический SQL
            db_op.Parameters.AddWithValue("login", Work_sess.login);
            var reader = db_op.ExecuteReader();

            if (!reader.Read())
                return false;

            Work_sess.name = reader.GetString(1); // сохраняем имя пользователя
            Work_sess.s_name = reader.GetString(2); // сохраняем фамилию пользователя
            Work_sess.pos = reader.GetString(3); // сохраняем должность пользователя
            con.Close();

            return true;
        }

        // получение всей базы данных
        public static NpgsqlDataAdapter show_db()
        {
            NpgsqlDataAdapter db_op;
            string DB_type = "";

            var con = new NpgsqlConnection(Param.DB_CONN_PARAMETERS);
            con.Open();

            switch (Work_sess.Access) // выбираем тип запроса в зависимости уровня доступа
            {
                case Param.Access_level.l_0: // гость может просматривать только свои данные
                    DB_type = Param.DB_USR_L0;
                    break;
                case Param.Access_level.l_1: // пользователь и администратор могут просмастривать всю БД
                case Param.Access_level.l_2:
                    DB_type = Param.DB_USR_L1_2;
                    break;
            }

            db_op = new NpgsqlDataAdapter(DB_type, con);
            switch (Work_sess.Access)
            {
                case Param.Access_level.l_0:
                    db_op.SelectCommand.Parameters.AddWithValue("login", Work_sess.login);
                    break;
            }
            con.Close();
            return db_op;
        }
    }
}
