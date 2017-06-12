namespace FootballDatabase.UI
{
    public partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CountriesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage TownsTab;
        private System.Windows.Forms.TabPage PlayersTab;
        private System.Windows.Forms.TabPage TeamsTab;
        private System.Windows.Forms.TabPage TrainersTab;
        private FootballDbDataSet footballDbDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private FootballDbDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FootballDbDataSet1 footballDbDataSet1;
        private System.Windows.Forms.BindingSource townsBindingSource;
        private FootballDbDataSet1TableAdapters.TownsTableAdapter townsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FootballDbDataSet2 footballDbDataSet2;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private FootballDbDataSet2TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private FootballDbDataSet3 footballDbDataSet3;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private FootballDbDataSet3TableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView5;
        private FootballDbDataSet4 footballDbDataSet4;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private FootballDbDataSet4TableAdapters.TrainersTableAdapter trainersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox townCountryIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox townNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerSalaryTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox playerNationalityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox playerAgeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox playerTeamIdTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox playerContractTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox playerPositionTextBox;
        private System.Windows.Forms.TextBox teamTownIdTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox trainerTeamIdTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox trainerContractTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox trainerSalaryTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox trainerNationalityTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox trainerAgeTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox trainerNameTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button exportPDFButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown playerIdPDFExport;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CountriesTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDbDataSet = new FootballDatabase.UI.FootballDbDataSet();
            this.TownsTab = new System.Windows.Forms.TabPage();
            this.townCountryIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.townNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.townsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDbDataSet1 = new FootballDatabase.UI.FootballDbDataSet1();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.exportPDFButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.playerIdPDFExport = new System.Windows.Forms.NumericUpDown();
            this.playerPositionTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.playerTeamIdTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.playerContractTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.playerSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.playerNationalityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.playerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDbDataSet2 = new FootballDatabase.UI.FootballDbDataSet2();
            this.TeamsTab = new System.Windows.Forms.TabPage();
            this.teamTownIdTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDbDataSet3 = new FootballDatabase.UI.FootballDbDataSet3();
            this.TrainersTab = new System.Windows.Forms.TabPage();
            this.trainerTeamIdTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.trainerContractTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.trainerSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.trainerNationalityTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.trainerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.trainerNameTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDbDataSet4 = new FootballDatabase.UI.FootballDbDataSet4();
            this.OwnersTab = new System.Windows.Forms.TabPage();
            this.ownerIncomesTextBox = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.ownerTeamIdTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.ownerNationalityTextBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ownerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownersDataSet = new FootballDatabase.UI.OwnersDataSet();
            this.countriesTableAdapter = new FootballDatabase.UI.FootballDbDataSetTableAdapters.CountriesTableAdapter();
            this.townsTableAdapter = new FootballDatabase.UI.FootballDbDataSet1TableAdapters.TownsTableAdapter();
            this.playersTableAdapter = new FootballDatabase.UI.FootballDbDataSet2TableAdapters.PlayersTableAdapter();
            this.teamsTableAdapter = new FootballDatabase.UI.FootballDbDataSet3TableAdapters.TeamsTableAdapter();
            this.trainersTableAdapter = new FootballDatabase.UI.FootballDbDataSet4TableAdapters.TrainersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ownersTableAdapter = new FootballDatabase.UI.OwnersDataSetTableAdapters.OwnersTableAdapter();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.ownersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teamIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataSet = new FootballDatabase.UI.teamsDataSet();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter1 = new FootballDatabase.UI.teamsDataSetTableAdapters.TeamsTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teamOwnerIdTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CountriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet)).BeginInit();
            this.TownsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet1)).BeginInit();
            this.PlayersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIdPDFExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet2)).BeginInit();
            this.TeamsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet3)).BeginInit();
            this.TrainersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet4)).BeginInit();
            this.OwnersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CountriesTab);
            this.tabControl1.Controls.Add(this.TownsTab);
            this.tabControl1.Controls.Add(this.PlayersTab);
            this.tabControl1.Controls.Add(this.TeamsTab);
            this.tabControl1.Controls.Add(this.TrainersTab);
            this.tabControl1.Controls.Add(this.OwnersTab);
            this.tabControl1.Location = new System.Drawing.Point(16, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // CountriesTab
            // 
            this.CountriesTab.Controls.Add(this.label3);
            this.CountriesTab.Controls.Add(this.countryNameTextBox);
            this.CountriesTab.Controls.Add(this.label2);
            this.CountriesTab.Controls.Add(this.dataGridView1);
            this.CountriesTab.Location = new System.Drawing.Point(4, 22);
            this.CountriesTab.Name = "CountriesTab";
            this.CountriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.CountriesTab.Size = new System.Drawing.Size(1092, 424);
            this.CountriesTab.TabIndex = 0;
            this.CountriesTab.Text = "Countries";
            this.CountriesTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Location = new System.Drawing.Point(9, 399);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Add a new row use this:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.countriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.footballDbDataSet;
            // 
            // footballDbDataSet
            // 
            this.footballDbDataSet.DataSetName = "FootballDbDataSet";
            this.footballDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TownsTab
            // 
            this.TownsTab.Controls.Add(this.townCountryIdTextBox);
            this.TownsTab.Controls.Add(this.label6);
            this.TownsTab.Controls.Add(this.label4);
            this.TownsTab.Controls.Add(this.townNameTextBox);
            this.TownsTab.Controls.Add(this.label5);
            this.TownsTab.Controls.Add(this.dataGridView2);
            this.TownsTab.Location = new System.Drawing.Point(4, 22);
            this.TownsTab.Name = "TownsTab";
            this.TownsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TownsTab.Size = new System.Drawing.Size(1092, 424);
            this.TownsTab.TabIndex = 1;
            this.TownsTab.Text = "Towns";
            this.TownsTab.UseVisualStyleBackColor = true;
            // 
            // townCountryIdTextBox
            // 
            this.townCountryIdTextBox.Location = new System.Drawing.Point(126, 398);
            this.townCountryIdTextBox.Name = "townCountryIdTextBox";
            this.townCountryIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.townCountryIdTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Existing Country Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // townNameTextBox
            // 
            this.townNameTextBox.Location = new System.Drawing.Point(9, 398);
            this.townNameTextBox.Name = "townNameTextBox";
            this.townNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.townNameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "To Add a new row use this:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.countryIdDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn1});
            this.dataGridView2.DataSource = this.townsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1092, 320);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // countryIdDataGridViewTextBoxColumn
            // 
            this.countryIdDataGridViewTextBoxColumn.DataPropertyName = "CountryId";
            this.countryIdDataGridViewTextBoxColumn.HeaderText = "CountryId";
            this.countryIdDataGridViewTextBoxColumn.Name = "countryIdDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn1
            // 
            this.isDeletedDataGridViewCheckBoxColumn1.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn1.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn1.Name = "isDeletedDataGridViewCheckBoxColumn1";
            // 
            // townsBindingSource
            // 
            this.townsBindingSource.DataMember = "Towns";
            this.townsBindingSource.DataSource = this.footballDbDataSet1;
            // 
            // footballDbDataSet1
            // 
            this.footballDbDataSet1.DataSetName = "FootballDbDataSet1";
            this.footballDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PlayersTab
            // 
            this.PlayersTab.Controls.Add(this.exportPDFButton);
            this.PlayersTab.Controls.Add(this.label25);
            this.PlayersTab.Controls.Add(this.playerIdPDFExport);
            this.PlayersTab.Controls.Add(this.playerPositionTextBox);
            this.PlayersTab.Controls.Add(this.label14);
            this.PlayersTab.Controls.Add(this.playerTeamIdTextBox);
            this.PlayersTab.Controls.Add(this.label13);
            this.PlayersTab.Controls.Add(this.playerContractTextBox);
            this.PlayersTab.Controls.Add(this.label12);
            this.PlayersTab.Controls.Add(this.playerSalaryTextBox);
            this.PlayersTab.Controls.Add(this.label11);
            this.PlayersTab.Controls.Add(this.playerNationalityTextBox);
            this.PlayersTab.Controls.Add(this.label10);
            this.PlayersTab.Controls.Add(this.playerAgeTextBox);
            this.PlayersTab.Controls.Add(this.label7);
            this.PlayersTab.Controls.Add(this.label8);
            this.PlayersTab.Controls.Add(this.playerNameTextBox);
            this.PlayersTab.Controls.Add(this.label9);
            this.PlayersTab.Controls.Add(this.dataGridView3);
            this.PlayersTab.Location = new System.Drawing.Point(4, 22);
            this.PlayersTab.Name = "PlayersTab";
            this.PlayersTab.Size = new System.Drawing.Size(1092, 424);
            this.PlayersTab.TabIndex = 2;
            this.PlayersTab.Text = "Players";
            this.PlayersTab.UseVisualStyleBackColor = true;
            // 
            // exportPDFButton
            // 
            this.exportPDFButton.Location = new System.Drawing.Point(1000, 395);
            this.exportPDFButton.Name = "exportPDFButton";
            this.exportPDFButton.Size = new System.Drawing.Size(75, 23);
            this.exportPDFButton.TabIndex = 4;
            this.exportPDFButton.Text = "Export PDF";
            this.exportPDFButton.UseVisualStyleBackColor = true;
            this.exportPDFButton.Click += new System.EventHandler(this.ExportPDFButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(952, 344);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Select Player\'s Id To Export";
            // 
            // playerIdPDFExport
            // 
            this.playerIdPDFExport.Location = new System.Drawing.Point(955, 360);
            this.playerIdPDFExport.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.playerIdPDFExport.Name = "playerIdPDFExport";
            this.playerIdPDFExport.Size = new System.Drawing.Size(120, 20);
            this.playerIdPDFExport.TabIndex = 27;
            // 
            // playerPositionTextBox
            // 
            this.playerPositionTextBox.Location = new System.Drawing.Point(654, 398);
            this.playerPositionTextBox.Name = "playerPositionTextBox";
            this.playerPositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerPositionTextBox.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(651, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "*Valid Position Number:";
            // 
            // playerTeamIdTextBox
            // 
            this.playerTeamIdTextBox.Location = new System.Drawing.Point(545, 398);
            this.playerTeamIdTextBox.Name = "playerTeamIdTextBox";
            this.playerTeamIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerTeamIdTextBox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(542, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "*Valid Team Id:";
            // 
            // playerContractTextBox
            // 
            this.playerContractTextBox.Location = new System.Drawing.Point(436, 398);
            this.playerContractTextBox.Name = "playerContractTextBox";
            this.playerContractTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerContractTextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Contract:";
            // 
            // playerSalaryTextBox
            // 
            this.playerSalaryTextBox.Location = new System.Drawing.Point(327, 398);
            this.playerSalaryTextBox.Name = "playerSalaryTextBox";
            this.playerSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerSalaryTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Salary:";
            // 
            // playerNationalityTextBox
            // 
            this.playerNationalityTextBox.Location = new System.Drawing.Point(220, 398);
            this.playerNationalityTextBox.Name = "playerNationalityTextBox";
            this.playerNationalityTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerNationalityTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nationality:";
            // 
            // playerAgeTextBox
            // 
            this.playerAgeTextBox.Location = new System.Drawing.Point(113, 398);
            this.playerAgeTextBox.Name = "playerAgeTextBox";
            this.playerAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerAgeTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "*Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "*Name:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(6, 398);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerNameTextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "To Add a new row use this:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.ageDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn2,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.playersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1092, 320);
            this.dataGridView3.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "Contract";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn2
            // 
            this.isDeletedDataGridViewCheckBoxColumn2.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn2.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn2.Name = "isDeletedDataGridViewCheckBoxColumn2";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.footballDbDataSet2;
            // 
            // footballDbDataSet2
            // 
            this.footballDbDataSet2.DataSetName = "FootballDbDataSet2";
            this.footballDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TeamsTab
            // 
            this.TeamsTab.Controls.Add(this.teamOwnerIdTextBox);
            this.TeamsTab.Controls.Add(this.label26);
            this.TeamsTab.Controls.Add(this.dataGridView4);
            this.TeamsTab.Controls.Add(this.teamTownIdTextBox);
            this.TeamsTab.Controls.Add(this.label15);
            this.TeamsTab.Controls.Add(this.label16);
            this.TeamsTab.Controls.Add(this.teamNameTextBox);
            this.TeamsTab.Controls.Add(this.label17);
            this.TeamsTab.Location = new System.Drawing.Point(4, 22);
            this.TeamsTab.Name = "TeamsTab";
            this.TeamsTab.Size = new System.Drawing.Size(1092, 424);
            this.TeamsTab.TabIndex = 3;
            this.TeamsTab.Text = "Teams";
            this.TeamsTab.UseVisualStyleBackColor = true;
            // 
            // teamTownIdTextBox
            // 
            this.teamTownIdTextBox.Location = new System.Drawing.Point(123, 400);
            this.teamTownIdTextBox.Name = "teamTownIdTextBox";
            this.teamTownIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamTownIdTextBox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "*Existing Town Id:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "*Name:";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(6, 400);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamNameTextBox.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "To Add a new row use this:";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.footballDbDataSet3;
            // 
            // footballDbDataSet3
            // 
            this.footballDbDataSet3.DataSetName = "FootballDbDataSet3";
            this.footballDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TrainersTab
            // 
            this.TrainersTab.Controls.Add(this.trainerTeamIdTextBox);
            this.TrainersTab.Controls.Add(this.label18);
            this.TrainersTab.Controls.Add(this.trainerContractTextBox);
            this.TrainersTab.Controls.Add(this.label19);
            this.TrainersTab.Controls.Add(this.trainerSalaryTextBox);
            this.TrainersTab.Controls.Add(this.label20);
            this.TrainersTab.Controls.Add(this.trainerNationalityTextBox);
            this.TrainersTab.Controls.Add(this.label21);
            this.TrainersTab.Controls.Add(this.trainerAgeTextBox);
            this.TrainersTab.Controls.Add(this.label22);
            this.TrainersTab.Controls.Add(this.label23);
            this.TrainersTab.Controls.Add(this.trainerNameTextBox);
            this.TrainersTab.Controls.Add(this.label24);
            this.TrainersTab.Controls.Add(this.dataGridView5);
            this.TrainersTab.Location = new System.Drawing.Point(4, 22);
            this.TrainersTab.Name = "TrainersTab";
            this.TrainersTab.Size = new System.Drawing.Size(1092, 424);
            this.TrainersTab.TabIndex = 4;
            this.TrainersTab.Text = "Trainers";
            this.TrainersTab.UseVisualStyleBackColor = true;
            // 
            // trainerTeamIdTextBox
            // 
            this.trainerTeamIdTextBox.Location = new System.Drawing.Point(545, 399);
            this.trainerTeamIdTextBox.Name = "trainerTeamIdTextBox";
            this.trainerTeamIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainerTeamIdTextBox.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(542, 383);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "*Valid Team Id:";
            // 
            // trainerContractTextBox
            // 
            this.trainerContractTextBox.Location = new System.Drawing.Point(436, 399);
            this.trainerContractTextBox.Name = "trainerContractTextBox";
            this.trainerContractTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainerContractTextBox.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(433, 383);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Contract:";
            // 
            // trainerSalaryTextBox
            // 
            this.trainerSalaryTextBox.Location = new System.Drawing.Point(327, 399);
            this.trainerSalaryTextBox.Name = "trainerSalaryTextBox";
            this.trainerSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainerSalaryTextBox.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 383);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Salary:";
            // 
            // trainerNationalityTextBox
            // 
            this.trainerNationalityTextBox.Location = new System.Drawing.Point(220, 399);
            this.trainerNationalityTextBox.Name = "trainerNationalityTextBox";
            this.trainerNationalityTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainerNationalityTextBox.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(217, 383);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Nationality:";
            // 
            // trainerAgeTextBox
            // 
            this.trainerAgeTextBox.Location = new System.Drawing.Point(113, 399);
            this.trainerAgeTextBox.Name = "trainerAgeTextBox";
            this.trainerAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainerAgeTextBox.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(110, 383);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "*Age:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 383);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "*Name:";
            // 
            // trainerNameTextBox
            // 
            this.trainerNameTextBox.Location = new System.Drawing.Point(6, 399);
            this.trainerNameTextBox.Name = "trainerNameTextBox";
            this.trainerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainerNameTextBox.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 361);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "To Add a new row use this:";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn4,
            this.ageDataGridViewTextBoxColumn1,
            this.nationalityDataGridViewTextBoxColumn1,
            this.salaryDataGridViewTextBoxColumn1,
            this.contractDataGridViewTextBoxColumn1,
            this.teamIdDataGridViewTextBoxColumn1,
            this.isDeletedDataGridViewCheckBoxColumn4});
            this.dataGridView5.DataSource = this.trainersBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1092, 320);
            this.dataGridView5.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            // 
            // nationalityDataGridViewTextBoxColumn1
            // 
            this.nationalityDataGridViewTextBoxColumn1.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn1.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn1.Name = "nationalityDataGridViewTextBoxColumn1";
            // 
            // salaryDataGridViewTextBoxColumn1
            // 
            this.salaryDataGridViewTextBoxColumn1.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn1.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn1.Name = "salaryDataGridViewTextBoxColumn1";
            // 
            // contractDataGridViewTextBoxColumn1
            // 
            this.contractDataGridViewTextBoxColumn1.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn1.HeaderText = "Contract";
            this.contractDataGridViewTextBoxColumn1.Name = "contractDataGridViewTextBoxColumn1";
            // 
            // teamIdDataGridViewTextBoxColumn1
            // 
            this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
            // 
            // isDeletedDataGridViewCheckBoxColumn4
            // 
            this.isDeletedDataGridViewCheckBoxColumn4.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn4.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn4.Name = "isDeletedDataGridViewCheckBoxColumn4";
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.footballDbDataSet4;
            // 
            // footballDbDataSet4
            // 
            this.footballDbDataSet4.DataSetName = "FootballDbDataSet4";
            this.footballDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OwnersTab
            // 
            this.OwnersTab.Controls.Add(this.dataGridView6);
            this.OwnersTab.Controls.Add(this.ownerIncomesTextBox);
            this.OwnersTab.Controls.Add(this.label30);
            this.OwnersTab.Controls.Add(this.ownerTeamIdTextBox);
            this.OwnersTab.Controls.Add(this.label31);
            this.OwnersTab.Controls.Add(this.ownerNationalityTextBox);
            this.OwnersTab.Controls.Add(this.label27);
            this.OwnersTab.Controls.Add(this.ownerAgeTextBox);
            this.OwnersTab.Controls.Add(this.label28);
            this.OwnersTab.Controls.Add(this.label29);
            this.OwnersTab.Controls.Add(this.ownerNameTextBox);
            this.OwnersTab.Location = new System.Drawing.Point(4, 22);
            this.OwnersTab.Name = "OwnersTab";
            this.OwnersTab.Size = new System.Drawing.Size(1092, 424);
            this.OwnersTab.TabIndex = 5;
            this.OwnersTab.Text = "Owners";
            this.OwnersTab.UseVisualStyleBackColor = true;
            // 
            // ownerIncomesTextBox
            // 
            this.ownerIncomesTextBox.Location = new System.Drawing.Point(440, 398);
            this.ownerIncomesTextBox.Name = "ownerIncomesTextBox";
            this.ownerIncomesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerIncomesTextBox.TabIndex = 47;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(437, 382);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 46;
            this.label30.Text = "*Incomes:";
            // 
            // ownerTeamIdTextBox
            // 
            this.ownerTeamIdTextBox.Location = new System.Drawing.Point(329, 398);
            this.ownerTeamIdTextBox.Name = "ownerTeamIdTextBox";
            this.ownerTeamIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerTeamIdTextBox.TabIndex = 45;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(326, 382);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 13);
            this.label31.TabIndex = 44;
            this.label31.Text = "*Valid Team Id:";
            // 
            // ownerNationalityTextBox
            // 
            this.ownerNationalityTextBox.Location = new System.Drawing.Point(220, 398);
            this.ownerNationalityTextBox.Name = "ownerNationalityTextBox";
            this.ownerNationalityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerNationalityTextBox.TabIndex = 43;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(217, 382);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 42;
            this.label27.Text = "Nationality:";
            // 
            // ownerAgeTextBox
            // 
            this.ownerAgeTextBox.Location = new System.Drawing.Point(113, 398);
            this.ownerAgeTextBox.Name = "ownerAgeTextBox";
            this.ownerAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerAgeTextBox.TabIndex = 41;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(110, 382);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 40;
            this.label28.Text = "*Age:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 382);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 13);
            this.label29.TabIndex = 39;
            this.label29.Text = "*Name:";
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(6, 398);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerNameTextBox.TabIndex = 38;
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.ownersDataSet;
            // 
            // ownersDataSet
            // 
            this.ownersDataSet.DataSetName = "OwnersDataSet";
            this.ownersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // townsTableAdapter
            // 
            this.townsTableAdapter.ClearBeforeFill = true;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To Update use the following table:";
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.nameDataGridViewTextBoxColumn5,
            this.ageDataGridViewTextBoxColumn2,
            this.nationalityDataGridViewTextBoxColumn2,
            this.incomesDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn5,
            this.teamIdDataGridViewTextBoxColumn2});
            this.dataGridView6.DataSource = this.ownersBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(1092, 321);
            this.dataGridView6.TabIndex = 48;
            // 
            // ownersBindingSource1
            // 
            this.ownersBindingSource1.DataMember = "Owners";
            this.ownersBindingSource1.DataSource = this.ownersDataSet;
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn5
            // 
            this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn5.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
            // 
            // ageDataGridViewTextBoxColumn2
            // 
            this.ageDataGridViewTextBoxColumn2.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn2.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn2.Name = "ageDataGridViewTextBoxColumn2";
            // 
            // nationalityDataGridViewTextBoxColumn2
            // 
            this.nationalityDataGridViewTextBoxColumn2.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn2.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn2.Name = "nationalityDataGridViewTextBoxColumn2";
            // 
            // incomesDataGridViewTextBoxColumn
            // 
            this.incomesDataGridViewTextBoxColumn.DataPropertyName = "Incomes";
            this.incomesDataGridViewTextBoxColumn.HeaderText = "Incomes";
            this.incomesDataGridViewTextBoxColumn.Name = "incomesDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn5
            // 
            this.isDeletedDataGridViewCheckBoxColumn5.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn5.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn5.Name = "isDeletedDataGridViewCheckBoxColumn5";
            // 
            // teamIdDataGridViewTextBoxColumn2
            // 
            this.teamIdDataGridViewTextBoxColumn2.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.Name = "teamIdDataGridViewTextBoxColumn2";
            // 
            // teamsDataSet
            // 
            this.teamsDataSet.DataSetName = "teamsDataSet";
            this.teamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.teamsDataSet;
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.ownerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn3,
            this.townIdDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn3});
            this.dataGridView4.DataSource = this.teamsBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1089, 319);
            this.dataGridView4.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // townIdDataGridViewTextBoxColumn
            // 
            this.townIdDataGridViewTextBoxColumn.DataPropertyName = "TownId";
            this.townIdDataGridViewTextBoxColumn.HeaderText = "TownId";
            this.townIdDataGridViewTextBoxColumn.Name = "townIdDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn3
            // 
            this.isDeletedDataGridViewCheckBoxColumn3.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn3.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn3.Name = "isDeletedDataGridViewCheckBoxColumn3";
            // 
            // teamOwnerIdTextBox
            // 
            this.teamOwnerIdTextBox.Location = new System.Drawing.Point(243, 400);
            this.teamOwnerIdTextBox.Name = "teamOwnerIdTextBox";
            this.teamOwnerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamOwnerIdTextBox.TabIndex = 19;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(240, 384);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 13);
            this.label26.TabIndex = 18;
            this.label26.Text = "*Existing Owner Id:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.CountriesTab.ResumeLayout(false);
            this.CountriesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet)).EndInit();
            this.TownsTab.ResumeLayout(false);
            this.TownsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet1)).EndInit();
            this.PlayersTab.ResumeLayout(false);
            this.PlayersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIdPDFExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet2)).EndInit();
            this.TeamsTab.ResumeLayout(false);
            this.TeamsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet3)).EndInit();
            this.TrainersTab.ResumeLayout(false);
            this.TrainersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDbDataSet4)).EndInit();
            this.OwnersTab.ResumeLayout(false);
            this.OwnersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage OwnersTab;
        private OwnersDataSet ownersDataSet;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private OwnersDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.TextBox ownerTeamIdTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox ownerNationalityTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox ownerAgeTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.TextBox ownerIncomesTextBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource ownersBindingSource1;
        private teamsDataSet teamsDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private teamsDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter1;
        private System.Windows.Forms.TextBox teamOwnerIdTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn townIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn3;
    }
}