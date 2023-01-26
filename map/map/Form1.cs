using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class map : Form
    {
        private const bool V = true;

        public map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name.Text = "Стадион Лужники";
            label1.Visible = false;
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;

            name.Text = "Начало марафона";
            label1.Text = "Полный марафон 60 км";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            name.Text = "Стадион Лужники";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;





        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            name.Text = "МЦК Лужники";
            label1.Visible = false;
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;

            PictureBoxEnergyBars.Location = new Point(705, 59);
            EnergyBarsLabel.Location = new Point(107, 59);
            PictureBoxDrinks.Location = new Point(705, 169);
            DrinksLabel.Location = new Point(107, 177);
        }

        private void PictureBoxMedical_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            name.Text = "Новодевичей монастырь";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Киевская";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;

            PictureBoxEnergyBars.Location = new Point(705, 169);
            EnergyBarsLabel.Location = new Point(107, 177);
            PictureBoxDrinks.Location = new Point(705, 286);
            DrinksLabel.Location = new Point(107, 290);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            name.Text = "МИД";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;

            PictureBoxEnergyBars.Location = new Point(705, 169);
            EnergyBarsLabel.Location = new Point(107, 177);
           
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            name.Text = "Парк Горького";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            name.Text = "Здания РАН";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Воробьевы горы";
            label1.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergyBars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
   
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;

            name.Text = "Середина марафона";
            label1.Text = "Полный марафон 40 км";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergyBars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;

            name.Text = "Конец марафона";
            label1.Text = "Полный марафон 20 км";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            name.Text = "Финиш!"
        }
    }
}