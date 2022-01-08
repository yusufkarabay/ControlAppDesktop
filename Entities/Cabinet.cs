using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cabinet
    {
        Guid cabinetId;
        string cabinetNo, receiverEmployee, deliveryEmployee, receiverPersonName, deliveryPersonName;
        DateTime deliveryDate;
        public Cabinet()
        {

        }
        public Cabinet(
            Guid cabinetId,
            string cabinetNo,
            string receiverEmployee,
            string receiverPersonName,
            string deliveryEmployee,
            string deliveryPersonName,
            DateTime deliveryDate)
        {
            this.cabinetId = cabinetId;
            this.cabinetNo = cabinetNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.receiverPersonName = receiverPersonName;
            this.deliveryPersonName = deliveryPersonName;
            this.deliveryDate = deliveryDate;
        }
        public Cabinet(
            string cabinetNo,
            string receiverEmployee,
            string deliveryEmployee,
            DateTime deliveryDate)
        {

            this.cabinetNo = cabinetNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.deliveryDate = deliveryDate;
        }



        public Guid CabinetId { get => cabinetId; set => cabinetId = value; }
        public string CabinetNo { get => cabinetNo; set => cabinetNo = value; }
        public string ReceiverEmployee { get => receiverEmployee; set => receiverEmployee = value; }
        public string DeliveryEmployee { get => deliveryEmployee; set => deliveryEmployee = value; }
        public string ReceiverPersonName { get => receiverPersonName; set => receiverPersonName = value; }
        public string DeliveryPersonName { get => deliveryPersonName; set => deliveryPersonName = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
    }
}
