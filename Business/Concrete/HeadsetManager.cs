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
    public class HeadsetManager
    {
        static HeadsetManager headsetManager;
        HeadsetDal headsetDal;
        string controlText;
        public HeadsetManager()
        {
            headsetDal = HeadsetDal.GetInstance();
        }
        string IsHeadsetComplete(Headset headset)
        {
            if (string.IsNullOrEmpty(headset.ReceiverPerson))
            {
                return "Lütfen Teslim Edilecek Personel Seçiniz";
            }
            if (string.IsNullOrEmpty(headset.DeliveryPerson))
            {
                return "Teslim Eden Personel Bilgisine Ulaşılamadı";
            }
            if (string.IsNullOrEmpty(headset.HeadsetStatusInfo))
            {
                return "Lütfen Kulaklık Durumunu Giriniz";
            }
            if (string.IsNullOrEmpty(headset.HeadsetSeriNo))
            {
                return "Lütfen Kulaklık Seri Numarasını Giriniz";
            }
            
            return "";
        }
        public string Add(Headset entity)
        {
            try
            {
                controlText = IsHeadsetComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return headsetDal.Add(entity);
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
                return headsetDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Headset GetByEmployeeName(string procuderName, string receiverPerson)
        {
            try
            {
                if (receiverPerson==null)
                {
                    return null;
                }
                return headsetDal.GetByEmployeeName(procuderName,receiverPerson);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<Headset> GetAll()
        {
            try
            {
                return headsetDal.GetAll();
            }
            catch
            {
                return new List<Headset>();
            }
        }

        public List<Headset> HeadsetByDeliveryEmployee(string procuderName, string deliverypersonName)
        {

            try
            {
                if (deliverypersonName == null)
                {
                    return null;
                }
                return headsetDal.HeadsetByDeliveryEmployee(procuderName, deliverypersonName);
            }
            catch (Exception)
            {

                return new List<Headset>();
            }
        }
        public List<Headset> HeadsetByReceiverEmployee(string procuderName, string receiverpersonName)
        {

            try
            {
                if (receiverpersonName == null)
                {
                    return null;
                }
                return headsetDal.HeadsetByReceiverEmployee(procuderName, receiverpersonName);
            }
            catch (Exception)
            {

                return new List<Headset>();
            }
        }
        public List<Headset> HeadsetBySeriNo(string procuderName, string headsetserino)
        {

            try
            {
                if (headsetserino == null)
                {
                    return null;
                }
                return headsetDal.HeadsetBySeriNo(procuderName, headsetserino);
            }
            catch (Exception)
            {

                return new List<Headset>();
            }
        }
        


        public static HeadsetManager GetInstance()
        {
            if (headsetManager == null) { headsetManager = new HeadsetManager(); }
            return headsetManager;
        }
    }
}
