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
        DateTime date;
     
        public Request(string requestTitle, string requestContent, DateTime date)
        {
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.date = date;
        }

        public Request(Guid requestId, string requestTitle, string requestContent, DateTime date)
        {
            this.requestId = requestId;
            this.requestTitle = requestTitle;
            this.requestContent = requestContent;
            this.date = date;
            
        }

        public Guid RequestId { get => requestId; set => requestId = value; }
        public string RequestTitle { get => requestTitle; set => requestTitle = value; }
        public string RequestContent { get => requestContent; set => requestContent = value; }
        public DateTime Date { get => date; set => date = value; }
        
    }
}
