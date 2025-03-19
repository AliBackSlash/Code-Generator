using System.Collections.Generic;
using System.Text;
using CodeGDataAccess;
using System.Data;

namespace CGBusinessLayer
{
    public class MakeCRUDOperationsForDataAccess
    {
        public static StringBuilder sb = new StringBuilder();


        private static string ReturnListToPramtersStringWithComa(List<string> Prameters)
        {
            return string.Join(", ", Prameters);
        }
        private static string ReturnListToPramtersStringWithComaAndByRef(List<string> Prameters)
        {
            return string.Join(", ref ", Prameters);
        }
        private static string MakeConvertFromDataBaseToDataTypes(List<string> Prameters, List<string> PrametersTypes)
        {
            StringBuilder sb = new StringBuilder();
            short counter = 0;
            foreach (string s in Prameters)
            {
                sb.AppendLine($"\t{s} = ({PrametersTypes[counter]})reader[\"{s}\"];");
                counter++;
            }
            return sb.ToString();
        }
        private static string ReturnListToPramtersStringWithComaAndAndSymole(List<string> Prameters)
        {
            return string.Join(", @", Prameters);
        }

        private static string PrintUpdateValues(List<string> Prameters)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in Prameters)
            {
                sb.AppendLine($"\n\t\t\t{s} = @{s},");
            }
            sb.Append("\n");
            return sb.ToString();
        }
        private static string PrintAddWithValuePrameters(List<string> Prameters)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in Prameters)
            {
                sb.AppendLine($"command.Parameters.AddWithValue(\"@{s}\",{s});");
            }
            return sb.ToString();
        }
        //the prametrers in list are the column name with their types
        private static void MakeInsert(List<string> Prameters, List<string> PrametersWithTypes, string tableName)
        {


            sb.Append($"\tpublic static bool Add{tableName} ({ReturnListToPramtersStringWithComa(PrametersWithTypes)})\n" +
                       "\t{\n" +
                        "\t  bool id = false;\n" +
                       $"\t  string query = @\"insert into {tableName} ({ReturnListToPramtersStringWithComa(Prameters)}) \nvalues\n " +
                       $"\t  (@{ReturnListToPramtersStringWithComaAndAndSymole(Prameters)}); select ScpeIdentity()\"; \n\n" +
                       $"\t  try\n" +
                        "\t  {\n" +                                               //only steal the connection string
                        "\t\tusing (SqlConnection connection = new SqlConnection(ConnectionString.Connectionstring))\n" +
                        "\t\t{\n" +
                        "\t\t  using (SqlCommand command = new SqlCommand(query, connection))\n" +
                        "\t\t  {\n" +
                        $"\t\t\t{PrintAddWithValuePrameters(Prameters)}\n" +
                         "\t\t\t connection.Open();\n" +
                         "\t\t\t object o = command.ExecuteScalar();\n" +
                         "\t\t\t if (o!=null)\n" +
                         "\t\t\t   id = true;\n" +
                        "\t\t  }\n" +
                         "\t\t}\n" +
                         "\t\t}\n" +
                        "\t\t   catch (Exception)\n" +
                        "\n\t\t  {\n" +
                        "\n\t\t  }\n" +
                        "\t  return id;\n" +
                        "\n}\t  \n\n");



        }

        private static void MakeUpdate(List<string> Prameters, List<string> PrametersWithTypes, string tableName)
        {


            sb.Append($"\tpublic static bool Update{tableName} ({ReturnListToPramtersStringWithComa(PrametersWithTypes)})\n" +
                       "\t{\n" +
                        "\t  bool Success = false;\n" +
                       $"\t  string query = @\"Update {tableName} set \n{PrintUpdateValues(Prameters)}\"; \n\n" +
                       $"\t  try\n" +
                        "\t  {\n" +                                               //only still the connection string
                        "\t\tusing (SqlConnection connection = new SqlConnection(ConnectionString.Connectionstring))\n" +
                        "\t\t{\n" +
                        "\t\t  using (SqlCommand command = new SqlCommand(query, connection))\n" +
                        "\t\t  {\n" +
                        $"\t\t\t{PrintAddWithValuePrameters(Prameters)}\n" +
                         "\t\t\t connection.Open();\n" +
                         "\t\t\t if (command.ExecuteNonQuery()!=0)\n" +
                         "\t\t\t   Success = true;\n" +
                        "\t\t  }\n" +
                         "\t\t}\n" +
                         "\t\t}\n" +
                        "\t\t   catch (Exception)\n" +
                        "\n\t\t  {\n" +
                        "\n\t\t  Success = false;\n" +
                        "\n\t\t  }\n" +
                        "\t  return Success;\n" +
                        "\n}\t  \n\n");



        }

        private static void MakeDeleteWithID(string deleteWithName, string tableName)
        {


            sb.Append($"\tpublic static bool Delete{tableName}WithID (int {deleteWithName})\n" +
                       "\t{\n" +
                        "\t  bool Success = false;\n" +
                       $"\t  string query = @\"delete {tableName} where {deleteWithName}  = @{deleteWithName}\"; \n\n" +
                       $"\t  try\n" +
                        "\t  {\n" +                                               //only still the connection string
                        "\t\tusing (SqlConnection connection = new SqlConnection(ConnectionString.Connectionstring))\n" +
                        "\t\t{\n" +
                        "\t\t  using (SqlCommand command = new SqlCommand(query, connection))\n" +
                        "\t\t  {\n" +
                        $"\t\t\tcommand.Parameters.AddWithValue(\"@{deleteWithName}\",{deleteWithName});\n" +
                         "\t\t\t connection.Open();\n" +
                         "\t\t\t if (command.ExecuteNonQuery()!=0)\n" +
                         "\t\t\t   Success = true;\n" +
                        "\t\t  }\n" +
                         "\t\t}\n" +
                         "\t\t}\n" +
                        "\t\t   catch (Exception)\n" +
                        "\n\t\t  {\n" +
                        "\n\t\t  Success = false;\n" +
                        "\n\t\t  }\n" +
                        "\t  return Success;\n" +
                        "\n}\t  \n\n");



        }

        private static void MakeDeleteWithName(string deleteWithName, string tableName)
        {


            sb.Append($"\tpublic static bool Delete{tableName}WithName (string {deleteWithName})\n" +
                       "\t{\n" +
                        "\t  bool Success = false;\n" +
                       $"\t  string query = @\"delete {tableName} where {deleteWithName}  = @{deleteWithName}\"; \n\n" +
                       $"\t  try\n" +
                        "\t  {\n" +                                               //only still the connection string
                        "\t\tusing (SqlConnection connection = new SqlConnection(ConnectionString.Connectionstring))\n" +
                        "\t\t{\n" +
                        "\t\t  using (SqlCommand command = new SqlCommand(query, connection))\n" +
                        "\t\t  {\n" +
                        $"\t\t\tcommand.Parameters.AddWithValue(\"@{deleteWithName}\",{deleteWithName});\n" +
                         "\t\t\t connection.Open();\n" +
                         "\t\t\t if (command.ExecuteNonQuery()!=0)\n" +
                         "\t\t\t   Success = true;\n" +
                        "\t\t  }\n" +
                         "\t\t}\n" +
                         "\t\t}\n" +
                        "\t\t   catch (Exception)\n" +
                        "\n\t\t  {\n" +
                        "\n\t\t  Success = false;\n" +
                        "\n\t\t  }\n" +
                        "\t  return Success;\n" +
                        "\n}\t  \n\n");



        }

        private static void MakeFindByID(string IDColumnName, string tableName, List<string> PrametersWithTypes, List<string> Prameters, List<string> PrametersTypes)
        {
            PrametersWithTypes.Remove("int "+IDColumnName);
            PrametersWithTypes.Remove("string "+IDColumnName);
            Prameters.Remove("string " + IDColumnName);
            sb.Append($"\tpublic static bool Find{tableName}ByID (int {IDColumnName},ref {ReturnListToPramtersStringWithComaAndByRef(PrametersWithTypes)})\n" +
                       "\t{\n" +
                        "\t  bool Success = false;\n" +
                       $"\t  string query = @\"select * from {tableName} where {IDColumnName}  = @{IDColumnName}\"; \n\n" +
                       $"\t  try\n" +
                        "\t  {\n" +                                               //only still the connection string
                        "\t\tusing (SqlConnection connection = new SqlConnection(ConnectionString.Connectionstring))\n" +
                        "\t\t{\n" +
                        "\t\t  using (SqlCommand command = new SqlCommand(query, connection))\n" +
                        "\t\t  {\n" +
                        $"\t\t\tcommand.Parameters.AddWithValue(\"@{IDColumnName}\",{IDColumnName});\n" +
                         "\t\t\t connection.Open();\n" +
                         "\t\t\t\t  using (SqlDataReader reader = command.ExecuteReader())\n" +
                         "\t\t\t\t{\n" +
                         "\t\t\t\t  while (reader.Read())\n" +
                         "\t\t\t\t  {" +
                         $"\t\t\t\t\t    {MakeConvertFromDataBaseToDataTypes(Prameters, PrametersTypes)}" +
                         "\t\t\t\t  }" +
                         "\t\t\t\t}\n" +
                        "\t\t  }\n" +
                         "\t\t}\n" +
                         "\t\t}\n" +
                        "\t\t   catch (Exception)\n" +
                        "\n\t\t  {\n" +
                        "\n\t\t  Success = false;\n" +
                        "\n\t\t  }\n" +
                        "\t  return Success;\n" +
                        "\n}\t  \n\n");



        }

        private static void MakeFindByName(string NameColumnName, string tableName, List<string> PrametersWithTypes, List<string> Prameters, List<string> PrametersTypes)
        {
            PrametersWithTypes.Remove(NameColumnName);
            Prameters.Remove(NameColumnName);
            sb.Append($"\tpublic static bool Find{tableName}ByName (string {NameColumnName}," +
                $"{ReturnListToPramtersStringWithComaAndByRef(PrametersWithTypes)})\n" +
                       "\t{\n" +
                        "\t  bool Success = false;\n" +
                       $"\t  string query = @\"select * from {tableName} where {NameColumnName}  = @{NameColumnName}\"; \n\n" +
                       $"\t  try\n" +
                        "\t  {\n" +                                               //only still the connection string
                        "\t\tusing (SqlConnection connection = new SqlConnection(ConnectionString.Connectionstring))\n" +
                        "\t\t{\n" +
                        "\t\t  using (SqlCommand command = new SqlCommand(query, connection))\n" +
                        "\t\t  {\n" +
                        $"\t\t\tcommand.Parameters.AddWithValue(\"@{NameColumnName}\",{NameColumnName});\n" +
                         "\t\t\t connection.Open();\n" +
                         "\t\t\t\t  using (SqlDataReader reader = command.ExecuteReader())\n" +
                         "\t\t\t\t{\n" +
                         "\t\t\t\t  while (reader.Read())\n" +
                         "\t\t\t\t  {" +
                         $"\t\t\t\t\t    {MakeConvertFromDataBaseToDataTypes(Prameters, PrametersTypes)}" +
                         "\t\t\t\t  }" +
                         "\t\t\t\t}\n" +
                        "\t\t  }\n" +
                         "\t\t}\n" +
                         "\t\t}\n" +
                        "\t\t   catch (Exception)\n" +
                        "\n\t\t  {\n" +
                        "\n\t\t  Success = false;\n" +
                        "\n\t\t  }\n" +
                        "\t  return Success;\n" +
                        "\n}\t  \n\n");



        }

        public static StringBuilder MakeDataAccess(List<string> Prameters, List<string> PrametersWithTypes, List<string> Types,
            string tableName, string NameOfIDOrColumnNameToDeleteTypeString, string NameOfIDOrColumnNameToDeleteTypeInt)
        {
            sb.Clear();
            MakeTheClassBody.body.Clear();
            MakeTheClassBody.MakeDataAccessClassBody("cls" + tableName + "DataAccess");
            sb.AppendLine(MakeTheClassBody.body.ToString());
            //---
            MakeInsert(Prameters, PrametersWithTypes, tableName);
            //---
            MakeUpdate(Prameters, PrametersWithTypes, tableName);
            //---
            if (NameOfIDOrColumnNameToDeleteTypeInt != null)
               { MakeDeleteWithID(NameOfIDOrColumnNameToDeleteTypeInt, tableName);
                MakeFindByID(NameOfIDOrColumnNameToDeleteTypeInt, tableName, PrametersWithTypes, Prameters, Types);
            }
            //---
            if (NameOfIDOrColumnNameToDeleteTypeString != null)
                { MakeDeleteWithName(NameOfIDOrColumnNameToDeleteTypeString, tableName);
                MakeFindByName(NameOfIDOrColumnNameToDeleteTypeString, tableName, PrametersWithTypes, Prameters, Types);
            }
            //---
            //MakeFindByID(NameOfIDOrColumnNameToDeleteTypeInt, tableName, PrametersWithTypes, Prameters, Types);
            //---
            //MakeFindByName(NameOfIDOrColumnNameToDeleteTypeString, tableName, PrametersWithTypes, Prameters, Types);
            //sb.AppendLine(MakeCRUDOperationsForDataAccess.sb.ToString());
            //---
            sb.AppendLine(MakeTheClassBody.ClosePract());
            //---
            sb.AppendLine();

            return sb;
        }

        public static DataTable GetAllDataBasesInSystem()
        {
            return Databases.GetAllDataBasesInSystem();

        }
    }
}
