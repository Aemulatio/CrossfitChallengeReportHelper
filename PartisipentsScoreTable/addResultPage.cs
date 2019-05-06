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

        private XDocument xDoc;

        private void addResultPage_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(@".\Challengers.xml"))
                {
                    return;
                }

                xDoc = XDocument.Load("Challengers.xml");

                #region ChallengersNumberComboBox

                List<int> numbersList = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("Number")
                    .Select(x => (int) x).ToList();

                foreach (var VARIABLE in numbersList)
                {
                    challengerNumberCB.Items.Add(VARIABLE);
                }

                #endregion

                #region ChallengersNameComboBox

                List<string> challengersList = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("Name")
                    .Select(x => (string) x).ToList();

                foreach (var VARIABLE in challengersList)
                {
                    challengerNameCB.Items.Add(VARIABLE);
                }

                #endregion

                xDoc.Save("Challengers.xml");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            CurrentStatus.Text = "Все данные загружены";
        }

        private void button1_Click(object sender, EventArgs e) //TODO: Add results UPDATE
        {
            try
            {
                xDoc = XDocument.Load("Challengers.xml");

                #region GettingAllRepeats

                #region 25

                List<int> w25 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w25")
                    .Select(x => (int) x).ToList();

                int W25 = w25[0];

                #endregion

                #region 35

                List<int> w35 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w35")
                    .Select(x => (int) x).ToList();
                int W35 = w35[0];

                #endregion

                #region 45

                List<int> w45 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w45")
                    .Select(x => (int) x).ToList();
                int W45 = w45[0];

                #endregion

                #region 60

                List<int> w60 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w60")
                    .Select(x => (int) x).ToList();
                int W60 = w60[0];

                #endregion

                #region 70

                List<int> w70 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w70")
                    .Select(x => (int) x).ToList();
                int W70 = w70[0];

                #endregion

                #region 80

                List<int> w80 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w80")
                    .Select(x => (int) x).ToList();
                int W80 = w80[0];

                #endregion

                #region 100

                List<int> w100 = xDoc.Root
                    .Elements("Challenger")
                    .Attributes("w100")
                    .Select(x => (int) x).ToList();
                int W100 = w100[0];

                #endregion

                #endregion

                if (repeatsBox.Text == String.Empty)
                {
                    return;
                }

                int currentRepeats = Convert.ToInt32(repeatsBox.Text);
                IEnumerable<XElement> results = new List<XElement>();
                try
                {
                    results = from chal in xDoc.Root.Descendants("Challenger")
                        where chal.Attribute("Number").Value == challengerNumberCB.SelectedItem.ToString()
                        select chal; //return person with selected number
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "#");
                }

                XElement result = results.ElementAt(0);


                switch (challengerWeightLbl.Text)
                {
                    case "25":
                        W25 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W25.ToString();
                        break;
                    case "35":
                        W35 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W35.ToString();
                        break;
                    case "45":
                        W45 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W45.ToString();
                        break;
                    case "60":
                        W60 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W60.ToString();
                        break;
                    case "70":
                        W70 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W70.ToString();
                        break;
                    case "80":
                        W80 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W80.ToString();
                        break;
                    case "100":
                        W100 += currentRepeats;
                        result.Attribute("w" + challengerWeightLbl.Text).Value = W100.ToString();
                        break;
                    default:
                        MessageBox.Show("Weight doesn't choose", "#", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }

                xDoc.Save("Challengers.xml");
                CurrentStatus.Text = "Обновил (☆▽☆)";

                weightsBox.Text = "";
                repeatsBox.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "#", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void repeatsBox_Enter(object sender, EventArgs e)
        {
        }
    }
}