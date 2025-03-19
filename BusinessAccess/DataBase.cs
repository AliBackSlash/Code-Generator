using CodeGDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess
{
    public class DataBase
    {
        public static DataTable GetAllDataBasesInSystem()
        {
            return Databases.GetAllDataBasesInSystem();

        }

        public static DataTable GetAllTabelsInDatabase(string DatabaseName)
        {
            return Databases.GetAllTabelsInDatabase(DatabaseName);

        }

        public static DataTable GetAllColumnInTalbe(string TableName, string DatabaseName)
        {
            return Databases.GetAllColumnInTalbe(TableName, DatabaseName);
        }
    }
}
