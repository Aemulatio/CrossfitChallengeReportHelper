using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: May be do some kind of report

namespace PartisipentsScoreTable
{
    public partial class showResults : UserControl
    {
        public showResults()
        {
            InitializeComponent();
        }

        private void showResults_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            challengerDataGridView.Refresh();
            challengerDataGridView.Update();
        }

        private void challengerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}