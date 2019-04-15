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
                SqlConnection con = new SqlConnection(Properties.Settings.Default.ChallengerDBConnectionString);
                con.Open();
                SqlCommand MCom = new SqlCommand();
                
                MCom.Connection = con;
                //insert into <название таблицы> ([<Имя столбца>, ... ]) values (<Значение>,...)
                //https://social.msdn.microsoft.com/Forums/vstudio/ru-RU/e5fa4f20-8293-4461-9fee-91867d4318ea/c-sql-insert-statement?forum=csharpgeneral
                //https://stackoverflow.com/questions/12241084/how-to-insert-data-into-sql-server

                MCom.CommandText = "INSERT INTO Challenger (Number, Name) values()"; //TODO: INSERTS
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
               
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Mesto");
                
                con.Close();
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