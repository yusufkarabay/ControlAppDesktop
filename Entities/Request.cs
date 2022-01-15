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
     
        public Request(string requestTitle, string requestContent, DateTime requestTime)
        {
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.requestTime = requestTime;
        }

        public Request(Guid requestId, string requestTitle, string requestContent, DateTime requestTime)
        {
            this.requestId = requestId;
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.requestTime = requestTime;
            
        }

        public Guid RequestId { get => requestId; set => requestId = value; }
        public string RequestTitle { get => requestTitle; set => requestTitle = value; }
        public string RequestContent { get => requestContent; set => requestContent = value; }
        public DateTime RequestTime { get => requestTime; set => requestTime = value; }
        
    }
}
