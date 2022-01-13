using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MaintenanceMail
    {
        Guid maintenanceMailId;
        string maintenanceEMail, maintenanceEmployeeName;

        public MaintenanceMail()
        {

        }
        public MaintenanceMail(string maintenanceEMail, string maintenanceEmployeeName)
        {

            this.maintenanceEMail = maintenanceEMail;
            this.maintenanceEmployeeName = maintenanceEmployeeName;
        }
        public MaintenanceMail(Guid maintenanceMailId, string maintenanceEMail, string maintenanceEmployeeName)
        {
            this.maintenanceMailId = maintenanceMailId;
            this.maintenanceEMail = maintenanceEMail;
            this.maintenanceEmployeeName = maintenanceEmployeeName;
        }

        public Guid MaintenanceMailId { get => maintenanceMailId; set => maintenanceMailId = value; }
        public string MaintenanceEMail { get => maintenanceEMail; set => maintenanceEMail = value; }
        public string MaintenanceEmployeeName { get => maintenanceEmployeeName; set => maintenanceEmployeeName = value; }
    }
}
