using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Authority
    {
        Guid authorityId;
        string authorityName;

        public Authority(string authorityName)
        {
            this.authorityName = authorityName;
        }

        public Authority(Guid authorityId, string authorityName)
        {
            this.authorityId = authorityId;
            this.authorityName = authorityName;
        }

        public string AuthorityName { get => authorityName; set => authorityName = value; }
        public Guid AuthorityId { get => authorityId; set => authorityId = value; }
    }
}
