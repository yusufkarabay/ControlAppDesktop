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
    public class PasswordNotesManager
    {
        static PasswordNotesManager passwordNotesManager;
        PasswordNotesDal passwordNotesDal;

        public PasswordNotesManager()
        {
            passwordNotesDal=PasswordNotesDal.GetInstance();
        }

        public static PasswordNotesManager GetInstance()
        {
            if (passwordNotesManager == null)
            {
                passwordNotesManager = new PasswordNotesManager();

            }
            return passwordNotesManager;
        }
        public string Add(PasswordNotes entity)
        {
            try
            {
                return passwordNotesDal.Add(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
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
            try
            {
                return passwordNotesDal.GetAll();
            }
            catch (Exception)
            {

                return new List<PasswordNotes>();
            }
        }

        public List<PasswordNotes> GetAllByDepartment(string procuderName, Guid departmentId)
        {
            try
            {
                return passwordNotesDal.GetAllByDepartment(procuderName, departmentId);
            }
            catch
            {
                return new List<PasswordNotes>();
            }
        }
        public List<PasswordNotes> GetPasswordTitle(string procuderName, string passwordtitle,Guid departmentId)
        {
            try
            {
                if (passwordtitle == null)
                {
                    return null;
                }
                return passwordNotesDal.GetPasswordTitle(procuderName, passwordtitle,departmentId);

            }
            catch (Exception)
            {

                return new List<PasswordNotes>();
            }
        }

        public string Update(PasswordNotes entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(PasswordNotes entity)
        {
            try
            {
                if (entity.PasswordId == null)
                {
                    return " Güncellemek İstediğiniz Şifreyi Seçiniz";

                }

                return passwordNotesDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
