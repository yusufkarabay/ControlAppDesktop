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
        static EmployeeDal employeeDal;
        SqlService sqlService;
     
 
        public EmployeeDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Employee entity)
        {
            string result = null;

            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("EmployeeCreate", new SqlParameter("@tc", entity.Tc),
                   new SqlParameter("@surname", entity.Surname), new SqlParameter("@bdate", entity.Bdate), new SqlParameter("@adrees", entity.Adress), new SqlParameter("@tel", entity.Tel), new SqlParameter("@mail", entity.Mail),
                   new SqlParameter("@departmanid", entity.DepartmentId), new SqlParameter("@authorityid", entity.AuthorityId));

                if (isSuccess)
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

            return result;
        }

        public string Delete(Guid id)
        {
            string result = null;

            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("EmployeeDelete", new SqlParameter("@id", id));
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

        public List<Employee> GetByTc(string procuderName, string tc)
        {
            List<Employee> employeesList = null;

            try
            {

                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@tc", tc));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    employeesList = new List<Employee>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Employee employee = new Employee(dataRow["TC"].ToString(), dataRow["NAME"].ToString(), dataRow["SURNAME"].ToString(),
                            dataRow["BDATE"].ConDate(), dataRow["ADRESS"].ToString(),
                            dataRow["TEL"].ToString(), dataRow["MAIL"].ToString(), dataRow["DEPARTMENTNAME"].ToString());

                        employeesList.Add(employee);
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return employeesList;
        }

        public List<Employee> GetAll()
        {

            List<Employee> employeesList = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("EmployeeList");
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    employeesList = new List<Employee>();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        employeesList.Add(new Employee(
                         (Guid)dataRow["ID"],
                        dataRow["TC"].ToString(),
                        dataRow["NAME"].ToString(),
                        dataRow["SURNAME"].ToString(),
                        dataRow["BDATE"].ConDate(),
                        dataRow["ADRESS"].ToString(),
                       dataRow["TEL"].ToString(),
                       dataRow["MAIL"].ToString(),
                       dataRow["DEPARTMENTNAME"].ToString(),
                       dataRow["AUTHORITYNAME"].ToString(),
                       (Guid)dataRow["DEPARTMENTID"],
                       (Guid)dataRow["AUTHORITYID"]));
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return employeesList;
        }

        public string Update(Employee entity, string oldName)
        {

            string result = null;

            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("EmployeeUpdate", new SqlParameter("@tc", entity.Tc), new SqlParameter("name", entity.Name), new SqlParameter("surname", entity.Surname), new SqlParameter("bdate", entity.Bdate), new SqlParameter("adress", entity.Adress),
                    new SqlParameter("@tel", entity.Tel), new SqlParameter("@mail", entity.Mail), new SqlParameter("departmentid", entity.DepartmentId), new SqlParameter(@"authorityid", entity.AuthorityId));

                if (isSuccess)
                {
                    result = entity.Tc + " Personeli Başarıyla Güncellendi";
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

        public static EmployeeDal GetInstance()
        {
            if (employeeDal == null)
            {
                employeeDal = new EmployeeDal();
            }
            return employeeDal;
        }

        public object[] Login(string tc, string password)
        {

            object[] infos = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("EmployeeLogin", new SqlParameter("@tc", tc), new SqlParameter("@password", password));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        string name, surname, departmentName, authorityName;
                        Guid departmentId, authorityId;

                        name = dataRow["NAME"].ToString();
                        surname = dataRow["SURNAME"].ToString();
                        departmentName = dataRow["DEPARTMENTNAME"].ToString();
                        authorityName = dataRow["AUTHORITYNAME"].ToString();
                        departmentId = (Guid)dataRow["DEPARTMENTID"];
                        authorityId = (Guid)dataRow["AUTHORITYID"];
                        infos = new object[] { tc, name, surname, departmentName, authorityName, departmentId, authorityId };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { }

            return infos;
        }

        public Employee Get(Guid id)
        {
            Employee employee = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("EmployeeGet", new SqlParameter("@id", id));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        string tc, name, surname, departmentName, authorityName, address, mail, tel;
                        DateTime bdate;
                        Guid departmentId, authorityId;

                        tc = dataRow["TC"].ToString();
                        name = dataRow["NAME"].ToString();
                        surname = dataRow["SURNAME"].ToString();
                        departmentName = dataRow["DEPARTMENTNAME"].ToString();
                        authorityName = dataRow["AUTHORITYNAME"].ToString();
                        departmentId = (Guid)dataRow["DEPARTMENTID"];
                        authorityId = (Guid)dataRow["AUTHORITYID"];
                        address = dataRow["ADRESS"].ToString();
                        mail = dataRow["MAIL"].ToString();
                        tel = dataRow["TEL"].ToString();
                        bdate = dataRow["BDATE"].ConDate();

                        employee = new Employee
                        {
                            Tc = tc,
                            Name = name,
                            Surname = surname,
                            DepartmentId = departmentId,
                            AuthorityId = authorityId,
                            Id = id,
                            AuthorityName = authorityName,
                            DepartmentName = departmentName,
                            Adress = address,
                            Mail = mail,
                            Tel = tel,
                            Bdate = bdate
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }

            return employee;
        }

        public string UpdateNew(Employee entity)
        {

            string result = null;

            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("EmployeeUpdate", new SqlParameter("@tc", entity.Tc), new SqlParameter("name", entity.Name), new SqlParameter("surname", entity.Surname), new SqlParameter("bdate", entity.Bdate), new SqlParameter("adress", entity.Adress),
                    new SqlParameter("@tel", entity.Tel), new SqlParameter("@mail", entity.Mail), new SqlParameter("departmentid", entity.DepartmentId), new SqlParameter(@"authorityid", entity.AuthorityId));

                if (isSuccess)
                {
                    result = entity.Tc + " Personeli Başarıyla Güncellendi";
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
    }
}
