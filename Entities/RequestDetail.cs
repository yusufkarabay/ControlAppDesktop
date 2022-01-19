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
        string requestedName;
        string requestingName;
        string requestTitle;
        string requestContent;
        Guid departmentId;
        string departmentName;
        DateTime requestTime;
        bool isSend;

        public RequestDetail()
        {

        }

        public RequestDetail(Guid requestId, bool isSend)
        {
            this.requestId = requestId;
            this.isSend = isSend;
        }
        public RequestDetail(Guid requestId, string requesting, Guid departmentId, string requested)
        {
            this.requestId = requestId;
            this.requesting = requesting;
            this.departmentId = departmentId;
            this.requested = requested;
        }
        public RequestDetail(Guid requestDetailId, Guid requestId, string requesting, Guid departmentId, string requested)
        {
            this.requestId = requestId;
            this.requesting = requesting;
            this.departmentId = departmentId;
            this.requested = requested;
            this.requestDetailId = requestDetailId;
        }
        public RequestDetail(Guid requestId, string requesting, Guid departmentId, bool isSend)
        {
            this.requestId = requestId;
            this.requesting = requesting;
            this.departmentId = departmentId;
            this.isSend = isSend;
        }


        public RequestDetail(Guid requestId, string requestingName, string requestTitle, string requestContent)
        {
            this.requestId = requestId;

            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
            this.requestingName = requestingName;
        }
        //******
        public RequestDetail(
            Guid requestDetailId,
            Guid requestId,
            string requestTitle,
            string requestContent,
            DateTime requestTime, 
            Guid departmentId,
            string departmentName, 
            string requesting,
            string requestingName)

        {
            this.departmentName = departmentName;
            this.requestTime = requestTime;
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
            this.requestingName = requestingName;
            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
            this.departmentId = departmentId;
            this.requesting = requesting;
        }
        public RequestDetail(
            Guid requestDetailId,
            Guid requestId,
            string requestTitle,
            string requestContent,
            DateTime requestTime,            
            string departmentName,
            string requesting,
            string requestingName)

        {
            this.departmentName = departmentName;
            this.requestTime = requestTime;
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
            this.requestingName = requestingName;
            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
           
            this.requesting = requesting;
        }
        public RequestDetail(Guid requestDetailId, Guid requestId, string requestingName, string requestTitle, string requestContent,
            Guid departmentId, Guid requestGroupId)

        {
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
            this.requestingName = requestingName;
            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
            this.departmentId = departmentId;

        }

        public RequestDetail(Guid requestDetailId, Guid requestId, string requestingName, string requestTitle, string requestContent,
           Guid departmentId)
        {
            this.requestDetailId = requestDetailId;
            this.requestId = requestId;
            this.requestingName = requestingName;
            this.requestContent = requestContent;
            this.requestTitle = requestTitle;
            this.departmentId = departmentId;
        }

        public RequestDetail(string requestContent, string requestTitle, string requesting)
        {
            this.requesting = requesting;
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
        public Guid DepartmentId { get => departmentId; set => departmentId = value; }

        public bool IsSend { get => isSend; set => isSend = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public DateTime RequestTime { get => requestTime; set => requestTime = value; }
        public string RequestedName { get => requestedName; set => requestedName = value; }
    }
}
