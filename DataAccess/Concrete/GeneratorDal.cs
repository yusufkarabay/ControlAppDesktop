using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GeneratorDal : SqlService, IRepository<Generator>
    {
        static GeneratorDal generatorDal;
        SqlService sqlService;
        public GeneratorDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Generator entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("GenereatorWorkedTimeAdd", new SqlParameter("@genereatorworkedtime", entity.GeneratorIWorkedTime),
                    new SqlParameter("@createdemployee", entity.CreatedEmployee), new SqlParameter("@addedtime", entity.AddedTime));

                if (isSuccess)
                {
                    return "Jeneratör Çalışma Zamanı Eklendi...";
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return result;
        }

        public string AllWorkedTime()
        {
            string workedTime;
            try
            {
                workedTime = sqlService.Reader("GeneratorAllTimeWorkedSum").ToString();


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return workedTime;

        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Generator Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Generator> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(Generator entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Generator entity)
        {
            throw new NotImplementedException();
        }
        public static GeneratorDal GetInstance()
        {
            if (generatorDal == null)
            {
                generatorDal = new GeneratorDal();
            }
            return generatorDal;
        }
    }
}
