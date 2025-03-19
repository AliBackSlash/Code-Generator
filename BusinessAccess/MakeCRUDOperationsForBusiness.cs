using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGBusinessLayer
{
    public class MakeCRUDOperationsForBusiness
    {
        static StringBuilder sb = new StringBuilder();

        private static string MakePropertiesSetAndGet(List<string> PrametersWithTypes)
        {

            sb.AppendLine("enum enMode {Add , Update}");
            sb.AppendLine("enMode mode;");
            foreach (string s in PrametersWithTypes)
                sb.AppendLine("public " + s + "{get; set;}");


            return sb.ToString();
        }

        private static string MakePropertiesAsPrameters(List<string> Prameters)
        {
            return string.Join(", ", Prameters);
        }
        private static string MakePropertiesAsPrametersWithRef(List<string> Prameters)
        {
            if (Prameters.Count == 1)
                return " ref " + Prameters[0];
            return string.Join(",ref ", Prameters);
        }
        private static string MakePropertiesAsPrametersWithValues(List<string> PrametersWithTypes)
        {
            return string.Join(";\n ", PrametersWithTypes);
        }
        private static string MakePropertiesImplenentInConstractor(List<string> Prameters)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in Prameters)
                sb.AppendLine("this." + s + " = " + s + ";");


            return sb.ToString();
        }
        private static string MakeDoubleConstractor(List<string> PrametersWithTypes, List<string> Prameters, string tableName)
        {

            sb.AppendLine($"public {tableName}()\n" +
                           "{\n" +
                           "\tmode = enMode.Add;\n" +
                           "}\n\n\n\n");

            sb.AppendLine($"\npublic {tableName}({string.Join(", ", PrametersWithTypes)})\n" +
                          "{\n" +
                          $"\t" + MakePropertiesImplenentInConstractor(Prameters) + "\n" +
                          "\tmode = enMode.Update;\n" +
                          "}\n");

            return sb.ToString();
        }

        private static void MakeAdd(List<string> PrametersWithTypes, List<string> Prameters, string tableName)
        {
            sb.AppendLine($"\nprivate  bool Add{tableName} ()\n");
            sb.AppendLine("{\n");
            sb.AppendLine($"return cls{tableName}DataAccess.Add{tableName}({MakePropertiesAsPrameters(Prameters)});\n");
            sb.AppendLine("}\n");
        }

        private static void MakeUpdate(List<string> PrametersWithTypes, List<string> Prameters, string tableName)
        {
            sb.AppendLine($"\nprivate  bool Update{tableName} ()\n");
            sb.AppendLine("{\n");
            sb.AppendLine($"return cls{tableName}DataAccess.Update{tableName}({MakePropertiesAsPrameters(Prameters)});\n");
            sb.AppendLine("}\n");
        }
        private static void MakeFindByID(List<string> PrametersWithTypes, List<string> Prameters, string tableName,
            string NameOfIDOrColumnNameToDeleteTypeInt)
        {
            PrametersWithTypes.Remove(NameOfIDOrColumnNameToDeleteTypeInt);
            Prameters.Remove(NameOfIDOrColumnNameToDeleteTypeInt);

            sb.AppendLine($"\nprivate static cls{tableName} Find(int {NameOfIDOrColumnNameToDeleteTypeInt})\n");
            sb.AppendLine("{\n");
            sb.AppendLine($"\n {MakePropertiesAsPrametersWithValues(PrametersWithTypes)};");
            sb.AppendLine($"bool found =  cls{tableName}DataAccess.Find{tableName}ByID({NameOfIDOrColumnNameToDeleteTypeInt}," +
                                                                              $"{MakePropertiesAsPrametersWithRef(Prameters)})\n");
            sb.AppendLine($"\nif(found) \n return new cls{tableName}({NameOfIDOrColumnNameToDeleteTypeInt}," +
                                                                              $"{MakePropertiesAsPrameters(Prameters)}); " +
                                                                              "else \n return null;");
            sb.AppendLine("}\n");
        }

        private static void MakeFindByName(List<string> PrametersWithTypes, List<string> Prameters, string tableName,
            string NameOfIDOrColumnNameToDeleteTypeString)
        {
            PrametersWithTypes.Remove(NameOfIDOrColumnNameToDeleteTypeString);
            Prameters.Remove(NameOfIDOrColumnNameToDeleteTypeString);

            sb.AppendLine($"\nprivate static cls{tableName} FindByName(string {NameOfIDOrColumnNameToDeleteTypeString})\n");
            sb.AppendLine("{\n");
            sb.AppendLine($"\n {MakePropertiesAsPrametersWithValues(PrametersWithTypes)};");
            sb.AppendLine($"bool found =  cls{tableName}DataAccess.Find{tableName}ByID({NameOfIDOrColumnNameToDeleteTypeString}," +
                                                                              $"{MakePropertiesAsPrametersWithRef(Prameters)})\n");
            sb.AppendLine($"\nif(found) \n retutn new cls{tableName}({NameOfIDOrColumnNameToDeleteTypeString}," +
                                                                              $"{MakePropertiesAsPrameters(Prameters)}); " +
                                                                              "else \n return null;");
            sb.AppendLine("}\n");
        }
        private static void MakeDeleteWithID(string tableName)
        {
            sb.AppendLine($"\nprivate static bool Delete{tableName}WithID (int ID)\n");
            sb.AppendLine("{\n");
            sb.AppendLine($"return cls{tableName}DataAccess.Delete{tableName}WithID(ID);\n");
            sb.AppendLine("}\n");
        }

        private static void MakeDeleteWithName(string tableName)
        {
            sb.AppendLine($"\nprivate static bool Delete{tableName}WithName (string Name)\n");
            sb.AppendLine("{\n");
            sb.AppendLine($"return cls{tableName}DataAccess.Delete{tableName}WithName(Name);\n");
            sb.AppendLine("}\n");
        }

        private static void MakeSave(string tableName)
        {

            sb.AppendLine("public bool Save()\n");
            sb.AppendLine("{\n");
            sb.AppendLine("switch(mode)\n{\ncase enMode.Add:\nreturn" +
                $" Add{tableName}();\n" +
                $"case enMode.Update:\n" +
                $"return Update{tableName}();\n" +
                "}" +
                $"return false;" +
               
                "}");

        }

        public static StringBuilder MakeBusinessLayer(List<string> Prameters, List<string> PrametersWithTypes, List<string> Types,
            string tableName, string NameOfIDOrColumnNameToDeleteTypeString, string NameOfIDOrColumnNameToDeleteTypeInt)
        {
            sb.Clear();
            MakeTheClassBody.body.Clear();
            MakeTheClassBody.MakeBusinessClassBody("cls" + tableName);
            sb.AppendLine(MakeTheClassBody.body.ToString());
            MakePropertiesSetAndGet(PrametersWithTypes);
            //---
            MakeDoubleConstractor(PrametersWithTypes, Prameters, "cls" + tableName);
            //---
            MakeAdd(PrametersWithTypes, Prameters, tableName);
            //---
            MakeUpdate(PrametersWithTypes, Prameters, tableName);
            //---
            if(NameOfIDOrColumnNameToDeleteTypeInt!=null)
            {
                MakeDeleteWithID(tableName);
                MakeFindByID(PrametersWithTypes, Prameters, tableName,
               NameOfIDOrColumnNameToDeleteTypeInt);
            }
            //---
            if (NameOfIDOrColumnNameToDeleteTypeString != null)
            {
                MakeDeleteWithName(tableName);
                MakeFindByName(PrametersWithTypes, Prameters, tableName,
                 NameOfIDOrColumnNameToDeleteTypeString);
            }
            //---
           
            MakeSave(tableName);
            sb.AppendLine(MakeTheClassBody.ClosePract());
            return sb;
        }

    }
}
