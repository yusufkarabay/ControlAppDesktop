using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RequestOnDepartmentManager
    {
        static RequestOnDepartmentManager requestOnDepartmentManager;
        RequestOnDepartmentDal requestOnDepartmentDal;
        public RequestOnDepartmentManager()
        {
            requestOnDepartmentDal = RequestOnDepartmentDal.GetInstance();
        }
        public static RequestOnDepartmentManager GetInstance()
        {
            if (requestOnDepartmentManager == null)
            {
                requestOnDepartmentManager = new RequestOnDepartmentManager();
            }
            return requestOnDepartmentManager;
        }
        public List<RequestOnDepartment> GetByDepartmentId(string procuderName, Guid departmentId)
        {
            try
            {
                return requestOnDepartmentDal.GetByDepartmentId(procuderName, departmentId);
            }
            catch
            {

                return new List<RequestOnDepartment>();
            }
        }
    }
}
