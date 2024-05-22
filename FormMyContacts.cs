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
    public partial class FormMyContacts : Form
    {
        public FormMyContacts()
        {
            InitializeComponent();
        }

        private void FormMyContacts_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            buttonExit.ForeColor = Color.Red;
            buttonExit.BackColor = Color.White;

            RoundAndDesign.setLabelDesign(labelfaut, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelfaut2, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelPhone, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelPhoneValue, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelEmail, ColorsAndFonts.DarkGrayOur);
            RoundAndDesign.setLabelDesign(labelEmailValue, ColorsAndFonts.DarkGrayOur);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
