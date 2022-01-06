using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntranceCard
    {
        Guid entranceCardId;
        string entranceCardSeriNo;
        string receiverEmployee;
        string deliveryEmployee;
        DateTime deliveryDate;
        string receiverPersonName;
        string deliveryPersonName;

        public EntranceCard() { }
        public EntranceCard(
            Guid entranceCardId,
            string entranceCardSeriNo,
            string receiverEmployee,
            string receiverPersonName,
            string deliveryEmployee,
            string deliveryPersonName,
            DateTime deliveryDate)
        {
            this.entranceCardId = entranceCardId;
            this.entranceCardSeriNo = entranceCardSeriNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.deliveryDate = deliveryDate;
            this.receiverPersonName = receiverPersonName;
            this.deliveryPersonName = deliveryPersonName;
        }
        public EntranceCard(string entranceCardSeriNo, string receiverEmployee, string deliveryEmployee, DateTime deliveryDate)
        {
            this.entranceCardSeriNo = entranceCardSeriNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.deliveryDate = deliveryDate;
        }

        public Guid EntranceCardId { get => entranceCardId; set => entranceCardId = value; }
        public string EntranceCardSeriNo { get => entranceCardSeriNo; set => entranceCardSeriNo = value; }
        public string ReceiverEmployee { get => receiverEmployee; set => receiverEmployee = value; }
        public string DeliveryEmployee { get => deliveryEmployee; set => deliveryEmployee = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public string ReceiverPersonName { get => receiverPersonName; set => receiverPersonName = value; }
        public string DeliveryPersonName { get => deliveryPersonName; set => deliveryPersonName = value; }
    }
}
