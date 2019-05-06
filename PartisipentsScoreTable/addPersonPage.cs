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

        private XDocument _xDoc;

        private string _fileName = String.Empty;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private void addBtn_Click(object sender, EventArgs e) //TODO: MessageBoxes Caption
        {
            string fullName = firstNameBox.Text + " " + lastNameBox.Text;


            if (FileName == String.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Create file named as 'Untitle'?", "#",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.No)
                {
                    //relocate to filePage
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    FileName = "Untitled";
                    using (StreamWriter sr = File.CreateText(@".\" + FileName + ".xml"))
                    {
                        sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                        sr.WriteLine("<Challengers>");
                        sr.WriteLine("</Challengers>");
                    }
                }
            }

            try
            {
                if (!File.Exists(@".\" + FileName + ".xml"))
                {
                    using (StreamWriter sr = File.CreateText(@".\" + FileName + ".xml"))
                    {
                        sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                        sr.WriteLine("<Challengers>");
                        sr.WriteLine("</Challengers>");
                    }
                }

                _xDoc = XDocument.Load(FileName + ".xml");

                if (_xDoc.Root != null)
                {
                    List<int> bisyNumbersList = _xDoc.Root
                        .Elements("Challenger")
                        .Attributes("Number")
                        .Select(x => (int) x).ToList();

                    List<string> challengersList = _xDoc.Root
                        .Elements("Challenger")
                        .Attributes("Name")
                        .Select(x => (string) x).ToList();


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
                }

                XElement newElement =
                    new XElement("Challenger",
                        new XAttribute("Number", personNumberBox.Text),
                        new XAttribute("Name", fullName),
                        new XAttribute("w25", 0),
                        new XAttribute("w35", 0),
                        new XAttribute("w45", 0),
                        new XAttribute("w60", 0),
                        new XAttribute("w70", 0),
                        new XAttribute("w80", 0),
                        new XAttribute("w100", 0)
                    );
                _xDoc.Descendants("Challengers").Last().Add(newElement);
                _xDoc.Save(FileName + ".xml");
                busyNumbersList.Text += (personNumberBox.Text + "; ");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Data);
                Console.WriteLine(exception.Source);
            }
        }

        private void addPersonPage_Load(object sender, EventArgs e)
        {
            if (File.Exists(@".\" + FileName + ".xml"))
            {
                _xDoc = XDocument.Load(FileName + ".xml");
                if (_xDoc.Root != null)
                {
                    var allResults = from chal in _xDoc.Root.Descendants("Challenger")
                        select chal.Attribute("Number").Value;

                    foreach (var VARIABLE in allResults)
                    {
                        busyNumbersList.Text += (VARIABLE + "; ");
                    }
                }
            }

        }

        private void addPersonPage_Enter(object sender, EventArgs e)
        {
            busyNumbersList.Clear();

            if (File.Exists(@".\" + FileName + ".xml"))
            {
                _xDoc = XDocument.Load(FileName + ".xml");
                if (_xDoc.Root != null)
                {
                    var allResults = from chal in _xDoc.Root.Descendants("Challenger")
                        select chal.Attribute("Number").Value;

                    foreach (var variable in allResults)
                    {
                        busyNumbersList.Text += (variable + "; ");
                    }
                }
            }
        }
    }
}