using System;
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
    public partial class RegistrOnMaraphon : Form
    {
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
            RoundAndDesign.setLabelDesign(labelVznos, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setButtonDesign(buttonSignUp);
            RoundAndDesign.setButtonDesign(buttonCancel);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White;
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
    }
}
