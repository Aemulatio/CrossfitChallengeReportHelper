using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace PartisipentsScoreTable
{
    public partial class addPersonPage : UserControl
    {
        public addPersonPage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string fullName = firstNameBox.Text + " " + lastNameBox.Text;

            try
            {
                if (!File.Exists(@".\Challangers.xml"))
                {
                    using (StreamWriter sr = File.CreateText(@".\Challangers.xml"))
                    {
                        sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf - 8\" ?>");
                        sr.WriteLine("< challengers >");
                        sr.WriteLine("</ challengers >");
                    }
                }

                XDocument xDoc = XDocument.Load("Challengers.xml");

                List<int> bisyNumbersList = xDoc.Root
                    .Elements("Challenger")
                    .Elements("Number")
                    .Select(x => (int) x).ToList();

                List<string> challengersList = xDoc.Root
                    .Elements("Challenger")
                    .Elements("Name")
                    .Select(x => (string)x).ToList();


                if (firstNameBox.Text == string.Empty
                    || lastNameBox.Text == String.Empty
                    || personNumberBox.Text == String.Empty)
                {
                    MessageBox.Show("Не все поля заполненны", "#", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (bisyNumbersList.Contains(Convert.ToInt32(personNumberBox.Text)))
                {
                    MessageBox.Show("Номер уже занят", "#", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (challengersList.Contains(fullName))
                {
                    MessageBox.Show("Уже внесен в список", "#", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                XElement newElement =
                    new XElement("Challenger",
                        new XElement("Number", personNumberBox.Text),
                        new XElement("Name", fullName),
                        new XElement("w25", 0),
                        new XElement("w35", 0),
                        new XElement("w45", 0),
                        new XElement("w60", 0),
                        new XElement("w70", 0),
                        new XElement("w80", 0),
                        new XElement("w100", 0)
                    );
                xDoc.Descendants("Challengers").Last().Add(newElement);
                xDoc.Save("Challengers.xml");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}