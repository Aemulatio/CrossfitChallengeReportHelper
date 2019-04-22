using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PartisipentsScoreTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            homePage1.BringToFront();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e) //createBtn
        {
            sidePanel.Height = createDocBtn.Height;
            sidePanel.Top = createDocBtn.Top;

            filePage1.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;

            homePage1.BringToFront();
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = addPersonBtn.Height;
            sidePanel.Top = addPersonBtn.Top;
            
            addPersonPage1.BringToFront();
        }

        private void addResultBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = addResultBtn.Height;
            sidePanel.Top = addResultBtn.Top;

            addResultPage1.BringToFront();
        }

        private void showResults_Click(object sender, EventArgs e)
        {

            sidePanel.Height = showResults.Height;
            sidePanel.Top = showResults.Top;

            showResults1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/aemulatio");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/stiiipan/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: Сделать чтонибудь к этой кнопке, только еще хз что))) 
        }
    }
}