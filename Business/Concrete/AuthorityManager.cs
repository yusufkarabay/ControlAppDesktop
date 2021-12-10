using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;

namespace Business.Concrete
{
    public class AuthorityManager
    {
        // ara yüzden gelen değerleri kontrol edeceğiz. Kullanıcı bizim şartlarımızı sağlıyor mu?
        AuthorityDal authorityDal;
        string controlText;
        static AuthorityManager authorityManager;
        private AuthorityManager()
        {
            authorityDal = AuthorityDal.GetInstance();

        }
        string IsAuthorityComplete(Authority authority)
        {
            if (string.IsNullOrEmpty(authority.AuthorityName))
            {
                return "Lütfen Oluşturulacak Yetki İçin Yetki Adı Giriniz";
            }
            if (authority.AuthorityName.Length > 50)
            {
                return "Lütfen Yetki Adını 50 Karakter Olacak Şekilde Giriniz";
            }
            return "";
        }

        //kontrol et, hata yoksa ekle, geriye mesaj dönder.
        public string Add(Authority entity)
        {
            try
            {
                controlText = IsAuthorityComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return authorityDal.Add(entity);
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
                    return "Lütfen Geçerli Bir Yetki Tipi Seçiniz.";
                }
                return authorityDal.Delete(id);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public Authority Get(Guid id)
        {
            return null;
        }

        public List<Authority> GetAll()
        {
            try
            {
                return authorityDal.GetAll();
            }
            catch
            {

                return new List<Authority>();
            }
        }

        public string Update(Authority entity, string oldName)
        {
            try
            {
                if (entity.AuthorityId == null)
                {
                    return "Lütfen Geçerli Bir Yetki Tipi Seçiniz.";
                }
                controlText = IsAuthorityComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                if (string.IsNullOrEmpty(oldName))
                {
                    return "Yetki İle İlgili Bilgiye Ulaşılamadı";

                }
                return authorityDal.Update(entity, oldName);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static AuthorityManager GetInstance()
        {
            if (authorityManager == null)
            {
                authorityManager = new AuthorityManager();
            }
            return authorityManager;
        }
    }
}
