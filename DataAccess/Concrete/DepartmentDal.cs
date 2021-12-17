using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;

namespace DataAccess.Concrete
{
    public class DepartmentDal
    {
        static DepartmentDal departmentDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        public DepartmentDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Department entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("@DepartmentCreate", new SqlParameter("@departmentName", entity.DepartmentName));
                if (isSuccess)
                {
                    result = entity.DepartmentName + " Departmanı Başarıyla Kaydedildi.";
                }
                else
                {
                    result = msg;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }

        public string Delete(Guid id)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("DepartmentDelete", new SqlParameter("@departmentid", id));
                if (isSuccess)
                {
                    result = "Departman Başarıyla Silindi";
                }
                else
                {
                    result = msg;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }
        public Department Get(Guid id)
        {
            Department department = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("DepartmentList", new SqlParameter("@departmentId", id));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        department = new Department(Guid.Parse(dataRow["DEPARTMENTID"].ToString()), dataRow["DEPARTMENTNAME"].ToString());
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return department;
        }

        public List<Department> GetByName(string procuderName, string departmentName)
        {
            List<Department> list = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("DepartmentList", new SqlParameter("@departmentName", departmentName));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    list = new List<Department>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Department department = new Department(dataRow["DEPARTMENTNAME"].ToString());
                        list.Add(department);
                    }
                }

            }
            catch (Exception ex) { }
            finally { }
            return list;
        }
        public List<Department> GetAll()
        {
            List<Department> list = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("DepartmentList");
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    list = new List<Department>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Department department = new Department(dataRow["DEPARTMENTNAME"].ToString());
                        list.Add(department);
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return list;

        }

        public string Update(Department entity, string oldName)
        {
            string result = null;

            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("DepartmentUpdate", new SqlParameter("@departmentid", entity.DepartmentId), new SqlParameter("@departmentName", entity.DepartmentName), new SqlParameter("@departmentOldName", oldName));
                if (isSuccess)
                {
                    result = entity.DepartmentName + " Departmanı Başarıyla Güncellendi";
                }
                else
                {
                    result = msg;
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return result;

        }
        public static DepartmentDal GetInstance()
        {
            if (departmentDal == null)
            {
                departmentDal = new DepartmentDal();
            }
            return departmentDal;
        }
    }
}
