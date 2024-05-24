using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class FormMySponsors : Form
    {
        public FormMySponsors()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMySponsors_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);
            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setButtonDesign(buttonLogOut);

            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelfaut2, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setLabelDesign(labelSponsorVznos, ColorsAndFonts.GrayOur);
            panelBar.BackColor = ColorsAndFonts.GrayOur;
            RoundAndDesign.setLabelDesign(labelVznosAll, ColorsAndFonts.GrayOur);

            FillPanelSponsorsVznos();
            FillPanelSponsorsInfo();

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White;
        }

        private void FillPanelSponsorsVznos() 
        {
            List<Registration> list = RegistrationDB.ReadRegistrationsDBFile();

            int standartX = 15;
            int standartY = 10;
            int summ = 0;
            foreach (Registration rgstr in list) 
            {
                if (WhoLogined.loginedUser.Email == rgstr.Email) 
                {
                    Label lbl = new Label();

                    panelSponsorVznos.Controls.Add(lbl);

                    lbl.Location = new Point(standartX, standartY);
                    lbl.Text = $"{rgstr.Fond} / {rgstr.VznosForFond}";
                    lbl.Font = new Font("Arial", 12.0f, FontStyle.Bold);
                    lbl.AutoSize = true;
                    RoundAndDesign.setLabelDesign(lbl, ColorsAndFonts.DarkGrayOur);

                    standartY += lbl.Height + 10;
                    summ += Convert.ToInt32(rgstr.VznosForFond);
                }
            }
            labelVznosAll.Text = $"Всего ${summ}";

        }

        private void FillPanelSponsorsInfo()
        {
            List<Sponsor> list = SponsorsDB.ReadSponsorsDBFile();
            List<Registration> list2 = RegistrationDB.ReadRegistrationsDBFile();
            // MessageBox.Show($"{list.Count}");

            int standartX = 0;
            int standartY = 0;
            foreach (Sponsor spnsr in list)
            {
                foreach (Registration reg in list2)
                {
                    if (reg.Fond == spnsr.Name && WhoLogined.loginedUser.Email == reg.Email)
                    {
                        Label lbl = new Label();
                        lbl.AutoSize = false;
                        lbl.Width = panelSponsorInfo.Width;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;

                        panelSponsorInfo.Controls.Add(lbl);

                        lbl.Location = new Point(standartX, standartY);
                        lbl.Text = spnsr.Name;
                        lbl.Font = new Font("Arial", 16.0f, FontStyle.Bold);
                        RoundAndDesign.setLabelDesign(lbl, ColorsAndFonts.GrayOur);

                        standartY += 10 + lbl.Height;

                        PictureBox pictureBox = new PictureBox();
                        panelSponsorInfo.Controls.Add(pictureBox);
                        pictureBox.Width = 150;
                        pictureBox.Height = 150;
                        pictureBox.Location = new Point((panelSponsorInfo.Width / 2) - (pictureBox.Width / 2), standartY);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = new Bitmap(spnsr.PathToPhoto);
                        RoundAndDesign.setRoundPictureBox(pictureBox);

                        standartY += pictureBox.Width + 10;

                        RichTextBox richTextBox = new RichTextBox();
                        panelSponsorInfo.Controls.Add(richTextBox);
                        richTextBox.Width = panelSponsorInfo.Width;
                        richTextBox.BackColor = Color.White;
                        richTextBox.BorderStyle = BorderStyle.None;
                        richTextBox.Location = new Point(0, standartY);
                        richTextBox.Font = new Font("Arial", 14.0f);
                        richTextBox.AppendText(spnsr.Description);
                    }
                }
            }

        }

        private void timerMySponsors_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }
    }
}
