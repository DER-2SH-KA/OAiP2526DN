using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _25_26
{
    public partial class FormMarathonSkills_Main : Form
    {
        public FormMarathonSkills_Main()
        {
            InitializeComponent();
        }

        private void FormMarathonSkills_Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelWelcome);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);
            RoundAndDesign.setLabelDesign(labelMR, ColorsAndFonts.LightGrayOur);
            RoundAndDesign.setLabelDesign(labelW21O2024, ColorsAndFonts.LightGrayOur);

            RoundAndDesign.setButtonDesign(buttonIWantToBeRunner);
            RoundAndDesign.setButtonDesign(buttonWantToBeSponsor);
            RoundAndDesign.setButtonDesign(buttonWantToKnowMoreAboutEvent);
            RoundAndDesign.setButtonDesign(buttonLogin);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White; // НЕ ИСПОЛЬЗОВАТЬ У ТАЙМЕРА RoundAndDesign!

            if (!System.IO.File.Exists(UsersDBInfo.PATH_TO_USERS_DB)) 
            {
                UsersDBInfo.CreateUsersDBFile();
            }

            if (!System.IO.File.Exists(RegistrationDB.PATH_TO_REGISTRATION_DB))
            {
                RegistrationDB.CreateRegistrsDBFile();
            }

            if (!System.IO.File.Exists(SponsorsDB.PATH_TO_SPONSOR_DB))
            {
                SponsorsDB.CreateSponsorsDBFile();
            }
        }

        private void buttonIWantToBeRunner_Click(object sender, EventArgs e)
        {
            FormRunnerAuthentification fr = new FormRunnerAuthentification();
            fr.Owner = this;
            fr.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Owner = this;
            fl.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonIWantToBeRunner_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonIWantToBeRunner, e);
        }

        private void buttonLogin_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonLogin, e);
        }

        private void buttonWantToBeSponsor_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonWantToBeSponsor, e);
        }

        private void buttonWantToKnowMoreAboutEvent_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonWantToKnowMoreAboutEvent, e);
        }
    }
}
