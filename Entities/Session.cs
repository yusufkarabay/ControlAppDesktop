using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Session
    {
        Guid sessionId;
        string tc;
        string password;

        public Session(string tc, string password)
        {
            this.tc = tc;
            this.password = password;
        }

        public Session(Guid sessionId, string tc, string password)
        {
            this.sessionId = sessionId;
            this.tc = tc;
            this.password = password;
        }

        public Guid SessionId { get => sessionId; set => sessionId = value; }
        public string Tc { get => tc; set => tc = value; }
        public string Password { get => password; set => password = value; }
    }
}
