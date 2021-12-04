using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Department
    {
        Guid departmentId;
        string departmentName;

        public Guid DepartmentId { get => departmentId; set => departmentId = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }

        public Department(Guid departmentId, string departmentName)
        {
            this.departmentId = departmentId;
            this.departmentName = departmentName;
        }

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }
    }
}
