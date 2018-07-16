using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Main
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            double Score = Settings.Score;
            string Name = tb_Name.Text;
            write(Name, Score);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            read();
        }

        private void write(string a, double b)
        {
            string cs = @"server=localhost;userid=root;password=1234;database=scoreboard";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO score VALUES(@Name,@Score)";
            cmd.Parameters.AddWithValue("@Name", a);
            cmd.Parameters.AddWithValue("@Score", b);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void read()
        {
            this.scoreTableAdapter.Fill(this.mySet1.score);
            dataGridView1.Sort(scoreDataGridViewTextBoxColumn,ListSortDirection.Descending);
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "mySet1.score". Sie können sie bei Bedarf verschieben oder entfernen.
            this.scoreTableAdapter.Fill(this.mySet1.score);
            dataGridView1.Sort(scoreDataGridViewTextBoxColumn, ListSortDirection.Descending);
        }
    }
}
