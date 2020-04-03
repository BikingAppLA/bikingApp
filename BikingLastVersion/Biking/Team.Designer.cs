namespace Biking
{
    partial class Team
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
            this.NomeTeamLabel = new System.Windows.Forms.Label();
            this.NomeTeamTextBox = new System.Windows.Forms.TextBox();
            this.ReturnButon = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddAthleteBTN = new System.Windows.Forms.Button();
            this.RemoveAthleteBooleanBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeTeamLabel
            // 
            this.NomeTeamLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NomeTeamLabel.ForeColor = System.Drawing.Color.Black;
            this.NomeTeamLabel.Location = new System.Drawing.Point(35, 52);
            this.NomeTeamLabel.Name = "NomeTeamLabel";
            this.NomeTeamLabel.Size = new System.Drawing.Size(91, 20);
            this.NomeTeamLabel.TabIndex = 214;
            this.NomeTeamLabel.Text = "Nome Team:";
            this.NomeTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeTeamTextBox
            // 
            this.NomeTeamTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NomeTeamTextBox.Location = new System.Drawing.Point(174, 52);
            this.NomeTeamTextBox.Name = "NomeTeamTextBox";
            this.NomeTeamTextBox.Size = new System.Drawing.Size(131, 20);
            this.NomeTeamTextBox.TabIndex = 222;
            // 
            // ReturnButon
            // 
            this.ReturnButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReturnButon.ForeColor = System.Drawing.Color.Black;
            this.ReturnButon.Location = new System.Drawing.Point(612, 93);
            this.ReturnButon.Name = "ReturnButon";
            this.ReturnButon.Size = new System.Drawing.Size(153, 53);
            this.ReturnButon.TabIndex = 223;
            this.ReturnButon.Text = "CANCELLA";
            this.ReturnButon.UseVisualStyleBackColor = false;
            this.ReturnButon.Click += new System.EventHandler(this.ReturnButon_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SaveButton.Location = new System.Drawing.Point(418, 93);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(169, 53);
            this.SaveButton.TabIndex = 240;
            this.SaveButton.Text = "Salva Team";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoriaLabel.ForeColor = System.Drawing.Color.Black;
            this.CategoriaLabel.Location = new System.Drawing.Point(323, 51);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(91, 20);
            this.CategoriaLabel.TabIndex = 241;
            this.CategoriaLabel.Text = "Categoria";
            this.CategoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(433, 51);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(103, 21);
            this.CategoriaComboBox.TabIndex = 242;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 313);
            this.dataGridView1.TabIndex = 243;
            // 
            // AddAthleteBTN
            // 
            this.AddAthleteBTN.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddAthleteBTN.Location = new System.Drawing.Point(31, 104);
            this.AddAthleteBTN.Name = "AddAthleteBTN";
            this.AddAthleteBTN.Size = new System.Drawing.Size(169, 53);
            this.AddAthleteBTN.TabIndex = 244;
            this.AddAthleteBTN.Text = "Aggiungi Atleta";
            this.AddAthleteBTN.UseVisualStyleBackColor = false;
            this.AddAthleteBTN.Click += new System.EventHandler(this.AddAthleteBTN_Click);
            // 
            // RemoveAthleteBooleanBTN
            // 
            this.RemoveAthleteBooleanBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveAthleteBooleanBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveAthleteBooleanBTN.Location = new System.Drawing.Point(31, 482);
            this.RemoveAthleteBooleanBTN.Name = "RemoveAthleteBooleanBTN";
            this.RemoveAthleteBooleanBTN.Size = new System.Drawing.Size(103, 62);
            this.RemoveAthleteBooleanBTN.TabIndex = 245;
            this.RemoveAthleteBooleanBTN.Text = "Rimuovi Atleta Spuntato";
            this.RemoveAthleteBooleanBTN.UseVisualStyleBackColor = false;
            this.RemoveAthleteBooleanBTN.Click += new System.EventHandler(this.RemoveAthleteBooleanBTN_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 621);
            this.Controls.Add(this.RemoveAthleteBooleanBTN);
            this.Controls.Add(this.AddAthleteBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReturnButon);
            this.Controls.Add(this.NomeTeamTextBox);
            this.Controls.Add(this.NomeTeamLabel);
            this.Name = "Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeTeamLabel;
        private System.Windows.Forms.TextBox NomeTeamTextBox;
        private System.Windows.Forms.Button ReturnButon;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Button AddAthleteBTN;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RemoveAthleteBooleanBTN;
    }
}