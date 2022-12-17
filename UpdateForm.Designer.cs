namespace VittePro1
{
    partial class UpdateForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelData2 = new System.Windows.Forms.Panel();
            this.labelDivision = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxDivision = new System.Windows.Forms.ComboBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.panelData1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelId = new System.Windows.Forms.Panel();
            this.buttonFindId = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelData2.SuspendLayout();
            this.panelData1.SuspendLayout();
            this.panelId.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.panelData);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(693, 348);
            this.panelMain.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelData.Controls.Add(this.panelUpdate);
            this.panelData.Controls.Add(this.panelData2);
            this.panelData.Controls.Add(this.panelData1);
            this.panelData.Controls.Add(this.panelId);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 69);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(693, 279);
            this.panelData.TabIndex = 2;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdate.Location = new System.Drawing.Point(0, 207);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(693, 69);
            this.panelUpdate.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Location = new System.Drawing.Point(295, 19);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelData2
            // 
            this.panelData2.Controls.Add(this.labelDivision);
            this.panelData2.Controls.Add(this.labelAge);
            this.panelData2.Controls.Add(this.comboBoxDivision);
            this.panelData2.Controls.Add(this.textBoxAge);
            this.panelData2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData2.Location = new System.Drawing.Point(0, 138);
            this.panelData2.Name = "panelData2";
            this.panelData2.Size = new System.Drawing.Size(693, 69);
            this.panelData2.TabIndex = 2;
            // 
            // labelDivision
            // 
            this.labelDivision.AutoSize = true;
            this.labelDivision.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDivision.Location = new System.Drawing.Point(315, 25);
            this.labelDivision.Name = "labelDivision";
            this.labelDivision.Size = new System.Drawing.Size(80, 25);
            this.labelDivision.TabIndex = 7;
            this.labelDivision.Text = "Division:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAge.Location = new System.Drawing.Point(52, 23);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(50, 25);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age:";
            // 
            // comboBoxDivision
            // 
            this.comboBoxDivision.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDivision.FormattingEnabled = true;
            this.comboBoxDivision.Items.AddRange(new object[] {
            "Company director",
            "Department director",
            "Team lead",
            "Senior",
            "Middle",
            "Junior"});
            this.comboBoxDivision.Location = new System.Drawing.Point(401, 25);
            this.comboBoxDivision.Name = "comboBoxDivision";
            this.comboBoxDivision.Size = new System.Drawing.Size(187, 25);
            this.comboBoxDivision.TabIndex = 4;
            this.comboBoxDivision.Enter += new System.EventHandler(this.comboBoxDivision_Enter);
            this.comboBoxDivision.Leave += new System.EventHandler(this.comboBoxDivision_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Location = new System.Drawing.Point(108, 23);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(187, 27);
            this.textBoxAge.TabIndex = 1;
            // 
            // panelData1
            // 
            this.panelData1.Controls.Add(this.labelName);
            this.panelData1.Controls.Add(this.labelSurname);
            this.panelData1.Controls.Add(this.textBoxSurname);
            this.panelData1.Controls.Add(this.textBoxName);
            this.panelData1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData1.Location = new System.Drawing.Point(0, 69);
            this.panelData1.Name = "panelData1";
            this.panelData1.Size = new System.Drawing.Size(693, 69);
            this.panelData1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(37, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(306, 22);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(89, 25);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Location = new System.Drawing.Point(401, 22);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(187, 27);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(108, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // panelId
            // 
            this.panelId.Controls.Add(this.buttonFindId);
            this.panelId.Controls.Add(this.labelId);
            this.panelId.Controls.Add(this.textBoxId);
            this.panelId.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelId.Location = new System.Drawing.Point(0, 0);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(693, 69);
            this.panelId.TabIndex = 0;
            // 
            // buttonFindId
            // 
            this.buttonFindId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFindId.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindId.Location = new System.Drawing.Point(401, 22);
            this.buttonFindId.Name = "buttonFindId";
            this.buttonFindId.Size = new System.Drawing.Size(100, 30);
            this.buttonFindId.TabIndex = 3;
            this.buttonFindId.Text = "Искать";
            this.buttonFindId.UseVisualStyleBackColor = false;
            this.buttonFindId.Click += new System.EventHandler(this.buttonFindId_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(68, 25);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(34, 25);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Location = new System.Drawing.Point(108, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(187, 27);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Enter += new System.EventHandler(this.textBoxId_Enter);
            this.textBoxId.Leave += new System.EventHandler(this.textBoxId_Leave);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(693, 69);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(693, 69);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Введите данные";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 348);
            this.Controls.Add(this.panelMain);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.panelMain.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelUpdate.ResumeLayout(false);
            this.panelData2.ResumeLayout(false);
            this.panelData2.PerformLayout();
            this.panelData1.ResumeLayout(false);
            this.panelData1.PerformLayout();
            this.panelId.ResumeLayout(false);
            this.panelId.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMain;
        private Panel panelTitle;
        private Panel panelData;
        private Label labelTitle;
        private Panel panelUpdate;
        private Panel panelData2;
        private TextBox textBoxAge;
        private Panel panelData1;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Panel panelId;
        private TextBox textBoxId;
        private Button buttonUpdate;
        private Button buttonFindId;
        private ComboBox comboBoxDivision;
        private Label labelDivision;
        private Label labelAge;
        private Label labelName;
        private Label labelSurname;
        private Label labelId;
    }
}