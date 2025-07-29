using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.Q02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string username="Mohamed";
        private string password="123";
        private string role = "Update";
        bool IAuthenticationService.AuthenticateUser(string username, string password)
        {
            if (username == this.username || password == this.password)
                return true;
            return false;
        }

        bool IAuthenticationService.AuthorizeUser(string username, string role)
        {
            if (username == this.username || role == this.role)
                return true;
            return false;
        }
    }
}
