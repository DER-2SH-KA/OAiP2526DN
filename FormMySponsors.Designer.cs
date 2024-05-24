namespace _25_26
{
    partial class FormMySponsors
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
            this.components = new System.ComponentModel.Container();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelfaut = new System.Windows.Forms.Label();
            this.labelfaut2 = new System.Windows.Forms.Label();
            this.labelSponsorVznos = new System.Windows.Forms.Label();
            this.panelSponsorVznos = new System.Windows.Forms.Panel();
            this.panelSponsorInfo = new System.Windows.Forms.Panel();
            this.timerMySponsors = new System.Windows.Forms.Timer(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.labelVznosAll = new System.Windows.Forms.Label();
            this.panelDateTime.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDateTime.Controls.Add(this.labelDateTime);
            this.panelDateTime.Location = new System.Drawing.Point(0, 519);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(842, 45);
            this.panelDateTime.TabIndex = 13;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(13, 3);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(817, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonLogOut);
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(842, 82);
            this.panelBack.TabIndex = 12;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogOut.Location = new System.Drawing.Point(703, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(127, 42);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(179, 16);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(445, 39);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "MARATHON SKILLS 2024";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut
            // 
            this.labelfaut.AutoSize = true;
            this.labelfaut.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut.Location = new System.Drawing.Point(319, 108);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(171, 27);
            this.labelfaut.TabIndex = 14;
            this.labelfaut.Text = "Мои спонсоры";
            this.labelfaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut2
            // 
            this.labelfaut2.AutoSize = true;
            this.labelfaut2.Font = new System.Drawing.Font("Arial", 16F);
            this.labelfaut2.Location = new System.Drawing.Point(110, 156);
            this.labelfaut2.Name = "labelfaut2";
            this.labelfaut2.Size = new System.Drawing.Size(614, 25);
            this.labelfaut2.TabIndex = 15;
            this.labelfaut2.Text = "Здесь показаны все ваши спонсоры в Marathon Skills 2016.";
            this.labelfaut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSponsorVznos
            // 
            this.labelSponsorVznos.AutoSize = true;
            this.labelSponsorVznos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSponsorVznos.Location = new System.Drawing.Point(541, 206);
            this.labelSponsorVznos.Name = "labelSponsorVznos";
            this.labelSponsorVznos.Size = new System.Drawing.Size(183, 24);
            this.labelSponsorVznos.TabIndex = 16;
            this.labelSponsorVznos.Text = "Спонсор / Взнос";
            this.labelSponsorVznos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSponsorVznos
            // 
            this.panelSponsorVznos.AutoScroll = true;
            this.panelSponsorVznos.Location = new System.Drawing.Point(451, 233);
            this.panelSponsorVznos.Name = "panelSponsorVznos";
            this.panelSponsorVznos.Size = new System.Drawing.Size(379, 212);
            this.panelSponsorVznos.TabIndex = 17;
            // 
            // panelSponsorInfo
            // 
            this.panelSponsorInfo.AutoScroll = true;
            this.panelSponsorInfo.Location = new System.Drawing.Point(17, 206);
            this.panelSponsorInfo.Name = "panelSponsorInfo";
            this.panelSponsorInfo.Size = new System.Drawing.Size(428, 307);
            this.panelSponsorInfo.TabIndex = 18;
            // 
            // timerMySponsors
            // 
            this.timerMySponsors.Enabled = true;
            this.timerMySponsors.Tick += new System.EventHandler(this.timerMySponsors_Tick);
            // 
            // panelBar
            // 
            this.panelBar.AutoScroll = true;
            this.panelBar.Location = new System.Drawing.Point(451, 451);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(379, 10);
            this.panelBar.TabIndex = 18;
            // 
            // labelVznosAll
            // 
            this.labelVznosAll.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelVznosAll.Location = new System.Drawing.Point(451, 464);
            this.labelVznosAll.Name = "labelVznosAll";
            this.labelVznosAll.Size = new System.Drawing.Size(379, 49);
            this.labelVznosAll.TabIndex = 19;
            this.labelVznosAll.Text = "Всего $0";
            this.labelVznosAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMySponsors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 563);
            this.Controls.Add(this.labelVznosAll);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelSponsorInfo);
            this.Controls.Add(this.panelSponsorVznos);
            this.Controls.Add(this.labelSponsorVznos);
            this.Controls.Add(this.labelfaut2);
            this.Controls.Add(this.labelfaut);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.panelBack);
            this.Name = "FormMySponsors";
            this.Text = "FormMySponsors";
            this.Load += new System.EventHandler(this.FormMySponsors_Load);
            this.panelDateTime.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.Label labelfaut2;
        private System.Windows.Forms.Label labelSponsorVznos;
        private System.Windows.Forms.Panel panelSponsorVznos;
        private System.Windows.Forms.Panel panelSponsorInfo;
        private System.Windows.Forms.Timer timerMySponsors;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label labelVznosAll;
    }
}