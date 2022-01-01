﻿using System;
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
        string employeeName;

        public Inventory()
        {

        }
        public Inventory(Guid inventoryId)
        {
            this.inventoryId = inventoryId;
        }

        public Inventory(Guid inventoryId, string inventorySeriNo, string inventoryName, int amount, string info, string createdEmployee, DateTime createdTime)
        {
            this.inventoryId = inventoryId;
            this.inventorySeriNo = inventorySeriNo;
            this.inventoryName = inventoryName;
            this.amount = amount;
            this.createdEmployee = createdEmployee;
            this.createdTime = createdTime;
            this.info = info;
        }
        public Inventory(Guid inventoryId, string inventorySeriNo, string inventoryName, int amount, string info, DateTime createdTime, string createdEmployee, string employeeName)
        {
            this.inventoryId = inventoryId;
            this.inventorySeriNo = inventorySeriNo;
            this.inventoryName = inventoryName;
            this.amount = amount;
            this.createdEmployee = createdEmployee;
            this.createdTime = createdTime;
            this.info = info;
            this.employeeName = employeeName;
        }
        
        public Inventory(string inventorySeriNo, string inventoryName, int amount, string info, DateTime createdTime, string createdEmployee, string employeeName)
        {
            this.inventorySeriNo = inventorySeriNo;
            this.inventoryName = inventoryName;
            this.amount = amount;
            this.info = info;
            this.createdEmployee = createdEmployee;
            this.createdTime = createdTime;
            this.employeeName=employeeName;
        }
        public Inventory(string inventorySeriNo, string inventoryName, int amount, string info, string createdEmployee, DateTime createdTime)
        {
            this.inventorySeriNo = inventorySeriNo;
            this.inventoryName = inventoryName;
            this.amount = amount;
            this.info = info;
            this.createdEmployee = createdEmployee;
          
        }

        public Guid InventoryId { get => inventoryId; set => inventoryId = value; }
        public string InventorySeriNo { get => inventorySeriNo; set => inventorySeriNo = value; }
        public string InventoryName { get => inventoryName; set => inventoryName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string CreatedEmployee { get => createdEmployee; set => createdEmployee = value; }
        public DateTime CreatedTime { get => createdTime; set => createdTime = value; }
        public string Info { get => info; set => info = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
    }
}
