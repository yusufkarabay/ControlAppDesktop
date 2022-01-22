using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;

namespace Business.Concrete
{
    public class EmployeeManager
    {
        static EmployeeManager employeeManager;
        EmployeeDal employeeDal;
        string controlText;
        public EmployeeManager()
        {
            employeeDal = EmployeeDal.GetInstance();
        }
        string IsEmployeeComplete(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.Name))
            {
                return "Lütfen Personel Adını Giriniz";
            }
            if (employee.Name.Length > 30)
            {
                return "Personel Adı 30 Karakterden Fazla Olamaz!";
            }
            if (string.IsNullOrEmpty(employee.Surname))
            {
                return "Lütfen Personel Soyadını Giriniz";
            }
            if (employee.Surname.Length > 20)
            {
                return "Personel Soyadı 20 Karakterden Fazla Olamaz!";
            }
            if (string.IsNullOrEmpty(employee.Tc))
            {
                return "Lütfen TC Kimlik Numarasını Giriniz";
            }
            if (employee.Tc.Length > 11)
            {
                return "TC Kimlik Numarası 11 Rakamdan Fazla Olamaz! ";
            }
            if (employee.Bdate == null)
            {
                return "Lütfen Personel Doğum Tarihini Giriniz";
            }
            if (employee.Adress.Length > 200)
            {
                return " Adress Bilgisi 200 karakterden fazla Olamaz";
            }

            if (employee.DepartmentId == null)
            {
                return " Personel İçin Lütfen Departman Seçiniz";
            }
            if (employee.AuthorityId == null)
            {
                return " Personel İçin Lütfen Yetki Seçiniz";
            }

            return "";
        }

        public string Add(Employee entity)
        {
            try
            {
                controlText = IsEmployeeComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return employeeDal.Add(entity);
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
                if (id == Guid.Empty)
                {
                    return "Silmek İçin Lütfen Geçerli Bir Personel Seçiniz.";
                }
                return employeeDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Employee GetById(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return null;
                }

                return employeeDal.Get(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Employee> GetByTc(string procuderName, string tc)
        {
            try
            {
                if (tc == null)
                {
                    return null;
                }
                return employeeDal.GetByTc(procuderName, tc);

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }
        public List<Employee> GetByName(string procuderName, string name)
        {
            try
            {
                if (name == null)
                {
                    return null;
                }
                return employeeDal.GetByName(procuderName, name);

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }
        public List<Employee> GetByTel(string procuderName, string tel)
        {
            try
            {
                if (tel == null)
                {
                    return null;
                }
                return employeeDal.GetByTel(procuderName, tel);

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }

        public List<Employee> GetByMail(string procuderName, string mail)
        {
            try
            {
                if (mail == null)
                {
                    return null;
                }
                return employeeDal.GetByMail(procuderName, mail);

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }

        public List<Employee> GetBySurname(string procuderName, string surname)
        {
            try
            {
                if (surname == null)
                {
                    return null;
                }
                return employeeDal.GetBySurname(procuderName, surname);

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }
        public List<Employee> GetByDepartment(string procuderName, string departmentid)
        {
            try
            {
                if (departmentid == null)
                {
                    return null;
                }
                return employeeDal.GetByDepartment(procuderName, departmentid);

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }


        public Employee Get(string tc)
        {
            return null;
        }

        public List<Employee> GetAll()
        {
            try
            {
                return employeeDal.GetAll();
            }
            catch
            {
                return new List<Employee>();
            }
        }
        public List<Employee> GetEmployeeMiniList()
        {
            try
            {
                return employeeDal.GetEmployeeMiniList();
            }
            catch
            {
                return new List<Employee>();
            }
        }

        public List<Employee> NotCheckedEmployeeList()
        {
            try
            {
                
                return employeeDal.NotCheckedEmployeeList();

            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }


        public string Checked(Employee entity)
        {
            try
            {
                if (entity.Tc == null)
                {
                    return " Onaylamak İstediğiniz Personeli Seçiniz";
                }
                return employeeDal.Checked(entity);
            }

            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Update(Employee entity)
        {
            try
            {
                if (entity.Tc == null)
                {
                    return " Güncellemek İstediğiniz Personeli Seçiniz";

                }
                controlText = IsEmployeeComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return employeeDal.Update(entity, "");
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string UpdateNew(Employee entity)
        {
            try
            {
                if (entity.Tc == null)
                {
                    return " Güncellemek İstediğiniz Personeli Seçiniz";

                }
                controlText = IsEmployeeComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return employeeDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static EmployeeManager GetInstance()
        {
            if (employeeManager == null) { employeeManager = new EmployeeManager(); }
            return employeeManager;
        }

        public object[] Login(string tc, string password)
        {
            try
            {
                return employeeDal.Login(tc.Trim(), password.Trim());
            }
            catch
            {

                return null;
            }
        }
    }
}
