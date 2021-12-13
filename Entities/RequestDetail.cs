using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RequestDetail
    {
        Guid requestDetailId;
        Guid requestId;
        string requesting;
        string requested;
        string requestingName;
        string requestTitle;
        string requestContent;

        public RequestDetail(Guid requestId, string requestingName,  string requestTitle, string requestContent)
        {
            this.requestId = requestId;
           
            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
            this.requestingName = requestingName;
        }

        public RequestDetail(Guid requestDetailId, Guid requestId, string requestingName,  string requestTitle, string requestContent)

        {
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
          
            this.requestingName = requestingName;
            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
        }

        public Guid RequestDetailId { get => requestDetailId; set => requestDetailId = value; }
        public Guid RequestId { get => requestId; set => requestId = value; }
        public string Requesting { get => requesting; set => requesting = value; }
        public string Requested { get => requested; set => requested = value; }
        public string RequestTitle { get => requestTitle; set => requestTitle = value; }
        public string RequestContent { get => requestContent; set => requestContent = value; }
        public string RequestingName { get => requestingName; set => requestingName = value; }
    }
}
