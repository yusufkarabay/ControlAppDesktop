using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Maintenance
    {
        Guid maintenanceId, contractId;
        int maintenanceMonth;
        DateTime firstMaintenanceDate;
        string contractName;

        public Maintenance()
        {

        }
        public Maintenance(Guid contractId, string contractName, int maintenanceMonth, DateTime firstMaintenanceDate)
        {
            this.contractId = contractId;
            this.maintenanceMonth = maintenanceMonth;
            this.firstMaintenanceDate = firstMaintenanceDate;
            this.contractName = contractName;   
        }
        public Maintenance(Guid contractId, string contractName, Guid maintenanceId, int maintenanceMonth, DateTime firstMaintenanceDate)
        {
            this.maintenanceId = maintenanceId;
            this.contractId = contractId;
            this.maintenanceMonth = maintenanceMonth;
            this.firstMaintenanceDate = firstMaintenanceDate;
            this.contractName = contractName;
        }

        public Maintenance(Guid maintenanceId, Guid contractId, int maintenanceMonth, DateTime firstMaintenanceDate, string contractName)
        {
            this.maintenanceId = maintenanceId;
            this.contractId = contractId;
            this.maintenanceMonth = maintenanceMonth;
            this.firstMaintenanceDate = firstMaintenanceDate;
            this.contractName = contractName;
        }

        public Maintenance(Guid maintenanceId, Guid contractId, string contractName, int maintenanceMonth, DateTime firstMaintenanceDate)
        {
            this.maintenanceId = maintenanceId;
            this.contractId = contractId;
            this.maintenanceMonth = maintenanceMonth;
            this.firstMaintenanceDate = firstMaintenanceDate;
            this.contractName = contractName;
        }

        public Guid MaintenanceId { get => maintenanceId; set => maintenanceId = value; }
        public Guid ContractId { get => contractId; set => contractId = value; }
        public int MaintenanceMonth { get => maintenanceMonth; set => maintenanceMonth = value; }
        public DateTime FirstMaintenanceDate { get => firstMaintenanceDate; set => firstMaintenanceDate = value; }
        public string ContractName { get => contractName; set => contractName = value; }
    }
}
