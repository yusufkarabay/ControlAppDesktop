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
    public class GeneratorManager
    {
        static GeneratorManager generatorManager;
        GeneratorDal generatorDal;
        public GeneratorManager()
        {
            generatorDal = GeneratorDal.GetInstance();
        }
        public static GeneratorManager GetInstance()
        {
            if (generatorManager == null)
            {
                generatorManager = new GeneratorManager();
            }
            return generatorManager;
        }
        public string Add(Generator entity)
        {
            try
            {
                return generatorDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Çalışma Zamanı Seçiniz Seçiniz.";
                }
                return generatorDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Generator Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public string AllWorkedTime()
        {
            string workedTime;
            try
            {
                return workedTime = generatorDal.AllWorkedTime();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
        public string BetweemTimeList(string procuderName, DateTime firstdate, DateTime seconddate)
        {
            string betweenTime;
            try
            {
                if (firstdate == null)
                {
                    return null;
                }
                else if (seconddate == null)
                {
                    return null;
                }
                betweenTime= generatorDal.BetweemTimeList(procuderName, firstdate,seconddate);
            }
            catch (Exception)
            {
                throw;
                
            }
            return betweenTime;
        }
        public string LastThreeMonthWorkedTime()
        {
            string workedTime;
            try
            {
                return workedTime = generatorDal.LastThreeMonthWorkedTime();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
        public string LastSixMonthWorkedTime()
        {
            string workedTime;
            try
            {
                return workedTime = generatorDal.LastSixMonthWorkedTime();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
        public string LastYearWorkedTime()
        {
            string workedTime;
            try
            {
                return workedTime = generatorDal.LastYearWorkedTime();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }
        


        public string Update(Generator entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Generator entity)
        {
            throw new NotImplementedException();
        }
    }
}
