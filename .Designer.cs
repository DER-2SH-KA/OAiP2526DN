namespace _25_26
{
    partial class FormMarathonSkills_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelW21O2024 = new System.Windows.Forms.Label();
            this.labelMR = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonIWantToBeRunner = new System.Windows.Forms.Button();
            this.buttonWantToKnowMoreAboutEvent = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.buttonWantToBeSponsor = new System.Windows.Forms.Button();
            this.timerMainMenu = new System.Windows.Forms.Timer(this.components);
            this.panelWelcome.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWelcome.Controls.Add(this.labelW21O2024);
            this.panelWelcome.Controls.Add(this.labelMR);
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(-2, -3);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(683, 178);
            this.panelWelcome.TabIndex = 0;
            // 
            // labelW21O2024
            // 
            this.labelW21O2024.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelW21O2024.Location = new System.Drawing.Point(213, 113);
            this.labelW21O2024.Name = "labelW21O2024";
            this.labelW21O2024.Size = new System.Drawing.Size(249, 30);
            this.labelW21O2024.TabIndex = 2;
            this.labelW21O2024.Text = "среда 21 октября 2024";
            this.labelW21O2024.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMR
            // 
            this.labelMR.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelMR.Location = new System.Drawing.Point(212, 83);
            this.labelMR.Name = "labelMR";
            this.labelMR.Size = new System.Drawing.Size(249, 30);
            this.labelMR.TabIndex = 1;
            this.labelMR.Text = "Москва, Россия";
            this.labelMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(139, 30);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(445, 39);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "MARATHON SKILLS 2024";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIWantToBeRunner
            // 
            this.buttonIWantToBeRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIWantToBeRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonIWantToBeRunner.Location = new System.Drawing.Point(185, 205);
            this.buttonIWantToBeRunner.Name = "buttonIWantToBeRunner";
            this.buttonIWantToBeRunner.Size = new System.Drawing.Size(300, 61);
            this.buttonIWantToBeRunner.TabIndex = 1;
            this.buttonIWantToBeRunner.Text = "Я хочу стать бегуом";
            this.buttonIWantToBeRunner.UseVisualStyleBackColor = true;
            this.buttonIWantToBeRunner.Click += new System.EventHandler(this.buttonIWantToBeRunner_Click);
            this.buttonIWantToBeRunner.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonIWantToBeRunner_Paint);
            // 
            // buttonWantToKnowMoreAboutEvent
            // 
            this.buttonWantToKnowMoreAboutEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWantToKnowMoreAboutEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonWantToKnowMoreAboutEvent.Location = new System.Drawing.Point(185, 339);
            this.buttonWantToKnowMoreAboutEvent.Name = "buttonWantToKnowMoreAboutEvent";
            this.buttonWantToKnowMoreAboutEvent.Size = new System.Drawing.Size(300, 61);
            this.buttonWantToKnowMoreAboutEvent.TabIndex = 3;
            this.buttonWantToKnowMoreAboutEvent.Text = "Я хочу узнать больше о событии";
            this.buttonWantToKnowMoreAboutEvent.UseVisualStyleBackColor = true;
            this.buttonWantToKnowMoreAboutEvent.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonWantToKnowMoreAboutEvent_Paint);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(548, 433);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 39);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogin_Paint);
            // 
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDateTime.Controls.Add(this.labelDateTime);
            this.panelDateTime.Location = new System.Drawing.Point(-2, 478);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(683, 45);
            this.panelDateTime.TabIndex = 3;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(0, 6);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(666, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonWantToBeSponsor
            // 
            this.buttonWantToBeSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWantToBeSponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonWantToBeSponsor.Location = new System.Drawing.Point(185, 272);
            this.buttonWantToBeSponsor.Name = "buttonWantToBeSponsor";
            this.buttonWantToBeSponsor.Size = new System.Drawing.Size(300, 61);
            this.buttonWantToBeSponsor.TabIndex = 2;
            this.buttonWantToBeSponsor.Text = "Я хочу стать спонсором бегуна";
            this.buttonWantToBeSponsor.UseVisualStyleBackColor = true;
            this.buttonWantToBeSponsor.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonWantToBeSponsor_Paint);
            // 
            // timerMainMenu
            // 
            this.timerMainMenu.Enabled = true;
            this.timerMainMenu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMarathonSkills_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 523);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonWantToKnowMoreAboutEvent);
            this.Controls.Add(this.buttonWantToBeSponsor);
            this.Controls.Add(this.buttonIWantToBeRunner);
            this.Controls.Add(this.panelWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMarathonSkills_Main";
            this.Text = "Marathon Skills 2016";
            this.Load += new System.EventHandler(this.FormMarathonSkills_Main_Load);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelW21O2024;
        private System.Windows.Forms.Label labelMR;
        private System.Windows.Forms.Button buttonIWantToBeRunner;
        private System.Windows.Forms.Button buttonWantToKnowMoreAboutEvent;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonWantToBeSponsor;
        private System.Windows.Forms.Timer timerMainMenu;
    }
}

