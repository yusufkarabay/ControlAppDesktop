using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MaintenanceMonth
    {
        int mainTenanceMonth;
        public MaintenanceMonth()
        {

        }
        public MaintenanceMonth(int mainTenanceMonth)
        {
            this.mainTenanceMonth = mainTenanceMonth;
        }

        public int MainTenanceMonth { get => mainTenanceMonth; set => mainTenanceMonth = value; }
    }
}
