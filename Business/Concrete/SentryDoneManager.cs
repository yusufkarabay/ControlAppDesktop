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
    public class SentryDoneManager
    {
        static SentryDoneManager sentryDoneManager;
        SentryDoneDal sentryDoneDal;
        string controlText;
        public SentryDoneManager()
        {
            sentryDoneDal = SentryDoneDal.GetInstance();
        }

        string IsSentryDoneComplete(SentryDone sentryDone)
        {
            if (string.IsNullOrEmpty(sentryDone.Done))
            {
                return "Lütfen Bir İş Giriniz. Boş Kayıt Girilemez";
            }
            return "";

        }
        public string Add(SentryDone entity)
        {
            try
            {
                controlText = IsSentryDoneComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return sentryDoneDal.Add(entity);
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
                return sentryDoneDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SentryDone Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<SentryDone> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(SentryDone entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(SentryDone entity)
        {
            try
            {
                if (entity.Done == null)
                {
                    return " Güncellemek İstediğiniz İşi Seçiniz";

                }
                controlText = IsSentryDoneComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return sentryDoneDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static SentryDoneManager GetInstance()
        {
            if (sentryDoneManager == null) { sentryDoneManager = new SentryDoneManager(); }
            return sentryDoneManager;
        }


        public List<SentryDone> GetSentryByDate(string procuderName, DateTime date)
        {
            try
            {
                if (date == null)
                {
                    return null;
                }
                return sentryDoneDal.GetSentryByDate(procuderName, date);

            }
            catch (Exception)
            {

                return new List<SentryDone>();
            }
        }
        public SentryDone GetSentryDone(Guid donesentryid)
        {
            try
            {
                if (donesentryid == Guid.Empty)
                {
                    return null;
                }
                return sentryDoneDal.GetSentryDone(donesentryid);
            }
            catch (Exception)
            {

                return null;
            }
            
        }
    }
}
