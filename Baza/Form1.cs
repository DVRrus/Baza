using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Baza
{

    public partial class Form1_auth2 : MetroFramework.Forms.MetroForm
    //public partial class Form1_auth2 : Form
    {
        public Form1_auth2()
        {
            InitializeComponent();
        }

        static class Auth
        {
            //Статичное поле, которое хранит значение статуса авторизации
            public static bool auth = false;
            //Статичное поле, которое хранит значения ID пользователя
            public static string auth_id = null;
            //Статичное поле, которое хранит значения ФИО пользователя
            public static string auth_fio = null;
            //Статичное поле, которое хранит количество привелегий пользователя
           // public static int auth_role = 0;
        }
        // строка подключения к БД
      //  string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_6;database=is_1_20_st6_KURS;password=40112334;";
       string connStr = "server=10.90.12.110;port=33333;user=st_1_20_6;database=is_1_20_st6_KURS;password=40112334;";
        //Переменная соединения
        MySqlConnection conn;
        //Логин и пароль к данной форме Вы сможете посмотреть в БД db_test таблице t_user

        //Вычисление хэша строки и возрат его из метода
        static string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        //Метод запроса данных пользователя по логину для запоминания их в полях класса
        public void GetUserInfo(string login_user)
        {
            //Объявлем переменную для запроса в БД
            string selected_id_stud = textBox1.Text;
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = $"SELECT * FROM t_user WHERE loginUser='{login_user}'";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                Auth.auth_id = reader[0].ToString();
                Auth.auth_fio = reader[1].ToString();
             //   Auth.auth_role = Convert.ToInt32(reader[3].ToString());
            }
            reader.Close(); // закрываем reader
                            // закрываем соединение с БД
            conn.Close();
        }
        Form2_auth1 f2 = new Form2_auth1();
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите логин", "Ошибка");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите пороль", "Ошибка");
                return;
            }
            //Запрос в БД на предмет того, если ли строка с подходящим логином и паролем
            string sql = "SELECT * FROM t_user WHERE loginUser = @un and  passUser = @up";
            //Открытие соединения
            conn.Open();
            //Объявляем таблицу
            DataTable table = new DataTable();
            //Объявляем адаптер
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Объявляем команду
            MySqlCommand command = new MySqlCommand(sql, conn);
            //Определяем параметры
            command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 25);
            //Присваиваем параметрам значение
            command.Parameters["@un"].Value = textBox1.Text;
            command.Parameters["@up"].Value = sha256(textBox2.Text);
            //Заносим команду в адаптер
            adapter.SelectCommand = command;
            //Заполняем таблицу
            adapter.Fill(table);
            //Закрываем соединение
            conn.Close();
            //Если вернулась больше 0 строк, значит такой пользователь существует
            if (table.Rows.Count > 0)
            {
                //Присваеваем глобальный признак авторизации
                Auth.auth = true;
                //Достаем данные пользователя в случае успеха
                GetUserInfo(textBox1.Text);
                MessageBox.Show("Вы авторезировались");
              //  f2.ShowDialog();
                //Закрываем форму
             //this.Close();
//f2.ShowDialog();
              this.Hide();
               f2.ShowDialog();
                this.Show();
            }
            else
            {
                //Отобразить сообщение о том, что авторизаия неуспешна
                MessageBox.Show("Неверные данные авторизации!");
            }
        }

        private void Form1_auth2_Load(object sender, EventArgs e)
        {
            //Инициализируем соединение с подходящей строкой
            conn = new MySqlConnection(connStr);
        }

     //   private void textBox2_TextChanged(object sender, EventArgs e)
      //  {
            //В текстбокс3 формируется хэш по мере ввода текста во второй текстбокс, используется метод шифрования (хэширования)
       //     textBox3.Text = sha256(textBox2.Text);
   //     }
        //**************************************************//
        //                                                  //
        //                                                  //
        //      Тут всякие методы, которые отвечают         //
        //      за быстрое заполнения текстбоксов           //                                 
        //                                                  //
        //**************************************************//
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_auth2_Load_1(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        RegistrForm f1 = new RegistrForm();
        private void button_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
    }
}

