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
    public partial class FormRunnerMenu : Form
    {
        public FormRunnerMenu()
        {
            InitializeComponent();
        }

        private void FormRunnerMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);
            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setButtonDesign(buttonLogOut);

            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setButtonDesign(buttonRegistrOnMaraphon);
            RoundAndDesign.setButtonDesign(buttonMaraphonResults);
            RoundAndDesign.setButtonDesign(buttonProfileEdit);
            RoundAndDesign.setButtonDesign(buttonMySponsors);
            RoundAndDesign.setButtonDesign(buttonMyContacts);



            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White;
        }

        private void buttonBack_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonBack, e);
        }

        private void buttonLogOut_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonLogOut, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMyContacts_Click(object sender, EventArgs e)
        {
            FormMyContacts fmc = new FormMyContacts();
            fmc.Owner = this;
            fmc.PointToClient(new Point(0, 0));
            fmc.ShowDialog();
        }

        private void buttonRegistrOnMaraphon_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonRegistrOnMaraphon, e);
        }

        private void buttonMaraphonResults_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonMaraphonResults, e);
        }

        private void buttonProfileEdit_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonProfileEdit, e);
        }

        private void buttonMySponsors_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonMySponsors, e);
        }

        private void buttonMyContacts_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonMyContacts, e);
        }

        private void timerRunnerMenu_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonRegistrOnMaraphon_Click(object sender, EventArgs e)
        {
            RegistrOnMaraphon rom = new RegistrOnMaraphon();
            rom.Owner = this;
            rom.Show();
        }

        private void buttonProfileEdit_Click(object sender, EventArgs e)
        {
            FormEditProfile fep = new FormEditProfile();
            fep.Owner = this;
            fep.ShowDialog();
        }

        private void buttonMySponsors_Click(object sender, EventArgs e)
        {
            FormMySponsors fms = new FormMySponsors();
            fms.Owner = this;
            fms.ShowDialog();
        }
    }
}
