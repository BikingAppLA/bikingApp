using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biking
{
    public partial class Team : Form
    {
        public static DataTable _table = new DataTable();
        static AccessOperations accessOperations = new AccessOperations();
        public static DataTable _table1 = new DataTable();
        
        public delegate void delPassData(TextBox text);
        DataTable listaGare = accessOperations.GetAccessTable(_table1);
        public Team()
        {
            InitializeComponent();

            string emptyItem = "";
            //Add items to Combobox Categoria
            for (int i = 0; i < listaGare.Rows.Count; i++)
            {
                var val = listaGare.Rows[i].ItemArray.GetValue(5);

                if (!CategoriaComboBox.Items.Contains(val))
                {
                    CategoriaComboBox.Items.Add(val);
                }
            }
            CategoriaComboBox.Items.Add(emptyItem);


            DataGridViewColumn nomeAtleta = new DataGridViewColumn
            {
                Name = "NomeAtleta",
                HeaderText = "Nome Atleta"
            };
            DataGridViewColumn categoria = new DataGridViewColumn
            {
                Name = "categoria",
                HeaderText = "Categoria"
            };
            DataGridViewColumn codiceFCIAtleta = new DataGridViewColumn
            {
                Name = "codiceFCIAtleta",
                HeaderText = "Codice FCI"
            };
            DataGridViewCheckBoxColumn booleanRemove = new DataGridViewCheckBoxColumn
            {
                Name = "Rimuovidallaista",
                HeaderText = "Rimuovi Dalla Lista"
            };
            codiceFCIAtleta.CellTemplate = new DataGridViewTextBoxCell();
            nomeAtleta.CellTemplate = new DataGridViewTextBoxCell();
            categoria.CellTemplate = new DataGridViewTextBoxCell();
            booleanRemove.CellTemplate = new DataGridViewCheckBoxCell();

            dataGridView1.Columns.Add(nomeAtleta);
            dataGridView1.Columns.Add(categoria);
            dataGridView1.Columns.Add(codiceFCIAtleta);
            dataGridView1.Columns.Add(booleanRemove);
        }

        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void RunnerList_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(accessOperations._accessConnectionString1);
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conn,
                CommandType = CommandType.Text
            };

            cmd.CommandText = @"INSERT INTO [Team] ([Nome], [Categoria]) " +
                "VALUES (@Nome, @Categoria)";

            conn.Open();

            string categoria = CategoriaComboBox.SelectedItem == null ? String.Empty : this.CategoriaComboBox.SelectedItem.ToString();
            string nomeTeam = NomeTeamTextBox.Text == null ? String.Empty : this.NomeTeamTextBox.Text.ToString();

            #region parameters

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Nome", nomeTeam);

            cmd.Parameters.AddWithValue("@Categoria", categoria ?? "");

            if (!string.IsNullOrEmpty(nomeTeam))
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "Team importato con successo!";
                MessageBox.Show(message);
            }
            else
            {
                string messageSeverity = "Devi inserire il nome del team!";
                MessageBox.Show(messageSeverity);
                return;
            }
            #endregion
        }

        private void AddAthleteBTN_Click(object sender, EventArgs e)
        {
            RunnerList runnerList = new RunnerList(this);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        private void RemoveAthleteBooleanBTN_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                var val1 = dataGridView1.Rows[i].Cells[3].Value == null ? String.Empty : dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (val1 == "True" && val1 != String.Empty)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
    }
}
