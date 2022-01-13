using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contract
    {
        Guid contractId;
        string contractName;
        DateTime contractStart;
        DateTime contractEnd;
        string company;
        string companyAdress;
        string companyTel;
        string notes;

        public Contract()
        {

        }
        public Contract(string contractName, DateTime contractStart, DateTime contractEnd, string company, string companyAdress, string companyTel, string notes)
        {
            this.contractName = contractName;
            this.contractStart = contractStart;
            this.contractEnd = contractEnd;
            this.company = company;
            this.companyAdress = companyAdress;
            this.companyTel = companyTel;
            this.notes = notes;
        }
        public Contract(Guid contractId, string contractName, DateTime contractStart, DateTime contractEnd, string company, string companyAdress, string companyTel, string notes)
        {
            this.contractId = contractId;
            this.contractName = contractName;
            this.contractStart = contractStart;
            this.contractEnd = contractEnd;
            this.company = company;
            this.companyAdress = companyAdress;
            this.companyTel = companyTel;
            this.notes = notes;
        }

        public Guid ContractId { get => contractId; set => contractId = value; }
        public string ContractName { get => contractName; set => contractName = value; }
        public DateTime ContractStart { get => contractStart; set => contractStart = value; }
        public string Company { get => company; set => company = value; }
        public string CompanyAdress { get => companyAdress; set => companyAdress = value; }
        public string CompanyTel { get => companyTel; set => companyTel = value; }
        public string Notes { get => notes; set => notes = value; }
        public DateTime ContractEnd { get => contractEnd; set => contractEnd = value; }
    }
}
