namespace _25_26
{
    partial class FormRunnerMenu
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
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelfaut = new System.Windows.Forms.Label();
            this.buttonRegistrOnMaraphon = new System.Windows.Forms.Button();
            this.buttonMaraphonResults = new System.Windows.Forms.Button();
            this.buttonMySponsors = new System.Windows.Forms.Button();
            this.buttonProfileEdit = new System.Windows.Forms.Button();
            this.buttonMyContacts = new System.Windows.Forms.Button();
            this.timerRunnerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelBack.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonLogOut);
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(801, 82);
            this.panelBack.TabIndex = 10;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogOut.Location = new System.Drawing.Point(661, 16);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(127, 42);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            this.buttonLogOut.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogOut_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBack.Location = new System.Drawing.Point(17, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonBack_Paint);
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
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDateTime.Controls.Add(this.labelDateTime);
            this.panelDateTime.Location = new System.Drawing.Point(0, 406);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(801, 45);
            this.panelDateTime.TabIndex = 11;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(13, 3);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(775, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut
            // 
            this.labelfaut.AutoSize = true;
            this.labelfaut.Font = new System.Drawing.Font("Arial", 18F);
            this.labelfaut.Location = new System.Drawing.Point(313, 100);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(156, 27);
            this.labelfaut.TabIndex = 12;
            this.labelfaut.Text = "Меню бегуна";
            this.labelfaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegistrOnMaraphon
            // 
            this.buttonRegistrOnMaraphon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRegistrOnMaraphon.Location = new System.Drawing.Point(122, 142);
            this.buttonRegistrOnMaraphon.Name = "buttonRegistrOnMaraphon";
            this.buttonRegistrOnMaraphon.Size = new System.Drawing.Size(262, 63);
            this.buttonRegistrOnMaraphon.TabIndex = 13;
            this.buttonRegistrOnMaraphon.Text = "Регистрация на марафон";
            this.buttonRegistrOnMaraphon.UseVisualStyleBackColor = true;
            this.buttonRegistrOnMaraphon.Click += new System.EventHandler(this.buttonRegistrOnMaraphon_Click);
            this.buttonRegistrOnMaraphon.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonRegistrOnMaraphon_Paint);
            // 
            // buttonMaraphonResults
            // 
            this.buttonMaraphonResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMaraphonResults.Location = new System.Drawing.Point(390, 142);
            this.buttonMaraphonResults.Name = "buttonMaraphonResults";
            this.buttonMaraphonResults.Size = new System.Drawing.Size(262, 63);
            this.buttonMaraphonResults.TabIndex = 14;
            this.buttonMaraphonResults.Text = "Результаты марафонов";
            this.buttonMaraphonResults.UseVisualStyleBackColor = true;
            this.buttonMaraphonResults.Click += new System.EventHandler(this.buttonMaraphonResults_Click);
            this.buttonMaraphonResults.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonMaraphonResults_Paint);
            // 
            // buttonMySponsors
            // 
            this.buttonMySponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMySponsors.Location = new System.Drawing.Point(390, 211);
            this.buttonMySponsors.Name = "buttonMySponsors";
            this.buttonMySponsors.Size = new System.Drawing.Size(262, 63);
            this.buttonMySponsors.TabIndex = 16;
            this.buttonMySponsors.Text = "Мои спонсоры";
            this.buttonMySponsors.UseVisualStyleBackColor = true;
            this.buttonMySponsors.Click += new System.EventHandler(this.buttonMySponsors_Click);
            this.buttonMySponsors.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonMySponsors_Paint);
            // 
            // buttonProfileEdit
            // 
            this.buttonProfileEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonProfileEdit.Location = new System.Drawing.Point(122, 211);
            this.buttonProfileEdit.Name = "buttonProfileEdit";
            this.buttonProfileEdit.Size = new System.Drawing.Size(262, 63);
            this.buttonProfileEdit.TabIndex = 15;
            this.buttonProfileEdit.Text = "Редактирование профиля";
            this.buttonProfileEdit.UseVisualStyleBackColor = true;
            this.buttonProfileEdit.Click += new System.EventHandler(this.buttonProfileEdit_Click);
            this.buttonProfileEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonProfileEdit_Paint);
            // 
            // buttonMyContacts
            // 
            this.buttonMyContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMyContacts.Location = new System.Drawing.Point(122, 280);
            this.buttonMyContacts.Name = "buttonMyContacts";
            this.buttonMyContacts.Size = new System.Drawing.Size(262, 63);
            this.buttonMyContacts.TabIndex = 17;
            this.buttonMyContacts.Text = "Мои контакты";
            this.buttonMyContacts.UseVisualStyleBackColor = true;
            this.buttonMyContacts.Click += new System.EventHandler(this.buttonMyContacts_Click);
            this.buttonMyContacts.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonMyContacts_Paint);
            // 
            // timerRunnerMenu
            // 
            this.timerRunnerMenu.Enabled = true;
            this.timerRunnerMenu.Tick += new System.EventHandler(this.timerRunnerMenu_Tick);
            // 
            // FormRunnerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMyContacts);
            this.Controls.Add(this.buttonMySponsors);
            this.Controls.Add(this.buttonProfileEdit);
            this.Controls.Add(this.buttonMaraphonResults);
            this.Controls.Add(this.buttonRegistrOnMaraphon);
            this.Controls.Add(this.labelfaut);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.panelBack);
            this.Name = "FormRunnerMenu";
            this.Text = "Меню бегуна";
            this.Load += new System.EventHandler(this.FormRunnerMenu_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.Button buttonRegistrOnMaraphon;
        private System.Windows.Forms.Button buttonMaraphonResults;
        private System.Windows.Forms.Button buttonMySponsors;
        private System.Windows.Forms.Button buttonProfileEdit;
        private System.Windows.Forms.Button buttonMyContacts;
        private System.Windows.Forms.Timer timerRunnerMenu;
    }
}