using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess.Concrete
{
    public class EmployeeDal : SqlService, IRepository<Employee>
    {
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        public EmployeeDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Employee entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("EmployeeCreate", new SqlParameter("@tc", entity.Tc),
           new SqlParameter("@surname", entity.Surname), new SqlParameter("@bdate", entity.Bdate), new SqlParameter("@adrees", entity.Adress), new SqlParameter("@tel", entity.Tel), new SqlParameter("@mail", entity.Mail),
           new SqlParameter("@departmanid", entity.DepartmentId), new SqlParameter("@@authorityid", entity.AuthorıtyId));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                    dataReader.Close();

                }
                if (result)
                {
                    return entity.Tc + " TC Kimlik Numaralı Personel Daha Önce Eklenmiştir";
                }
                else
                {
                    return entity.Name + " İsimli Personel Başarıyla Eklendi";
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
                sqlService.StoreReader("EmployeeDelete", new SqlParameter("@id", id);
                return "Personel Başarı İle Silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Employee Get(Guid id)
        {
            return null;
        }

        public List<Employee> GetAll()
        {

            try
            {
                List<Employee> list = new List<Employee>();
                dataReader = sqlService.StoreReader("EmployeeList");
                while (dataReader.Read())
                {
                    list.Add(new Employee(dataReader["TC"].ToString(), dataReader["NAME"].ToString(), dataReader["SURNAME"].ToString(), dataReader["BDATE"].ConDate(), dataReader["ADRESS"].ToString(),
                         dataReader["TEL"].ToString(), dataReader["MAIL"].ToString(), dataReader["DEPARTMENTNAME"].ToString(), dataReader["AUTHORITYNAME"].ToString()));

                }
                dataReader.Close();
                return list;
            }
            catch
            {

                return new List<Employee>();
            }
        }

        public string Update(Employee entity, string oldName)
        {

            try
            {
                dataReader = sqlService.StoreReader("EmployeeUpdate", new SqlParameter("@tc", entity.Tc), new SqlParameter("name", entity.Name), new SqlParameter("bdate", entity.Bdate), new SqlParameter("ædress", entity.Adress),
                new SqlParameter("@tel", entity.Tel), new SqlParameter("@mail", entity.Mail), new SqlParameter(), new SqlParameter("departmentId", entity.DepartmentId), new SqlParameter(@"authorityId", entity.AuthorityId));

                {
                    return entity.Tc + " Personel Başarıyla Güncellendi";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
