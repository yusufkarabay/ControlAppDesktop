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

        public Guid RequestDetailId { get => requestDetailId; set => requestDetailId = value; }
        public Guid RequestId { get => requestId; set => requestId = value; }
        public string Requesting { get => requesting; set => requesting = value; }
        public string Requested { get => requested; set => requested = value; }

        public RequestDetail(Guid requestDetailId, Guid requestId, string requesting, string requested)
        {
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
            this.requesting = requesting;
            this.requested = requested;
        }

        public RequestDetail(Guid requestId, string requesting, string requested)
        {
            this.requestId = requestId;
            this.requesting = requesting;
            this.requested = requested;
        }

    }
}
