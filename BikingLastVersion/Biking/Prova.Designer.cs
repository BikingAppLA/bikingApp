namespace Biking
{
    partial class Prova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReturnButon = new System.Windows.Forms.Button();
            this.NomeGaraLabel = new System.Windows.Forms.Label();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.NomeAtletaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeGaraComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.NomeAtletaTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MostraTuttiButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TransferToData2BTN = new System.Windows.Forms.Button();
            this.RemoveFromData2BTN = new System.Windows.Forms.Button();
            this.SelectALLGrid1BTN = new System.Windows.Forms.Button();
            this.SelectALLGrid2BTN = new System.Windows.Forms.Button();
            this.SaveProvaBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeProvaTextBox = new System.Windows.Forms.TextBox();
            this.AssegnPunteggiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButon
            // 
            this.ReturnButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReturnButon.ForeColor = System.Drawing.Color.Black;
            this.ReturnButon.Location = new System.Drawing.Point(1206, 61);
            this.ReturnButon.Name = "ReturnButon";
            this.ReturnButon.Size = new System.Drawing.Size(101, 49);
            this.ReturnButon.TabIndex = 204;
            this.ReturnButon.Text = "CANCELLA";
            this.ReturnButon.UseVisualStyleBackColor = false;
            this.ReturnButon.Click += new System.EventHandler(this.ReturnButon_Click);
            // 
            // NomeGaraLabel
            // 
            this.NomeGaraLabel.BackColor = System.Drawing.Color.White;
            this.NomeGaraLabel.ForeColor = System.Drawing.Color.Black;
            this.NomeGaraLabel.Location = new System.Drawing.Point(40, 33);
            this.NomeGaraLabel.Name = "NomeGaraLabel";
            this.NomeGaraLabel.Size = new System.Drawing.Size(68, 21);
            this.NomeGaraLabel.TabIndex = 213;
            this.NomeGaraLabel.Text = "Nome Gara:";
            this.NomeGaraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.BackColor = System.Drawing.Color.White;
            this.CategoriaLabel.ForeColor = System.Drawing.Color.Black;
            this.CategoriaLabel.Location = new System.Drawing.Point(177, 33);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(68, 21);
            this.CategoriaLabel.TabIndex = 214;
            this.CategoriaLabel.Text = "Categoria";
            this.CategoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeAtletaLabel
            // 
            this.NomeAtletaLabel.BackColor = System.Drawing.Color.White;
            this.NomeAtletaLabel.ForeColor = System.Drawing.Color.Black;
            this.NomeAtletaLabel.Location = new System.Drawing.Point(310, 33);
            this.NomeAtletaLabel.Name = "NomeAtletaLabel";
            this.NomeAtletaLabel.Size = new System.Drawing.Size(68, 21);
            this.NomeAtletaLabel.TabIndex = 215;
            this.NomeAtletaLabel.Text = "Nome Atleta";
            this.NomeAtletaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1339, 21);
            this.label4.TabIndex = 216;
            this.label4.Text = "FILTRI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeGaraComboBox
            // 
            this.NomeGaraComboBox.FormattingEnabled = true;
            this.NomeGaraComboBox.Location = new System.Drawing.Point(22, 68);
            this.NomeGaraComboBox.Name = "NomeGaraComboBox";
            this.NomeGaraComboBox.Size = new System.Drawing.Size(105, 21);
            this.NomeGaraComboBox.TabIndex = 217;
            this.NomeGaraComboBox.SelectionChangeCommitted += new System.EventHandler(this.NomeGaraComboBox_SelectionChangeCommitted);
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(159, 68);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(103, 21);
            this.CategoriaComboBox.TabIndex = 218;
            this.CategoriaComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoriaComboBox_SelectionChangeCommitted);
            // 
            // NomeAtletaTextBox
            // 
            this.NomeAtletaTextBox.Location = new System.Drawing.Point(288, 68);
            this.NomeAtletaTextBox.Name = "NomeAtletaTextBox";
            this.NomeAtletaTextBox.Size = new System.Drawing.Size(123, 20);
            this.NomeAtletaTextBox.TabIndex = 221;
            this.NomeAtletaTextBox.TextChanged += new System.EventHandler(this.NomeAtletaTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 140);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 339);
            this.dataGridView1.TabIndex = 222;
            // 
            // MostraTuttiButton
            // 
            this.MostraTuttiButton.BackColor = System.Drawing.Color.White;
            this.MostraTuttiButton.ForeColor = System.Drawing.Color.Black;
            this.MostraTuttiButton.Location = new System.Drawing.Point(434, 33);
            this.MostraTuttiButton.Name = "MostraTuttiButton";
            this.MostraTuttiButton.Size = new System.Drawing.Size(82, 39);
            this.MostraTuttiButton.TabIndex = 223;
            this.MostraTuttiButton.Text = "Mostra Tutti";
            this.MostraTuttiButton.UseVisualStyleBackColor = false;
            this.MostraTuttiButton.Click += new System.EventHandler(this.MostraTuttiButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(729, 140);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(598, 339);
            this.dataGridView2.TabIndex = 224;
            // 
            // TransferToData2BTN
            // 
            this.TransferToData2BTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransferToData2BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferToData2BTN.Location = new System.Drawing.Point(649, 292);
            this.TransferToData2BTN.Name = "TransferToData2BTN";
            this.TransferToData2BTN.Size = new System.Drawing.Size(59, 32);
            this.TransferToData2BTN.TabIndex = 225;
            this.TransferToData2BTN.Text = ">>";
            this.TransferToData2BTN.UseVisualStyleBackColor = false;
            this.TransferToData2BTN.Click += new System.EventHandler(this.TransferToData2BTN_Click);
            // 
            // RemoveFromData2BTN
            // 
            this.RemoveFromData2BTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveFromData2BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromData2BTN.Location = new System.Drawing.Point(649, 352);
            this.RemoveFromData2BTN.Name = "RemoveFromData2BTN";
            this.RemoveFromData2BTN.Size = new System.Drawing.Size(59, 32);
            this.RemoveFromData2BTN.TabIndex = 226;
            this.RemoveFromData2BTN.Text = "<<";
            this.RemoveFromData2BTN.UseVisualStyleBackColor = false;
            this.RemoveFromData2BTN.Click += new System.EventHandler(this.RemoveFromData2BTN_Click);
            // 
            // SelectALLGrid1BTN
            // 
            this.SelectALLGrid1BTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectALLGrid1BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectALLGrid1BTN.Location = new System.Drawing.Point(503, 496);
            this.SelectALLGrid1BTN.Name = "SelectALLGrid1BTN";
            this.SelectALLGrid1BTN.Size = new System.Drawing.Size(124, 32);
            this.SelectALLGrid1BTN.TabIndex = 227;
            this.SelectALLGrid1BTN.Text = "Seleziona Tutti";
            this.SelectALLGrid1BTN.UseVisualStyleBackColor = false;
            this.SelectALLGrid1BTN.Click += new System.EventHandler(this.SelectALLData1BTN_Click);
            // 
            // SelectALLGrid2BTN
            // 
            this.SelectALLGrid2BTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectALLGrid2BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectALLGrid2BTN.Location = new System.Drawing.Point(729, 496);
            this.SelectALLGrid2BTN.Name = "SelectALLGrid2BTN";
            this.SelectALLGrid2BTN.Size = new System.Drawing.Size(122, 32);
            this.SelectALLGrid2BTN.TabIndex = 228;
            this.SelectALLGrid2BTN.Text = "Seleziona Tutti";
            this.SelectALLGrid2BTN.UseVisualStyleBackColor = false;
            this.SelectALLGrid2BTN.Click += new System.EventHandler(this.SelectALLGrid2BTN_Click);
            // 
            // SaveProvaBTN
            // 
            this.SaveProvaBTN.BackColor = System.Drawing.Color.GreenYellow;
            this.SaveProvaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProvaBTN.ForeColor = System.Drawing.Color.Black;
            this.SaveProvaBTN.Location = new System.Drawing.Point(1024, 61);
            this.SaveProvaBTN.Name = "SaveProvaBTN";
            this.SaveProvaBTN.Size = new System.Drawing.Size(137, 49);
            this.SaveProvaBTN.TabIndex = 229;
            this.SaveProvaBTN.Text = "Salva Prova";
            this.SaveProvaBTN.UseVisualStyleBackColor = false;
            this.SaveProvaBTN.Click += new System.EventHandler(this.SaveProvaBTN_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(668, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 231;
            this.label1.Text = "Nome Prova:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeProvaTextBox
            // 
            this.NomeProvaTextBox.Location = new System.Drawing.Point(671, 69);
            this.NomeProvaTextBox.Name = "NomeProvaTextBox";
            this.NomeProvaTextBox.Size = new System.Drawing.Size(147, 20);
            this.NomeProvaTextBox.TabIndex = 232;
            // 
            // AssegnPunteggiButton
            // 
            this.AssegnPunteggiButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AssegnPunteggiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssegnPunteggiButton.ForeColor = System.Drawing.Color.Black;
            this.AssegnPunteggiButton.Location = new System.Drawing.Point(862, 61);
            this.AssegnPunteggiButton.Name = "AssegnPunteggiButton";
            this.AssegnPunteggiButton.Size = new System.Drawing.Size(119, 53);
            this.AssegnPunteggiButton.TabIndex = 233;
            this.AssegnPunteggiButton.Text = "Assegna Punteggi";
            this.AssegnPunteggiButton.UseVisualStyleBackColor = false;
            // 
            // Prova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1339, 613);
            this.Controls.Add(this.AssegnPunteggiButton);
            this.Controls.Add(this.NomeProvaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveProvaBTN);
            this.Controls.Add(this.SelectALLGrid2BTN);
            this.Controls.Add(this.SelectALLGrid1BTN);
            this.Controls.Add(this.RemoveFromData2BTN);
            this.Controls.Add(this.TransferToData2BTN);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MostraTuttiButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NomeAtletaTextBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.NomeGaraComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomeAtletaLabel);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.NomeGaraLabel);
            this.Controls.Add(this.ReturnButon);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Prova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prova";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButon;
        private System.Windows.Forms.Label NomeGaraLabel;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Label NomeAtletaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NomeGaraComboBox;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.TextBox NomeAtletaTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MostraTuttiButton;
        private System.Windows.Forms.Button TransferToData2BTN;
        private System.Windows.Forms.Button RemoveFromData2BTN;
        private System.Windows.Forms.Button SelectALLGrid1BTN;
        private System.Windows.Forms.Button SelectALLGrid2BTN;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SaveProvaBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeProvaTextBox;
        private System.Windows.Forms.Button AssegnPunteggiButton;
    }
}