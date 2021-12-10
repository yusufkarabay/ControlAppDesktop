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
    public class DepartmentManager
    {
        static DepartmentManager departmentManager;
        DepartmentDal departmentDal;
        string controlText;
        private DepartmentManager()
        {
            departmentDal = DepartmentDal.GetInstance();
        }

        string IsDepartmentComplete(Department department)
        {
            if (string.IsNullOrEmpty(department.DepartmentName))
            {
                return "Lütfen Departman Adını Giriniz";
            }
            if (department.DepartmentName.Length > 50)
            {
                return "Departman İsmi İçin En Fazla 50 Karakter Giriş Yapabilirsiniz";
            }
            return "";
        }
        public string Add(Department entity)
        {
            try
            {
                controlText = IsDepartmentComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return departmentDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Departman Seçiniz.";
                }
                return departmentDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
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
                return departmentDal.GetAll();
            }
            catch
            {
                return new List<Department>();
            }
        }

        public string Update(Department entity, string oldName)
        {
            try
            {

                if (entity.DepartmentId == null)
                {
                    return "Güncellemek İçin Lütfen Geçerli Bir Departman Seçiniz.";
                }
                controlText = IsDepartmentComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                if (string.IsNullOrEmpty(oldName))
                {
                    return "Departman Bilgileri Bulunamadı";
                }
                return departmentDal.Update(entity, oldName);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static DepartmentManager GetInstance()
        {
            if (departmentManager == null) { departmentManager = new DepartmentManager(); }
            return departmentManager;
        }
    }
}
