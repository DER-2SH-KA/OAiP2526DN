namespace _25_26
{
    partial class RegistrOnMaraphon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timerRegistOnMaraphon = new System.Windows.Forms.Timer(this.components);
            this.labelfaut = new System.Windows.Forms.Label();
            this.labelfaut1 = new System.Windows.Forms.Label();
            this.labelVidMaraph = new System.Windows.Forms.Label();
            this.checkBox42 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.labelComplects = new System.Windows.Forms.Label();
            this.comboBoxCHarityes = new System.Windows.Forms.ComboBox();
            this.labelSummaVZnos = new System.Windows.Forms.Label();
            this.labelVznos2 = new System.Windows.Forms.Label();
            this.labelDetVznos = new System.Windows.Forms.Label();
            this.labelVznos = new System.Windows.Forms.Label();
            this.labelRegVznos = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxVznos = new System.Windows.Forms.TextBox();
            this.panelBack.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonLogOut);
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(801, 82);
            this.panelBack.TabIndex = 11;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogOut.Location = new System.Drawing.Point(661, 16);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(127, 42);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            this.buttonLogOut.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogOut_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBack.Location = new System.Drawing.Point(17, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonBack_Paint);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(179, 16);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(445, 39);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "MARATHON SKILLS 2024";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDateTime.Controls.Add(this.labelDateTime);
            this.panelDateTime.Location = new System.Drawing.Point(0, 609);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(801, 45);
            this.panelDateTime.TabIndex = 12;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(13, 3);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(775, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRegistOnMaraphon
            // 
            this.timerRegistOnMaraphon.Enabled = true;
            this.timerRegistOnMaraphon.Tick += new System.EventHandler(this.timerRegistOnMaraphon_Tick);
            // 
            // labelfaut
            // 
            this.labelfaut.Font = new System.Drawing.Font("Arial", 16F);
            this.labelfaut.Location = new System.Drawing.Point(17, 127);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(771, 96);
            this.labelfaut.TabIndex = 13;
            this.labelfaut.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться на Skills Marathon " +
    "2016 проводимом в Москве. Russia. С вами свяжутся после.";
            this.labelfaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut1
            // 
            this.labelfaut1.AutoSize = true;
            this.labelfaut1.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut1.Location = new System.Drawing.Point(259, 100);
            this.labelfaut1.Name = "labelfaut1";
            this.labelfaut1.Size = new System.Drawing.Size(295, 27);
            this.labelfaut1.TabIndex = 14;
            this.labelfaut1.Text = "Регистрация на марафон";
            this.labelfaut1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVidMaraph
            // 
            this.labelVidMaraph.AutoSize = true;
            this.labelVidMaraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVidMaraph.Location = new System.Drawing.Point(91, 223);
            this.labelVidMaraph.Name = "labelVidMaraph";
            this.labelVidMaraph.Size = new System.Drawing.Size(201, 29);
            this.labelVidMaraph.TabIndex = 15;
            this.labelVidMaraph.Text = "Вид марафона ";
            // 
            // checkBox42
            // 
            this.checkBox42.AutoSize = true;
            this.checkBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox42.Location = new System.Drawing.Point(56, 268);
            this.checkBox42.Name = "checkBox42";
            this.checkBox42.Size = new System.Drawing.Size(252, 24);
            this.checkBox42.TabIndex = 16;
            this.checkBox42.Text = "42km Полный марафон($145)";
            this.checkBox42.UseVisualStyleBackColor = true;
            this.checkBox42.CheckedChanged += new System.EventHandler(this.checkBox42_CheckedChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox21.Location = new System.Drawing.Point(56, 306);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(221, 24);
            this.checkBox21.TabIndex = 26;
            this.checkBox21.Text = "21km Полумарафон ($75)";
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox5.Location = new System.Drawing.Point(56, 343);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(239, 24);
            this.checkBox5.TabIndex = 27;
            this.checkBox5.Text = "5km Малая дистанция ($20)";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonC.Location = new System.Drawing.Point(482, 369);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(284, 53);
            this.radioButtonC.TabIndex = 31;
            this.radioButtonC.Text = "Вариант C ($45): Вариант B + футболка + сувенирный буклет";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonB.Location = new System.Drawing.Point(482, 314);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(284, 49);
            this.radioButtonB.TabIndex = 30;
            this.radioButtonB.Text = "Вариант B ($20): вариант A + бейсболка + бутылка воды";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonA
            // 
            this.radioButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonA.Location = new System.Drawing.Point(482, 255);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(284, 53);
            this.radioButtonA.TabIndex = 29;
            this.radioButtonA.Text = "Вариант А ($0):  Номер бегуна \r\n+ RFID браслет";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // labelComplects
            // 
            this.labelComplects.AutoSize = true;
            this.labelComplects.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComplects.Location = new System.Drawing.Point(474, 223);
            this.labelComplects.Name = "labelComplects";
            this.labelComplects.Size = new System.Drawing.Size(292, 29);
            this.labelComplects.TabIndex = 28;
            this.labelComplects.Text = "Варианты комплектов";
            // 
            // comboBoxCHarityes
            // 
            this.comboBoxCHarityes.FormattingEnabled = true;
            this.comboBoxCHarityes.Items.AddRange(new object[] {
            "Фонд кошек"});
            this.comboBoxCHarityes.Location = new System.Drawing.Point(204, 483);
            this.comboBoxCHarityes.Name = "comboBoxCHarityes";
            this.comboBoxCHarityes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCHarityes.TabIndex = 36;
            // 
            // labelSummaVZnos
            // 
            this.labelSummaVZnos.AutoSize = true;
            this.labelSummaVZnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSummaVZnos.Location = new System.Drawing.Point(65, 524);
            this.labelSummaVZnos.Name = "labelSummaVZnos";
            this.labelSummaVZnos.Size = new System.Drawing.Size(141, 20);
            this.labelSummaVZnos.TabIndex = 34;
            this.labelSummaVZnos.Text = "Сумма взноса ($):";
            // 
            // labelVznos2
            // 
            this.labelVznos2.AutoSize = true;
            this.labelVznos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVznos2.Location = new System.Drawing.Point(65, 483);
            this.labelVznos2.Name = "labelVznos2";
            this.labelVznos2.Size = new System.Drawing.Size(58, 20);
            this.labelVznos2.TabIndex = 33;
            this.labelVznos2.Text = "Взнос:";
            // 
            // labelDetVznos
            // 
            this.labelDetVznos.AutoSize = true;
            this.labelDetVznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetVznos.Location = new System.Drawing.Point(91, 438);
            this.labelDetVznos.Name = "labelDetVznos";
            this.labelDetVznos.Size = new System.Drawing.Size(197, 29);
            this.labelDetVznos.TabIndex = 32;
            this.labelDetVznos.Text = "Детали взноса";
            // 
            // labelVznos
            // 
            this.labelVznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.labelVznos.Location = new System.Drawing.Point(469, 480);
            this.labelVznos.Name = "labelVznos";
            this.labelVznos.Size = new System.Drawing.Size(315, 64);
            this.labelVznos.TabIndex = 38;
            this.labelVznos.Text = "$999";
            this.labelVznos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegVznos
            // 
            this.labelRegVznos.AutoSize = true;
            this.labelRegVznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegVznos.Location = new System.Drawing.Point(464, 438);
            this.labelRegVznos.Name = "labelRegVznos";
            this.labelRegVznos.Size = new System.Drawing.Size(320, 29);
            this.labelRegVznos.TabIndex = 37;
            this.labelRegVznos.Text = "Регистрационный взнос";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(416, 561);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(138, 39);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCancel_Paint);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSignUp.Location = new System.Drawing.Point(253, 561);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(141, 39);
            this.buttonSignUp.TabIndex = 41;
            this.buttonSignUp.Text = "Регистрация";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            this.buttonSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSignUp_Paint);
            // 
            // textBoxVznos
            // 
            this.textBoxVznos.Location = new System.Drawing.Point(212, 526);
            this.textBoxVznos.Name = "textBoxVznos";
            this.textBoxVznos.Size = new System.Drawing.Size(113, 20);
            this.textBoxVznos.TabIndex = 43;
            // 
            // RegistrOnMaraphon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.textBoxVznos);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelVznos);
            this.Controls.Add(this.labelRegVznos);
            this.Controls.Add(this.comboBoxCHarityes);
            this.Controls.Add(this.labelSummaVZnos);
            this.Controls.Add(this.labelVznos2);
            this.Controls.Add(this.labelDetVznos);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.labelComplects);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox21);
            this.Controls.Add(this.checkBox42);
            this.Controls.Add(this.labelVidMaraph);
            this.Controls.Add(this.labelfaut1);
            this.Controls.Add(this.labelfaut);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.panelBack);
            this.Name = "RegistrOnMaraphon";
            this.Text = "RegistrOnMaraphon";
            this.Load += new System.EventHandler(this.RegistrOnMaraphon_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer timerRegistOnMaraphon;
        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.Label labelfaut1;
        private System.Windows.Forms.Label labelVidMaraph;
        private System.Windows.Forms.CheckBox checkBox42;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Label labelComplects;
        private System.Windows.Forms.ComboBox comboBoxCHarityes;
        private System.Windows.Forms.Label labelSummaVZnos;
        private System.Windows.Forms.Label labelVznos2;
        private System.Windows.Forms.Label labelDetVznos;
        private System.Windows.Forms.Label labelVznos;
        private System.Windows.Forms.Label labelRegVznos;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxVznos;
    }
}