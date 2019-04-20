using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                using (SqlConnection connection =
                    new SqlConnection(Properties.Settings.Default.ChallengerDBConnectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(@"select * from Challenger",
                            connection)) //TODO: INSERTS
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine("aaaaaa - " + reader[0]);
                                Console.WriteLine("aaaaaa - " + reader[1]);
                                Console.WriteLine("aaaaaa -----------------");
                                challengerNumberCB.Items.Add(reader[0].ToString());
                                challengerNameCB.Items.Add(reader[1].ToString());
                                CurrentStatus.Text = $"Загружен - {reader[1]}";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                CurrentStatus.Text = "Все данные загружены";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nНе работаю(");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Add results UPDATE
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable tbl = new DataTable();
                SqlCommand command = new SqlCommand("UPDATE Challenger SET '25' = @reps Where Number = @num");
                SqlConnection con = new SqlConnection(Properties.Settings.Default.ChallengerDBConnectionString);
                con.Open();
                command.Parameters.AddWithValue("@reps", Convert.ToInt32(challengerRepeatsLbl.Text));
                command.Parameters.AddWithValue("@num", Convert.ToInt32(challengerNumberLbl.Text));
                dataAdapter.SelectCommand = command;
                dataAdapter.SelectCommand.Connection = con;
                tbl.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(tbl);

                using (var cmdBuilder = new SqlCommandBuilder(dataAdapter))
                {
                    dataAdapter.Update(tbl);
                }

                /*using (SqlConnection connection =
                    new SqlConnection(Properties.Settings.Default.ChallengerDBConnectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(
                            "UPDATE Challenger SET " + comboBox1.SelectedItem.ToString() +
                            " = @reps Where Number = @num",
                            connection)) //TODO: INSERTS
                        {
                            command.Parameters.AddWithValue("@reps", Convert.ToInt32(challengerRepeatsLbl.Text));
                            command.Parameters.AddWithValue("@num", Convert.ToInt32(challengerNumberLbl.Text));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                */
                CurrentStatus.Text = "Обновил (☆▽☆)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nНе работаю(");
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
            challengerWeightLbl.Text = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            challengerRepeatsLbl.Text = textBox1.Text != String.Empty ? textBox1.Text : "Повторы";
        }
    }
}