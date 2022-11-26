namespace Baza
{
    partial class RegistrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_n_m = new System.Windows.Forms.TextBox();
            this.textBox_porolRet = new System.Windows.Forms.TextBox();
            this.textBox_porol = new System.Windows.Forms.TextBox();
            this.Registrlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегестрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(163, 68);
            this.textBox_FIO.Multiline = true;
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(138, 25);
            this.textBox_FIO.TabIndex = 1;
            // 
            // textBox_n_m
            // 
            this.textBox_n_m.Location = new System.Drawing.Point(163, 116);
            this.textBox_n_m.Multiline = true;
            this.textBox_n_m.Name = "textBox_n_m";
            this.textBox_n_m.Size = new System.Drawing.Size(138, 25);
            this.textBox_n_m.TabIndex = 2;
            // 
            // textBox_porolRet
            // 
            this.textBox_porolRet.Location = new System.Drawing.Point(163, 257);
            this.textBox_porolRet.Multiline = true;
            this.textBox_porolRet.Name = "textBox_porolRet";
            this.textBox_porolRet.Size = new System.Drawing.Size(138, 25);
            this.textBox_porolRet.TabIndex = 3;
            // 
            // textBox_porol
            // 
            this.textBox_porol.Location = new System.Drawing.Point(163, 202);
            this.textBox_porol.Multiline = true;
            this.textBox_porol.Name = "textBox_porol";
            this.textBox_porol.Size = new System.Drawing.Size(138, 25);
            this.textBox_porol.TabIndex = 4;
            // 
            // Registrlabel
            // 
            this.Registrlabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Registrlabel.Location = new System.Drawing.Point(160, 9);
            this.Registrlabel.Name = "Registrlabel";
            this.Registrlabel.Size = new System.Drawing.Size(131, 31);
            this.Registrlabel.TabIndex = 5;
            this.Registrlabel.Text = "Регистрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Электронный адресс или номер телефона";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пороль";
       
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Повторите пороль";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(163, 157);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(138, 25);
            this.textBox_login.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(46, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Логин";
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrlabel);
            this.Controls.Add(this.textBox_porol);
            this.Controls.Add(this.textBox_porolRet);
            this.Controls.Add(this.textBox_n_m);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.button1);
            this.Name = "RegistrForm";
            this.Text = "RegistrForm";
            this.Load += new System.EventHandler(this.RegistrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_n_m;
        private System.Windows.Forms.TextBox textBox_porolRet;
        private System.Windows.Forms.TextBox textBox_porol;
        private System.Windows.Forms.Label Registrlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label5;
    }
}