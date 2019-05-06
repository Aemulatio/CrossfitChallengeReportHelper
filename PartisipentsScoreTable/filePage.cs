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

            openFileDialog1.Filter = "XML tables(*.xml)|*.xml";
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

        private void submitNameButton_Click(object sender, EventArgs e)
        {
            if (fileNameBox.Text != String.Empty)
            {
                FileName = fileNameBox.Text;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
             FileName = openFileDialog1.SafeFileName;
             FileName = FileName.Remove(FileName.Length - 4);
            // читаем файл в строку
            Console.WriteLine("FN - " + FileName);
            MessageBox.Show("Файл открыт");
        }
    }
}