using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DrawerManager : IRepository<Drawer>
    {
        static DrawerManager drawerManager;
        DrawerDal drawerDal;
        public DrawerManager()
        {
            drawerDal = DrawerDal.GetInstance();
        }
        public string Add(Drawer entity)
        {
            try
            {
                return drawerDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Çekmece Seçiniz.";
                }
                return drawerDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Drawer Get(Guid id)
        {
            throw new NotImplementedException();
        }


        public List<Drawer> DrawerByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {
            try
            {
                if (deliveryEmployeeName == null)
                {
                    return null;
                }
                return drawerDal.DrawerByDeliveryEmployee(procuderName, deliveryEmployeeName);
            }
            catch (Exception)
            {

                return new List<Drawer>();
            }
        }
        public List<Drawer> DrawerByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            try
            {
                if (receiverEmployeeName == null)
                {
                    return null;
                }
                return drawerDal.DrawerByReceiverEmployee(procuderName, receiverEmployeeName);
            }
            catch (Exception)
            {

                return new List<Drawer>();
            }
        }
        public List<Drawer> DrawerByDrawerNo(string procuderName, string drawerNo)
        {
            try
            {
                if (drawerNo == null)
                {
                    return null;
                }
                return drawerDal.DrawerByDrawerNo(procuderName, drawerNo);
            }
            catch (Exception)
            {

                return new List<Drawer>();
            }
        }


        public List<Drawer> GetAll()
        {
            try
            {
                return drawerDal.GetAll();
            }
            catch (Exception)
            {

                return new List<Drawer>();
            }
        }
        public static DrawerManager GetInstance()
        {
            if (drawerManager == null)
            {
                drawerManager = new DrawerManager();

            }
            return drawerManager;
        }

        public string Update(Drawer entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Drawer entity)
        {
            throw new NotImplementedException();
        }
    }
}
