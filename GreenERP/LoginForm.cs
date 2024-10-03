using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenERP
{
    public partial class LoginForm : Form
    {
        private User[] users = new User[]
        {
            new Agronom(01,"Anton","Anton2404","qwerty12345",Role.Agronom),
            new Mechanisator(02,"Andriy","Andriy2404","qwerty54321",Role.Mechanisator),
            new Economist(03,"Mykola","Mykola2404","qwerty56789",Role.Economist),
            new Director(04,"Sergiy","Sergiy2404","qwerty98765",Role.Director),
            new Administrator(05,"Oleg","Oleg2404","qwerty91285",Role.Administrator),
        };

        public LoginForm()
        {
            InitializeComponent();
            CreateComponent();
        }
        
        private void CreateComponent()
        {
            this.Load += new EventHandler(LoginForm_Load);
            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
            this.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 140);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(100, 100);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Увійти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(90, 60);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(90, 20);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(150, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(30, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(30, 20);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логін:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма логіну";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введіть логін та пароль.");
                return;
            }

            User user = users.FirstOrDefault(u => u.Login == textBoxLogin.Text && u.Password == textBoxPassword.Text);
            if(user != null)
            {
                switch (user.userRole) 
                {
                    case Role.Administrator:
                        MainForm adminForm = new MainForm(user);
                        adminForm.Show();
                        this.Close();
                        break;

                    case Role.Director:
                        MainForm directorForm = new MainForm(user);
                        directorForm.Show();
                        this.Close();
                        break;

                    case Role.Economist:
                        EconomistForm economistForm = new EconomistForm(user);
                        economistForm.Show();
                        this.Close();
                        break;

                    case Role.Agronom:
                        AgronomForm agronomForm = new AgronomForm(user);
                        agronomForm.Show();
                        this.Close();
                        break;

                    case Role.Mechanisator:
                        MechanisatorForm mechanisatorForm = new MechanisatorForm(user);
                        mechanisatorForm.Show();
                        this.Close();
                        break;

                    default:
                        MessageBox.Show("Вашої ролі не знайдено");
                        break;
                }
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

            textBoxLogin.Focus();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете закрити форму?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Заблокувати закриття форми
                }
            }
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
