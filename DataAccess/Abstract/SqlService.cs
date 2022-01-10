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
        public SqlCommand Execute(string commandText, params SqlParameter[] sqlParameters) // filtre ederken birden fazla parametre gönderme ihtimali olduğu için params kullanılıyor. dizi yapısı olur
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

        public (bool, string) ExecuteV2(string commandText, params SqlParameter[] sqlParameters)
        {
            bool isSuccess = false;
            string message = null;

            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection connection = null;

            try
            {
                connection = OpenConnection();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = commandText;
                sqlCommand.Connection = connection;
                if (sqlParameters != null)
                    sqlCommand.Parameters.AddRange(sqlParameters);

                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    message = "Verilen kriterlere göre istenilen işlem yapılamadı.";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                sqlCommand.Dispose();

                if (connection != null) connection.Close();
            }

            return (isSuccess, message);

        }

        public string Reader(string commandText)
        {
            int result;
            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection connection = null;
            try
            {
                connection = OpenConnection();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = commandText;
                sqlCommand.Connection = connection;
                result = int.Parse(sqlCommand.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCommand.Dispose();

                if (connection != null) connection.Close();
            }
            return result.ToString() + " Dakika Çalışmıştır";
        }
        public string ReaderV2(string commandText, params SqlParameter[] sqlParameters)
        {
            string result;

            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection connection = null;
            try
            {
                connection = OpenConnection();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = commandText;
                sqlCommand.Connection = connection;

                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                 result=sqlCommand.ExecuteScalar().ToString();
                
                

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                sqlCommand.Dispose();

                if (connection != null) connection.Close();
            }
            return result.ToString() + " Dakika Çalışmıştır";
        }
        


        public (DataTable, string) StoredV2(string commandText, params SqlParameter[] sqlParameters)
        {
            DataTable results = null;
            string message = null;

            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection connection = null;

            try
            {
                connection = OpenConnection();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = commandText;
                sqlCommand.Connection = connection;
                if (sqlParameters != null)
                    sqlCommand.Parameters.AddRange(sqlParameters);

                results = new DataTable("Results");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                sqlCommand.Dispose();

                if (connection != null) connection.Close();
            }

            return (results, message);
        }

        public SqlCommand Stored(string commandText, params SqlParameter[] sqlParameters)
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

        public (bool, string) StoreReaderV2(string commandText, params SqlParameter[] sqlParameters)
        {
            return ExecuteV2(commandText, sqlParameters);
        }

        public DataTable GetDataTable(string commandText, params SqlParameter[] sqlParameters)// select tablosundan aldığımız değeri tablo haline getireceğiz
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//sqldataadapter bir depo gibi düşünebiliriz.
            sqlDataAdapter.SelectCommand = Stored(commandText, sqlParameters);//hazır olan(kendi yazdığım) stored metodumu kullanacağım
            DataTable dataTable = new DataTable();//geriye bir datatable dönderecğim için oluşturuyorum.
            sqlDataAdapter.Fill(dataTable);//dataadapterden geleni datatable'i doldur
            return dataTable;//doldurduğunu dönder

        }
    }
}
