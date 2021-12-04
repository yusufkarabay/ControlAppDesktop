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
        string requestedName;

        public RequestDetail(Guid requestId, string requesting, string requested, string requestingName, string requestedName)
        {
            this.requestId = requestId;
            this.requesting = requesting;
            this.requested = requested;
            this.requestingName = requestingName;
            this.requestedName = requestedName;
        }

        public RequestDetail(Guid requestDetailId, Guid requestId, string requesting, string requested, string requestingName, string requestedName)
        {
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
            this.requesting = requesting;
            this.requested = requested;
            this.requestingName = requestingName;
            this.requestedName = requestedName;
        }

        public Guid RequestDetailId { get => requestDetailId; set => requestDetailId = value; }
        public Guid RequestId { get => requestId; set => requestId = value; }
        public string Requesting { get => requesting; set => requesting = value; }
        public string Requested { get => requested; set => requested = value; }
        public string RequestingName { get => requestingName; set => requestingName = value; }
        public string RequestedName { get => requestedName; set => requestedName = value; }
    }
}
