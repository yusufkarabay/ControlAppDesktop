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
    public class GuestCardManager : IRepository<GuestCard>

    {
        static GuestCardManager guestCardManager;
        GuestCardDal guestCardDal;
        public GuestCardManager()
        {
            guestCardDal = GuestCardDal.GetInstance();
        }
        public string Add(GuestCard entity)
        {
            try
            {
                return guestCardDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Misafir Kartı Seçiniz.";
                }
                return guestCardDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public GuestCard Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<GuestCard> GetAll()
        {
            try
            {
                return guestCardDal.GetAll();
            }
            catch (Exception)
            {

                return new List<GuestCard>();
            }
        }

        public List<GuestCard> GuestCardByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {
            try
            {
                if (deliveryEmployeeName == null)
                {
                    return null;
                }
                return guestCardDal.GuestCardByDeliveryEmployee(procuderName, deliveryEmployeeName);
            }
            catch (Exception)
            {

                return new List<GuestCard>();
            }
        }
        public List<GuestCard> GuestCardByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            try
            {
                if (receiverEmployeeName == null)
                {
                    return null;
                }
                return guestCardDal.GuestCardByReceiverEmployee(procuderName, receiverEmployeeName);
            }
            catch (Exception)
            {

                return new List<GuestCard>();
            }
        }
        public List<GuestCard> GuestCardByGuestCardNo(string procuderName, string guestCardNo)
        {
            try
            {
                if (guestCardNo == null)
                {
                    return null;
                }
                return guestCardDal.GuestCardByGuestCardNo(procuderName, guestCardNo);
            }
            catch (Exception)
            {

                return new List<GuestCard>();
            }
        }


        public static GuestCardManager GetInstance()
        {
            if (guestCardManager == null)
            {
                guestCardManager = new GuestCardManager();

            }
            return guestCardManager;
        }

        public string Update(GuestCard entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(GuestCard entity)
        {
            throw new NotImplementedException();
        }
    }
}
