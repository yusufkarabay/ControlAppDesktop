using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FuelManager
    {
        static FuelManager fuelManager;
        FuelDal fuelDal;
        public FuelManager()
        {
            fuelDal= FuelDal.GetInstance(); 
        }
       public static FuelManager GetInstance()
        {
            if (fuelManager==null)
            {
                fuelManager = new FuelManager();
            }
            return fuelManager;
        }
        public string LastFuel()
        {
            string lastFuel;
            try
            {
                return lastFuel = fuelDal.LastFuel();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
        public string Add(Fuel entity)
        {
            try
            {
                return fuelDal.Add(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string GetLastTime()
        {
            string fuelTime;
            try
            {
                return fuelTime = fuelDal.GetLastTime();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
        public string GetLastEmployee()
        {
            string fuelEmployee;
            try
            {
                return fuelEmployee = fuelDal.GetLastEmployee();
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
       

    }
}
