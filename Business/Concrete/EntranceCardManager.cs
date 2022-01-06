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
    public class EntranceCardManager : IRepository<EntranceCard>
    {
        static EntranceCardManager entranceCardManager;
        EntranceCardDal entranceCardDal;
        string controlText;
        public EntranceCardManager()
        {
            entranceCardDal = EntranceCardDal.GetInstance();
        }
        public string Add(EntranceCard entity)
        {
            try
            {
                return entranceCardDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Kart Seçiniz.";
                }
                return entranceCardDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<EntranceCard> EntranceCardByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {
            try
            {
                if (deliveryEmployeeName == null)
                {
                    return null;
                }
                return entranceCardDal.EntranceCardByDeliveryEmployee(procuderName, deliveryEmployeeName);
            }
            catch (Exception)
            {

                return new List<EntranceCard>();
            }
        }
        public List<EntranceCard> EntranceCardByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            try
            {
                if (receiverEmployeeName == null)
                {
                    return null;
                }
                return entranceCardDal.EntranceCardByReceiverEmployee(procuderName, receiverEmployeeName);
            }
            catch (Exception)
            {

                return new List<EntranceCard>();
            }
        }
        public List<EntranceCard> EntranceCardBySeriNo(string procuderName, string entranceCardSeriNo)
        {
            try
            {
                if (entranceCardSeriNo == null)
                {
                    return null;
                }
                return entranceCardDal.EntranceCardBySeriNo(procuderName, entranceCardSeriNo);
            }
            catch (Exception)
            {

                return new List<EntranceCard>();
            }
        }

        public EntranceCard Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<EntranceCard> GetAll()
        {
            try
            {
                return entranceCardDal.GetAll();
            }
            catch (Exception ) 
            {

                return new List<EntranceCard>();
            }
        }

        public string Update(EntranceCard entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(EntranceCard entity)
        {
            throw new NotImplementedException();
        }
        public static EntranceCardManager GetInstance()
        {
            if (entranceCardManager == null) { entranceCardManager = new EntranceCardManager(); }
            return entranceCardManager;
        }
    }
}
