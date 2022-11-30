using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
       public class Auth
        {
            //Статичное поле, которое хранит значение статуса авторизации
            public static bool auth = false;
            //Статичное поле, которое хранит значения ID пользователя
            public static string auth_id = null;
            //Статичное поле, которое хранит значения ФИО пользователя
            public static string auth_fio = null;
            //Статичное поле, которое хранит количество привелегий пользователя
            public static int auth_role = 0;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2_auth1());
        
        }
    }
}
