namespace _33.BMI_калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.trackBarBMI = new System.Windows.Forms.TrackBar();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonOtmena = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.pictureBoxWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxMan = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelves = new System.Windows.Forms.Label();
            this.label1BMI = new System.Windows.Forms.Label();
            this.pictureBoxWoman2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMan2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan2)).BeginInit();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(42, 326);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(78, 29);
            this.height.TabIndex = 0;
            this.height.Text = "Рост:";
            this.height.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.height.Click += new System.EventHandler(this.height_Click);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(42, 374);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(65, 29);
            this.weight.TabIndex = 1;
            this.weight.Text = "Вес:";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBMI.Location = new System.Drawing.Point(438, 326);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(64, 25);
            this.labelBMI.TabIndex = 7;
            this.labelBMI.Text = "ИМТ:";
            // 
            // trackBarBMI
            // 
            this.trackBarBMI.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBMI.LargeChange = 0;
            this.trackBarBMI.Location = new System.Drawing.Point(387, 398);
            this.trackBarBMI.Maximum = 50;
            this.trackBarBMI.Name = "trackBarBMI";
            this.trackBarBMI.Size = new System.Drawing.Size(442, 69);
            this.trackBarBMI.TabIndex = 11;
            this.trackBarBMI.TabStop = false;
            this.trackBarBMI.Value = 18;
            this.trackBarBMI.Scroll += new System.EventHandler(this.trackBarBMI_Scroll);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(13, 432);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(172, 36);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonOtmena
            // 
            this.buttonOtmena.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOtmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtmena.Location = new System.Drawing.Point(219, 432);
            this.buttonOtmena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOtmena.Name = "buttonOtmena";
            this.buttonOtmena.Size = new System.Drawing.Size(129, 36);
            this.buttonOtmena.TabIndex = 13;
            this.buttonOtmena.Text = "Отмена";
            this.buttonOtmena.UseVisualStyleBackColor = false;
            this.buttonOtmena.Click += new System.EventHandler(this.buttonOtmena_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(128, 325);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(148, 28);
            this.textBoxHeight.TabIndex = 14;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(128, 372);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(148, 28);
            this.textBoxWeight.TabIndex = 15;
            // 
            // pictureBoxWoman
            // 
            this.pictureBoxWoman.Image = global::_33.BMI_калькулятор.Properties.Resources._1200px_Toilet_women_svg;
            this.pictureBoxWoman.Location = new System.Drawing.Point(174, 52);
            this.pictureBoxWoman.Name = "pictureBoxWoman";
            this.pictureBoxWoman.Size = new System.Drawing.Size(128, 222);
            this.pictureBoxWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWoman.TabIndex = 5;
            this.pictureBoxWoman.TabStop = false;
            this.pictureBoxWoman.Click += new System.EventHandler(this.pictureBoxWoman_Click);
            // 
            // pictureBoxMan
            // 
            this.pictureBoxMan.Image = global::_33.BMI_калькулятор.Properties.Resources.man_toilet_icon;
            this.pictureBoxMan.Location = new System.Drawing.Point(39, 52);
            this.pictureBoxMan.Name = "pictureBoxMan";
            this.pictureBoxMan.Size = new System.Drawing.Size(96, 222);
            this.pictureBoxMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMan.TabIndex = 4;
            this.pictureBoxMan.TabStop = false;
            this.pictureBoxMan.Click += new System.EventHandler(this.pictureBoxMan_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(399, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(548, 440);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(598, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(640, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 22;
            // 
            // labelves
            // 
            this.labelves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelves.Location = new System.Drawing.Point(507, 269);
            this.labelves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelves.Name = "labelves";
            this.labelves.Size = new System.Drawing.Size(243, 37);
            this.labelves.TabIndex = 23;
            this.labelves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1BMI
            // 
            this.label1BMI.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1BMI.Location = new System.Drawing.Point(508, 322);
            this.label1BMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1BMI.Name = "label1BMI";
            this.label1BMI.Size = new System.Drawing.Size(214, 35);
            this.label1BMI.TabIndex = 24;
            this.label1BMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWoman2
            // 
            this.pictureBoxWoman2.Image = global::_33.BMI_калькулятор.Properties.Resources._1200px_Toilet_women_svg;
            this.pictureBoxWoman2.Location = new System.Drawing.Point(539, 22);
            this.pictureBoxWoman2.Name = "pictureBoxWoman2";
            this.pictureBoxWoman2.Size = new System.Drawing.Size(133, 211);
            this.pictureBoxWoman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWoman2.TabIndex = 25;
            this.pictureBoxWoman2.TabStop = false;
            // 
            // pictureBoxMan2
            // 
            this.pictureBoxMan2.Image = global::_33.BMI_калькулятор.Properties.Resources.man_toilet_icon;
            this.pictureBoxMan2.Location = new System.Drawing.Point(552, 22);
            this.pictureBoxMan2.Name = "pictureBoxMan2";
            this.pictureBoxMan2.Size = new System.Drawing.Size(109, 211);
            this.pictureBoxMan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMan2.TabIndex = 26;
            this.pictureBoxMan2.TabStop = false;
            this.pictureBoxMan2.Click += new System.EventHandler(this.pictureBoxMan2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(846, 525);
            this.Controls.Add(this.pictureBoxWoman2);
            this.Controls.Add(this.label1BMI);
            this.Controls.Add(this.labelves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonOtmena);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.trackBarBMI);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.pictureBoxWoman);
            this.Controls.Add(this.pictureBoxMan);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.pictureBoxMan2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.PictureBox pictureBoxMan;
        private System.Windows.Forms.PictureBox pictureBoxWoman;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.TrackBar trackBarBMI;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonOtmena;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelves;
        private System.Windows.Forms.Label label1BMI;
        private System.Windows.Forms.PictureBox pictureBoxWoman2;
        private System.Windows.Forms.PictureBox pictureBoxMan2;
    }
}

