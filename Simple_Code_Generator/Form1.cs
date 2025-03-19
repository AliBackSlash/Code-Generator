using BusinessAccess;
using CGBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Prameters        = new List<string>();
        List<string> PrameterWithType = new List<string>();
        List<string> types            = new List<string>();
        string TableName;
        string NameColumnName;
        string IDColumnName;
        string DatabaseName;
        string SavePath;
        bool TabelsFound = false;
        private void button1_Click(object sender, EventArgs e)
        {
            IDColumnName = Prameters.Find(s => s == "Code" || s == "ID");
            NameColumnName = Prameters.Find(s => s == "Name");
            if (types.Count>0)
           {
                textBox1.Text = MakeCRUDOperationsForDataAccess.MakeDataAccess(Prameters, PrameterWithType,
                types, TableName, NameColumnName, IDColumnName).ToString();
               
            }

        }
        DataTable Databases = new DataTable();
        DataTable tables = new DataTable();
        DataTable ColumnWithTypes = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            Databases = DataBase.GetAllDataBasesInSystem();
            dgvallDataBases.Rows.Clear();
            foreach (DataRow row in Databases.Rows)
            {
                dgvallDataBases.Rows.Add(row["Databases"]);
            }
        }

        private void FillAllLists()
        {
            Prameters.Clear();
            PrameterWithType.Clear();
            types.Clear();
            foreach (DataRow r in ColumnWithTypes.Rows)
            {

                Prameters.Add(r["Columns"].ToString());
                PrameterWithType.Add(r["CsharpType"].ToString() + " " + r["Columns"].ToString());
                types.Add(r["CsharpType"].ToString());

            }
            TableName = dgvAllTables.CurrentRow.Cells[0].Value.ToString();

        }

        private void dgvAllTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ColumnWithTypes = DataBase.GetAllColumnInTalbe(dgvAllTables.CurrentRow.Cells[0].Value.ToString(),
                dgvallDataBases.CurrentRow.Cells[0].Value.ToString());

            dgvAllColumnsWithThierTypes.Rows.Clear();
            foreach (DataRow r in ColumnWithTypes.Rows)
            {
                dgvAllColumnsWithThierTypes.Rows.Add(r["Columns"], r["CsharpType"]);
            }
            FillAllLists();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tables = DataBase.GetAllTabelsInDatabase(dgvallDataBases.CurrentRow.Cells[0].Value.ToString());
            dgvAllTables.Rows.Clear();
            foreach (DataRow row in tables.Rows)
            {
                dgvAllTables.Rows.Add(row["Tables"]);
            }

            DatabaseName = dgvallDataBases.CurrentRow.Cells[0].Value.ToString();

            TabelsFound = true;
            btGetPath.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDColumnName = Prameters.Find(s => s == "Code" || s == "ID");
            NameColumnName = Prameters.Find(s => s == "Name");
            if (types.Count>0)
            {
                textBox1.Text = MakeCRUDOperationsForBusiness.MakeBusinessLayer(Prameters, PrameterWithType,
                types, TableName, NameColumnName, IDColumnName).ToString(); 
            }
        }

        string GetFilePath(string FileName)
        {
            svFileSavePath.Filter = "File Name|*.*";
            svFileSavePath.FilterIndex = 1;
            svFileSavePath.RestoreDirectory = true;
            string selectedFilePath;
            if (svFileSavePath.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                return selectedFilePath = svFileSavePath.FileName;

            }
            return "";
        }
        private void btMDAccess_Click(object sender, EventArgs e)
        {

            DatabaseName = dgvallDataBases.CurrentRow.Cells[0].Value.ToString();
            tables = DataBase.GetAllTabelsInDatabase(DatabaseName);
            progMakeData.Maximum = tables.Rows.Count;
            progMakeData.Visible = true;
            string TableName = "";
            Directory.CreateDirectory(SavePath + "\\Data Access");
            StringBuilder dataAccessScript = new StringBuilder();
            foreach (DataRow row in tables.Rows)
            {
                progMakeData.Value++;
                TableName = row["Tables"].ToString();
                ColumnWithTypes.Clear();
                ColumnWithTypes = DataBase.GetAllColumnInTalbe(row["Tables"].ToString(), DatabaseName);
                FillAllLists();
                IDColumnName = Prameters.Find(s => s == "Code" || s == "ID");
                NameColumnName = Prameters.Find(s => s == "Name");
                dataAccessScript = MakeCRUDOperationsForDataAccess.MakeDataAccess(Prameters, PrameterWithType,
                types, TableName, NameColumnName, IDColumnName);

                File.WriteAllText(SavePath + "\\Data Access" + $"\\cls{TableName}.cs", dataAccessScript.ToString());
                dataAccessScript.Clear();
            }

            progMakeData.Visible = false;
            dataAccessScript = MakeTheClassBody.makeConnectionString(DatabaseName);
            File.WriteAllText(SavePath + "\\Data Access" + $"\\clsConnectionString.cs", dataAccessScript.ToString());
        }

       
        private void btMBAccess_Click(object sender, EventArgs e)
        {

            DatabaseName = dgvallDataBases.CurrentRow.Cells[0].Value.ToString();
            tables = DataBase.GetAllTabelsInDatabase(DatabaseName);
            progMBusiness.Maximum = tables.Rows.Count;
            progMBusiness.Visible = true;
            string TableName = "";
            Directory.CreateDirectory(SavePath + "\\Business Access");
            StringBuilder BusinessAccessScript = new StringBuilder();
            foreach (DataRow row in tables.Rows)
            {
                progMBusiness.Value++;
                TableName = row["Tables"].ToString();
                ColumnWithTypes = DataBase.GetAllColumnInTalbe(row["Tables"].ToString(), DatabaseName);
                FillAllLists();
                IDColumnName = Prameters.Find(s => s == "Code" || s == "ID");
                NameColumnName = Prameters.Find(s => s == "Name");
                BusinessAccessScript = MakeCRUDOperationsForBusiness.MakeBusinessLayer(Prameters, PrameterWithType,
                types, TableName, NameColumnName, IDColumnName);

                File.WriteAllText(SavePath + "\\Business Access" + $"\\cls{TableName}.cs", BusinessAccessScript.ToString());
                BusinessAccessScript.Clear();
            }

            progMBusiness.Visible = false;

        }

        private void btMBoth_Click(object sender, EventArgs e)
        {

            progMBoth.Maximum = 2;
            btMDAccess_Click(null, null);
            progMBoth.Visible = true;

            progMBoth.Value++;
            btMBAccess_Click(null, null);
            progMBoth.Value++;
            progMBoth.Visible = false;

        }

        private void btGetPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select the folder to save the file";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    SavePath = folderBrowserDialog.SelectedPath;
                    if (!string.IsNullOrEmpty(SavePath) && TabelsFound)
                    {
                        txBath.Text = SavePath;
                        btMBAccess.Enabled = true;
                        btMDAccess.Enabled = true;
                        btMBoth.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Location");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
            }
        }
    }
}
