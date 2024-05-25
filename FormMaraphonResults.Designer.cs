namespace _25_26
{
    partial class FormMaraphonResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelfaut1 = new System.Windows.Forms.Label();
            this.labelfaut2 = new System.Windows.Forms.Label();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAgeCategory = new System.Windows.Forms.Label();
            this.labelVK = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.ColumnMarathon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShowResult = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBack.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBack.Controls.Add(this.buttonLogOut);
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Controls.Add(this.labelWelcome);
            this.panelBack.Location = new System.Drawing.Point(1, 3);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(940, 82);
            this.panelBack.TabIndex = 3;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.Location = new System.Drawing.Point(799, 17);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(127, 42);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            this.buttonLogOut.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogOut_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(16, 17);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(137, 42);
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
            this.labelWelcome.Location = new System.Drawing.Point(248, 29);
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
            this.panelDateTime.Location = new System.Drawing.Point(1, 657);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(940, 45);
            this.panelDateTime.TabIndex = 39;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.labelDateTime.Location = new System.Drawing.Point(0, 4);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(937, 30);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "ДатеВремя";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfaut1
            // 
            this.labelfaut1.AutoSize = true;
            this.labelfaut1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfaut1.Location = new System.Drawing.Point(375, 110);
            this.labelfaut1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfaut1.Name = "labelfaut1";
            this.labelfaut1.Size = new System.Drawing.Size(188, 27);
            this.labelfaut1.TabIndex = 40;
            this.labelfaut1.Text = "Мои результаты";
            // 
            // labelfaut2
            // 
            this.labelfaut2.AutoSize = true;
            this.labelfaut2.Font = new System.Drawing.Font("Arial", 14F);
            this.labelfaut2.Location = new System.Drawing.Point(141, 152);
            this.labelfaut2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfaut2.Name = "labelfaut2";
            this.labelfaut2.Size = new System.Drawing.Size(678, 66);
            this.labelfaut2.TabIndex = 41;
            this.labelfaut2.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills.\r\nОбщее мес" +
    "то сравнивает всех бегунов.\r\nМесто по категории compares runners in the same gen" +
    "der and age categories.\r\n";
            this.labelfaut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPol.Location = new System.Drawing.Point(188, 272);
            this.labelPol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(55, 22);
            this.labelPol.TabIndex = 42;
            this.labelPol.Text = "Пол:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 14F);
            this.labelGender.Location = new System.Drawing.Point(265, 272);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 22);
            this.labelGender.TabIndex = 43;
            // 
            // labelAgeCategory
            // 
            this.labelAgeCategory.AutoSize = true;
            this.labelAgeCategory.Font = new System.Drawing.Font("Arial", 14F);
            this.labelAgeCategory.Location = new System.Drawing.Point(658, 273);
            this.labelAgeCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgeCategory.Name = "labelAgeCategory";
            this.labelAgeCategory.Size = new System.Drawing.Size(0, 22);
            this.labelAgeCategory.TabIndex = 45;
            // 
            // labelVK
            // 
            this.labelVK.AutoSize = true;
            this.labelVK.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVK.Location = new System.Drawing.Point(388, 272);
            this.labelVK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVK.Name = "labelVK";
            this.labelVK.Size = new System.Drawing.Size(229, 22);
            this.labelVK.TabIndex = 44;
            this.labelVK.Text = "Возрастная категория:";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToOrderColumns = true;
            this.dataGridViewResults.AllowUserToResizeColumns = false;
            this.dataGridViewResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResults.ColumnHeadersHeight = 45;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarathon,
            this.ColumnDistance,
            this.ColumnTime,
            this.ColumnOM,
            this.ColumnMK});
            this.dataGridViewResults.Cursor = System.Windows.Forms.Cursors.AppStarting;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResults.EnableHeadersVisualStyles = false;
            this.dataGridViewResults.GridColor = System.Drawing.Color.White;
            this.dataGridViewResults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewResults.Location = new System.Drawing.Point(73, 304);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.RowHeadersWidth = 25;
            this.dataGridViewResults.RowTemplate.Height = 28;
            this.dataGridViewResults.Size = new System.Drawing.Size(809, 276);
            this.dataGridViewResults.TabIndex = 46;
            // 
            // ColumnMarathon
            // 
            this.ColumnMarathon.Frozen = true;
            this.ColumnMarathon.HeaderText = "Марафон";
            this.ColumnMarathon.MinimumWidth = 16;
            this.ColumnMarathon.Name = "ColumnMarathon";
            this.ColumnMarathon.Width = 101;
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.Frozen = true;
            this.ColumnDistance.HeaderText = "Дистанция";
            this.ColumnDistance.MinimumWidth = 16;
            this.ColumnDistance.Name = "ColumnDistance";
            this.ColumnDistance.Width = 108;
            // 
            // ColumnTime
            // 
            this.ColumnTime.Frozen = true;
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.MinimumWidth = 16;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Width = 80;
            // 
            // ColumnOM
            // 
            this.ColumnOM.Frozen = true;
            this.ColumnOM.HeaderText = "Общее место";
            this.ColumnOM.MinimumWidth = 16;
            this.ColumnOM.Name = "ColumnOM";
            this.ColumnOM.Width = 118;
            // 
            // ColumnMK
            // 
            this.ColumnMK.Frozen = true;
            this.ColumnMK.HeaderText = "Место по категории";
            this.ColumnMK.MinimumWidth = 16;
            this.ColumnMK.Name = "ColumnMK";
            this.ColumnMK.Width = 158;
            // 
            // buttonShowResult
            // 
            this.buttonShowResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowResult.Location = new System.Drawing.Point(318, 595);
            this.buttonShowResult.Name = "buttonShowResult";
            this.buttonShowResult.Size = new System.Drawing.Size(313, 42);
            this.buttonShowResult.TabIndex = 5;
            this.buttonShowResult.Text = "Показать все результаты";
            this.buttonShowResult.UseVisualStyleBackColor = true;
            this.buttonShowResult.Click += new System.EventHandler(this.buttonShowResult_Click);
            this.buttonShowResult.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonShowResult_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMaraphonResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 690);
            this.Controls.Add(this.buttonShowResult);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.labelAgeCategory);
            this.Controls.Add(this.labelVK);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelfaut2);
            this.Controls.Add(this.labelfaut1);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.panelBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMaraphonResults";
            this.Text = "FormMaraphonResults";
            this.Load += new System.EventHandler(this.FormMaraphonResults_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelfaut1;
        private System.Windows.Forms.Label labelfaut2;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAgeCategory;
        private System.Windows.Forms.Label labelVK;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonShowResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarathon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMK;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}