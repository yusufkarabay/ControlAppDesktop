using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccess.Concrete
{
    public class AuthorityDal : SqlService, IRepository<Authority>
    {
        SqlService sqlService;//sql servisimi burada türettim
        SqlDataReader dataReader;//okuma  işlemi için oluşturduk
        bool result;
        public AuthorityDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Authority entity)
        {
            try
            {//ekleme işlemi için veritabanında oluşturduğum  AuthorityCreate prosedürünü çoğırdım ve orada prosedürün istediği nvarchar(50) dğerini gönderceğim

                dataReader = sqlService.StoreReader("AuthorityCreate", new SqlParameter("@authorityName", entity.AuthorityName));
                if (dataReader.Read())
                {//sorguda ki ilk değeri alırım. sorguyu dizi eşekline çevirecektir. Tek verinin peşinde olduğumuz için if kullandık. eğer liste isteseydin while kullanacaktık.
                    result = dataReader[0].ConBool();
                    dataReader.Close();
                }
                if (result)
                {
                    return entity.AuthorityName + " Yetki Tipi Daha Önce Eklendi";
                }
                else
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
                sqlService.StoreReader("AuthorityDelete", new SqlParameter("@authortyid", id));
                return "Yetki Başarı İle Silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Authority Get(Guid id)
        {
            return null;//!!!!!!!!!!!!!!!!!!!! diğer metodlarda öğrenince gel doldur.
        }

        public List<Authority> GetAll()
        {
            try
            {
                List<Authority> list = new List<Authority>();   // liste oluşturacağız
                dataReader = sqlService.StoreReader("AuthorityList");
                while (dataReader.Read())
                {
                    Authority authority = new Authority(dataReader["AUTHORITYNAME"].ToString());//id'i görüntelemedik yalnızca yetki adını görüntüledik.
                    list.Add(authority);// oluşturduğum """"listeye ekliyorum"""""
                }
                dataReader.Close();
                return list;
            }
            catch 
            {

                return new List<Authority>();
            }
        }

        public string Update(Authority entity,string oldName)
        {
            try
            {
                dataReader = sqlService.StoreReader("AuthorityUpdate", new SqlParameter("@authorityid", entity.AuthorityId), new SqlParameter("@authorityName", entity.AuthorityName), new SqlParameter("@authorityOldName",oldName));
                if (dataReader.Read())
                {
                    result=dataReader[0].ConBool();
                    
                }
                if (result)
                {
                    return entity.AuthorityName + "  İsimli Aktif Bir Kayıt Bulanmaktadır!";
                }
                else
                {
                    return entity.AuthorityName + "  İsimli YetkiBaşarıyla Güncellendi";
                }
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }
    }
}
