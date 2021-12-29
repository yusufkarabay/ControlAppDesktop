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
        public SentryToDo() {   }
        public SentryToDo(string toDo, DateTime createdTime, string createdEmployee)
        {
            this.toDo = toDo;
            this.createdTime = createdTime; 
            this.CreatedEmployee = createdEmployee;
        }
        public SentryToDo(string toDo, DateTime createdTime) {
            this.toDo = toDo;
            this.CreatedTime = createdTime;
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
    }
}
