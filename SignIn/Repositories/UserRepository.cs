using SignIn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public bool AuthenticateUser(string login, string password)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [users] where login=@login and password=@password";
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }
    }
}
