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
    public class RequestDetailManager
    {
        static RequestDetailManager requestDetailManager;
        RequestDetailDal requestDetailDal;
        string controlText;
        public RequestDetailManager()
        {
            requestDetailDal = RequestDetailDal.GetInstance();
        }

        string IsRequestDetailComplete(RequestDetail requestDetail)
        {
            if (string.IsNullOrEmpty(requestDetail.Requested))
            {
                return "Lütfen Talep Ettiğiniz Kişiyi Seçiniz";
            }

            return "";
        }
        public string Add(RequestDetail entity)
        {
            throw new NotImplementedException();
        }
        public string RequestToDepartment(RequestDetail entity)
        {
            try
            {
                return requestDetailDal.RequestToDepartment(entity);
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
                    return "Lütfen Geçerli Bir Talep Seçiniz";
                }
                return requestDetailDal.Delete(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public RequestDetail Get(Guid id)
        {
            return null;
        }

        public List<RequestDetail> GetAll(string procuderName, string tc)
        {
            try
            {
                return requestDetailDal.GetByTc(procuderName,tc);
            }
            catch
            {

                return new List<RequestDetail>();
            }
        }
        public List<RequestDetail> GetByDepartmentId(string procuderName, Guid departmentId)
        {
            try
            {
                return requestDetailDal.GetByDepartmentId(procuderName, departmentId);
            }
            catch
            {

                return new List<RequestDetail>();
            }
        }
        

        public string Update(RequestDetail entity)
        {
            try
            {
                if (entity.RequestDetailId == null)
                {
                    return "Lütfen Güncellemek İçin Geçerli Bir Talep Seçiniz";
                }
                controlText = IsRequestDetailComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return requestDetailDal.Update(entity,"");
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static RequestDetailManager GetInstance()
        {
            if (requestDetailManager == null)
            {
                requestDetailManager = new RequestDetailManager();
            }
            return requestDetailManager;
        }
    }
}
