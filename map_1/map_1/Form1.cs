using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToiletslLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name.Text = "МЦД Лужники";
            km.Visible = false;
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;

            PictureBoxEnergybars.Location = new Point(608, 83);
            EnergyBarsLabel.Location = new Point(6937, 97);
            PictureBoxDrinks.Location = new Point(608, 155);
            DrinksLabel.Location = new Point(686, 170);


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            name.Text = "Новодевичей монастырь";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Киевская";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
            //data
            PictureBoxEnergybars.Location = new Point(675, 171);
            EnergyBarsLabel.Location = new Point(788, 194);
            PictureBoxDrinks.Location = new Point(675, 267);
            DrinksLabel.Location = new Point(788, 289);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            name.Text = "МИД";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
            //data
            PictureBoxEnergybars.Location = new Point(675, 267);
            EnergyBarsLabel.Location = new Point(788, 289);
            PictureBoxDrinks.Location = new Point(675, 363);
            DrinksLabel.Location = new Point(788, 388);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            name.Text = "Парк Горького";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;

            PictureBoxInformation.Location = new Point(608, 155); InformationLabel.Location = new Point(686, 170);
            //data
           
            PictureBoxEnergybars.Location = new Point(675, 267);
            EnergyBarsLabel.Location = new Point(788, 289);
            PictureBoxDrinks.Location = new Point(675, 363);
            DrinksLabel.Location = new Point(788, 388);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            name.Text = "Здания РАН";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
            //data
            PictureBoxEnergybars.Location = new Point(675, 171);
            EnergyBarsLabel.Location = new Point(788, 194);
            PictureBoxDrinks.Location = new Point(675, 267);
            DrinksLabel.Location = new Point(788, 289);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Воробьевы горы";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            name.Text = "Стадион Лужники";
            km.Visible = false;
            pictureBoxToilet.Visible = true; ToiletslLabel.Visible = true;
            PictureBoxMedical.Visible = true; MedicalLabel.Visible = true;
            PictureBoxInformation.Visible = true; InformationLabel.Visible = true;
            PictureBoxEnergybars.Visible = true; EnergyBarsLabel.Visible = true;
            PictureBoxDrinks.Visible = true; DrinksLabel.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            name.Text = "Финиш";
            km.Visible = false;
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            name.Text = "1-й старт";
            km.Visible = true;
            km.Text = "Полный марафон 40 км";
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            name.Text = "2-й старт";
            km.Visible = true;
            km.Text = "Половинный марафон 20 км";
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            name.Text = "3-й старт";
            km.Visible = true;
            km.Text = "Веселый старт 5 км";
            pictureBoxToilet.Visible = false; ToiletslLabel.Visible = false;
            PictureBoxMedical.Visible = false; MedicalLabel.Visible = false;
            PictureBoxInformation.Visible = false; InformationLabel.Visible = false;
            PictureBoxEnergybars.Visible = false; EnergyBarsLabel.Visible = false;
            PictureBoxDrinks.Visible = false; DrinksLabel.Visible = false;
        }
    }
}
