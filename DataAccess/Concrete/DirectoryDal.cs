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
    public class DirectoryDal : SqlService, IRepository<Directory>
    {
        static DirectoryDal directoryDal;
        SqlService sqlService;
        public DirectoryDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Directory entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("DirectoryAdd", new SqlParameter("@directoryuser", entity.DirectoryUserName),
                    new SqlParameter("@directoryuserphone", entity.DirectoryPhone), new SqlParameter("@info", entity.Info));
                if (isSuccess)
                {
                    return entity.DirectoryUserName + " Adlı Kayıt Telefon Rehberine Eklenmiştir...";
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
            throw new NotImplementedException();
        }

        public Directory Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Directory> GetAll()
        {

            List<Directory> directories = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("DirectoryAllList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    directories = new List<Directory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        directories.Add(new Directory(
                       Guid.Parse(dataRow["DIRECTORYID"].ToString()),
                       dataRow["DIRECTORYUSER"].ToString(),
                       dataRow["USERPHONE"].ToString(),
                       dataRow["INFO"].ToString()));

                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return directories;
        }
        public List<Directory> DirectoryByUserName(string procuderName, string directoryuser)
        {

            List<Directory> directories = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@directoryuser", directoryuser));

                if (dt.Rows.Count > 0)
                {
                    directories = new List<Directory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        directories.Add(new Directory(
                     Guid.Parse(dataRow["DIRECTORYID"].ToString()),
                     dataRow["DIRECTORYUSER"].ToString(),
                     dataRow["USERPHONE"].ToString(),
                     dataRow["INFO"].ToString()));


                    }
                }
                else directories = null;
            }

            catch (Exception ex) { }
            finally { }

            return directories;
        }
        public List<Directory> DirectoryByUserPhone(string procuderName, string directoryuserphone)
        {
            List<Directory> directories = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@directoryuserphone", directoryuserphone));

                if (dt.Rows.Count > 0)
                {
                    directories = new List<Directory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        directories.Add(new Directory(
                     Guid.Parse(dataRow["DIRECTORYID"].ToString()),
                     dataRow["DIRECTORYUSER"].ToString(),
                     dataRow["USERPHONE"].ToString(),
                     dataRow["INFO"].ToString()));


                    }
                }
                else directories = null;
            }

            catch (Exception ex) { }
            finally { }

            return directories;
        }
        public List<Directory> DirectoryByInfo(string procuderName, string info)
        {

            List<Directory> directories = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@info", info));

                if (dt.Rows.Count > 0)
                {
                    directories = new List<Directory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        directories.Add(new Directory(
                     Guid.Parse(dataRow["DIRECTORYID"].ToString()),
                     dataRow["DIRECTORYUSER"].ToString(),
                     dataRow["USERPHONE"].ToString(),
                     dataRow["INFO"].ToString()));


                    }
                }
                else directories = null;
            }

            catch (Exception ex) { }
            finally { }

            return directories;
        }

        public string Update(Directory entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Directory entity)
        {
            throw new NotImplementedException();
        }
        public static DirectoryDal GetInstance()
        {
            if (directoryDal == null)
            {
                directoryDal = new DirectoryDal();
            }
            return directoryDal;
        }
    }
}
