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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClassLibrary1;
using MySql.Data.MySqlClient;
using static Baza.Form1_auth2;

namespace Baza
{
    public partial class Form2_auth1 : Form
    {
     
        public Form2_auth1()
        {
            InitializeComponent();
        }
        //Form3 f2 = new Form3();
        Form1_auth2 f1 = new Form1_auth2();


       private void Form2_auth1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
        string connStr = "server=10.90.12.110;port=33333;user=st_1_20_6;database=is_1_20_st6_KURS;password=40112334;";
        MySqlConnection conn;
        private void Form2_auth1_Load_1(object sender, EventArgs e)
        {
            //Инициализируем соединение с подходящей строкой
            conn = new MySqlConnection(connStr);

          
        }
     
       
        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
       f1.ShowDialog();

            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации

            //Вызов формы в режиме диалога

            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ы
                label5.Text = $"Вы вошли как {Auth.auth_fio}";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
