using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace гонки_lubimova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clear()
        {
            pictureBoxDrinks.Visible = false; labelDrinks.Visible = false; pictureBoxEnergy.Visible = false; labelEnergy.Visible = false;
            pictureBoxToilets.Visible = false; labelToilets.Visible = false; pictureBoxInformation.Visible = false; labelInformation.Visible = false;
            pictureBoxMedical.Visible = false; labelMedical.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clear(); name_label.Text = "MCC Luzhniki"; marathon_label.Text = "Samba full marafon";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true; pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Race start 1"; marathon_label.Text = "Samba full marafon";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Novodevichy Convent"; marathon_label.Text = "Samba full marafon"; pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true; pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true; pictureBoxMedical.Visible = true; labelMedical.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            clear(); name_label.Text = "Metro Kiyevskaya"; marathon_label.Text = "Samba full marafon";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true; pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "MID"; marathon_label.Text = "Samba full marafon"; pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true; pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxMedical.Visible = true; labelMedical.Visible = true; pictureBoxMedical.Location = new Point(710, 482); labelMedical.Location = new Point(803, 500);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            clear(); name_label.Text = "Gorky Park"; marathon_label.Text = "Jongo halt marafon";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true; pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxToilets.Visible = true; labelToilets.Visible = true; pictureBoxInformation.Visible = true; labelInformation.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            clear(); name_label.Text = "Building RAN"; marathon_label.Text = "Jongo halt marafon";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true; pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxToilets.Visible = true; labelToilets.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Metro Vorobyevyi gory"; marathon_label.Text = "Jongo halt marafon"; pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true; pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true; pictureBoxMedical.Visible = true; labelMedical.Visible = true;
            pictureBoxInformation.Location = new Point(710, 556); labelInformation.Location = new Point(803, 575);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Statdium Luzhniki"; marathon_label.Text = "Capoira fun 5km"; pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true; pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true; pictureBoxMedical.Visible = true; labelMedical.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Race start 2"; marathon_label.Text = "Jongo halt marafon";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Race start 3"; marathon_label.Text = "Capoira fun 5km";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clear();
            name_label.Text = "Finish!!"; marathon_label.Text = null;
        }
    }
}
