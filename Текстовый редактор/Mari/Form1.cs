using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Mari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void ButtomOpen_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
                {
                    richTextBox1.Clear(); //Очищаем richTextBox
                    openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                    string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                    richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
                }
        }

        private void buttomSave_Click(object sender, EventArgs e)
        {
            
                saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
                saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
                {
                    var name = saveFileDialog1.FileName; //Задаем имя файлу
                    File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
    }
                richTextBox1.Clear();
                }

        private void buttomCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Copy())
            {
                richTextBox1.Paste();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void buttonshrift_Click(object sender, EventArgs e)
        { 
                FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonColour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox1.Clear();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Copy())
            {
                richTextBox1.Paste();
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           AboutBox1 Form = new AboutBox1();
            Form.Show();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVurezat_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void vudelit_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Copy())
            {
                richTextBox1.Paste();
            }
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void копироватьToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вырезатьToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void вставитьToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Copy())
            {
                richTextBox1.Paste();
            }
        }
        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void прдварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectAll(); //выделение всего текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll(); //Отмена выделения
         

        }

        private void contextMenuStrip1_Opening_2(object sender, CancelEventArgs e)
        {
            richTextBox1.ContextMenuStrip = contextMenuStrip1;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ContextMenuStrip = contextMenuStrip1;

        }
    }
}
