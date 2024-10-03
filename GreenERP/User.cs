using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenERP
{
    public class User
    {
        public User()
        {
        }

        public User(int idUser, string name, string login, string password, Role userRole)
        {
            IdUser = idUser;
            Name = name;
            Login = login;
            Password = password;
            this.userRole = userRole;
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role userRole { get; set; }
    }

    public enum Role
    {
        Administrator,
        Director,
        Economist,
        Agronom,
        Mechanisator,
    }
}
