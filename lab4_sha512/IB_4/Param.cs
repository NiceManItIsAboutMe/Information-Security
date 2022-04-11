using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_4
{
    public static class Param
    {
        static public string DB_CONN_PARAMETERS = "Host=students.ami.nstu.ru;Port=5432;Database=students;User Id=pmi-b8606;Password=syct0Qui;"; //параметр подключения к базе данных
        static public string DB_USR_L0 = "select * from pmib8606.university where login = (@login)"; //запрос на получение всей базы данных для конкретного пользователя
        static public string DB_USR_L1_2 = "select * from pmib8606.university"; //запрос на получение всей базы данных
        public enum Access_level { l_0, l_1, l_2 }; // тип данных для уровней допуска

        static public MainWindow F1; // общий параметр для формы (необходим для блокировки формы, чтобы избежать двойного входа)
    }
}
