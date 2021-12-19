using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.Concrete
{
    public class AuthorityDal : SqlService, IRepository<Authority>
    {
        static AuthorityDal authorityDal;//getinstance değişkeni
        SqlService sqlService;//sql servisimi burada türettim
        SqlDataReader dataReader;//okuma  işlemi için oluşturduk
        bool result;
        private AuthorityDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Authority entity)
        {
            try
            {//ekleme işlemi için veritabanında oluşturduğum  AuthorityCreate prosedürünü çoğırdım ve orada prosedürün istediği nvarchar(50) dğerini gönderceğim

                var (isSuccess, msg) = sqlService.StoreReaderV2("AuthorityCreate", new SqlParameter("@authorityName", entity.AuthorityName));
                if(isSuccess)
                {
                    return entity.AuthorityName + " Yetki Tipi Daha Önce Eklendi";
                } else
                {
                    return entity.AuthorityName + " Yetki Başarıyla  Eklendi";
                }
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("AuthorityDelete", new SqlParameter("@authortyid", id));
                if (isSuccess)
                {
                    return "Yetki Başarı İle Silindi";
                }
                else
                {
                    return "Yetki alınamadı";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Authority Get(Guid id)
        {
            Authority authority = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("AuthorityList", new SqlParameter("@authorityid", id));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        authority = new Authority(dataRow["AUTHORITYNAME"].ToString());//id'i görüntelemedik yalnızca yetki adını görüntüledik.
                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return authority;
        }

        public List<Authority> GetAll()
        {
            List<Authority> list = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("AuthorityList");
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    list = new List<Authority>();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        Authority authority = new Authority(dataRow["AUTHORITYNAME"].ToString());//id'i görüntelemedik yalnızca yetki adını görüntüledik.
                        list.Add(authority);// oluşturduğum """"listeye ekliyorum"""""
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return list;
        }

        public string Update(Authority entity, string oldName)
        {
            string result = null;

            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("AuthorityUpdate", new SqlParameter("@authorityid", entity.AuthorityId), new SqlParameter("@authorityName", entity.AuthorityName), new SqlParameter("@authorityOldName", oldName));

                if (isSuccess)
                {
                    result = entity.AuthorityName + "  İsimli YetkiBaşarıyla Güncellendi";
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

        public static AuthorityDal GetInstance()
        {
            if (authorityDal == null)
            {
                authorityDal = new AuthorityDal();
            }
            return authorityDal;
        }

        public string UpdateEmployee(Authority entity)
        {
            throw new NotImplementedException();
        }
    }
}
