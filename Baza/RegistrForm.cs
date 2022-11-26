using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Baza
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }
        /*
        static class Auth
        {
            //Статичное поле, которое хранит значение статуса авторизации
            public static bool auth = false;
            //Статичное поле, которое хранит значения ID пользователя
            public static string auth_id = null;
            //Статичное поле, которое хранит значения ФИО пользователя
            public static string auth_fio = null;

            
            public static string auth_m_t = null;
           
            //Статичное поле, которое хранит количество привелегий пользователя
            // public static int auth_role = 0;
        }
        */
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
        private void RegistrForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
         // string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_6;database=is_1_20_st6_KURS;password=40112334;";
        string connStr = "server=10.90.12.110;port=33333;user=st_1_20_6;database=is_1_20_st6_KURS;password=40112334;";
        //Переменная соединения
        MySqlConnection conn;

        Form2_auth1 f2 = new Form2_auth1();
        private void button1_Click(object sender, EventArgs e)
        {




            //  string sql = "INSERT INTO `t_user`(`loginUser`, `passUser`,`FIO`, `NomberTel_mail`)";
            if (textBox_FIO.Text == "")
            {
                MessageBox.Show("Введите ФИО", "Ошибка");
                return;

            }
            if (textBox_n_m.Text == "")
            {
                MessageBox.Show("Введите адресс электронной почты", "Ошибка");
                return;

            }

            if (textBox_login.Text == "")
            {
                MessageBox.Show("Введите логин", "Ошибка");
                return;
                
            }

            if (textBox_porol.Text == "")
            {
                MessageBox.Show("Введите пароль", "Ошибка");
                return;
                
            }

            if (textBox_porolRet.Text == "")
            {
                MessageBox.Show("Потвердите пароль", "Ошибка");
                return;

            }

            if (IsUserExists()) 
            { return; } 
            
           
        
            /*
            if (isUsersExists())
            {
                return;
            }
            */
         //   DataTable table = new DataTable();
          //  MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `t_user`(`loginUser`, `passUser`,`FIO`, `NomberTel_mail`) VALUES (@loginUser, @passUser, @FIO, @NomberTel_mail)", conn);

            conn.Open();
            command.Parameters.Add("@loginUser", MySqlDbType.VarChar, 25).Value = textBox_login.Text;
            command.Parameters.Add("@passUser", MySqlDbType.VarChar, 25).Value = sha256(textBox_porol.Text = textBox_porolRet.Text);
            command.Parameters.Add("@FIO", MySqlDbType.VarChar, 25).Value = textBox_FIO.Text;
            command.Parameters.Add("@NomberTel_mail", MySqlDbType.VarChar, 25).Value = textBox_n_m.Text;
       //     adapter.SelectCommand = command;
          //  adapter.Fill(table);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегестрировались");
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Произошла ошибка, аккаунт не был создан");
            }
            conn.Close();
        }   
        public Boolean IsUserExists()
        {


            DataTable table = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter();
          MySqlCommand command = new MySqlCommand("SELECT * FROM t_user WHERE loginUser = @un", conn);
           command.Parameters.Add("@un", MySqlDbType.VarChar).Value = textBox_login.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже зарегистрирован введите другой", "Ошибка");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}