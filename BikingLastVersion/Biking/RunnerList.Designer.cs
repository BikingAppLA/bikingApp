namespace Biking
{
    partial class RunnerList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReturnButon = new System.Windows.Forms.Button();
            this.CategorieFilterLabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ReturnButon
            // 
            this.ReturnButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReturnButon.ForeColor = System.Drawing.Color.Black;
            this.ReturnButon.Location = new System.Drawing.Point(736, 31);
            this.ReturnButon.Name = "ReturnButon";
            this.ReturnButon.Size = new System.Drawing.Size(101, 49);
            this.ReturnButon.TabIndex = 224;
            this.ReturnButon.Text = "CANCELLA";
            this.ReturnButon.UseVisualStyleBackColor = false;
            this.ReturnButon.Click += new System.EventHandler(this.ReturnButon_Click);
            // 
            // CategorieFilterLabel
            // 
            this.CategorieFilterLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategorieFilterLabel.Location = new System.Drawing.Point(12, 22);
            this.CategorieFilterLabel.Name = "CategorieFilterLabel";
            this.CategorieFilterLabel.Size = new System.Drawing.Size(79, 44);
            this.CategorieFilterLabel.TabIndex = 225;
            this.CategorieFilterLabel.Text = "Filtra Categorie:";
            this.CategorieFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(124, 35);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(124, 21);
            this.CategoriaComboBox.TabIndex = 226;
            this.CategoriaComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoriaComboBox_SelectionChangeCommitted);
            // 
            // RunnerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 561);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.CategorieFilterLabel);
            this.Controls.Add(this.ReturnButon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RunnerList";
            this.Text = "RunnerList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReturnButon;
        private System.Windows.Forms.Label CategorieFilterLabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
    }
}