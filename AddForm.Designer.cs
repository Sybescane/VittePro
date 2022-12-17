namespace VittePro1
{
    partial class AddForm
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
            this.panelFields = new System.Windows.Forms.Panel();
            this.panelButtonAdd = new System.Windows.Forms.Panel();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.panelAgeAndDiv = new System.Windows.Forms.Panel();
            this.comboBoxDivision = new System.Windows.Forms.ComboBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.panelNameAndSurname = new System.Windows.Forms.Panel();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelText = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelFields.SuspendLayout();
            this.panelButtonAdd.SuspendLayout();
            this.panelAgeAndDiv.SuspendLayout();
            this.panelNameAndSurname.SuspendLayout();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMain.Controls.Add(this.panelFields);
            this.panelMain.Controls.Add(this.panelText);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(549, 272);
            this.panelMain.TabIndex = 0;
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelFields.Controls.Add(this.panelButtonAdd);
            this.panelFields.Controls.Add(this.panelAgeAndDiv);
            this.panelFields.Controls.Add(this.panelNameAndSurname);
            this.panelFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFields.Location = new System.Drawing.Point(0, 69);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(549, 203);
            this.panelFields.TabIndex = 1;
            // 
            // panelButtonAdd
            // 
            this.panelButtonAdd.Controls.Add(this.buttonAddEmployee);
            this.panelButtonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonAdd.Location = new System.Drawing.Point(406, 0);
            this.panelButtonAdd.Name = "panelButtonAdd";
            this.panelButtonAdd.Size = new System.Drawing.Size(143, 203);
            this.panelButtonAdd.TabIndex = 3;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEmployee.Location = new System.Drawing.Point(28, 75);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(100, 30);
            this.buttonAddEmployee.TabIndex = 2;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // panelAgeAndDiv
            // 
            this.panelAgeAndDiv.Controls.Add(this.comboBoxDivision);
            this.panelAgeAndDiv.Controls.Add(this.textBoxAge);
            this.panelAgeAndDiv.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAgeAndDiv.Location = new System.Drawing.Point(204, 0);
            this.panelAgeAndDiv.Name = "panelAgeAndDiv";
            this.panelAgeAndDiv.Size = new System.Drawing.Size(224, 203);
            this.panelAgeAndDiv.TabIndex = 1;
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
            this.comboBoxDivision.Location = new System.Drawing.Point(20, 118);
            this.comboBoxDivision.Name = "comboBoxDivision";
            this.comboBoxDivision.Size = new System.Drawing.Size(170, 25);
            this.comboBoxDivision.TabIndex = 3;
            this.comboBoxDivision.Enter += new System.EventHandler(this.comboBoxDivision_Enter);
            this.comboBoxDivision.Leave += new System.EventHandler(this.comboBoxDivision_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAge.Location = new System.Drawing.Point(20, 35);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(170, 25);
            this.textBoxAge.TabIndex = 1;
            this.textBoxAge.Enter += new System.EventHandler(this.textBoxAge_Enter);
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // panelNameAndSurname
            // 
            this.panelNameAndSurname.Controls.Add(this.textBoxSurname);
            this.panelNameAndSurname.Controls.Add(this.textBoxName);
            this.panelNameAndSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNameAndSurname.Location = new System.Drawing.Point(0, 0);
            this.panelNameAndSurname.Name = "panelNameAndSurname";
            this.panelNameAndSurname.Size = new System.Drawing.Size(204, 203);
            this.panelNameAndSurname.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(22, 118);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(158, 25);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(22, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 25);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.labelTitle);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(549, 69);
            this.panelText.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(549, 69);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Введите данные";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 272);
            this.Controls.Add(this.panelMain);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.panelMain.ResumeLayout(false);
            this.panelFields.ResumeLayout(false);
            this.panelButtonAdd.ResumeLayout(false);
            this.panelAgeAndDiv.ResumeLayout(false);
            this.panelAgeAndDiv.PerformLayout();
            this.panelNameAndSurname.ResumeLayout(false);
            this.panelNameAndSurname.PerformLayout();
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMain;
        private Panel panelText;
        private Label labelTitle;
        private Panel panelFields;
        private Panel panelAgeAndDiv;
        private Panel panelNameAndSurname;
        private Panel panelButtonAdd;
        private Button buttonAddEmployee;
        private TextBox textBoxAge;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private ComboBox comboBoxDivision;
    }
}