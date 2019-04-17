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
                using (SqlConnection connection =
                    new SqlConnection(Properties.Settings.Default.ChallengerDBConnectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command =
                            new SqlCommand(@"INSERT Challenger VALUES(@number, @name, 0, 0, 0, 0, 0, 0, 0)",
                                connection)) //TODO: INSERTS
                        {
                            command.Parameters.Add(new SqlParameter("@number", personNumberBox.Text));
                            command.Parameters.Add(new SqlParameter("@name", fullName));
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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