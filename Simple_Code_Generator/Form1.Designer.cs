using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Simple_Code_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btMBoth = new System.Windows.Forms.Button();
            this.btMBAccess = new System.Windows.Forms.Button();
            this.btMDAccess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progMakeData = new System.Windows.Forms.ProgressBar();
            this.progMBusiness = new System.Windows.Forms.ProgressBar();
            this.progMBoth = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvallDataBases = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAllColumnsWithThierTypes = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllTables = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txBath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.svFileSavePath = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGetPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallDataBases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllColumnsWithThierTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTables)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.467F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btMBoth, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btMBAccess, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btMDAccess, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.progMakeData, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.progMBusiness, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.progMBoth, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 339);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(749, 53);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btMBoth
            // 
            this.btMBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMBoth.Enabled = false;
            this.btMBoth.Location = new System.Drawing.Point(598, 2);
            this.btMBoth.Margin = new System.Windows.Forms.Padding(2);
            this.btMBoth.Name = "btMBoth";
            this.btMBoth.Size = new System.Drawing.Size(149, 31);
            this.btMBoth.TabIndex = 4;
            this.btMBoth.Text = "Make Both";
            this.btMBoth.UseVisualStyleBackColor = true;
            this.btMBoth.Click += new System.EventHandler(this.btMBoth_Click);
            // 
            // btMBAccess
            // 
            this.btMBAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMBAccess.Enabled = false;
            this.btMBAccess.Location = new System.Drawing.Point(449, 2);
            this.btMBAccess.Margin = new System.Windows.Forms.Padding(2);
            this.btMBAccess.Name = "btMBAccess";
            this.btMBAccess.Size = new System.Drawing.Size(145, 31);
            this.btMBAccess.TabIndex = 3;
            this.btMBAccess.Text = "Make Business Access";
            this.btMBAccess.UseVisualStyleBackColor = true;
            this.btMBAccess.Click += new System.EventHandler(this.btMBAccess_Click);
            // 
            // btMDAccess
            // 
            this.btMDAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMDAccess.Enabled = false;
            this.btMDAccess.Location = new System.Drawing.Point(300, 2);
            this.btMDAccess.Margin = new System.Windows.Forms.Padding(2);
            this.btMDAccess.Name = "btMDAccess";
            this.btMDAccess.Size = new System.Drawing.Size(145, 31);
            this.btMDAccess.TabIndex = 2;
            this.btMDAccess.Text = "Make Data Access";
            this.btMDAccess.UseVisualStyleBackColor = true;
            this.btMDAccess.Click += new System.EventHandler(this.btMDAccess_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(151, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show business access";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show data access";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progMakeData
            // 
            this.progMakeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progMakeData.ForeColor = System.Drawing.Color.Red;
            this.progMakeData.Location = new System.Drawing.Point(300, 37);
            this.progMakeData.Margin = new System.Windows.Forms.Padding(2);
            this.progMakeData.Name = "progMakeData";
            this.progMakeData.Size = new System.Drawing.Size(145, 14);
            this.progMakeData.TabIndex = 5;
            this.progMakeData.Visible = false;
            // 
            // progMBusiness
            // 
            this.progMBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progMBusiness.Location = new System.Drawing.Point(449, 37);
            this.progMBusiness.Margin = new System.Windows.Forms.Padding(2);
            this.progMBusiness.Name = "progMBusiness";
            this.progMBusiness.Size = new System.Drawing.Size(145, 14);
            this.progMBusiness.TabIndex = 6;
            this.progMBusiness.Visible = false;
            // 
            // progMBoth
            // 
            this.progMBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progMBoth.Location = new System.Drawing.Point(598, 37);
            this.progMBoth.Margin = new System.Windows.Forms.Padding(2);
            this.progMBoth.Name = "progMBoth";
            this.progMBoth.Size = new System.Drawing.Size(149, 14);
            this.progMBoth.TabIndex = 7;
            this.progMBoth.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvallDataBases, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvAllColumnsWithThierTypes, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvAllTables, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txBath, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(749, 333);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvallDataBases
            // 
            this.dgvallDataBases.AllowUserToAddRows = false;
            this.dgvallDataBases.AllowUserToDeleteRows = false;
            this.dgvallDataBases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvallDataBases.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvallDataBases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvallDataBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvallDataBases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dgvallDataBases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvallDataBases.Location = new System.Drawing.Point(2, 2);
            this.dgvallDataBases.Margin = new System.Windows.Forms.Padding(2);
            this.dgvallDataBases.Name = "dgvallDataBases";
            this.dgvallDataBases.RowHeadersVisible = false;
            this.dgvallDataBases.RowHeadersWidth = 62;
            this.dgvallDataBases.Size = new System.Drawing.Size(146, 301);
            this.dgvallDataBases.TabIndex = 5;
            this.dgvallDataBases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.HeaderText = "Data Bases";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvAllColumnsWithThierTypes
            // 
            this.dgvAllColumnsWithThierTypes.AllowUserToAddRows = false;
            this.dgvAllColumnsWithThierTypes.AllowUserToDeleteRows = false;
            this.dgvAllColumnsWithThierTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllColumnsWithThierTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllColumnsWithThierTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllColumnsWithThierTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.type});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllColumnsWithThierTypes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllColumnsWithThierTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllColumnsWithThierTypes.Location = new System.Drawing.Point(314, 2);
            this.dgvAllColumnsWithThierTypes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllColumnsWithThierTypes.Name = "dgvAllColumnsWithThierTypes";
            this.dgvAllColumnsWithThierTypes.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllColumnsWithThierTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllColumnsWithThierTypes.RowHeadersVisible = false;
            this.dgvAllColumnsWithThierTypes.RowHeadersWidth = 62;
            this.dgvAllColumnsWithThierTypes.Size = new System.Drawing.Size(176, 301);
            this.dgvAllColumnsWithThierTypes.TabIndex = 3;
            // 
            // Column
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column.HeaderText = "Columns";
            this.Column.MinimumWidth = 8;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // type
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold);
            this.type.DefaultCellStyle = dataGridViewCellStyle5;
            this.type.HeaderText = "Types";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // dgvAllTables
            // 
            this.dgvAllTables.AllowUserToAddRows = false;
            this.dgvAllTables.AllowUserToDeleteRows = false;
            this.dgvAllTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTables.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table});
            this.dgvAllTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllTables.Location = new System.Drawing.Point(152, 2);
            this.dgvAllTables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllTables.Name = "dgvAllTables";
            this.dgvAllTables.RowHeadersVisible = false;
            this.dgvAllTables.RowHeadersWidth = 62;
            this.dgvAllTables.Size = new System.Drawing.Size(158, 301);
            this.dgvAllTables.TabIndex = 4;
            this.dgvAllTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllTables_CellClick);
            // 
            // Table
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Table.DefaultCellStyle = dataGridViewCellStyle9;
            this.Table.HeaderText = "Tables";
            this.Table.MinimumWidth = 8;
            this.Table.Name = "Table";
            this.Table.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txBath
            // 
            this.txBath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txBath.Location = new System.Drawing.Point(314, 307);
            this.txBath.Margin = new System.Windows.Forms.Padding(2);
            this.txBath.Multiline = true;
            this.txBath.Name = "txBath";
            this.txBath.Size = new System.Drawing.Size(176, 24);
            this.txBath.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(495, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 299);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGetPath);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(495, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 22);
            this.panel1.TabIndex = 10;
            // 
            // btGetPath
            // 
            this.btGetPath.BackColor = System.Drawing.Color.White;
            this.btGetPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGetPath.Enabled = false;
            this.btGetPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btGetPath.Location = new System.Drawing.Point(0, 0);
            this.btGetPath.Margin = new System.Windows.Forms.Padding(2);
            this.btGetPath.Name = "btGetPath";
            this.btGetPath.Size = new System.Drawing.Size(33, 22);
            this.btGetPath.TabIndex = 8;
            this.btGetPath.Text = "...";
            this.btGetPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGetPath.UseVisualStyleBackColor = false;
            this.btGetPath.Click += new System.EventHandler(this.btGetPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(753, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallDataBases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllColumnsWithThierTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTables)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvAllColumnsWithThierTypes;
        private DataGridView dgvAllTables;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private DataGridViewButtonColumn Table;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn type;
        private DataGridView dgvallDataBases;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Button button2;
        private Button btMBoth;
        private Button btMBAccess;
        private Button btMDAccess;
        private ProgressBar progMakeData;
        private ProgressBar progMBusiness;
        private ProgressBar progMBoth;
        private SaveFileDialog svFileSavePath;
        private TextBox txBath;
        private RichTextBox textBox1;
        private Panel panel1;
        private Button btGetPath;
        private Button button3;
    }
}
