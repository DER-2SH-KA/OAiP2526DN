﻿namespace _25_26
{
    partial class FormRunnerRegistration
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.labelfaut2 = new System.Windows.Forms.Label();
            this.labelfaut = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.labelBithday = new System.Windows.Forms.Label();
            this.dateTimePickerBithday = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timerRunnerRegistration = new System.Windows.Forms.Timer(this.components);
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBack.Location = new System.Drawing.Point(24, 26);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(206, 65);
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
            this.labelWelcome.Location = new System.Drawing.Point(372, 45);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(665, 59);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "MARATHON SKILLS 2024";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(0, -5);
            this.panelBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1410, 126);
            this.panelBack.TabIndex = 2;
            // 
            // labelfaut2
            // 
            this.labelfaut2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfaut2.Location = new System.Drawing.Point(110, 168);
            this.labelfaut2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfaut2.Name = "labelfaut2";
            this.labelfaut2.Size = new System.Drawing.Size(1185, 95);
            this.labelfaut2.TabIndex = 13;
            this.labelfaut2.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве бегуна";
            this.labelfaut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut
            // 
            this.labelfaut.AutoSize = true;
            this.labelfaut.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut.Location = new System.Drawing.Point(530, 126);
            this.labelfaut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(346, 41);
            this.labelfaut.TabIndex = 12;
            this.labelfaut.Text = "Регистрация бегуна";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPassword.Location = new System.Drawing.Point(316, 357);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(300, 35);
            this.textBoxPassword.TabIndex = 21;
            this.textBoxPassword.Tag = "";
            this.textBoxPassword.Text = "Пароль";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxEmail.Location = new System.Drawing.Point(316, 308);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(370, 35);
            this.textBoxEmail.TabIndex = 20;
            this.textBoxEmail.Text = "Enter your email address";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelPassword.Location = new System.Drawing.Point(108, 354);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(183, 46);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Пароль:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelEmail.Location = new System.Drawing.Point(172, 308);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(118, 46);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Emal:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPassword2.Location = new System.Drawing.Point(316, 406);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(300, 35);
            this.textBoxPassword2.TabIndex = 23;
            this.textBoxPassword2.Tag = "";
            this.textBoxPassword2.Text = "Повторите пароль";
            // 
            // labelPassword2
            // 
            this.labelPassword2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelPassword2.Location = new System.Drawing.Point(0, 403);
            this.labelPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(291, 46);
            this.labelPassword2.TabIndex = 22;
            this.labelPassword2.Text = "Повторите пароль:";
            this.labelPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFirstName.Location = new System.Drawing.Point(316, 455);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(300, 35);
            this.textBoxFirstName.TabIndex = 25;
            this.textBoxFirstName.Tag = "";
            this.textBoxFirstName.Text = "Имя";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelFirstName.Location = new System.Drawing.Point(108, 452);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(183, 46);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSecondName.Location = new System.Drawing.Point(316, 505);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(300, 35);
            this.textBoxSecondName.TabIndex = 27;
            this.textBoxSecondName.Tag = "";
            this.textBoxSecondName.Text = "Фамилия";
            // 
            // labelSecondName
            // 
            this.labelSecondName.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelSecondName.Location = new System.Drawing.Point(108, 502);
            this.labelSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(183, 46);
            this.labelSecondName.TabIndex = 26;
            this.labelSecondName.Text = "Фамилия:";
            this.labelSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSex
            // 
            this.labelSex.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelSex.Location = new System.Drawing.Point(108, 548);
            this.labelSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(183, 46);
            this.labelSex.TabIndex = 28;
            this.labelSex.Text = "Пол:";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другое"});
            this.comboBoxSex.Location = new System.Drawing.Point(316, 554);
            this.comboBoxSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(242, 37);
            this.comboBoxSex.TabIndex = 29;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxImage.Location = new System.Drawing.Point(1090, 268);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(204, 203);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 30;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxImage
            // 
            this.textBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxImage.Location = new System.Drawing.Point(789, 502);
            this.textBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(300, 35);
            this.textBoxImage.TabIndex = 32;
            this.textBoxImage.Tag = "";
            this.textBoxImage.Text = "Photo_logo.jpg";
            // 
            // labelImage
            // 
            this.labelImage.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelImage.Location = new System.Drawing.Point(783, 451);
            this.labelImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(186, 46);
            this.labelImage.TabIndex = 31;
            this.labelImage.Text = "Фото файл:";
            this.labelImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOpenImage.Location = new System.Drawing.Point(1114, 502);
            this.buttonOpenImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(180, 46);
            this.buttonOpenImage.TabIndex = 33;
            this.buttonOpenImage.Text = "Просмотр";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            this.buttonOpenImage.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonOpenImage_Paint);
            // 
            // labelBithday
            // 
            this.labelBithday.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelBithday.Location = new System.Drawing.Point(783, 568);
            this.labelBithday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBithday.Name = "labelBithday";
            this.labelBithday.Size = new System.Drawing.Size(256, 46);
            this.labelBithday.TabIndex = 34;
            this.labelBithday.Text = "Дата рождения:";
            this.labelBithday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerBithday
            // 
            this.dateTimePickerBithday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerBithday.Location = new System.Drawing.Point(1048, 574);
            this.dateTimePickerBithday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerBithday.Name = "dateTimePickerBithday";
            this.dateTimePickerBithday.Size = new System.Drawing.Size(244, 30);
            this.dateTimePickerBithday.TabIndex = 35;
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
            this.comboBoxCountry.Location = new System.Drawing.Point(1048, 635);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(242, 37);
            this.comboBoxCountry.TabIndex = 37;
            // 
            // labelCountry
            // 
            this.labelCountry.Font = new System.Drawing.Font("Arial", 15.75F);
            this.labelCountry.Location = new System.Drawing.Point(840, 629);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(183, 46);
            this.labelCountry.TabIndex = 36;
            this.labelCountry.Text = "Страна:";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDateTime.Controls.Add(this.labelDateTime);
            this.panelDateTime.Location = new System.Drawing.Point(0, 797);
            this.panelDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(1410, 69);
            this.panelDateTime.TabIndex = 38;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(0, 6);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(1406, 46);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRunnerRegistration
            // 
            this.timerRunnerRegistration.Enabled = true;
            this.timerRunnerRegistration.Tick += new System.EventHandler(this.timerRunnerRegistration_Tick);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSignUp.Location = new System.Drawing.Point(476, 706);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(212, 60);
            this.buttonSignUp.TabIndex = 39;
            this.buttonSignUp.Text = "Регистрация";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            this.buttonSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSignUp_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(720, 706);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(207, 60);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCancel_Paint);
            // 
            // FormRunnerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 863);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSignUp);
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
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelfaut2);
            this.Controls.Add(this.labelfaut);
            this.Controls.Add(this.panelBack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRunnerRegistration";
            this.Text = "Регистрация бегуна";
            this.Load += new System.EventHandler(this.FormRunnerRegistration_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelDateTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label labelfaut2;
        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Label labelBithday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBithday;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer timerRunnerRegistration;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonCancel;
    }
}