using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SentryToDo
    {
        Guid sentryToDoId;
        string toDo;
        DateTime createdTime;
        string createdEmployee;
        string employeeName;
        Guid departmentId;
        public SentryToDo() {   }
        public SentryToDo(string toDo, DateTime createdTime, string createdEmployee,Guid departmentId)
        {
            this.toDo = toDo;
            this.createdTime = createdTime; 
            this.CreatedEmployee = createdEmployee;
            this.departmentId = departmentId;
        }
        public SentryToDo(string toDo, DateTime createdTime) {
            this.toDo = toDo;
            this.CreatedTime = createdTime;
        }
        public SentryToDo(Guid sentryToDoId, string toDo, DateTime createdTime, string createdEmployee, string employeeName,Guid departmentId)
        {
            this.sentryToDoId = sentryToDoId;
            this.toDo = toDo;
            this.createdTime = createdTime;
            this.createdEmployee = createdEmployee;
            this.employeeName= employeeName;
            this.departmentId = departmentId;
        }
        public SentryToDo(Guid sentryToDoId, string toDo, DateTime createdTime, string createdEmployee)
        {
            this.sentryToDoId = sentryToDoId;
            this.toDo = toDo;
            this.createdTime = createdTime;
            this.createdEmployee = createdEmployee;
            
        }

        public Guid SentryToDoId { get => sentryToDoId; set => sentryToDoId = value; }
        public string ToDo { get => toDo; set => toDo = value; }
        public DateTime CreatedTime { get => createdTime; set => createdTime = value; }
        public string CreatedEmployee { get => createdEmployee; set => createdEmployee = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public Guid DepartmentId { get => departmentId; set => departmentId = value; }
    }
}
