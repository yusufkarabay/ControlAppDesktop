
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Fuel
    {
        Guid fuelId;
        DateTime fuelTime;
        string fuelEmployee;
        string fuelEmployeeName;

        public Fuel()
        {

        }
        public Fuel(string fuelEmployee)
        {
            this.fuelEmployee = fuelEmployee;

        }
        public Fuel(DateTime fuelTime)
        {

            this.fuelTime = fuelTime;

        }
        public Fuel(DateTime fuelTime, string fuelEmployee)
        {

            this.fuelTime = fuelTime;
            this.fuelEmployee = fuelEmployee;
        }
        public Fuel(DateTime fuelTime, string fuelEmployee, string fuelEmployeeName)
        {

            this.fuelTime = fuelTime;
            this.fuelEmployee = fuelEmployee;
            this.fuelEmployeeName = fuelEmployeeName;
        }
        public Fuel(Guid fuelId, DateTime fuelTime, string fuelEmployee)
        {
            this.fuelId = fuelId;
            this.fuelTime = fuelTime;
            this.fuelEmployee = fuelEmployee;
        }

        public Guid FuelId { get => fuelId; set => fuelId = value; }
        public DateTime FuelTime { get => fuelTime; set => fuelTime = value; }
        public string FuelEmployee { get => fuelEmployee; set => fuelEmployee = value; }
        public string FuelEmployeeName { get => fuelEmployeeName; set => fuelEmployeeName = value; }
    }
}
