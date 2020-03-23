namespace Biking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.textboxDirectory = new System.Windows.Forms.TextBox();
            this.directory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCboBox = new System.Windows.Forms.Label();
            this.openFileLabel = new System.Windows.Forms.Label();
            this.accessImportButton = new System.Windows.Forms.Button();
            this.clearDbButton = new System.Windows.Forms.Button();
            this.accessDbShow = new System.Windows.Forms.Button();
            this.AddRunnerButton = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.CreaGaraBtn = new System.Windows.Forms.Button();
            this.AddProvaButton = new System.Windows.Forms.Button();
            this.CreaProvaTEAMBUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CategoriaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CategoriaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriaLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.ForeColor = System.Drawing.Color.White;
            this.CategoriaLabel.Location = new System.Drawing.Point(0, 0);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(938, 39);
            this.CategoriaLabel.TabIndex = 0;
            this.CategoriaLabel.Text = "Categorie";
            this.CategoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxDirectory
            // 
            this.textboxDirectory.Location = new System.Drawing.Point(144, 65);
            this.textboxDirectory.Name = "textboxDirectory";
            this.textboxDirectory.Size = new System.Drawing.Size(257, 22);
            this.textboxDirectory.TabIndex = 8;
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(407, 65);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(34, 21);
            this.directory.TabIndex = 9;
            this.directory.Text = "...";
            this.directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directory.UseVisualStyleBackColor = true;
            this.directory.Click += new System.EventHandler(this.Directory_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(938, 465);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // labelCboBox
            // 
            this.labelCboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCboBox.Location = new System.Drawing.Point(176, 106);
            this.labelCboBox.Name = "labelCboBox";
            this.labelCboBox.Size = new System.Drawing.Size(79, 44);
            this.labelCboBox.TabIndex = 13;
            this.labelCboBox.Text = "Filtra Categorie:";
            this.labelCboBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileLabel
            // 
            this.openFileLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openFileLabel.Location = new System.Drawing.Point(42, 63);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(76, 23);
            this.openFileLabel.TabIndex = 14;
            this.openFileLabel.Text = "Open file:";
            this.openFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessImportButton
            // 
            this.accessImportButton.BackColor = System.Drawing.Color.Orange;
            this.accessImportButton.Location = new System.Drawing.Point(45, 103);
            this.accessImportButton.Name = "accessImportButton";
            this.accessImportButton.Size = new System.Drawing.Size(105, 51);
            this.accessImportButton.TabIndex = 20;
            this.accessImportButton.Text = "EXPORT to DataBase";
            this.accessImportButton.UseVisualStyleBackColor = false;
            this.accessImportButton.Click += new System.EventHandler(this.AccessExportButton_Click);
            // 
            // clearDbButton
            // 
            this.clearDbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearDbButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDbButton.Location = new System.Drawing.Point(630, 65);
            this.clearDbButton.Name = "clearDbButton";
            this.clearDbButton.Size = new System.Drawing.Size(104, 61);
            this.clearDbButton.TabIndex = 21;
            this.clearDbButton.Text = "DESTROY DB";
            this.clearDbButton.UseVisualStyleBackColor = false;
            this.clearDbButton.Click += new System.EventHandler(this.ClearDbButton_Click);
            // 
            // accessDbShow
            // 
            this.accessDbShow.BackColor = System.Drawing.Color.PowderBlue;
            this.accessDbShow.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessDbShow.Location = new System.Drawing.Point(520, 65);
            this.accessDbShow.Name = "accessDbShow";
            this.accessDbShow.Size = new System.Drawing.Size(104, 61);
            this.accessDbShow.TabIndex = 22;
            this.accessDbShow.Text = "Mostra Db Access";
            this.accessDbShow.UseVisualStyleBackColor = false;
            this.accessDbShow.Click += new System.EventHandler(this.AccessDbShow_Click);
            // 
            // AddRunnerButton
            // 
            this.AddRunnerButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddRunnerButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRunnerButton.Location = new System.Drawing.Point(520, 139);
            this.AddRunnerButton.Name = "AddRunnerButton";
            this.AddRunnerButton.Size = new System.Drawing.Size(104, 61);
            this.AddRunnerButton.TabIndex = 28;
            this.AddRunnerButton.Text = "Aggiungi Ciclista";
            this.AddRunnerButton.UseVisualStyleBackColor = false;
            this.AddRunnerButton.Click += new System.EventHandler(this.AddRunnerButton_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(272, 117);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(169, 24);
            this.comboBoxFilter.TabIndex = 29;
            this.comboBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxFilter_SelectionChangeCommitted);
            // 
            // CreaGaraBtn
            // 
            this.CreaGaraBtn.BackColor = System.Drawing.Color.SlateGray;
            this.CreaGaraBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreaGaraBtn.Location = new System.Drawing.Point(630, 139);
            this.CreaGaraBtn.Name = "CreaGaraBtn";
            this.CreaGaraBtn.Size = new System.Drawing.Size(104, 61);
            this.CreaGaraBtn.TabIndex = 30;
            this.CreaGaraBtn.Text = "CREA LISTA GARA";
            this.CreaGaraBtn.UseVisualStyleBackColor = false;
            this.CreaGaraBtn.Click += new System.EventHandler(this.CreaGaraBtn_Click);
            // 
            // AddProvaButton
            // 
            this.AddProvaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddProvaButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProvaButton.Location = new System.Drawing.Point(520, 212);
            this.AddProvaButton.Name = "AddProvaButton";
            this.AddProvaButton.Size = new System.Drawing.Size(104, 61);
            this.AddProvaButton.TabIndex = 31;
            this.AddProvaButton.Text = "CREA PROVA SINGOLA";
            this.AddProvaButton.UseVisualStyleBackColor = false;
            this.AddProvaButton.Click += new System.EventHandler(this.CreaProvaButton_Click);
            // 
            // CreaProvaTEAMBUTTON
            // 
            this.CreaProvaTEAMBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CreaProvaTEAMBUTTON.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreaProvaTEAMBUTTON.Location = new System.Drawing.Point(630, 212);
            this.CreaProvaTEAMBUTTON.Name = "CreaProvaTEAMBUTTON";
            this.CreaProvaTEAMBUTTON.Size = new System.Drawing.Size(104, 61);
            this.CreaProvaTEAMBUTTON.TabIndex = 32;
            this.CreaProvaTEAMBUTTON.Text = "CREA PROVA SQUADRE";
            this.CreaProvaTEAMBUTTON.UseVisualStyleBackColor = false;
            this.CreaProvaTEAMBUTTON.Click += new System.EventHandler(this.CreaProvaTeamBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::Biking.Properties.Resources.cyclist;
            this.ClientSize = new System.Drawing.Size(938, 744);
            this.Controls.Add(this.CreaProvaTEAMBUTTON);
            this.Controls.Add(this.AddProvaButton);
            this.Controls.Add(this.CreaGaraBtn);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.AddRunnerButton);
            this.Controls.Add(this.accessDbShow);
            this.Controls.Add(this.clearDbButton);
            this.Controls.Add(this.accessImportButton);
            this.Controls.Add(this.openFileLabel);
            this.Controls.Add(this.labelCboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.textboxDirectory);
            this.Controls.Add(this.CategoriaLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.TextBox textboxDirectory;
        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCboBox;
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.Button accessImportButton;
        private System.Windows.Forms.Button clearDbButton;
        private System.Windows.Forms.Button accessDbShow;
        private System.Windows.Forms.Button AddRunnerButton;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button CreaGaraBtn;
        private System.Windows.Forms.Button AddProvaButton;
        private System.Windows.Forms.Button CreaProvaTEAMBUTTON;
    }
}

