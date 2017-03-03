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

namespace Main
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }
        
        private List<String> board = new List<String>();
        private List<String> toPush = new List<String>();
        private String[] sync = new String[3];
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //.pushBoard
            // Read the csv File and remove the header and compare the data with the preloaded ArrayList and add new Entries.
            // Convert the Csv Reads to a String-Array
            // Paste the new StringArray Parts to the existing list-view at the scoreboard
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //.getBoard
            // Push Data from Variables to a csv File with an predefinded Header
        }
    }
}
