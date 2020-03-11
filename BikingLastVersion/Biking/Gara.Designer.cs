namespace Biking
{
    partial class Gara
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCboBox = new System.Windows.Forms.Label();
            this.ReturnButon = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CategoriaComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddAllButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.ProvaLabel = new System.Windows.Forms.Label();
            this.garaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.GaraNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 443);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // labelCboBox
            // 
            this.labelCboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCboBox.Location = new System.Drawing.Point(0, 0);
            this.labelCboBox.Name = "labelCboBox";
            this.labelCboBox.Size = new System.Drawing.Size(1105, 44);
            this.labelCboBox.TabIndex = 21;
            this.labelCboBox.Text = "Creazione Liste di Gara";
            this.labelCboBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnButon
            // 
            this.ReturnButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReturnButon.Location = new System.Drawing.Point(808, 65);
            this.ReturnButon.Name = "ReturnButon";
            this.ReturnButon.Size = new System.Drawing.Size(97, 39);
            this.ReturnButon.TabIndex = 203;
            this.ReturnButon.Text = "CANCELLA";
            this.ReturnButon.UseVisualStyleBackColor = false;
            this.ReturnButon.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(575, 128);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(530, 443);
            this.dataGridView2.TabIndex = 204;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // CategoriaComboBoxFilter
            // 
            this.CategoriaComboBoxFilter.FormattingEnabled = true;
            this.CategoriaComboBoxFilter.Location = new System.Drawing.Point(105, 74);
            this.CategoriaComboBoxFilter.Name = "CategoriaComboBoxFilter";
            this.CategoriaComboBoxFilter.Size = new System.Drawing.Size(75, 21);
            this.CategoriaComboBoxFilter.TabIndex = 205;
            this.CategoriaComboBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxFilter_SelectionChangeCommitted_1);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 65);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(87, 30);
            this.CategoryLabel.TabIndex = 206;
            this.CategoryLabel.Text = "Scegli la Categoria:";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAllButton
            // 
            this.AddAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddAllButton.Location = new System.Drawing.Point(215, 577);
            this.AddAllButton.Name = "AddAllButton";
            this.AddAllButton.Size = new System.Drawing.Size(114, 40);
            this.AddAllButton.TabIndex = 207;
            this.AddAllButton.Text = "Aggiungi Tutti";
            this.AddAllButton.UseVisualStyleBackColor = false;
            this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.BackColor = System.Drawing.Color.Red;
            this.DeleteAllButton.Location = new System.Drawing.Point(791, 580);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(114, 40);
            this.DeleteAllButton.TabIndex = 208;
            this.DeleteAllButton.Text = "Togli Tutti";
            this.DeleteAllButton.UseVisualStyleBackColor = false;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // ProvaLabel
            // 
            this.ProvaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProvaLabel.Location = new System.Drawing.Point(186, 65);
            this.ProvaLabel.Name = "ProvaLabel";
            this.ProvaLabel.Size = new System.Drawing.Size(106, 31);
            this.ProvaLabel.TabIndex = 209;
            this.ProvaLabel.Text = "Inserisci Tipo di Gara:";
            this.ProvaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // garaBindingSource
            // 
            this.garaBindingSource.DataMember = "Gara";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveButton.Location = new System.Drawing.Point(692, 65);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(97, 39);
            this.SaveButton.TabIndex = 211;
            this.SaveButton.Text = "SALVA";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GaraNameTextBox
            // 
            this.GaraNameTextBox.Location = new System.Drawing.Point(298, 76);
            this.GaraNameTextBox.Name = "GaraNameTextBox";
            this.GaraNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.GaraNameTextBox.TabIndex = 212;
            // 
            // Gara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 632);
            this.Controls.Add(this.GaraNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProvaLabel);
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.AddAllButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoriaComboBoxFilter);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ReturnButon);
            this.Controls.Add(this.labelCboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunnerList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCboBox;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReturnButon;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox CategoriaComboBoxFilter;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button AddAllButton;
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.Label ProvaLabel;
        private System.Windows.Forms.BindingSource garaBindingSource;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox GaraNameTextBox;
    }
}