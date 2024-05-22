using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _25_26
{
    public class RoundAndDesign
    {
        public static void setButtonRound(Button btn, PaintEventArgs e) 
        {
            GraphicsPath grPath = new GraphicsPath();
            Pen currPen = new Pen(ColorsAndFonts.DarkGrayOur);
            currPen.Width = 2;

            e.Graphics.DrawEllipse(currPen, -(btn.Width * 1.05f - btn.Width) / 2, -btn.Height / 2, btn.Width * 1.05f, btn.Height * 2f);

            grPath.AddEllipse(-((btn.Width * 1.05f - btn.Width) / 2) - 1, -(btn.Height / 2) - 1, (btn.Width * 1.05f) + 2, (btn.Height * 2f) + 2);

            Region Button_Region = new Region(grPath);
            btn.Region = Button_Region;
        }

        public static void setButtonDesign(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = ColorsAndFonts.DarkGrayOur;
            btn.FlatAppearance.BorderSize = 2;
            btn.BackColor = ColorsAndFonts.LightGrayOur;
        }

        public static void setLabelDesign(Label lbl, Color foreColor) 
        {
            lbl.ForeColor = foreColor;
        }

        public static void setPanelDesign(Panel pnl)
        {
            pnl.BackColor = ColorsAndFonts.DarkGrayOur;
        }

        public static void setTextBoxDesign(TextBox textbox)
        {
            textbox.BackColor = Color.White;
            textbox.ForeColor = ColorsAndFonts.DarkGrayOur;
            textbox.Font = ColorsAndFonts.ItalicFont12;
        }

        public static void setComboBoxDesign(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = ColorsAndFonts.DarkGrayOur;
            comboBox.Font = ColorsAndFonts.ItalicFont12;
        }

        public static void setDateTimePickerDesign(DateTimePicker dtp)
        {
            dtp.CalendarMonthBackground = Color.White;
            dtp.CalendarTitleBackColor = Color.White;
            dtp.CalendarForeColor = ColorsAndFonts.DarkGrayOur;
            dtp.CalendarTitleForeColor = ColorsAndFonts.DarkGrayOur;
            dtp.CalendarTrailingForeColor = ColorsAndFonts.DarkGrayOur;
            dtp.Font = ColorsAndFonts.Font9;
            dtp.CalendarFont = ColorsAndFonts.Font9;
        }

        public static void setCheckBoxDesign(CheckBox chbx, Color clr) 
        {
            chbx.ForeColor = clr;
            chbx.BackColor = Color.White;
        }

        public static void setRadioButtonDesign(RadioButton rbtn, Color clr) 
        {
            rbtn.ForeColor = clr;
            rbtn.BackColor = Color.White;
        }
    }
}
