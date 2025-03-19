using System;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace CGBusinessLayer
{
    public class MakeTheClassBody
    {
        public static StringBuilder body = new StringBuilder();
        public MakeTheClassBody()
        {

        }

        public static void MakeDataAccessClassBody(string ClassName)
        {
            body.AppendLine("using System;\n");
            body.AppendLine("using System.Data;");
            body.AppendLine("using System.Data.SqlClient;");
            body.AppendLine($"namespace {ClassName}NameSpace\n");
            body.AppendLine("{\n");
            body.AppendLine($"    public class {ClassName}");
            body.AppendLine("    {");


        }
        public static void MakeBusinessClassBody(string ClassName)
        {
            body.AppendLine("using System;\n\n");
            body.AppendLine("namespace NameSpaceName\n");
            body.AppendLine("{\n");
            body.AppendLine($"    public class {ClassName}");
            body.AppendLine("    {");


        }
        public static string ClosePract()
        {
            string close = "";
            close += "\n    }\n\n";
            close += "}\n\n";
            return close;
        }

        public static StringBuilder makeConnectionString(string DataBaseName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;\n");
            sb.AppendLine($"    public class ConnectionString");
            sb.AppendLine("    {");
            sb.AppendLine($"    \t public static string Connectionstring = \"Server=.;Database = {DataBaseName};user id = sa ;Password = sa123456\";");
            sb.AppendLine("\n    }\n\n");
            return sb;
        }
    }

   
}







