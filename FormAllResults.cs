using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _25_26
{
    public partial class FormAllResults : Form
    {
        public FormAllResults()
        {
            InitializeComponent();
        }

        private void FormAllResults_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);

            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelPol, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelCategory, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelMarathon, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelDistance, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelSum, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelFinish, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelTime, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelAverageTime, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelTotalFinish, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelSumRunners, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setComboBoxDesign(comboBoxCategory);
            RoundAndDesign.setComboBoxDesign(comboBoxDistance);
            RoundAndDesign.setComboBoxDesign(comboBoxMarathon);
            RoundAndDesign.setComboBoxDesign(comboBoxGender);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White;

            RoundAndDesign.setButtonDesign(buttonBack);
            RoundAndDesign.setButtonDesign(buttonLogOut);
            RoundAndDesign.setButtonDesign(buttonSearch);

            RoundAndDesign.setDataGridDesign2(dataGridViewResults);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Rows.Clear();
            // List<string> filesStrings = new List<string>();

            string[] Gender = new string[] { "", "m", "f" };
            string[] Category = new string[] { "18-29", "30-40" };
            string[] Marathon = new string[] { "2014 Japan", "2013 German", "2012 Vietnam", "2011 UK" };
            string[] Distance = new string[] { "42km", "21km", "5km" };
            using (StreamReader sr = new StreamReader(UsersResult.Path_To_Users_Result_File))
            {
                try
                {
                    string[] separator = { Environment.NewLine };
                    string[] strings = sr.ReadToEnd().Split(separator, StringSplitOptions.None);
                    string[] temp = new string[12];
                    string[] timeString = new string[4];
                    int countRunners = 0;
                    int countFinishedRunners = 0;
                    
                    int sumtime = 0;
                    foreach (string str in strings)
                    {
                        if (str != null && str != "")
                        {
                            temp = str.Split(new char[] { '|' });
                            timeString = temp[5].Split(new char[] { '.' });


                            string time = $"{timeString[0]}h {timeString[1]}m {timeString[2]}s";
                            temp[5] = time;
                            int i = 1;

                            if (temp[1].Contains(Gender[comboBoxGender.SelectedIndex]) &&
                                temp[2].Contains(Category[comboBoxCategory.SelectedIndex]) &&
                                temp[3].Contains(Marathon[comboBoxMarathon.SelectedIndex]) &&
                                temp[4].Contains(Distance[comboBoxDistance.SelectedIndex])
                            )
                            {
                                dataGridViewResults.Rows.Add(temp[6], temp[5], temp[8], temp[9]);
                                sumtime += Int32.Parse(timeString[0]) * 3600 + Int32.Parse(timeString[1]) * 60 + Int32.Parse(timeString[2]);
                                countRunners++;
                                if (temp[10] == "t") { countFinishedRunners++; }
                            }
                            else if (comboBoxGender.SelectedIndex == 0 &&
                            temp[2].Contains(Category[comboBoxCategory.SelectedIndex]) &&
                            temp[3].Contains(Marathon[comboBoxMarathon.SelectedIndex]) &&
                            temp[4].Contains(Distance[comboBoxDistance.SelectedIndex])
                            )
                            {
                                dataGridViewResults.Rows.Add(temp[6], temp[5], temp[8], temp[9]);
                                sumtime += Int32.Parse(timeString[0]) * 3600 + Int32.Parse(timeString[1]) * 60 + Int32.Parse(timeString[2]);
                                countRunners++;
                                if (temp[10] == "t") { countFinishedRunners++; }
                            }
                            i++;
                            if (countRunners != 0)
                            {
                                labelTime.Text = TimeSpan.FromSeconds(sumtime / countRunners).ToString(@"hh\:mm\:ss");
                                labelSum.Text = $"{countRunners}";
                                labelFinish.Text = $"{countFinishedRunners}";
                            }
                            else 
                            {
                                labelTime.Text = "00:00:00";
                                labelSum.Text = "0";
                                labelFinish.Text = "0";
                            }
                        }
                    }
                }

                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    // MessageBox.Show("Вы выбрали не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                finally { }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonBack_Click(object sender, EventArgs e)
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

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonSearch, e);
        }
    }
}
