using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Users
    {
        Guid userId;
        string tc;
        string password;

        public Users(string tc, string password)
        {
            this.tc = tc;
            this.password = password;
        }

        public Users(Guid userId, string tc, string password)
        {
            this.userId = userId;
            this.tc = tc;
            this.password = password;
        }

        public Guid UserId { get => userId; set => userId = value; }
        public string Tc { get => tc; set => tc = value; }
        public string Password { get => password; set => password = value; }
    }
}
