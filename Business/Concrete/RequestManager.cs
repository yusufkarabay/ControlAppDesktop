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
    public class RequestManager
    {
        static RequestManager requestManager;
        RequestDal requestDal;
        string controlText;
        public RequestManager()
        {
            requestDal = RequestDal.GetInstance();
        }
        string IsRequestComplete(Request request)
        {
            if (string.IsNullOrEmpty(request.RequestTitle))
            {
                return "Lütfen Konu Alanını Doldurunuz";
            }
            if (request.RequestTitle.Length > 100)
            {
                return "Konu Adı 100 Karakterden Fazla Olamaz";
            }
            if (request.RequestContent.Length > 1000)
            {
                return "Talep İçin En Fazla 100 Karakter Giriş Yapabilirsiniz";
            }
            if (string.IsNullOrEmpty(request.RequestContent))
            {
                return "Lütfen Talep İçeriğini Giriniz";
            }
            return "";
        }
        public string Add(Request entity)
        {
            try
            {
                controlText = IsRequestComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return requestDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Talep  Seçiniz.";
                }
                return requestDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Request Get(Guid id)
        {
            return null;
        }

        public List<Request> GetAll()
        {
            try
            {
                return requestDal.GetAll();
            }
            catch
            {

                return new List<Request>();
            }
        }
        public string RequestIsSend(Request entity)
        {
            try
            {
                if (entity.RequestId == null)
                {
                    return " Talep Gönderilemedi";

                }
               
                return requestDal.RequestIsSend(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public List<Request> RequestSendedList(string procedureName, string createdEmployee)
        {
            try
            {
                return requestDal.RequestSendedList(procedureName,createdEmployee);
            }
            catch
            {

                return new List<Request>();
            }
        }
        

        public string Update(Request entity, string oldName)
        {
            try
            {
                if (entity.RequestTitle == null)
                {
                    return "Talep Konu Alanı Boş Geçilemez";
                }
                controlText = IsRequestComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                
                return requestDal.Update(entity,"");
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
        
        public static RequestManager GetInstance()
        {
            if (requestManager == null)
            {
                requestManager = new RequestManager();

            }
            return requestManager;
        }
    }
}
