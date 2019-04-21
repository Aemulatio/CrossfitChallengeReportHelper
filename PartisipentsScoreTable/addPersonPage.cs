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
using System.Xml;
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

                var name = from Challengers in xDoc.Descendants("Challengers")
                    select Challengers.Element("Name").Value;


                Console.WriteLine(name);
                Console.WriteLine(name.GetType());

                foreach (var VARIABLE in name)
                {
                    Console.WriteLine(VARIABLE);
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