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
        public LoginForm()
        {
            
            InitializeComponent();
            CreateComponent();
        }

        private void CreateComponent()
        {
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Paint += LoginForm_Paint;

            Panel loginpanel = new Panel();
            loginpanel.Dock = DockStyle.Fill;
            Controls.Add(loginpanel);

            Label loginlabel = new Label();
            loginlabel.Text = "Логін користувача";
            loginlabel.Location = new Point(60, 60);
            loginlabel.AutoSize = true;
            loginpanel.Controls.Add(loginlabel);

            Label passwordlabel = new Label();
            passwordlabel.Text = "Пароль користувача";
            passwordlabel.Location = new Point(60, 120);
            passwordlabel.AutoSize = true;
            loginpanel.Controls.Add(passwordlabel);

            TextBox loginBox = new TextBox();
            loginBox.Location = new Point(240, 60);
            loginBox.Width = 100;
            loginpanel.Controls.Add(loginBox);

            TextBox passBox = new TextBox();
            passBox.Location = new Point(240, 120);
            passBox.PasswordChar = '*';
            passBox.Width = 100;
            loginpanel.Controls.Add(passBox);

            Button loginEnterButton = new Button();
            loginEnterButton.Location = new Point(100, 200);
            loginEnterButton.Width = 200;
            loginEnterButton.Text = "Увійти у систему";
            loginEnterButton.Click += LoginEnterButton_Click;
            loginpanel.Controls.Add(loginEnterButton);
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Логін",this.Font,Brushes.Magenta,new Point(10,10));
        }

        private void LoginEnterButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DB.Close()
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені що хочете вийти з додатку?","Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No){
                    e.Cancel = true;
                }
            }
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginEnterButton_Click( sender,  e);
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {

        }

        private void LoginForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {

            
        }

        private void LoginForm_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {
            MessageBox.Show("Невірна мова");
        }
    }
}
