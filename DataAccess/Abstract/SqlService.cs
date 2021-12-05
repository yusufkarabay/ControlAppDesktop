using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public abstract class SqlService
    {
        /* veritabanı adresini connectionString tutacak readonly olması sadece okunabilir ve müdahala edilemez. aynı bilgisayarda sunucuda çalışıyorsak(local sql) server=. şeklinde yazılabilir
        uzak sql ise ip adresi yazılabilir. Integrated security=true dersek şifre vermeye gerek kalmaz. False ise userid ve password belirtmek gerekecektir
         */
        readonly string connectionString = "Server=KARABAY;Database=CONTROLAPP;Integrated Security=True;";

        SqlConnection connection;// sql bağlantı nesnesidir


        public SqlService()
        {    //her seferinde yeni nesne türetmeyecek. bir kez çalışınca türetecek. her sqlcommand'ın içine koymaktansa buraya aldık.
            connection = new SqlConnection(connectionString);// bağlanma işlemini adres değişkenine göre yapacaktır
        }

        //bu metodun sonucu olarak SqlConnection dönecektir. SqlConnectin nesnesinden türetilen connection'u return ederiz
        protected SqlConnection OpenConnection()
        {
            // bağlantının durumu kapalıysa aç
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
            //kapalı durumunu açtı ve açılan bağlantıyı dönderdi
            return connection;
        }
        //void olmasının sebebi geriye değer döndermeyecek. yalnızca bağlantıyı kapatıyoruz.OpenConnection'da açıp. sonra açılanı gönbderiyorduk
        void CloseConnection()
        {
            // bağlantının durumu açıksa kapat
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }

        }

        //SqlCommand "sql komutu" parametreye göre sql komutunu çalıştırmak olarak düşünülebilir.
        protected SqlCommand Execute(string commandText, params SqlParameter[] sqlParameters) // filtre ederken birden fazla parametre gönderme ihtimali olduğu için params kullanılıyor. dizi yapısı olur
        {                                                                                     //execute etme işlemi olarak düşünebiliriz
            SqlCommand cmd = new SqlCommand();  //SqlCommand nesnesinden türeme yapılıyor
            cmd.CommandText = commandText;      // sorgu(komut) cümlem. commandText parametresine(özelliğine) atama yaptım
            cmd.Connection = OpenConnection();  // bu komuta veritabaanının bağlantısını gönderdik "OpenConnection()" metodu ile.
            cmd.CommandType = CommandType.Text;// komut tipi text (bu yazılmasa da olur bu değer default olarak text gelir)
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);//birden fazla parametre addrange ile eklenebilir.
            }
            cmd.ExecuteNonQuery();// komutu execute et" sorguyu çalıştırmak"
            CloseConnection();//bağlantı kaldırılıyor
            return cmd;
        }
        //sql okuma sorgulama işlemi olarak düşünülebilir.
        protected SqlDataReader Reader(string commandText, params SqlParameter[] sqlParameters)// değer okuma işlemi olarak düşünebiliriz
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.Text;
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            SqlDataReader sqlDataReader = cmd.ExecuteReader();// SqlDataReader sqlden gelen sonuçlarıu okuyan nesne.ExecuteReader metodu ile. oraya git execute et" sorgula" ve oku "read".
            return sqlDataReader;// okuduğun sonucu gönder
        }

        protected SqlCommand Stored(string commandText, params SqlParameter[] sqlParameters)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;//text yerine stored prosedürlerimizi kullanacağız.  execute işlemlerini olarak sınıflandırabiliriz. hazır prosedürlerimizi göndereceğiz
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            cmd.ExecuteNonQuery();
            CloseConnection();
            return cmd;

        }
        protected SqlDataReader StoreReader(string commandText, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;// prosedürlerderden okuma olanları kullanacağız.
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        protected DataTable GetDataTable(string commandText, params SqlParameter[] sqlParameters)// select tablosundan aldığımız değeri tablo haline getireceğiz
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//sqldataadapter bir depo gibi düşünebiliriz.
            sqlDataAdapter.SelectCommand = Stored(commandText, sqlParameters);//hazır olan(kendi yazdığım) stored metodumu kullanacağım
            DataTable dataTable = new DataTable();//geriye bir datatable dönderecğim için oluşturuyorum.
            sqlDataAdapter.Fill(dataTable);//dataadapterden geleni datatable'i doldur
            return dataTable;//doldurduğunu dönder

        }
    }
}
