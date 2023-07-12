using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.Models
{
    interface IUserRepository
    {
        bool AuthenticateUser(string login, string password);
    }
}
