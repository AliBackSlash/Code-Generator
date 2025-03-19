using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGDataAccess
{
    public class Databases
    {

        public static DataTable GetAllDataBasesInSystem()
        {
            DataTable dt = new DataTable();
            string query = @"select name as Databases from sys.databases where name not in ('tempdb','model','msdb','master') order by name ";

            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionsettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);

                        }
                    }
                }
            }
            catch (Exception)

            {

            }
            return dt;

        }
        public static DataTable GetAllTabelsInDatabase(string DatabaseName)
        {
            DataTable dt = new DataTable();
            string query = $"use {DatabaseName};select Table_Name as Tables from INFORMATION_SCHEMA.TABLES where" +
                             $"  TABLE_CATALOG = '{DatabaseName}' order by Tables";

            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionsettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);

                        }
                    }
                }
            }
            catch (Exception)

            {

            }
            return dt;

        }
        public static DataTable GetAllColumnInTalbe(string TableName, string DatabaseName)
        {
            DataTable dt = new DataTable();
            string query = $@"use {DatabaseName};
                              select COLUMN_NAME as Columns , CASE DATA_TYPE
                               WHEN 'int' THEN 'int'
                               WHEN 'bigint' THEN 'long'
                               WHEN 'smallint' THEN 'short'
                               WHEN 'tinyint' THEN 'byte'
                               WHEN 'bit' THEN 'bool'
                               WHEN 'decimal' THEN 'decimal'
                               WHEN 'numeric' THEN 'decimal'
                               WHEN 'float' THEN 'double'
                               WHEN 'real' THEN 'float'
                               WHEN 'money' THEN 'decimal'
                               WHEN 'smallmoney' THEN 'decimal'
                               WHEN 'char' THEN 'string'
                               WHEN 'varchar' THEN 'string'
                               WHEN 'text' THEN 'string'
                               WHEN 'nchar' THEN 'string'
                               WHEN 'nvarchar' THEN 'string'
                               WHEN 'ntext' THEN 'string'
                               WHEN 'binary' THEN 'byte[]'
                               WHEN 'varbinary' THEN 'byte[]'
                               WHEN 'image' THEN 'byte[]'
                               WHEN 'datetime' THEN 'DateTime'
                               WHEN 'datetime2' THEN 'DateTime'
                               WHEN 'smalldatetime' THEN 'DateTime'
                               WHEN 'date' THEN 'DateTime'
                               WHEN 'time' THEN 'TimeSpan'
                               WHEN 'timestamp' THEN 'byte[]'
                               ELSE 'object'
                               END AS CsharpType  from INFORMATION_SCHEMA.COLUMNS where  TABLE_NAME = '{TableName}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionsettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);

                        }
                    }
                }
            }
            catch (Exception)

            {

            }
            return dt;

        }


    }
}
