using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{

    public static class Helper
    {//metotlarla çevirme işlemi yapacak. Her seferinde kod içerisine çevirme işlemi yapılmayacak.
        public static int ContInt(this object param)
        {
            return Convert.ToInt32(param);
        }
        public static bool ConBool(this object param)
        {
            return Convert.ToBoolean(param);
        }
        public static DateTime ConDate(this object param)
        {
           return Convert.ToDateTime(param);
           
        }
        public static Guid ConGuidToString(this object param)
        {
            return Guid.Parse(param.ToString());
        }
    }
}
