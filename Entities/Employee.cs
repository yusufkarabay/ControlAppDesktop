using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        Guid id;
        string tc;
        string name;
        string surname;
        DateTime bdate;
        string adress;
        string tel;
        string mail;
        Guid departmentId;
        Guid authorityId;
        string departmentName;
        string authorityName;

        public Employee() { }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Employee(Guid id, string tc, string name, string surname, DateTime bdate,
        string adress, string tel, string mail, string departmentName, string authorityName,
        Guid departmentId,
        Guid authorityId)
        {
            this.id = id;
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentName = departmentName;
            this.authorityName = authorityName;
            this.departmentId = departmentId;
            this.authorityId = authorityId;
        }
        public Employee(Guid id, string tc, string name, string surname, DateTime bdate,
       string adress, string tel, string mail, string departmentName,
       Guid departmentId,
       Guid authorityId)
        {
            this.id = id;
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentName = departmentName;

            this.departmentId = departmentId;
            this.authorityId = authorityId;
        }

        public Employee(Guid id, string tc, string name, string surname, DateTime bdate, string adress, string tel, string mail, string departmentName, string authorityName)
        {
            this.id = id;
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentName = departmentName;
            this.authorityName = authorityName;
        }
        public Employee(string tc, string name, string surname, DateTime bdate, string adress, string tel, string mail, string departmentName, string authorityName)
        {

            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentName = departmentName;
            this.authorityName = authorityName;
        }
        public Employee(string tc, string name, string surname, DateTime bdate, string adress, string tel, string mail, string departmentName)
        {
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentName = departmentName;
        }
        public Employee(string tc, string name, string surname,
            DateTime bdate, string adress, string tel, string mail, Guid departmentId, Guid authorityId)
        {
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentId = departmentId;
            this.authorityId = authorityId;
            this.authorityName = authorityName;
            this.departmentName = departmentName;
        }



        public Guid Id { get => id; set => id = value; }
        public Guid DepartmentId { get => departmentId; set => departmentId = value; }
        public Guid AuthorityId { get => authorityId; set => authorityId = value; }
        public string Tc { get => tc; set => tc = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Bdate { get => bdate; set => bdate = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string AuthorityName { get => authorityName; set => authorityName = value; }
    }
}
