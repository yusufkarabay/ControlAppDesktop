﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SentryDone
    {
        Guid sentrydoneId;
        string done;
        DateTime createdTime;
        string createdEmployee;
        string employeeName;

        public SentryDone(Guid sentrydoneId, string done, DateTime createdTime, string createdEmployee, string employeeName)
        {
            this.sentrydoneId = sentrydoneId; 
            this.done = done;
            this.createdTime = createdTime;
            this.createdEmployee = createdEmployee;
            this.employeeName = employeeName;
        }

        public SentryDone(Guid sentrydoneId, string done, DateTime createdTime, string createdEmployee)
        {
            this.sentrydoneId = sentrydoneId;
            this.done = done;
            this.createdTime = createdTime;
            this.createdEmployee = createdEmployee;
        }

        public SentryDone()
        {

        }
        public SentryDone(string done, DateTime createdTime, string createdEmployee)
        {
            this.done = done;
            this.createdTime = createdTime;
            this.createdEmployee = createdEmployee;
        }
        public SentryDone(string done, DateTime createdTime)
        {
            this.done = done;
            this.createdTime = createdTime;
            
        }
        public SentryDone(Guid sentrydoneId, string done, DateTime createdTime)
        {
            this.done = done;
            this.createdTime = createdTime;
            this.sentrydoneId = sentrydoneId;

        }

        public Guid SentrydoneId { get => sentrydoneId; set => sentrydoneId = value; }
        public string Done { get => done; set => done = value; }
        public DateTime CreatedTime { get => createdTime; set => createdTime = value; }
        public string CreatedEmployee { get => createdEmployee; set => createdEmployee = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
    }
}
