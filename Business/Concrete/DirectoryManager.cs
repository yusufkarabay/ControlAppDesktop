
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DirectoryManager : IRepository<Directory>
    {
        static DirectoryManager directoryManager;
        DirectoryDal directoryDal;
        public DirectoryManager()
        {
            directoryDal = DirectoryDal.GetInstance();
        }

        public string Add(Directory entity)
        {

            try
            {
                return directoryDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Kayıt Seçiniz.";
                }
                return directoryDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Directory Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Directory> GetAll()
        {
            try
            {
                return directoryDal.GetAll();
            }
            catch (Exception)
            {

                return new List<Directory>();
            }
        }


        public List<Directory> DirectoryByUserName(string procuderName, string directoryuser)
        {
            try
            {
                if (directoryuser == null)
                {
                    return null;
                }
                return directoryDal.DirectoryByUserName(procuderName, directoryuser);
            }
            catch (Exception)
            {

                return new List<Directory>();
            }
        }
        public List<Directory> DirectoryByUserPhone(string procuderName, string directoryuserphone)
        {
            try
            {
                if (directoryuserphone == null)
                {
                    return null;
                }
                return directoryDal.DirectoryByUserPhone(procuderName, directoryuserphone);
            }
            catch (Exception)
            {

                return new List<Directory>();
            }
        }
        public List<Directory> DirectoryByInfo(string procuderName, string info)
        {
            try
            {
                if (info == null)
                {
                    return null;
                }
                return directoryDal.DirectoryByInfo(procuderName, info);
            }
            catch (Exception)
            {

                return new List<Directory>();
            }
        }


        public string Update(Directory entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Directory entity)
        {
            try
            {
                if (entity.DirectoryUserName == null)
                {
                    return " Güncellemek İstediğiniz Envanteri Seçiniz";

                }
                
                return directoryDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static DirectoryManager GetInstance()
        {
            if (directoryManager == null)
            {
                directoryManager = new DirectoryManager();
            }
            return directoryManager;

        }
    }
}
