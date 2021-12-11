﻿using System;
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
                return " Adress Bilgisi 300 karakterden fazla Olamaz";
            }
            if (employee.Tel.Length > 10)
            {
                return " Telefon Numarasını Başında Sıfır Olmadan 10 Hane Şeklinde Giriniz";
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
                if (id == null)
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

        public Employee Get(Guid id)
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

        public string Update(Employee entity, string oldName)
        {
            try
            {
                if (entity.Id == null)
                {
                    return " Güncellemek İstediğiniz Personeli Seçiniz";

                }
                controlText = IsEmployeeComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                if (string.IsNullOrEmpty(oldName))
                {
                    return " Personel Bilgileri Bulunamadı";
                }
                return employeeDal.Update(entity, oldName); 
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

    }
}