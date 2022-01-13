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
    public class ContractDal : SqlService, IRepository<Contract>
    {
        static ContractDal contractDal;
        SqlService sqlService;
        public ContractDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Contract entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("ContractAdd", new SqlParameter("@contractname", entity.ContractName),
                    new SqlParameter("@contractstart", entity.ContractStart), new SqlParameter("@contractend",entity.ContractEnd), new SqlParameter("@company", entity.Company),
                    new SqlParameter("@companyadress", entity.CompanyAdress), new SqlParameter("@companytel", entity.CompanyTel), new SqlParameter("@notes", entity.Notes));
                if (isSuccess)
                {
                    return entity.ContractName + " Sözleşmesi Kaydedilmiştir.";
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

        public Contract Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Contract> GetAll()
        {
            List<Contract> contracts = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("ContractAllList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    contracts = new List<Contract>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        contracts.Add(new Contract(

                       Guid.Parse(dataRow["CONTRACTID"].ToString()),
                       dataRow["CONTRACTNAME"].ToString(),
                       DateTime.Parse(dataRow["CONTRACTSTART"].ToString()),
                       DateTime.Parse(dataRow["CONTRACTEND"].ToString()),
                        dataRow["COMPANY"].ToString(),
                       dataRow["COMPANYADRESS"].ToString(),
                       dataRow["COMPANYTEL"].ToString(),
                       dataRow["NOTES"].ToString()));




                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return contracts;
        }

        public string Update(Contract entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Contract entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("ContractUpdate", new SqlParameter("@contractid", entity.ContractId),
                    new SqlParameter("@contractname", entity.ContractName),new SqlParameter("@contractstart",entity.ContractStart),
                    new SqlParameter("@contractend",entity.ContractEnd),
                    new SqlParameter("@company",entity.Company),new SqlParameter("@companyadress",entity.CompanyAdress),new SqlParameter("@companytel",entity.CompanyTel),
                    new SqlParameter("@notes",entity.Notes));
                if (isSuccess)
                {
                    result = "Sözleşme Başarı İle Güncellendi";
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
        public static ContractDal GetInstance()
        {
            if (contractDal==null)
            {
                contractDal=new ContractDal();
            }
            return contractDal;
        }
    }
}
