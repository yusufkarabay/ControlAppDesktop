using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Generator
    {
        Guid generatorTimeId;
        int generatorIWorkedTime;
        string createdEmployee;
        DateTime addedTime;

        public Generator()
        {

        }
        public Generator(Guid generatorTimeId, int generatorIWorkedTime, string createdEmployee, DateTime addedTime)
        {
            this.generatorTimeId = generatorTimeId;
            this.generatorIWorkedTime = generatorIWorkedTime;
            this.createdEmployee = createdEmployee;
            this.addedTime = addedTime;
        }
       
        public Generator(int generatorIWorkedTime, string createdEmployee, DateTime addedTime)
        {

            this.generatorIWorkedTime = generatorIWorkedTime;
            this.createdEmployee = createdEmployee;
            this.addedTime = addedTime;
        }
        public Guid GeneratorTimeId { get => generatorTimeId; set => generatorTimeId = value; }
        public int GeneratorIWorkedTime { get => generatorIWorkedTime; set => generatorIWorkedTime = value; }
        public string CreatedEmployee { get => createdEmployee; set => createdEmployee = value; }
        public DateTime AddedTime { get => addedTime; set => addedTime = value; }
       
    }
}
