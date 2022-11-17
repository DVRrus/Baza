using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using MySql.Data.MySqlClient;

namespace Baza
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_auth1 st1 = new Form2_auth1();


            string connStr = "server=10.90.12.110;port=33333;user=st_1_20_6;database=is_1_20_st6_KURS;password=40112334;";
            //Переменная соединения
            MySqlConnection conn;
            MySqlCommand command = new MySqlCommand("");

            command.Parameters 

        }
    }
}
