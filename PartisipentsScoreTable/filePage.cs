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
    public partial class filePage : UserControl
    {
        public filePage()
        {
            InitializeComponent();
        }

        private void filePage_Load(object sender, EventArgs e)
        {
            //TODO: Make save/load file;
            //TODO: If load -> convert to DB format (if it necessary)
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _fileName = String.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileNameBox.Text != String.Empty)
            {
                FileName = fileNameBox.Text;
            }
        }
    }
}