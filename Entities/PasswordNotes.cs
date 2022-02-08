using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PasswordNotes
    {
        Guid passwordId;
        string passwordTitle;
        string password;        
        string passwordNote;       
        DateTime createdTime;
        string createdEmployee;
        string employeeName;
        Guid departmentId;
       
        public PasswordNotes()
        {

        }

        public PasswordNotes(string passwordTitle, string password, string passwordNote, DateTime createdTime, string createdEmployee)
        {
            this.passwordTitle=passwordTitle;
            this.password=password;
            this.passwordNote=passwordNote;
            this.createdTime=createdTime;
            this.createdEmployee=createdEmployee;
        }
        public PasswordNotes(string passwordTitle, string password, string passwordNote, DateTime createdTime, string createdEmployee,Guid departmentId)
        {
            this.passwordTitle=passwordTitle;
            this.password=password;
            this.passwordNote=passwordNote;
            this.createdTime=createdTime;
            this.createdEmployee=createdEmployee;
            this.departmentId=departmentId;
        }

        public PasswordNotes(Guid passwordId, string passwordTitle, string password, string passwordNote,  DateTime createdTime,string createdEmployee)
        {
            this.passwordId=passwordId;
            this.passwordTitle=passwordTitle;
            this.password=password;
            this.passwordNote=passwordNote;
            this.createdEmployee=createdEmployee;
            this.createdTime=createdTime;
        }

        public PasswordNotes(Guid passwordId, string passwordTitle, string password, string passwordNote, DateTime createdTime, string createdEmployee, string employeeName)
        {
            this.passwordId=passwordId;
            this.passwordTitle=passwordTitle;
            this.password=password;
            this.passwordNote=passwordNote;
            this.createdTime=createdTime;
            this.createdEmployee=createdEmployee;
            this.employeeName=employeeName;
            
        }
        public PasswordNotes(Guid passwordId, string passwordTitle, string password, string passwordNote, DateTime createdTime, string createdEmployee, string employeeName,Guid departmentId)
        {
            this.passwordId=passwordId;
            this.passwordTitle=passwordTitle;
            this.password=password;
            this.passwordNote=passwordNote;
            this.createdTime=createdTime;
            this.createdEmployee=createdEmployee;
            this.employeeName=employeeName;
            this.departmentId=departmentId;

        }

        public Guid PasswordId { get => passwordId; set => passwordId=value; }
        public string PasswordTitle { get => passwordTitle; set => passwordTitle=value; }
        public string Password { get => password; set => password=value; }
        public string PasswordNote { get => passwordNote; set => passwordNote=value; }
        public string CreatedEmployee { get => createdEmployee; set => createdEmployee=value; }
        public DateTime CreatedTime { get => createdTime; set => createdTime=value; }
        public string EmployeeName { get => employeeName; set => employeeName=value; }
        public Guid DepartmentId { get => departmentId; set => departmentId=value; }
    }
}
