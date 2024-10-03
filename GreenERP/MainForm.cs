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
    public partial class MainForm : Form
    {
        protected User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            switch (user.userRole)
            {
                case Role.Administrator:
                    Button manageUsersButton = new Button();
                    manageUsersButton.Text = "Управління користувачами";
                    manageUsersButton.Location = new Point(10, 10);
                    this.Controls.Add(manageUsersButton);
                    break;
                case Role.Director:
                    Button reportsButton = new Button();
                    reportsButton.Text = "Звіти";
                    reportsButton.Location = new Point(10, 10);
                    this.Controls.Add(reportsButton);
                    break;
                case Role.Economist:
                    Button manageFinancesButton = new Button();
                    manageFinancesButton.Text = "Управління фінансами";
                    manageFinancesButton.Location = new Point(10, 10);
                    this.Controls.Add(manageFinancesButton);
                    break;
                case Role.Agronom:
                    Button manageFieldsButton = new Button();
                    manageFieldsButton.Text = "Управління полями";
                    manageFieldsButton.Location = new Point(10, 10);
                    this.Controls.Add(manageFieldsButton);
                    break;
                case Role.Mechanisator:
                    Button manageEquipmentButton = new Button();
                    manageEquipmentButton.Text = "Управління технікою";
                    manageEquipmentButton.Location = new Point(10, 10);
                    this.Controls.Add(manageEquipmentButton);
                    break;
            }
        }
    }
}
