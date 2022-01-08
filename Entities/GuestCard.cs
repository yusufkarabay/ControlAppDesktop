using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GuestCard
    {
        Guid guestCardId;
        string guestCardNo, receiverEmployee, deliveryEmployee, receiverPersonName, deliveryPersonName;
        DateTime deliveryDate;

        public GuestCard(Guid guestCardId, string guestCardNo, string receiverEmployee, string deliveryEmployee, string receiverPersonName, string deliveryPersonName, DateTime deliveryDate)
        {
            this.guestCardId = guestCardId;
            this.guestCardNo = guestCardNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.receiverPersonName = receiverPersonName;
            this.deliveryPersonName = deliveryPersonName;
            this.deliveryDate = deliveryDate;
        }
        public GuestCard( string guestCardNo, string receiverEmployee, string deliveryEmployee, DateTime deliveryDate)
        {
           
            this.guestCardNo = guestCardNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.deliveryDate = deliveryDate;
        }


        public Guid GuestCardId { get => guestCardId; set => guestCardId = value; }
        public string GuestCardNo { get => guestCardNo; set => guestCardNo = value; }
        public string ReceiverEmployee { get => receiverEmployee; set => receiverEmployee = value; }
        public string DeliveryEmployee { get => deliveryEmployee; set => deliveryEmployee = value; }
        public string ReceiverPersonName { get => receiverPersonName; set => receiverPersonName = value; }
        public string DeliveryPersonName { get => deliveryPersonName; set => deliveryPersonName = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
    }
}
