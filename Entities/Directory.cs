using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Directory
    {
        Guid directoryId;
        string directoryUserName;
        string directoryPhone;
        string info;

        public Directory()
        {

        }

        public Directory(Guid directoryId, string directoryUserName, string directoryPhone, string info)
        {
            this.directoryId = directoryId;
            this.directoryUserName = directoryUserName;
            this.directoryPhone = directoryPhone;
            this.info = info;
        }
        public Directory(string directoryUserName, string directoryPhone, string info)
        {
            this.directoryUserName = directoryUserName;
            this.directoryPhone = directoryPhone;
            this.info = info;
        }

        public Guid DirectoryId { get => directoryId; set => directoryId = value; }
        public string DirectoryUserName { get => directoryUserName; set => directoryUserName = value; }
        public string DirectoryPhone { get => directoryPhone; set => directoryPhone = value; }
        public string Info { get => info; set => info = value; }
    }
}
