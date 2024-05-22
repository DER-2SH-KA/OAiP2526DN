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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            RoundAndDesign.setPanelDesign(panelBack);
            RoundAndDesign.setLabelDesign(labelWelcome, Color.White);
            RoundAndDesign.setButtonDesign(buttonBack);

            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelfaut2, ColorsAndFonts.DarkGrayOur);

            RoundAndDesign.setLabelDesign(labelEmail, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelPassword, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setTextBoxDesign(textBoxEmail);
            RoundAndDesign.setTextBoxDesign(textBoxPassword);

            RoundAndDesign.setButtonDesign(buttonLogin);
            RoundAndDesign.setButtonDesign(buttonCancel);

            RoundAndDesign.setPanelDesign(panelDateTime);
            labelDateTime.ForeColor = Color.White; // НЕ ИСПОЛЬЗОВАТЬ У ТАЙМЕРА RoundAndDesign!
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = Timer.getTimeSpaceBeforeMaraphon();
            labelDateTime.Text = $"{span.Days} дней {span.Hours} часов {span.Minutes} минут {span.Seconds} секунд до старта марафона!";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonBack_Click(sender, e);
        }

        private void buttonBack_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonBack, e);
        }

        private void buttonLogin_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonLogin, e);
        }

        private void buttonCancel_Paint(object sender, PaintEventArgs e)
        {
            RoundAndDesign.setButtonRound(buttonCancel, e);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //string path = System.IO.Directory.GetCurrentDirectory();
            //MessageBox.Show($"{path}");
            List<User> userListForLogin = UsersDBInfo.ReadUsersDBFile();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            bool signin = false;

            if (email != "" && password != "" && 
                email != "Enter your email address0" && 
                password != "Enter your password") 
            {
                foreach (User user in userListForLogin) 
                {
                    if (user.Email == email)
                    {
                        if (user.Password == password) 
                        {
                            signin = true;
                            WhoLogined.Email = user.Email;
                            break;
                        }
                    }
                }

                if (signin)
                {
                    MessageBox.Show(
                        "Вход выполнен успешно!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    FormRunnerMenu frm = new FormRunnerMenu();
                    frm.Owner = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Электронная почта или пароль не верны, или аккаунта не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Незаполнены электронная почта или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
;        }
    }
}
