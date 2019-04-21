using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            try
            {
                if (!File.Exists(@".\Challengers.xml"))
                {
                    using (StreamWriter sr = File.CreateText(@".\Challengers.xml"))
                    {
                        sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf - 8\" ?>");
                        sr.WriteLine("< challengers >");
                        sr.WriteLine("</ challengers >");
                    }
                }

                XDocument xDoc = XDocument.Load("Challengers.xml");
                var result = from VAR in xDoc.Root.Descendants("Challenger")
                    select VAR;

                foreach (var VARIABLE in result)
                {
                    challengerDataGridView.Rows.Add(
                        VARIABLE.Attribute("Number").Value
                        , VARIABLE.Attribute("Name").Value
                        , VARIABLE.Attribute("w25").Value
                        , VARIABLE.Attribute("w35").Value
                        , VARIABLE.Attribute("w45").Value
                        , VARIABLE.Attribute("w60").Value
                        , VARIABLE.Attribute("w70").Value
                        , VARIABLE.Attribute("w80").Value
                        , VARIABLE.Attribute("w100").Value
                        , (int.Parse(VARIABLE.Attribute("w25").Value) * 25 +
                           int.Parse(VARIABLE.Attribute("w35").Value) * 35 +
                           int.Parse(VARIABLE.Attribute("w45").Value) * 45 +
                           int.Parse(VARIABLE.Attribute("w60").Value) * 60 +
                           int.Parse(VARIABLE.Attribute("w70").Value) * 70 +
                           int.Parse(VARIABLE.Attribute("w80").Value) * 80 +
                           int.Parse(VARIABLE.Attribute("w100").Value) * 100)
                    );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            challengerDataGridView.Rows.Clear();
            showResults_Load(sender,e);
        }

        private void challengerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}