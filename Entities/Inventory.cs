using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Inventory
    {
        Guid inventoryId;
        string inventorySeriNo;
        string inventoryName;
        int amount;
        string info;
        string createdEmployee;
        DateTime createdTime;

        public Inventory()
        {

        }

        public Inventory(Guid inventoryId, string inventorySeriNo, string inventoryName, int amount, string info, string createdEmployee, DateTime createdTime)
        {
            this.inventoryId = inventoryId;
            this.inventorySeriNo = inventorySeriNo;
            this.inventoryName = inventoryName;
            this.amount = amount;
            this.info = info;
            this.createdEmployee = createdEmployee;
            this.createdTime = createdTime;
        }
        public Inventory(string inventorySeriNo, string inventoryName, int amount, string info, string createdEmployee, DateTime createdTime)
        {
            this.inventorySeriNo = inventorySeriNo;
            this.inventoryName = inventoryName;
            this.amount = amount;
            this.info = info;
            this.createdEmployee = createdEmployee;
            this.createdTime = createdTime;
        }

        public Guid InventoryId { get => inventoryId; set => inventoryId = value; }
        public string InventorySeriNo { get => inventorySeriNo; set => inventorySeriNo = value; }
        public string InventoryName { get => inventoryName; set => inventoryName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string CreatedEmployee { get => createdEmployee; set => createdEmployee = value; }
        public DateTime CreatedTime { get => createdTime; set => createdTime = value; }
        public string Info { get => info; set => info = value; }
    }
}
