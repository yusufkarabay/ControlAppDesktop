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
        string name;       
        string surname;
        string password;
        string rePassword;
        DateTime bdate;
        string adress;
        string tel;
        string mail;

     
        string departmentName;
        string authorityName;
        string employeeFullName;        
        string employeeName;
        string employeeSurname;


        string tc;
        Guid departmentId;
        Guid authorityId;
        bool isDeleted;
        string approvedEmployee;
        bool isUser;


        public Employee() { }
        public string FullName
        {
            get
            {
                return employeeName + " " + employeeSurname;
            }
        }
        public Employee(string tc, string employeeName, string employeeSurname)
        {
            this.tc = tc;
            this.employeeName = employeeName;
            this.employeeSurname = employeeSurname;
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
        //onaylanmış personel listelemesi

        public Employee(Guid id, string tc, string name, string surname, DateTime bdate,
        string adress, string tel, string mail, string departmentName, string authorityName,
        Guid departmentId,
        Guid authorityId,bool isDeleted, string approvedEmployee)
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
            this.isDeleted=isDeleted;
            this.approvedEmployee= approvedEmployee; 
        }
        // onaylanmamış personelin listelenmesi
        public Employee(Guid id, string tc, string name, string surname, DateTime bdate,
        string adress, string tel, string mail, bool isDeleted, string approvedEmployee)/*, Guid departmentId, string departmentName, Guid authorityId, string authorityName)*/
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
            this.isDeleted = isDeleted;
            this.approvedEmployee = approvedEmployee;
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
        public Employee(string tc, string name, string surname,
            DateTime bdate, string adress, string tel,
            string mail, Guid departmentId, Guid authorityId, string departmentName, string authorityName)
        {

            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentId = departmentId;
            this.departmentName = departmentName;
            this.authorityName = authorityName;
            this.authorityId = authorityId;
        }
        // İçerden kullanıcı yada personel ekleme
        public Employee(
            string tc, 
            string name,
            string surname,
           DateTime bdate, 
           string adress,
           string tel,
           string mail,
           string password,
           string rePassword,
           Guid departmentId,
           Guid authorityId,
           bool isDeleted,
           bool isUser)
        {

            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentId = departmentId;
            this.password = password;
            this.rePassword = rePassword;
            this.authorityId = authorityId;
            this.isDeleted = isDeleted;
            this.isUser=isUser; 
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
        public Employee(
            string tc,
            string name,
            string surname,
            DateTime bdate,
            string adress,
            string tel,
            string mail,
            Guid departmentId
           )// Guid authorityId
        {
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
            this.departmentId = departmentId;
            //this.authorityId = authorityId;

        }
        public Employee(
            Guid id,
            Guid departmentId,
            Guid authorityId,
            string tc,
            string name,
            string surname,
            DateTime bdate,
            string adress,
            string tel,
            string mail,
            string departmentName,
            string authorityName

       )
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
            this.authorityName = authorityName;
        }

        public Employee( string tc, string name, string surname, string password, string rePassword, DateTime bdate, string adress, string tel, string mail)
        {
            
            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.rePassword = rePassword;
            this.bdate = bdate;
            this.adress = adress;
            this.tel = tel;
            this.mail = mail;
        }

        public Employee(string tc, Guid departmentId, Guid authorityId, bool isDeleted, string approvedEmployee)
        {
            this.tc = tc;
            this.departmentId = departmentId;
            this.authorityId = authorityId;
            this.isDeleted = isDeleted;
            this.approvedEmployee = approvedEmployee;
        }
        public Employee(string tc ,bool isDeleted, string approvedEmployee)
        {
            this.tc = tc;           
            this.isDeleted = isDeleted;
            this.approvedEmployee = approvedEmployee;
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
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeSurname { get => employeeSurname; set => employeeSurname = value; }
        public string EmployeeFullName { get => employeeFullName; set => employeeFullName = value; }
        public string Password { get => password;  }
        public string RePassword { get => rePassword; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
       
        public string ApprovedEmployee { get => approvedEmployee; set => approvedEmployee = value; }
        public bool IsUser { get => isUser; set => isUser = value; }
    }
}
