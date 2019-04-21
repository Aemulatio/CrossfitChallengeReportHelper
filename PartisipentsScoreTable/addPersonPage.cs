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

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Challengers.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе

            Console.WriteLine(xRoot);






            //https://www.youtube.com/watch?v=BHdNd6ojeDI  - delegation 

            /*
             *  using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChallengerDBConnectionString))
                {
                    string saveStaff = "INSERT into Challenger (staffName,userID,idDepartment) VALUES (@staffName,@userID,@idDepartment)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = connection;
                        querySaveStaff.Parameters.Add("@staffName", SqlDbType.VarChar, 30).Value = name;
                        connection.Open();
                    }
                }
             */
            /*


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
           }*/




        }

//        public List<Challenger> Challengers
//        {
//            get { return challengers; }
//
//        }
    }
}