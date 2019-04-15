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
    public partial class addPersonPage : UserControl
    {
        private List<Challenger> challengers;

        public addPersonPage()
        {
            InitializeComponent();
            challengers = new List<Challenger>();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string fullName = firstNameBox.Text + " " + lastNameBox.Text;

            try
            {
                //challengers.Add(new Challenger(Convert.ToInt32(personNumberBox.Text), fullName));
                firstNameBox.Text = lastNameBox.Text = personNumberBox.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Введен не верный номер!", "Повнимательней!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }


            Console.WriteLine("_________________________________");

            foreach (var VARIABLE in challengers)
            {
                Console.WriteLine(VARIABLE.Number);
                Console.WriteLine(VARIABLE.Name);
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________");

        }

//        public List<Challenger> Challengers
//        {
//            get { return challengers; }
//
//        }




    }
}