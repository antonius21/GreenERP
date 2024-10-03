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
    public partial class MechanisatorForm : MainForm
    {
        public MechanisatorForm(User user):base(user) 
        {
            InitializeComponent();
            CreateComponent();
        }
        private void CreateComponent()
        {
            Label welcomeLabel = new Label();
            welcomeLabel.Text = $"Вітаємо, {user.Name}!";
            welcomeLabel.Location = new Point(10, 40); // Змінено розташування
            this.Controls.Add(welcomeLabel);

            Button viewEquipmentButton = new Button();
            viewEquipmentButton.Text = "Переглянути техніку";
            viewEquipmentButton.Location = new Point(10, 80); // Змінено розташування
            this.Controls.Add(viewEquipmentButton);

            Button addEquipmentButton = new Button();
            addEquipmentButton.Text = "Додати техніку";
            addEquipmentButton.Location = new Point(10, 120); // Змінено розташування
            this.Controls.Add(addEquipmentButton);
        }
    }
}
