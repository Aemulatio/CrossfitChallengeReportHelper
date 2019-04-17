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
            //TODO: Load data from DB to dataGridView (it should be it 2nd course's courseWork)

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
                this.challengerTableAdapter.Fill(this.challengerDBDataSet.Challenger);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void challengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.challengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.challengerDBDataSet);
        }
    }
}