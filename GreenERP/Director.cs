using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenERP
{
    internal class Director : User
    {
        public Director()
        {
        }

        public Director(int idUser, string name, string login, string password, Role userRole) : base(idUser, name, login, password, Role.Director)
        {
        }
    }
}
