namespace _25_26
{
    partial class FormRunnerAuthentification
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonIAmNew = new System.Windows.Forms.Button();
            this.buttonIAmOld = new System.Windows.Forms.Button();
            this.timerClockRunner = new System.Windows.Forms.Timer(this.components);
            this.panelBack.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(-4, -3);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(690, 78);
            this.panelBack.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBack.Location = new System.Drawing.Point(16, 15);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 44);
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
            this.labelWelcome.Location = new System.Drawing.Point(152, 20);
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
            this.panelDateTime.Location = new System.Drawing.Point(-4, 388);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(690, 45);
            this.panelDateTime.TabIndex = 5;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(3, 4);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(690, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(549, 343);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(116, 39);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogin_Paint);
            // 
            // buttonIAmNew
            // 
            this.buttonIAmNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonIAmNew.Location = new System.Drawing.Point(192, 232);
            this.buttonIAmNew.Name = "buttonIAmNew";
            this.buttonIAmNew.Size = new System.Drawing.Size(293, 61);
            this.buttonIAmNew.TabIndex = 8;
            this.buttonIAmNew.Text = "Я новый участник";
            this.buttonIAmNew.UseVisualStyleBackColor = true;
            this.buttonIAmNew.Click += new System.EventHandler(this.buttonWantToBeRunner_Click);
            this.buttonIAmNew.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonIAmNew_Paint);
            // 
            // buttonIAmOld
            // 
            this.buttonIAmOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonIAmOld.Location = new System.Drawing.Point(192, 151);
            this.buttonIAmOld.Name = "buttonIAmOld";
            this.buttonIAmOld.Size = new System.Drawing.Size(293, 61);
            this.buttonIAmOld.TabIndex = 7;
            this.buttonIAmOld.Text = "Я участвовал ранее";
            this.buttonIAmOld.UseVisualStyleBackColor = true;
            this.buttonIAmOld.Click += new System.EventHandler(this.buttonIWantToBeRunner_Click);
            this.buttonIAmOld.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonIAmOld_Paint);
            // 
            // timerClockRunner
            // 
            this.timerClockRunner.Enabled = true;
            this.timerClockRunner.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRunnerAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.buttonIAmNew);
            this.Controls.Add(this.buttonIAmOld);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelBack);
            this.Name = "FormRunnerAuthentification";
            this.Text = "Войти в бегуна";
            this.Load += new System.EventHandler(this.FormRunnerAuthentification_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonIAmNew;
        private System.Windows.Forms.Button buttonIAmOld;
        private System.Windows.Forms.Timer timerClockRunner;
    }
}