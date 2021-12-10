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

namespace DataAccess.Concrete
{
    public class DepartmentDal : IRepository<Department>
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
            try
            {
                dataReader = sqlService.StoreReader("@DepartmentCreate", new SqlParameter("@departmentName", entity.DepartmentName));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.DepartmentName + " Adında Başka Bir Departman Bulunmaktadır.";
                }
                else
                {
                    return entity.DepartmentName + " Departmanı Başarıyla Kaydedildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                sqlService.Stored("DepartmentDelete", new SqlParameter("@departmentid", id));
                return "Departman Başarıyla Silindi";
            }
            catch (Exception ex)
            {

                return ex.Message; ;
            }
        }

        public Department Get(Guid id)
        {
            return null;
        }

        public List<Department> GetAll()
        {
            try
            {
                List<Department> list = new List<Department>();
                dataReader = sqlService.StoreReader("DepartmentList");
                while (dataReader.Read())
                {
                    Department department = new Department(dataReader["DEPARTMENTNAME"].ToString());
                    list.Add(department);
                }
                dataReader.Close();
                return list;
            }
            catch (Exception)
            {

                return new List<Department>();
            }
        }

        public string Update(Department entity, string oldName)
        {
            try
            {
                dataReader = sqlService.StoreReader("DepartmentUpdate", new SqlParameter("@departmentid", entity.DepartmentId), new SqlParameter("@departmentName", entity.DepartmentName), new SqlParameter("@@departmentOldName", oldName));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();

                }
                dataReader.Close();
                if (result)
                {
                    return entity.DepartmentName + " Adında Başka Bir Departman Bulunmaktadır.";
                }
                return entity.DepartmentName + " Departmanı Başarıyla Güncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
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
