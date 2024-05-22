using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class FormRunnerAuthentification : Form
    {
        public FormRunnerAuthentification()
        {
            InitializeComponent();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIWantToBeRunner_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Owner = this;
            fl.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonIWantToBeRunner_Click(sender, e);
        }

        private void FormRunnerAuthentification_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);

            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setButtonDesign(buttonIAmOld);
            RoundAndDesign.setButtonDesign(buttonIAmNew);
            RoundAndDesign.setButtonDesign(buttonLogin);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White; // НЕ ИСПОЛЬЗОВАТЬ У ТАЙМЕРА RoundAndDesign!
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonWantToBeRunner_Click(object sender, EventArgs e)
        {
            FormRunnerRegistration frr = new FormRunnerRegistration();
            frr.Owner = this;
            frr.Show();
        }

        private void buttonBack_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonBack, e);
        }

        private void buttonIAmOld_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonIAmOld, e);
        }

        private void buttonIAmNew_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonIAmNew, e);
        }

        private void buttonLogin_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonLogin, e);
        }
    }
}
