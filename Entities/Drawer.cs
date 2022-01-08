using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Drawer
    {
        Guid drawerId;
        string drawerNo;
        string receiverEmployee;
        string deliveryEmployee;
        DateTime deliveryDate;
        string receiverPersonName;
        string deliveryPersonName;

        public Drawer()
        {

        }
        public Drawer(Guid drawerId,
            string drawerNo,
            string receiverEmployee,
            string receiverPersonName,
            string deliveryEmployee,
            string deliveryPersonName,
            DateTime deliveryDate)
        {
            this.drawerId = drawerId;
            this.drawerNo = drawerNo;
            this.receiverEmployee = receiverEmployee;
            this.receiverPersonName = receiverPersonName;
            this.deliveryEmployee = deliveryEmployee;
            this.deliveryPersonName = deliveryPersonName;
            this.deliveryDate = deliveryDate;


        }
        public Drawer(

           string drawerNo,
           string receiverEmployee,
           string deliveryEmployee,
           DateTime deliveryDate)
        {
            this.drawerNo = drawerNo;
            this.receiverEmployee = receiverEmployee;
            this.deliveryEmployee = deliveryEmployee;
            this.deliveryDate = deliveryDate;
        }




        public Guid DrawerId { get => drawerId; set => drawerId = value; }
        public string DrawerNo { get => drawerNo; set => drawerNo = value; }
        public string ReceiverEmployee { get => receiverEmployee; set => receiverEmployee = value; }
        public string DeliveryEmployee { get => deliveryEmployee; set => deliveryEmployee = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public string ReceiverPersonName { get => receiverPersonName; set => receiverPersonName = value; }
        public string DeliveryPersonName { get => deliveryPersonName; set => deliveryPersonName = value; }
    }
}
