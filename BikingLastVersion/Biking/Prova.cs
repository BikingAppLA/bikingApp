using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biking
{
    public partial class Prova : Form
    {
        static AccessOperations accessOperations = new AccessOperations();
        public static DataTable _table1 = new DataTable();
        public static DataTable _table2 = new DataTable();
        DataTable listaGare = accessOperations.GetGaraAtletaTable(_table1);
        DataTable listaAtleti = accessOperations.GetAccessTable(_table2);

        public Prova()
        {
            InitializeComponent();

            //Add items to Combobox NomeGara
            for (int i = 0; i < listaGare.Rows.Count; i++)
            {
                var val = listaGare.Rows[i].ItemArray.GetValue(1);

                if (!NomeGaraComboBox.Items.Contains(val))
                {
                    NomeGaraComboBox.Items.Add(val);
                }
            }

            string emptyItem = "";
            NomeGaraComboBox.Items.Add(emptyItem);

            //Add items to Combobox Categoria
            for (int i = 0; i < listaGare.Rows.Count; i++)
            {
                var val = listaGare.Rows[i].ItemArray.GetValue(3);

                if (!CategoriaComboBox.Items.Contains(val))
                {
                    CategoriaComboBox.Items.Add(val);
                }
            }
            CategoriaComboBox.Items.Add(emptyItem);

            DataGridViewColumn nomeGara = new DataGridViewColumn
            {
                Name = "NomeGara",
                HeaderText = "Nome Gara"
            };
            DataGridViewColumn codiceFCIATLETA = new DataGridViewColumn
            {
                Name = "CodiceFCIATLETA",
                HeaderText = "Codice FCI"
            };
            DataGridViewColumn nomeTesserato = new DataGridViewColumn
            {
                Name = "NomeTesserato",
                HeaderText = "Nome Tesserato"
            };
            DataGridViewColumn categoria = new DataGridViewColumn
            {
                Name = "Categoria",
                HeaderText = "Categoria"
            };
            DataGridViewCheckBoxColumn booleanRemove = new DataGridViewCheckBoxColumn
            {
                Name = "Rimuovidallaista",
                HeaderText = "Rimuovi Dalla Lista"
            };

            nomeGara.CellTemplate = new DataGridViewTextBoxCell();
            codiceFCIATLETA.CellTemplate = new DataGridViewTextBoxCell();
            nomeTesserato.CellTemplate = new DataGridViewTextBoxCell();
            categoria.CellTemplate = new DataGridViewTextBoxCell();
            booleanRemove.CellTemplate = new DataGridViewCheckBoxCell();

            dataGridView2.Columns.Add(nomeGara);
            dataGridView2.Columns.Add(codiceFCIATLETA);
            dataGridView2.Columns.Add(nomeTesserato);
            dataGridView2.Columns.Add(categoria);
            dataGridView2.Columns.Add(booleanRemove);

        }


        //Close this form(showdialog) and return to the precedent
        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Filter Dynamically datagridview by combobox nomegara
        private void NomeGaraComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nomeGara = NomeGaraComboBox.SelectedItem == null ? String.Empty : this.NomeGaraComboBox.SelectedItem.ToString();
            string categoria = CategoriaComboBox.SelectedItem == null ? String.Empty : this.CategoriaComboBox.SelectedItem.ToString();

            DataTable res1 = new DataTable();
            var res = GetJoinedTable(res1);

            this.dataGridView1.DataSource = res;

            if (categoria != "" || nomeGara != "")
            {
                if (nomeGara != "" && categoria != "")
                {
                    DataView dv = new DataView(res, $@"NomeGara = '{nomeGara}' AND Categoria = '{categoria}' ", "Categoria Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
                }
                else if (nomeGara != "" && categoria == "")
                {
                    DataView dv = new DataView(res, $@"NomeGara = '{nomeGara}'", "Categoria Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
                }
                else if (nomeGara == "" && categoria != "")
                {
                    DataView dv = new DataView(res, $@"Categoria = '{categoria}'", "Categoria Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
                }
            }
            else if (categoria == "" && nomeGara == "")
            {
                dataGridView1.DataSource = null;
            }

        }

        private void MostraTuttiButton_Click(object sender, EventArgs e)
        {
            DataTable res1 = new DataTable();
            var res = GetJoinedTable(res1);

            dataGridView1.DataSource = res;
        }

        //Filter Dynamically datagridview by combobox categoria
        private void CategoriaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nomeGara = NomeGaraComboBox.SelectedItem == null ? String.Empty : this.NomeGaraComboBox.SelectedItem.ToString();
            string categoria = CategoriaComboBox.SelectedItem == null ? String.Empty : this.CategoriaComboBox.SelectedItem.ToString();
            DataTable res1 = new DataTable();
            var res = GetJoinedTable(res1);

            if (categoria != "" || nomeGara != "")
            {
                if (categoria != "" && nomeGara != "")
                {
                    DataView dv = new DataView(res, $@"Categoria = '{categoria}' AND NomeGara = '{nomeGara}' ", "Categoria Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
                }
                else if (categoria != "" && nomeGara == "")
                {
                    DataView dv = new DataView(res, $@"Categoria = '{categoria}'", "Categoria Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
                }
                else if (categoria == "" && nomeGara != "")
                {
                    DataView dv = new DataView(res, $@"NomeGara = '{nomeGara}'", "Categoria Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
                }
            }
            else if (categoria == "" && nomeGara == "")
            {
                dataGridView1.DataSource = null;
            }
        }

        //DYNAMIC FILTER ON RUNNER NAME
        private void NomeAtletaTextBox_TextChanged(object sender, EventArgs e)
        {
            string textBoxNome = NomeAtletaTextBox.Text;
            DataTable res1 = new DataTable();
            var res = GetJoinedTable(res1);

            if (textBoxNome != "")
            {
                DataView dv3 = new DataView(res, $@"NomeTesserato LIKE '%{textBoxNome}%'", "NomeTesserato Desc", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv3.ToTable(false, "NomeGara", "CodiceFCIATLETA", "NomeTesserato", "Categoria", "Seleziona Atleta per la Prova");
            }
        }

        //Method to fill a table already JOINED, ready for the datagridview
        public DataTable GetJoinedTable(DataTable dt)
        {
            DataTable res = new DataTable();

            OleDbConnection conn = new OleDbConnection(accessOperations._accessConnectionString1);

            OleDbCommand cmd1 = new OleDbCommand("SELECT GaraATLETA.NomeGara, GaraATLETA.CodiceFCIATLETA, GaraATLETA.Categoria, Runner.NomeTesserato FROM Runner INNER JOIN GaraATLETA ON Runner.[CodiceFCI] = GaraATLETA.[CodiceFCIATLETA]; ", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd1);

            conn.Open();
            res.Clear();
            adapter.Fill(dt);
            conn.Close();
            dt.Columns.Add("Seleziona Atleta per la Prova", typeof(Boolean));
            return dt;
        }

        private void TransferToData2BTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string val1 = dataGridView1.Rows[i].Cells[4].Value.ToString() ?? String.Empty;
                if (val1 == "True")
                {
                    dataGridView2.Rows.Add($"{dataGridView1.Rows[i].Cells[0].Value.ToString()}", $"{dataGridView1.Rows[i].Cells[1].Value.ToString()}", $"{dataGridView1.Rows[i].Cells[2].Value.ToString()}", $"{dataGridView1.Rows[i].Cells[3].Value.ToString()}");
                }
                dataGridView1.Rows[i].Cells[4].Value = false;
            }
        }
        
        private void RemoveFromData2BTN_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                var val1 = dataGridView2.Rows[i].Cells[4].Value == null ? String.Empty : dataGridView2.Rows[i].Cells[4].Value.ToString();
                if (val1 == "True" && val1 != String.Empty)
                {
                    dataGridView2.Rows.RemoveAt(i);
                }
            }
        }

        private void SelectALLData1BTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var val1 = row.Cells[4].Value.ToString();
                if (val1 == "False" || string.IsNullOrWhiteSpace(val1))
                {
                    row.Cells[4].Value = true;
                }
                else
                {
                    row.Cells[4].Value = false;
                }
            }
        }

        private void SelectALLGrid2BTN_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow rows in dataGridView2.Rows)
                {
                    var val2 = Convert.ToBoolean(rows.Cells[4].Value);
                    if (val2 == false)
                    {
                        rows.Cells[4].Value = true;
                    }
                    else
                    {
                        rows.Cells[4].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
        }
    }
}
