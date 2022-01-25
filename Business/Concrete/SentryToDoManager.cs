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
    public class SentryToDoManager
    {
        static SentryToDoManager sentryToDoManager;
        SentryToDoDal sentryToDoDal;
        string controlText;
        public SentryToDoManager()
        {
            sentryToDoDal = SentryToDoDal.GetInstance();
        }

        string IsSentryToDoComplete(SentryToDo sentryToDo)
        {
            if (string.IsNullOrEmpty(sentryToDo.ToDo))
            {
                return "Lütfen Bir İş Giriniz. Boş Kayıt Girilemez";
            }
            return "";

        }
        public string Add(SentryToDo entity)
        {
            try
            {
                controlText = IsSentryToDoComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return sentryToDoDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli İş Seçiniz.";
                }
                return sentryToDoDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateNew(SentryToDo entity)
        {
            try
            {
                if (entity.ToDo == null)
                {
                    return " Güncellemek İstediğiniz İşi Seçiniz";

                }
                controlText = IsSentryToDoComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return sentryToDoDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static SentryToDoManager GetInstance()
        {
            if (sentryToDoManager == null) { sentryToDoManager = new SentryToDoManager(); }
            return sentryToDoManager;
        }
        public List<SentryToDo> GetSentryToDoByDate(string procuderName, DateTime date,Guid departmentId)
        {
            try
            {
                if (date == null)
                {
                    return null;
                }
                return sentryToDoDal.GetSentryToDoByDate(procuderName, date,departmentId);

            }
            catch (Exception)
            {

                return new List<SentryToDo>();
            }
        }
        public SentryToDo GetSentryToDo(Guid todoSentryId)
        {
            try
            {
                if (todoSentryId == Guid.Empty)
                {
                    return null;
                }
                return sentryToDoDal.GetSentryToDo(todoSentryId);
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
