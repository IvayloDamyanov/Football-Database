using FootballDatabase.Data;
using FootballDatabase.Utils.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballDatabase.UI
{
    public partial class MainWindow : Form
    {
        FootballDbContext context = new FootballDbContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            dataGridView3.Refresh();
            dataGridView4.Refresh();
            dataGridView5.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CountryNameTextBox.Text.Length >= 2)
            {
                footballDbDataSet.Countries.AddCountriesRow(CountryNameTextBox.Text, false);
            }

            if (TownNameTextBox.Text.Length >= 2 
                && TownCountryIdTextBox.Text.Length >= 1 
                && int.Parse(TownCountryIdTextBox.Text) < footballDbDataSet.Countries.Count)
            {
                footballDbDataSet1.Towns.AddTownsRow(TownNameTextBox.Text, int.Parse(TownCountryIdTextBox.Text), false);
            }

            if (PlayerNameTextBox.Text.Length >= 2)
            {
                decimal salary = 0;
                int contract = 0;
                if (PlayerSalaryTextBox.Text.Length > 0)
                {
                    salary = decimal.Parse(PlayerSalaryTextBox.Text);
                }
                if (PlayerContractTextBox.Text.Length > 0)
                {
                    contract = int.Parse(PlayerContractTextBox.Text);
                }

                footballDbDataSet2.Players.AddPlayersRow(PlayerNameTextBox.Text, 
                                                            int.Parse(PlayerAgeTextBox.Text), 
                                                            PlayerNationalityTextBox.Text, 
                                                            salary, 
                                                            contract, 
                                                            int.Parse(PlayerTeamIdTextBox.Text), 
                                                            false, 
                                                            int.Parse(PlayerPositionTextBox.Text));
            }

            if (TeamNameTextBox.Text.Length >= 2
                && TeamTownIdTextBox.Text.Length >= 1
                && int.Parse(TeamTownIdTextBox.Text) < footballDbDataSet1.Towns.Count)
            {
                footballDbDataSet3.Teams.AddTeamsRow(TeamNameTextBox.Text, int.Parse(TeamTownIdTextBox.Text), false);
            }

            if (TrainerNameTextBox.Text.Length >= 2)
            {
                decimal salary = 0;
                int contract = 0;
                if (TrainerSalaryTextBox.Text.Length > 0)
                {
                    salary = decimal.Parse(TrainerSalaryTextBox.Text);
                }
                if (TrainerContractTextBox.Text.Length > 0)
                {
                    contract = int.Parse(TrainerContractTextBox.Text);
                }

                footballDbDataSet4.Trainers.AddTrainersRow(PlayerNameTextBox.Text,
                                                            int.Parse(PlayerAgeTextBox.Text),
                                                            PlayerNationalityTextBox.Text,
                                                            salary,
                                                            contract,
                                                            int.Parse(PlayerTeamIdTextBox.Text),
                                                            false);
            }


            this.countriesTableAdapter.Update(footballDbDataSet);
            this.townsTableAdapter.Update(footballDbDataSet1);
            this.playersTableAdapter.Update(footballDbDataSet2);
            this.teamsTableAdapter.Update(footballDbDataSet3);
            this.trainersTableAdapter.Update(footballDbDataSet4);

            this.ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportPDFButton_Click(object sender, EventArgs e)
        {
            int id = (int)playerIdPDFExport.Value;
            PdfReporter.ExportPlayerToPDF(id);
        }
    }
}
