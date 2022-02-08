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
    public class PasswordNotesDal : SqlService, IRepository<PasswordNotes>
    {
        static PasswordNotesDal passwordNotesDal;
        SqlService sqlService;
        public PasswordNotesDal()
        {
            sqlService=SqlDatabase.GetInstance();
        }
        public string Add(PasswordNotes entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("PasswordNotesCreate", new SqlParameter("@passwordtitle", entity.PasswordTitle),
                    new SqlParameter("@password", entity.Password), new SqlParameter("@passwordnotes", entity.PasswordNote),
                    new SqlParameter("@createdtime", entity.CreatedTime), new SqlParameter("@createdemployee", entity.CreatedEmployee), new SqlParameter("@departmentid", entity.DepartmentId));
                if (isSuccess)
                {
                    return "Şifre Kaydedilmiştir";
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

        public PasswordNotes Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PasswordNotes> GetAll()
        {
            List<PasswordNotes> passwordNotes = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("PasswordNotesList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    passwordNotes = new List<PasswordNotes>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        passwordNotes.Add(new PasswordNotes(
                       Guid.Parse(dataRow["PASSWORDID"].ToString()),
                       dataRow["PASSWORDTITLE"].ToString(),
                       dataRow["PASSWORD"].ToString(),
                       dataRow["PASSWORDNOTES"].ToString(),
                       DateTime.Parse(dataRow["CREATEDTIME"].ToString()),
                       dataRow["CREATEDEMPLOYEE"].ToString(),
                        $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}"));

                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return passwordNotes;
        }
        public List<PasswordNotes> GetPasswordTitle(string procuderName, string passwordtitle,Guid departmentId)
        {
            List<PasswordNotes> passwordNotes = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@passwordtitle", passwordtitle),new SqlParameter("@departmentid",departmentId));

                if (dt.Rows.Count > 0)
                {
                    passwordNotes = new List<PasswordNotes>();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        passwordNotes.Add(new PasswordNotes(
                          Guid.Parse(dataRow["PASSWORDID"].ToString()),
                       dataRow["PASSWORDTITLE"].ToString(),
                       dataRow["PASSWORD"].ToString(),
                       dataRow["PASSWORDNOTES"].ToString(),
                       DateTime.Parse(dataRow["CREATEDTIME"].ToString()),
                       dataRow["CREATEDEMPLOYEE"].ToString(),
                        $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}"
                        ));
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return passwordNotes;
        }
        public List<PasswordNotes> GetAllByDepartment(string procuderName, Guid departmentId)
        {
            List<PasswordNotes> passwordNotes = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@departmentid", departmentId));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    passwordNotes = new List<PasswordNotes>();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        passwordNotes.Add(new PasswordNotes(
                          Guid.Parse(dataRow["PASSWORDID"].ToString()),
                       dataRow["PASSWORDTITLE"].ToString(),
                       dataRow["PASSWORD"].ToString(),
                       dataRow["PASSWORDNOTES"].ToString(),
                       DateTime.Parse(dataRow["CREATEDTIME"].ToString()),
                       dataRow["CREATEDEMPLOYEE"].ToString(),
                        $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}"
                        ));
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return passwordNotes;
        }
        public string Update(PasswordNotes entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(PasswordNotes entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("PasswordNotesUpdate", new SqlParameter("@passwordid", entity.PasswordId),
                   new SqlParameter("@passwordtitle", entity.PasswordTitle),
                    new SqlParameter("@password", entity.Password), new SqlParameter("@passwordnotes", entity.PasswordNote),
                    new SqlParameter("@createdtime", entity.CreatedTime), new SqlParameter("@createdemployee", entity.CreatedEmployee),new SqlParameter("@departmentid",entity.DepartmentId));
                if (isSuccess)
                {
                    result = "Şifre  Başarı İle Güncellendi";
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
        public static PasswordNotesDal GetInstance()
        {
            if (passwordNotesDal == null)
            {
                passwordNotesDal = new PasswordNotesDal();
            }
            return passwordNotesDal;
        }
    }
}
