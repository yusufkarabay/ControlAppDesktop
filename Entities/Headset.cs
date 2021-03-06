using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Headset
    {
        Guid headsetId;
        string headsetSeriNo;
        string receiverPerson;
        string deliveryPerson;
        string headsetStatusInfo;
        DateTime deliveryDate;
        string receiverPersonName;
        string deliveryPersonName;

        public Headset()
        {

        }
        public Headset(
        Guid headsetId,
        string headsetSeriNo,
        string receiverPerson,
        string receiverPersonName,
        string deliveryPerson,
        string deliveryPersonName,
        string headsetStatusInfo,
        DateTime deliveryDate)

        {
            this.headsetId = headsetId;
            this.deliveryDate = deliveryDate;
            this.receiverPerson = receiverPerson;
            this.headsetStatusInfo = headsetStatusInfo;
            this.headsetSeriNo = headsetSeriNo;
            this.deliveryPerson = deliveryPerson;
            this.receiverPersonName = receiverPersonName;
            this.deliveryPersonName = deliveryPersonName;

        }
        public Headset(
        string headsetSeriNo,
        string receiverPerson,
        string deliveryPerson,
        string headsetStatusInfo,
        DateTime deliveryDate)

        {
            this.deliveryDate = deliveryDate;
            this.receiverPerson = receiverPerson;
            this.headsetStatusInfo = headsetStatusInfo;
            this.headsetSeriNo = headsetSeriNo;
            this.deliveryPerson = deliveryPerson;
        }
        public Headset(
       Guid headsetId,
       string headsetSeriNo,
       //string receiverPerson,
       string receiverPersonName,
       // string deliveryPerson,
       string deliveryPersonName,
       string headsetStatusInfo,
       DateTime deliveryDate)

        {
            this.headsetId = headsetId;
            this.deliveryDate = deliveryDate;
            // this.receiverPerson = receiverPerson;
            this.headsetStatusInfo = headsetStatusInfo;
            this.headsetSeriNo = headsetSeriNo;
            // this.deliveryPerson = deliveryPerson;
            this.receiverPersonName = receiverPersonName;
            this.deliveryPersonName = deliveryPersonName;

        }


        public Guid HeadsetId { get => headsetId; set => headsetId = value; }
        public string HeadsetSeriNo { get => headsetSeriNo; set => headsetSeriNo = value; }
        public string ReceiverPerson { get => receiverPerson; set => receiverPerson = value; }
        public string DeliveryPerson { get => deliveryPerson; set => deliveryPerson = value; }
        public string HeadsetStatusInfo { get => headsetStatusInfo; set => headsetStatusInfo = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public string ReceiverPersonName { get => receiverPersonName; set => receiverPersonName = value; }
        public string DeliveryPersonName { get => deliveryPersonName; set => deliveryPersonName = value; }
    }
}
