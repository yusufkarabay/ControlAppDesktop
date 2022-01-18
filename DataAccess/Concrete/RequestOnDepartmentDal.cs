using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RequestOnDepartmentDal : SqlService, IRepository<RequestOnDepartment>
    {
        static RequestOnDepartmentDal requestOnDepartmentDal;
        SqlService sqlService;
        public RequestOnDepartmentDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public static RequestOnDepartmentDal GetInstance()
        {
            if (requestOnDepartmentDal==null)
            {
                requestOnDepartmentDal = new RequestOnDepartmentDal();
            }
            return requestOnDepartmentDal;
        }
        public string Add(RequestOnDepartment entity)
        {
            throw new NotImplementedException();
        }

        public List<RequestOnDepartment> GetByDepartmentId(string proceduerName, Guid departmentId)
        {
            List<RequestOnDepartment> requestOnDepartments = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(proceduerName, new SqlParameter("@departmentid", departmentId));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    requestOnDepartments = new List<RequestOnDepartment>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        requestOnDepartments.Add(new RequestOnDepartment(
                        Guid.Parse(dataRow["REQUESTGROUPID"].ToString()),
                        Guid.Parse(dataRow["REQUESTID"].ToString()),
                        dataRow["REQUESTTITLE"].ToString(),
                        dataRow["REQUESTCONTENT"].ToString(),
                        DateTime.Parse(dataRow["REQUESTTIME"].ToString()),
                        dataRow["REQUESTING"].ToString(),
                        Guid.Parse(dataRow["DEPATMENTID"].ToString())));


                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return requestOnDepartments;
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public RequestOnDepartment Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<RequestOnDepartment> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(RequestOnDepartment entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(RequestOnDepartment entity)
        {
            throw new NotImplementedException();
        }
    }
}
