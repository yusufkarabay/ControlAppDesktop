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
        // veritabanı adresini connectionString tutacak
        readonly string connectionString = "Server=KARABAY;Database=CONTROLAPP;Integrated Security=True;";
        SqlConnection connection;
        public SqlService()
        {
            connection = new SqlConnection(connectionString);
        }
        protected SqlConnection OpenConnection()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
            return connection;
        }
        void CloseConnection()
        {

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }

        }

        protected SqlCommand Execute(string commandText, params SqlParameter[] sqlParameters)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.Text;
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            cmd.ExecuteNonQuery();
            CloseConnection();
            return cmd;

        }
        protected SqlDataReader Reader(string commandText, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.Text;
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }

        protected SqlCommand Stored(string commandText, params SqlParameter[] sqlParameters)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandType = CommandType.StoredProcedure;
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        protected DataTable GetDataTable(string commandText, params SqlParameter[] sqlParameters)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = Stored(commandText, sqlParameters);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;

        }
    }
}
