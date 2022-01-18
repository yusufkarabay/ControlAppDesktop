using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Request
    {
        Guid requestId;
        string requestTitle;
        string requestContent;
        DateTime requestTime;
        bool isSend;
     
        public Request(string requestTitle, string requestContent, DateTime requestTime)
        {
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.requestTime = requestTime;
        }
        
        public Request()
        {

        }

        public Request(Guid requestId, string requestTitle, string requestContent, DateTime requestTime)
        {
            this.requestId = requestId;
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.requestTime = requestTime;

        }
        public Request(Guid requestId, string requestTitle, string requestContent, DateTime requestTime,bool isSend)
        {
            this.requestId = requestId;
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.requestTime = requestTime;
            this.isSend=isSend; 
        }
        public Request(Guid requestId,  bool isSend)
        {
            this.requestId = requestId;
            this.isSend = isSend;
        }

        public Guid RequestId { get => requestId; set => requestId = value; }
        public string RequestTitle { get => requestTitle; set => requestTitle = value; }
        public string RequestContent { get => requestContent; set => requestContent = value; }
        public DateTime RequestTime { get => requestTime; set => requestTime = value; }
        public bool IsSend { get => isSend; set => isSend = value; }
    }
}
