using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RequestOnDepartment
    {
        Guid requestGroupId;
        Guid requestId;
        string requestTitle;
        string requestContent;
        DateTime requestTime;
        string requesting;
        Guid departmentId;
        string requested;
        string requestingName;
        

        public RequestOnDepartment()
        {

        }
        public RequestOnDepartment(Guid requestGroupId, Guid requestId,string requestTitle,string requestContent, DateTime requestTime, string requesting, string requestingName, Guid departmentId, string requested)
        {
            this.requestGroupId = requestGroupId;
            this.requestId = requestId;
            this.requesting = requesting;
            this.departmentId = departmentId;
            this.requested = requested;
            this.requestContent = requestContent;
            this.requestTime = requestTime;
            this.requestTitle = requestTitle;
            this.requestingName = requestingName;   
        }
        public RequestOnDepartment(Guid requestGroupId, Guid requestId, string requestTitle, string requestContent, DateTime requestTime, string requesting, Guid departmentId)
        {
            this.requestGroupId = requestGroupId;
            this.requestId = requestId;
            this.requesting = requesting;
            this.departmentId = departmentId;
           
            this.requestContent = requestContent;
            this.requestTime = requestTime;
            this.requestTitle = requestTitle;

        }

        public Guid RequestGroupId { get => requestGroupId; set => requestGroupId = value; }
        public Guid RequestId { get => requestId; set => requestId = value; }
        public string Requesting { get => requesting; set => requesting = value; }
        public Guid DepartmentId { get => departmentId; set => departmentId = value; }
        public string Requested { get => requested; set => requested = value; }
        public string RequestTitle { get => requestTitle; set => requestTitle = value; }
        public string RequestContent { get => requestContent; set => requestContent = value; }
        public DateTime RequestTime { get => requestTime; set => requestTime = value; }
        public string RequestingName { get => requestingName; set => requestingName = value; }
    }
}
