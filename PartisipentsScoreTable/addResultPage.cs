using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PartisipentsScoreTable
{
    public partial class addResultPage : UserControl
    {
        public addResultPage()
        {
            InitializeComponent();
        }


        private void addResultPage_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(@".\Challangers.xml"))
                {
                    return;
                }

                XDocument xDoc = XDocument.Load("Challengers.xml");

                List<int> numbersList = xDoc.Root
                    .Elements("Challenger")
                    .Elements("Number")
                    .Select(x => (int)x).ToList();

                List<string> challengersList = xDoc.Root
                    .Elements("Challenger")
                    .Elements("Name")
                    .Select(x => (string)x).ToList();


                

                
                xDoc.Save("Challengers.xml");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }












            CurrentStatus.Text = "Все данные загружены";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Add results UPDATE

            CurrentStatus.Text = "Обновил (☆▽☆)";
        }

        private void challengerNumberCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            challengerNameCB.SelectedIndex = challengerNumberCB.SelectedIndex;
            challengerNumberLbl.Text = challengerNumberCB.SelectedItem.ToString();
        }

        private void challengerNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            challengerNumberCB.SelectedIndex = challengerNameCB.SelectedIndex;
            challengerNameLbl.Text = challengerNameCB.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            challengerWeightLbl.Text = weightsBox.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            challengerRepeatsLbl.Text = repeatsBox.Text != String.Empty ? repeatsBox.Text : "Повторы";
        }
    }
}