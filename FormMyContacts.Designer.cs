namespace _25_26
{
    partial class FormMyContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelfaut = new System.Windows.Forms.Label();
            this.labelfaut2 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneValue = new System.Windows.Forms.Label();
            this.labelEmailValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(403, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelfaut
            // 
            this.labelfaut.AutoSize = true;
            this.labelfaut.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut.Location = new System.Drawing.Point(168, 52);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(115, 27);
            this.labelfaut.TabIndex = 13;
            this.labelfaut.Text = "Контакты";
            this.labelfaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut2
            // 
            this.labelfaut2.Font = new System.Drawing.Font("Arial", 14F);
            this.labelfaut2.Location = new System.Drawing.Point(12, 79);
            this.labelfaut2.Name = "labelfaut2";
            this.labelfaut2.Size = new System.Drawing.Size(415, 62);
            this.labelfaut2.TabIndex = 14;
            this.labelfaut2.Text = "Для дополнительной информации, пожалуйста, свяжитесь с координаторами ";
            this.labelfaut2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(12, 141);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(111, 24);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Телефон:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(12, 166);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 24);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhoneValue
            // 
            this.labelPhoneValue.AutoSize = true;
            this.labelPhoneValue.Font = new System.Drawing.Font("Arial", 14F);
            this.labelPhoneValue.Location = new System.Drawing.Point(128, 142);
            this.labelPhoneValue.Name = "labelPhoneValue";
            this.labelPhoneValue.Size = new System.Drawing.Size(167, 22);
            this.labelPhoneValue.TabIndex = 17;
            this.labelPhoneValue.Text = "+55 11 9988 7766";
            this.labelPhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmailValue
            // 
            this.labelEmailValue.AutoSize = true;
            this.labelEmailValue.Font = new System.Drawing.Font("Arial", 14F);
            this.labelEmailValue.Location = new System.Drawing.Point(90, 169);
            this.labelEmailValue.Name = "labelEmailValue";
            this.labelEmailValue.Size = new System.Drawing.Size(295, 22);
            this.labelEmailValue.TabIndex = 18;
            this.labelEmailValue.Text = "coordinators@marathonkskills.org";
            this.labelEmailValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMyContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 300);
            this.Controls.Add(this.labelEmailValue);
            this.Controls.Add(this.labelPhoneValue);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelfaut2);
            this.Controls.Add(this.labelfaut);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMyContacts";
            this.Text = "FormMyContacts";
            this.Load += new System.EventHandler(this.FormMyContacts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.Label labelfaut2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneValue;
        private System.Windows.Forms.Label labelEmailValue;
    }
}