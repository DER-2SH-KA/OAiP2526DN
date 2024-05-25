using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class FormMaraphonResults : Form
    {
        public FormMaraphonResults()
        {
            InitializeComponent();
        }

        private void FormMaraphonResults_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);

            RoundAndDesign.setLabelDesign(labelfaut1, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelfaut2, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelPol, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelVK, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelGender, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelAgeCategory, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White;

            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setButtonDesign(buttonLogOut);
            RoundAndDesign.setButtonDesign(buttonShowResult);

            RoundAndDesign.setDataGridDesign1(dataGridViewResults);
            

            string[] result = new string[8];
            using (StreamReader sr = new StreamReader(UsersResult.Path_To_Users_Result_File, Encoding.UTF8))
            {
                string tempString = "";
                string[] temp = new string[8];
                string[] timeString = new string[3];
                string time;

                for (int i = 0; i < File.ReadAllLines(UsersResult.Path_To_Users_Result_File).Length; i++)
                {
                    tempString = sr.ReadLine();
                    if (tempString != null && tempString.Contains(WhoLogined.loginedUser.Email))
                    {
                        temp = tempString.Split(new char[] { '|' });
                        
                        if(WhoLogined.loginedUser.Email == temp[0])
                        {
                            if (temp[1].Trim() == "m") labelGender.Text = "мужской";
                            else labelGender.Text = "женский";
                            labelAgeCategory.Text = temp[2].Trim();
                            timeString = temp[5].Split(new char[] { '.' });
                            time = $"{timeString[0]}h {timeString[1]}m {timeString[2]}s";
                            temp[5] = time;
                            dataGridViewResults.Rows.Add(temp[3], temp[4], temp[5], temp[6], temp[7]);
                        }
                        
                    }
                }
            }
        }

        private void buttonLogOut_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonLogOut, e);
        }

        private void buttonBack_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonBack, e);
        }

        private void buttonShowResult_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonShowResult, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            FormAllResults ar = new FormAllResults();
            ar.Owner = this;
            ar.Show();
        }
    }
}
