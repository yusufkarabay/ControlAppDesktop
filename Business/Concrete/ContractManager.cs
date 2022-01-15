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
    public class ContractManager
    {
        static ContractManager contractManager;
        ContractDal contractDal;
        public ContractManager()
        {
            contractDal = ContractDal.GetInstance();
        }
        public static ContractManager GetInstance()
        {
            if (contractManager == null)
            {
                contractManager = new ContractManager();
            }
            return contractManager;
        }
        public string Add(Contract entity)
        {
            try
            {
                return contractDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Sözleşme Seçiniz.";
                }
                return contractDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Contract Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Contract> GetAll()
        {
            try
            {
                return contractDal.GetAll();
            }
            catch (Exception)
            {

                return new List<Contract>();
            }
        }

        public string Update(Contract entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Contract entity)
        {
            try
            {
                if (entity.ContractName == null)
                {
                    return " Güncellemek İstediğiniz Sözleşmeyi Seçiniz";

                }

                return contractDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}

