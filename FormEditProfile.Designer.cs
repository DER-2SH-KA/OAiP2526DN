namespace _25_26
{
    partial class FormEditProfile
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.dateTimePickerBithday = new System.Windows.Forms.DateTimePicker();
            this.labelBithday = new System.Windows.Forms.Label();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelfaut2 = new System.Windows.Forms.Label();
            this.labelfaut = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelfaut3 = new System.Windows.Forms.Label();
            this.labelEmailValue = new System.Windows.Forms.Label();
            this.timerEditProfile = new System.Windows.Forms.Timer(this.components);
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(480, 506);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(138, 39);
            this.buttonCancel.TabIndex = 66;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCancel_Paint);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSave.Location = new System.Drawing.Point(317, 506);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 39);
            this.buttonSave.TabIndex = 65;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSignUp_Paint);
            // 
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDateTime.Controls.Add(this.labelDateTime);
            this.panelDateTime.Location = new System.Drawing.Point(0, 565);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(940, 45);
            this.panelDateTime.TabIndex = 64;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(0, 4);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(937, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Russia",
            "Russian Federation",
            "RF",
            "Imperian Russia",
            "USSR",
            "Rus\'"});
            this.comboBoxCountry.Location = new System.Drawing.Point(211, 350);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(163, 28);
            this.comboBoxCountry.TabIndex = 63;
            // 
            // labelCountry
            // 
            this.labelCountry.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelCountry.Location = new System.Drawing.Point(72, 346);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(122, 30);
            this.labelCountry.TabIndex = 62;
            this.labelCountry.Text = "Страна:";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerBithday
            // 
            this.dateTimePickerBithday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerBithday.Location = new System.Drawing.Point(211, 310);
            this.dateTimePickerBithday.Name = "dateTimePickerBithday";
            this.dateTimePickerBithday.Size = new System.Drawing.Size(164, 23);
            this.dateTimePickerBithday.TabIndex = 61;
            // 
            // labelBithday
            // 
            this.labelBithday.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelBithday.Location = new System.Drawing.Point(34, 306);
            this.labelBithday.Name = "labelBithday";
            this.labelBithday.Size = new System.Drawing.Size(171, 30);
            this.labelBithday.TabIndex = 60;
            this.labelBithday.Text = "Дата рождения:";
            this.labelBithday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOpenImage.Location = new System.Drawing.Point(771, 264);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(120, 30);
            this.buttonOpenImage.TabIndex = 59;
            this.buttonOpenImage.Text = "Просмотр";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            this.buttonOpenImage.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonOpenImage_Paint);
            // 
            // textBoxImage
            // 
            this.textBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxImage.Location = new System.Drawing.Point(554, 264);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(201, 26);
            this.textBoxImage.TabIndex = 58;
            this.textBoxImage.Tag = "";
            this.textBoxImage.Text = "Photo_logo.jpg";
            // 
            // labelImage
            // 
            this.labelImage.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelImage.Location = new System.Drawing.Point(550, 231);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(124, 30);
            this.labelImage.TabIndex = 57;
            this.labelImage.Text = "Фото файл:";
            this.labelImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxImage.Location = new System.Drawing.Point(755, 112);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(136, 132);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 56;
            this.pictureBoxImage.TabStop = false;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другое"});
            this.comboBoxSex.Location = new System.Drawing.Point(210, 276);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(163, 28);
            this.comboBoxSex.TabIndex = 55;
            // 
            // labelSex
            // 
            this.labelSex.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelSex.Location = new System.Drawing.Point(71, 272);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(122, 30);
            this.labelSex.TabIndex = 54;
            this.labelSex.Text = "Пол:";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSecondName.Location = new System.Drawing.Point(210, 244);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(201, 26);
            this.textBoxSecondName.TabIndex = 53;
            this.textBoxSecondName.Tag = "";
            this.textBoxSecondName.Text = "Фамилия";
            // 
            // labelSecondName
            // 
            this.labelSecondName.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelSecondName.Location = new System.Drawing.Point(71, 242);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(122, 30);
            this.labelSecondName.TabIndex = 52;
            this.labelSecondName.Text = "Фамилия:";
            this.labelSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 212);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(201, 26);
            this.textBoxFirstName.TabIndex = 51;
            this.textBoxFirstName.Tag = "";
            this.textBoxFirstName.Text = "Имя";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelFirstName.Location = new System.Drawing.Point(71, 210);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(122, 30);
            this.labelFirstName.TabIndex = 50;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPassword2.Location = new System.Drawing.Point(690, 460);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(201, 26);
            this.textBoxPassword2.TabIndex = 49;
            this.textBoxPassword2.Tag = "";
            this.textBoxPassword2.Text = "Повторите пароль";
            // 
            // labelPassword2
            // 
            this.labelPassword2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelPassword2.Location = new System.Drawing.Point(479, 458);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(194, 30);
            this.labelPassword2.TabIndex = 48;
            this.labelPassword2.Text = "Повторите пароль:";
            this.labelPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPassword.Location = new System.Drawing.Point(690, 428);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(201, 26);
            this.textBoxPassword.TabIndex = 47;
            this.textBoxPassword.Tag = "";
            this.textBoxPassword.Text = "Пароль";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelPassword.Location = new System.Drawing.Point(551, 426);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(122, 30);
            this.labelPassword.TabIndex = 45;
            this.labelPassword.Text = "Пароль:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelEmail.Location = new System.Drawing.Point(115, 180);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(79, 30);
            this.labelEmail.TabIndex = 44;
            this.labelEmail.Text = "Emal:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelfaut2
            // 
            this.labelfaut2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfaut2.Location = new System.Drawing.Point(491, 357);
            this.labelfaut2.Name = "labelfaut2";
            this.labelfaut2.Size = new System.Drawing.Size(417, 62);
            this.labelfaut2.TabIndex = 43;
            this.labelfaut2.Text = "Оставьте эти поля незаполненными, если вы не хотите изменять пароль";
            this.labelfaut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut
            // 
            this.labelfaut.AutoSize = true;
            this.labelfaut.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut.Location = new System.Drawing.Point(136, 112);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(300, 27);
            this.labelfaut.TabIndex = 42;
            this.labelfaut.Text = "Редактирование профиля";
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonLogOut);
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(940, 82);
            this.panelBack.TabIndex = 41;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBack.Location = new System.Drawing.Point(16, 17);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(137, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonBack_Paint);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(248, 29);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(445, 39);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "MARATHON SKILLS 2024";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut3
            // 
            this.labelfaut3.AutoSize = true;
            this.labelfaut3.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut3.Location = new System.Drawing.Point(626, 325);
            this.labelfaut3.Name = "labelfaut3";
            this.labelfaut3.Size = new System.Drawing.Size(171, 27);
            this.labelfaut3.TabIndex = 67;
            this.labelfaut3.Text = "Смена пароля";
            // 
            // labelEmailValue
            // 
            this.labelEmailValue.AutoSize = true;
            this.labelEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmailValue.Location = new System.Drawing.Point(207, 186);
            this.labelEmailValue.Name = "labelEmailValue";
            this.labelEmailValue.Size = new System.Drawing.Size(149, 20);
            this.labelEmailValue.TabIndex = 68;
            this.labelEmailValue.Text = "someEmail@mail.ru";
            // 
            // timerEditProfile
            // 
            this.timerEditProfile.Enabled = true;
            this.timerEditProfile.Tick += new System.EventHandler(this.timerEditProfile_Tick);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogOut.Location = new System.Drawing.Point(764, 26);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(127, 42);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            this.buttonLogOut.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogOut_Paint);
            // 
            // FormEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 609);
            this.Controls.Add(this.labelEmailValue);
            this.Controls.Add(this.labelfaut3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelfaut2);
            this.Controls.Add(this.labelfaut);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.dateTimePickerBithday);
            this.Controls.Add(this.labelBithday);
            this.Controls.Add(this.buttonOpenImage);
            this.Controls.Add(this.textBoxImage);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panelBack);
            this.Name = "FormEditProfile";
            this.Text = "Редактирование профиля";
            this.Load += new System.EventHandler(this.FormEditProfile_Load);
            this.panelDateTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.DateTimePicker dateTimePickerBithday;
        private System.Windows.Forms.Label labelBithday;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelfaut2;
        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelfaut3;
        private System.Windows.Forms.Label labelEmailValue;
        private System.Windows.Forms.Timer timerEditProfile;
        private System.Windows.Forms.Button buttonLogOut;
    }
}