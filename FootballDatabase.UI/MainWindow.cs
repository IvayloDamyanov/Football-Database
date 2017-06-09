using FootballDatabase.Commands;
using FootballDatabase.Contracts;
using FootballDatabase.Core;
using FootballDatabase.Data;
using System;
using System.Windows.Forms;

namespace FootballDatabase.UI
{
    public partial class MainWindow : Form
    {
        private static FootballDbContext context;
        private static DataWriter dataWriter;
        private static QueryBuilder queryBuilder;

        public MainWindow()
        {
            InitializeComponent();

            context = new FootballDbContext();
            dataWriter = new DataWriter(context);
            queryBuilder = new QueryBuilder(context);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tableName = comboBox1.Text;
            int idValue = (int)numericUpDown1.Value;

            string str = queryBuilder.AddQuery(tableName, idValue);

            textBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tableName = comboBox1.Text;
            int idValue = (int)numericUpDown1.Value;

            queryBuilder.DeleteQuery(tableName, idValue);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
