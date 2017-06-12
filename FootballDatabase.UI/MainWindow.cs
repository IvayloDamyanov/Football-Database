namespace FootballDatabase.UI
{
    using System;
    using System.Windows.Forms;
    using FootballDatabase.Data.Contexts;
    using FootballDatabase.Utils.Models;

    public partial class MainWindow : Form
    {
        private SqlServerFootballDbContext context = new SqlServerFootballDbContext();

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamsDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter1.Fill(this.teamsDataSet.Teams);
            // TODO: This line of code loads data into the 'ownersDataSet.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.ownersDataSet.Owners);
            // TODO: This line of code loads data into the 'footballDbDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.footballDbDataSet.Countries);
            
            // TODO: This line of code loads data into the 'footballDbDataSet1.Towns' table. You can move, or remove it, as needed.
            this.townsTableAdapter.Fill(this.footballDbDataSet1.Towns);
            
            // TODO: This line of code loads data into the 'footballDbDataSet2.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.footballDbDataSet2.Players);
            
            // TODO: This line of code loads data into the 'footballDbDataSet3.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.footballDbDataSet3.Teams);
            
            // TODO: This line of code loads data into the 'footballDbDataSet4.Trainers' table. You can move, or remove it, as needed.
            this.trainersTableAdapter.Fill(this.footballDbDataSet4.Trainers);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
            this.dataGridView2.Refresh();
            this.dataGridView3.Refresh();
            this.dataGridView4.Refresh();
            this.dataGridView5.Refresh();
            this.dataGridView6.Refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.countryNameTextBox.Text.Length >= 2)
            {
                this.footballDbDataSet.Countries.AddCountriesRow(this.countryNameTextBox.Text, false);
            }

            if (this.townNameTextBox.Text.Length >= 2 
                && this.townCountryIdTextBox.Text.Length >= 1 
                && int.Parse(this.townCountryIdTextBox.Text) < this.footballDbDataSet.Countries.Count)
            {
                this.footballDbDataSet1.Towns.AddTownsRow(this.townNameTextBox.Text, int.Parse(this.townCountryIdTextBox.Text), false);
            }

            if (this.playerNameTextBox.Text.Length >= 2)
            {
                decimal salary = 0;
                int contract = 0;
                if (this.playerSalaryTextBox.Text.Length > 0)
                {
                    salary = decimal.Parse(this.playerSalaryTextBox.Text);
                }

                if (this.playerContractTextBox.Text.Length > 0)
                {
                    contract = int.Parse(this.playerContractTextBox.Text);
                }

                this.footballDbDataSet2.Players.AddPlayersRow(
                    this.playerNameTextBox.Text, 
                    int.Parse(this.playerAgeTextBox.Text),
                    this.playerNationalityTextBox.Text, 
                    salary, 
                    contract, 
                    int.Parse(this.playerTeamIdTextBox.Text), 
                    false, 
                    int.Parse(this.playerPositionTextBox.Text));
            }

            if (this.teamNameTextBox.Text.Length >= 2
                && this.teamTownIdTextBox.Text.Length >= 1
                && int.Parse(this.teamTownIdTextBox.Text) < this.footballDbDataSet1.Towns.Count
                && this.teamOwnerIdTextBox.Text.Length >= 1)
            {
                this.teamsDataSet.Teams.AddTeamsRow(int.Parse(this.teamOwnerIdTextBox.Text) , this.teamNameTextBox.Text, int.Parse(this.teamTownIdTextBox.Text), false);
            }

            if (this.trainerNameTextBox.Text.Length >= 2)
            {
                decimal salary = 0;
                int contract = 0;
                if (this.trainerSalaryTextBox.Text.Length > 0)
                {
                    salary = decimal.Parse(this.trainerSalaryTextBox.Text);
                }

                if (this.trainerContractTextBox.Text.Length > 0)
                {
                    contract = int.Parse(this.trainerContractTextBox.Text);
                }

                this.footballDbDataSet4.Trainers.AddTrainersRow(
                    this.trainerNameTextBox.Text,
                    int.Parse(this.trainerAgeTextBox.Text),
                    this.trainerNationalityTextBox.Text,
                    salary,
                    contract,
                    int.Parse(this.trainerTeamIdTextBox.Text),
                    false);
            }

            if (this.ownerNameTextBox.Text.Length >= 2)
            {
                decimal incomes = 0;

                if (this.ownerIncomesTextBox.Text.Length > 0)
                {
                    incomes = decimal.Parse(this.ownerIncomesTextBox.Text);
                }

                this.ownersDataSet.Owners.AddOwnersRow(
                    int.Parse(this.ownerTeamIdTextBox.Text),
                    this.ownerNameTextBox.Text,
                    this.ownerNationalityTextBox.Text,
                    int.Parse(this.ownerAgeTextBox.Text),
                    incomes,                    
                    false);
            }

            this.countriesTableAdapter.Update(this.footballDbDataSet);
            this.townsTableAdapter.Update(this.footballDbDataSet1);
            this.playersTableAdapter.Update(this.footballDbDataSet2);
            this.teamsTableAdapter1.Update(this.teamsDataSet);
            this.trainersTableAdapter.Update(this.footballDbDataSet4);
            this.ownersTableAdapter.Update(this.ownersDataSet);

            this.ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }     
                }     
            };

            func(this.Controls);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //do not delete, breaks something
        {
        }

        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            int id = (int)this.playerIdPDFExport.Value;
            PdfReporter.ExportPlayerToPDF(id);
        }
    }
}
