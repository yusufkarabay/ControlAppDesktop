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
    public class DrawerDal : SqlService, IRepository<Drawer>
    {
        static DrawerDal drawerDal;
        SqlService sqlService;
        public DrawerDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Drawer entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("DrawerDelivery", new SqlParameter("@drawerno", entity.DrawerNo),
                    new SqlParameter("@receiveremployee", entity.ReceiverEmployee), new SqlParameter("@deliveriyemployee", entity.DeliveryEmployee),
                    new SqlParameter("@deliverydate", entity.DeliveryDate));
                if (isSuccess)
                {
                    return entity.DrawerNo + " Numaralı Çekmece Teslim Edilmişitir";
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
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("DrawerReturnDelivery", new SqlParameter("@drawerid", id));
                if (isSuccess)
                {
                    result = "Çekmece Başarı İle Teslim Alındı";
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

        public Drawer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Drawer> GetAll()
        {
            List<Drawer> drawers = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("DrawerList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    drawers = new List<Drawer>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        drawers.Add(new Drawer(
                       Guid.Parse(dataRow["DRAWERID"].ToString()),
                       dataRow["DRAWERNO"].ToString(),
                       dataRow["RECEIVEREMPLOYEE"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYEMPLOYEE"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return drawers;
        }

        public List<Drawer> DrawerByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {

            List<Drawer> drawers = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@deliveryemployee", deliveryEmployeeName));

                if (dt.Rows.Count > 0)
                {
                    drawers = new List<Drawer>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        drawers.Add(new Drawer(
                         Guid.Parse(dataRow["DRAWERID"].ToString()),
                         dataRow["DRAWERNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else drawers = null;
                }
            
            catch (Exception ex) { }
            finally { }

            return drawers;
        }
        public List<Drawer> DrawerByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {


            List<Drawer> drawers = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@receiveremployee", receiverEmployeeName));

                if (dt.Rows.Count > 0)
                {
                    drawers = new List<Drawer>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        drawers.Add(new Drawer(
                      Guid.Parse(dataRow["DRAWERID"].ToString()),
                      dataRow["DRAWERNO"].ToString(),
                      dataRow["RECEIVEREMPLOYEE"].ToString(),
                      $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                      dataRow["DELIVERYEMPLOYEE"].ToString(),
                       $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                      DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
                else drawers = null;
            }

            catch (Exception ex) { }
            finally { }

            return drawers;
        }
    
        public List<Drawer> DrawerByDrawerNo(string procuderName, string drawerNo)
        {

            List<Drawer> drawers = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@drawerno", drawerNo));

                if (dt.Rows.Count > 0)
                {
                    drawers = new List<Drawer>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        drawers.Add(new Drawer(
                       Guid.Parse(dataRow["DRAWERID"].ToString()),
                       dataRow["DRAWERNO"].ToString(),
                       dataRow["RECEIVEREMPLOYEE"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYEMPLOYEE"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
                else drawers = null;
            }

            catch (Exception ex) { }
            finally { }

            return drawers;
        }
        public string Update(Drawer entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Drawer entity)
        {
            throw new NotImplementedException();
        }

        public static DrawerDal GetInstance()
        {
            if (drawerDal == null)
            {
                drawerDal = new DrawerDal();
            }
            return drawerDal;
        }
    }
}
