using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesEF
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }
        public string CheckCode { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string EMailAddress { get; set; }
        public string ApproverFullName { get; set; }
        public DateTime? BirthDate { get; set; }

        // IsUser özelliği BaseEntity'nin Enabled propertysine bağlandı
        //public bool? IsUser { get; set; }

        // Navigation Properties
        Department Department { get; set; }

        //Not mapped
        public string FullName { get => Name + " " + Surname; }
    }
}
