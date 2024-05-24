using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class RegistrOnMaraphon : Form
    {
        private static int payVznosByDistation = 0;
        private static int payVznosByEquipment = 0;

        public RegistrOnMaraphon()
        {
            InitializeComponent();
        }

        private void RegistrOnMaraphon_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);
            RoundAndDesign.setButtonDesign(buttonLogOut);

            RoundAndDesign.setLabelDesign(labelfaut1, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setLabelDesign(labelVidMaraph, ColorsAndFonts.GrayOur);
            RoundAndDesign.setCheckBoxDesign(checkBox42, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setCheckBoxDesign(checkBox21, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setCheckBoxDesign(checkBox5, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setLabelDesign(labelComplects, ColorsAndFonts.GrayOur);
            RoundAndDesign.setRadioButtonDesign(radioButtonA, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setRadioButtonDesign(radioButtonB, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setRadioButtonDesign(radioButtonC, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setLabelDesign(labelDetVznos, ColorsAndFonts.GrayOur);
            RoundAndDesign.setLabelDesign(labelVznos2, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelSummaVZnos, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setComboBoxDesign(comboBoxCHarityes);
            RoundAndDesign.setTextBoxDesign(textBoxVznos);

            RoundAndDesign.setLabelDesign(labelRegVznos, ColorsAndFonts.GrayOur);
            RoundAndDesign.setLabelDesign(labelVznos, ColorsAndFonts.GrayOur);

            RoundAndDesign.setButtonDesign(buttonSignUp);
            RoundAndDesign.setButtonDesign(buttonCancel);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White;

            List<Sponsor> list = SponsorsDB.ReadSponsorsDBFile();
            foreach (Sponsor sponsor in list)
            {
                comboBoxCHarityes.Items.Add(sponsor.Name);
            }

            if (list.Count != 0)
            {
                comboBoxCHarityes.SelectedIndex = 0;
            }
            else comboBoxCHarityes.Items.Add("--Нет спонсоров--");

            labelVznos.Text = "$0";
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonBack, e);
        }

        private void buttonLogOut_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonLogOut, e);
        }

        private void buttonSignUp_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonSignUp, e);
        }

        private void buttonCancel_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonCancel, e);
        }

        private void timerRegistOnMaraphon_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void reloadeLabelVznos()
        {
            labelVznos.Text = $"${payVznosByDistation + payVznosByEquipment}";
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked) payVznosByDistation += 145;
            else payVznosByDistation -= 145;
            reloadeLabelVznos();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked) payVznosByDistation += 75;
            else payVznosByDistation -= 75;
            reloadeLabelVznos();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) payVznosByDistation += 20;
            else payVznosByDistation -= 20;
            reloadeLabelVznos();
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked) 
            {
                payVznosByEquipment = 0;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
            }
            reloadeLabelVznos();
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                payVznosByEquipment = 20;
                radioButtonA.Checked = false;
                radioButtonC.Checked = false;
            }
            reloadeLabelVznos();
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
            {
                payVznosByEquipment = 45;
                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                reloadeLabelVznos();
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            double vznosForFond = 0.0;
            bool canRegistr = true;

            try 
            {
                vznosForFond = Convert.ToDouble(textBoxVznos.Text);

                if (vznosForFond < 0) 
                {
                    canRegistr = false;
                }
            }
            catch (FormatException) 
            {
                canRegistr = false;
            }

            if (
                (checkBox42.Checked || checkBox21.Checked || checkBox5.Checked) && 
                (radioButtonA.Checked || radioButtonB.Checked || radioButtonC.Checked) && 
                canRegistr
            ) 
            {
                byte radioVariant = 4;

                if (radioButtonA.Checked) radioVariant = 0;
                else if (radioButtonB.Checked) radioVariant = 1;
                else if (radioButtonC.Checked) radioVariant = 2;

                DateTime regTime = DateTime.Now;

                RegistrationDB.AddRegistrsToDBFile(
                    new Registration(
                        WhoLogined.loginedUser.Email, 
                        checkBox5.Checked, checkBox21.Checked, checkBox42.Checked,
                        radioVariant, 
                        vznosForFond, 
                        (payVznosByDistation + payVznosByEquipment), 
                        comboBoxCHarityes.Text.Trim(), 
                        new DateTime(regTime.Year, regTime.Month, regTime.Day)
                    )
                );
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
