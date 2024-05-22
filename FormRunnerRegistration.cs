﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class FormRunnerRegistration : Form
    {
        private string pathToPhotoPublic = "";

        public FormRunnerRegistration()
        {
            InitializeComponent();
        }

        private void timerRunnerRegistration_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonCancel_Click(sender, e);
        }

        private void FormRunnerRegistration_Load(object sender, EventArgs e)
        {
            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);

            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelfaut2, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setLabelDesign(labelEmail, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxEmail);
            RoundAndDesign.setLabelDesign(labelPassword, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxPassword);
            RoundAndDesign.setLabelDesign(labelPassword2, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxPassword2);
            RoundAndDesign.setLabelDesign(labelFirstName, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxFirstName);
            RoundAndDesign.setLabelDesign(labelSecondName, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxSecondName);
            RoundAndDesign.setLabelDesign(labelSex, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setComboBoxDesign(comboBoxSex);
            RoundAndDesign.setLabelDesign(labelImage, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxImage);
            RoundAndDesign.setLabelDesign(labelBithday, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setDateTimePickerDesign(dateTimePickerBithday);
            pictureBoxImage.BackColor = ColorsAndFonts.GrayOur;
            RoundAndDesign.setLabelDesign(labelCountry, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setComboBoxDesign(comboBoxCountry);

            comboBoxSex.SelectedIndex = 0;
            comboBoxCountry.SelectedIndex = 0;

            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setButtonDesign(buttonOpenImage);
            RoundAndDesign.setButtonDesign(buttonSignUp);
            RoundAndDesign.setButtonDesign(buttonCancel);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White; // НЕ ИСПОЛЬЗОВАТЬ У ТАЙМЕРА RoundAndDesign!

        }

        private void buttonBack_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonBack, e);
        }

        private void buttonOpenImage_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonOpenImage, e);
        }

        private void buttonSignUp_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonSignUp, e);
        }

        private void buttonCancel_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonCancel, e);
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog()) 
            {
                of.Multiselect = false;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    if (of.CheckFileExists && of.CheckFileExists)
                    {
                        // MessageBox.Show(of.FileName);
                        pictureBoxImage.Image = new Bitmap(of.FileName);
                        pathToPhotoPublic = of.FileName;
                        textBoxImage.Text = of.SafeFileName;
                    }
                    else
                    {
                        pictureBoxImage.BackColor = ColorsAndFonts.GrayOur;
                        pathToPhotoPublic = "";
                        textBoxImage.Text = "Photo_logo.jpg";
                    }
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string password2 = textBoxPassword2.Text.Trim();
            string firstName = textBoxFirstName.Text.Trim();
            string secondName = textBoxSecondName.Text.Trim();
            byte sex = Convert.ToByte(comboBoxSex.SelectedIndex);
            string pathToPhoto = textBoxImage.Text.Trim();
            DateTime dateTime = Convert.ToDateTime(dateTimePickerBithday.Value);
            string country = comboBoxCountry.Text.Trim();

            if (email != "" && email.Contains("@") && !email.Contains("|"))
            {
                if (password != "" && password == password2 && password != "Пароль" && !password.Contains("|"))
                {
                    if (firstName != "" && secondName != "" && firstName != "Имя" && secondName != "Фамилия" && 
                        !firstName.Contains("|") && !secondName.Contains("|"))
                    {
                        if (pathToPhoto != "" && pathToPhoto != "Photo_logo.jpg" && !pathToPhotoPublic.Contains("|"))
                        {
                            if (country != "" && comboBoxCountry.Items.Contains(country))
                            {
                                UsersDBInfo.AddUserToDBFile(
                                    new User(
                                        email, password, firstName, secondName,
                                        sex, pathToPhotoPublic, dateTime, country
                                    )
                                );
                                MessageBox.Show(
                                    "Новый аккаунт был зарегистрирован успешно!", "Уведомление", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information
                                );
                            }
                            else MessageBox.Show("Указана неизвестная страна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Путь к фото не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Имя или Фамилия незаполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Пароль либо не указан, либо не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Неверный формат электронной почты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
