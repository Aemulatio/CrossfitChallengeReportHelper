using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartisipentsScoreTable
{
    public partial class showResults : UserControl
    {
        private addPersonPage challengerList;

        public showResults()
        {
            InitializeComponent();
            challengerList = new addPersonPage();
        }

        private void showResults_Load(object sender, EventArgs e)
        {
//            foreach (var VARIABLE in challengerList.Challengers)
//            {
//                dataGridView1.Rows.Add(VARIABLE);
//            }
        }
    }
}
