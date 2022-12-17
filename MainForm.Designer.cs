namespace VittePro1
{
    partial class MainForm
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFindDateAndGroup = new System.Windows.Forms.Button();
            this.buttonFindDate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelButton.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelButton.Controls.Add(this.buttonUpdate);
            this.panelButton.Controls.Add(this.buttonDelete);
            this.panelButton.Controls.Add(this.buttonFindDateAndGroup);
            this.panelButton.Controls.Add(this.buttonFindDate);
            this.panelButton.Controls.Add(this.buttonAdd);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(800, 100);
            this.panelButton.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUpdate.Location = new System.Drawing.Point(640, 0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 100);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Изменить данные о сотруднике";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelete.Location = new System.Drawing.Point(480, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 100);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Уволить сотрудника";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFindDateAndGroup
            // 
            this.buttonFindDateAndGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFindDateAndGroup.Location = new System.Drawing.Point(320, 0);
            this.buttonFindDateAndGroup.Name = "buttonFindDateAndGroup";
            this.buttonFindDateAndGroup.Size = new System.Drawing.Size(160, 100);
            this.buttonFindDateAndGroup.TabIndex = 2;
            this.buttonFindDateAndGroup.Text = "Список поздразделения";
            this.buttonFindDateAndGroup.UseVisualStyleBackColor = true;
            this.buttonFindDateAndGroup.Click += new System.EventHandler(this.buttonFindDateAndGroup_Click);
            // 
            // buttonFindDate
            // 
            this.buttonFindDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFindDate.Location = new System.Drawing.Point(160, 0);
            this.buttonFindDate.Name = "buttonFindDate";
            this.buttonFindDate.Size = new System.Drawing.Size(160, 100);
            this.buttonFindDate.TabIndex = 1;
            this.buttonFindDate.Text = "Общий список";
            this.buttonFindDate.UseVisualStyleBackColor = true;
            this.buttonFindDate.Click += new System.EventHandler(this.buttonFindDate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 100);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить сотрудника";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMain.Controls.Add(this.panelTable);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 453);
            this.panelMain.TabIndex = 4;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridView1);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTable.Location = new System.Drawing.Point(0, 100);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(800, 353);
            this.panelTable.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 353);
            this.dataGridView1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrom";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelButton.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelButton;
        private Button buttonFindDateAndGroup;
        private Button buttonFindDate;
        private Button buttonAdd;
        private Panel panelMain;
        private Panel panelTable;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridView1;
    }
}