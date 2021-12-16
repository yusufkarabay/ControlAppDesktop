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
           new SqlParameter("@departmanid", entity.DepartmentId), new SqlParameter("@authorityid", entity.AuthorityId));
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
                sqlService.StoreReader("EmployeeDelete", new SqlParameter("@id", id));
                return "Personel Başarı İle Silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Employee> GetByTc(string procuderName, string tc)
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                dataReader = sqlService.StoreReader(procuderName, new SqlParameter("@tc", tc));
                while (dataReader.Read())
                {
                    Employee employee = new Employee(dataReader["TC"].ToString(), dataReader["NAME"].ToString(), dataReader["SURNAME"].ToString(),
                        dataReader["BDATE"].ConDate(), dataReader["ADRESS"].ToString(),
                        dataReader["TEL"].ToString(), dataReader["MAIL"].ToString(), dataReader["DEPARTMENTNAME"].ToString());
                    employees.Add(employee);
                }
                dataReader.Close();
                return employees;


            }
            catch
            {

                return new List<Employee>();
            }
        }

        public List<Employee> GetAll()
        {

            try
            {
                List<Employee> list = new List<Employee>();
                dataReader = sqlService.StoreReader("EmployeeList");
                while (dataReader.Read())
                {
                    list.Add(new Employee((Guid)dataReader["ID"], dataReader["TC"].ToString(), dataReader["NAME"].ToString(), dataReader["SURNAME"].ToString(), dataReader["BDATE"].ConDate(), dataReader["ADRESS"].ToString(),
                         dataReader["TEL"].ToString(), dataReader["MAIL"].ToString(), dataReader["DEPARTMENTNAME"].ToString(), dataReader["AUTHORITYNAME"].ToString(), (Guid)dataReader["DEPARTMENTID"], (Guid)dataReader["AUTHORITYID"]));

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
            try
            {
                object[] infos = null;
                dataReader = sqlService.StoreReader("EmployeeLogin", new SqlParameter("@tc", tc), new SqlParameter("@password", password));
                if (dataReader.Read())
                {
                    string name, surname, departmentName, authorityName;
                    Guid departmentId, authorityId;


                    name = dataReader["NAME"].ToString();
                    surname = dataReader["SURNAME"].ToString();
                    departmentName = dataReader["DEPARTMENTNAME"].ToString();
                    authorityName = dataReader["AUTHORITYNAME"].ToString();
                    departmentId = (Guid)dataReader["DEPARTMENTID"];
                    authorityId = (Guid)dataReader["AUTHORITYID"];
                    infos = new object[] { tc, name, surname, departmentName, authorityName, departmentId, authorityId };

                }

                dataReader.Close();
                return infos;
            }
            catch
            {
                return null;
            }
        }

        public Employee Get(Guid id)
        {
            Employee employee = null;
            SqlDataReader dr = null;

            try
            {
                dr = sqlService.StoreReader("EmployeeGet", new SqlParameter("@id", id));

                if (dr.Read())
                {
                    string tc, name, surname, departmentName, authorityName, address, mail, tel;
                    DateTime bdate;
                    Guid departmentId, authorityId;

                    tc = dataReader["TC"].ToString();
                    name = dataReader["NAME"].ToString();
                    surname = dataReader["SURNAME"].ToString();
                    departmentName = dataReader["DEPARTMENTNAME"].ToString();
                    authorityName = dataReader["AUTHORITYNAME"].ToString();
                    departmentId = (Guid)dataReader["DEPARTMENTID"];
                    authorityId = (Guid)dataReader["AUTHORITYID"];
                    address = dataReader["ADRESS"].ToString();
                    mail = dataReader["MAIL"].ToString();
                    tel = dataReader["TEL"].ToString();
                    bdate = dataReader["BDATE"].ConDate();

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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dr.Close();
            }

            return employee;
        }
    }
}
