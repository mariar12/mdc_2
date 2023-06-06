using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.BMI_калькулятор
{
    public partial class Form1 : Form
    {
        float h;
        float w;
        float imt;

       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            h = float.Parse(textBoxHeight.Text); 
            w = float.Parse(textBoxWeight.Text);
            h = h / 100; //перевод роста в метры
            imt = w / (h * h);  // вычисляем ИМТ
            label1BMI.Text = imt.ToString("N");  // выводим значение ИМТ на метку, сокращаем до 2 знаков с помощью "N"
            trackBarBMI.Value = (int)imt;

            // Отображаем метку с результатом и определяем, в какой категории находится ИМТ
            labelves.Visible = true;
            if (imt < 18.5)
                labelves.Text = "Недостаточный вес";
            if ((imt > 18.5) & (imt < 24.9))
                labelves.Text = "Здоровый вес";
            if ((imt > 24.9) & (imt < 29.9))
                labelves.Text = "Избыточный вес";
            if (imt > 30)
                labelves.Text = "Ожирение вес";
        }

       

        // Обработчик нажатия на картинку женщины
        private void pictureBoxWoman_Click(object sender, EventArgs e)
        {
            pictureBoxWoman.BorderStyle = BorderStyle.Fixed3D;
            if (pictureBoxWoman.BorderStyle == BorderStyle.Fixed3D)
                pictureBoxMan.BorderStyle = BorderStyle.None;
            pictureBoxMan2.Visible = false;
            pictureBoxWoman2.Visible = true;
        }

        // Обработчик нажатия на картинку мужчины
        private void pictureBoxMan_Click(object sender, EventArgs e)
        {
            pictureBoxMan.BorderStyle = BorderStyle.Fixed3D;
            if (pictureBoxMan.BorderStyle == BorderStyle.Fixed3D)
                pictureBoxWoman.BorderStyle = BorderStyle.None;
            pictureBoxWoman2.Visible = false;
            pictureBoxMan2.Visible = true;
        }

        // Обработчик нажатия на кнопку "Отмена"
        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            // Очищаем текстовые поля и метки
            textBoxHeight.Clear();
            textBoxWeight.Clear();
            label1BMI.Text = " ";
            labelves.Text = " ";

            pictureBoxWoman2.Visible = false;
            pictureBoxMan2.Visible = false;
        }

        private void height_Click(object sender, EventArgs e)
        {

        }

        private void trackBarBMI_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBoxWoman2_Click(object sender, EventArgs e)
        {
            pictureBoxWoman2.Visible = false;
        }

        private void pictureBoxMan2_Click(object sender, EventArgs e)
        {
            pictureBoxMan2.Visible = false;
        }
    }
}
