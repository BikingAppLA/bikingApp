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
    public partial class Gara : Form
    {
        static AccessOperations accessOperations = new AccessOperations();

        public static DataTable _table = new DataTable();
        public static DataTable _table1 = new DataTable();
        public string filterCboBox1;
        DataTable dataTableCurrent = accessOperations.GetAccessTable(_table);

        public Gara(DataTable dt)
        {
            InitializeComponent();


            for (int i = 0; i < dataTableCurrent.Rows.Count; i++)
            {
                var val = dataTableCurrent.Rows[i].ItemArray.GetValue(5);

                if (!CategoriaComboBoxFilter.Items.Contains(val))
                {
                    CategoriaComboBoxFilter.Items.Add(val);
                }
            }

            DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                Text = "TOGLI",
                UseColumnTextForButtonValue = true
            };

            DataGridViewColumn nameCol = new DataGridViewColumn
            {
                Name = "NomeTesserato",
                HeaderText = "Nome Tesserato"
            };

            nameCol.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn fciCol = new DataGridViewColumn
            {
                Name = "CodiceFci",
                HeaderText = "Codice FCI"
            };

            fciCol.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn catCol = new DataGridViewColumn
            {
                Name = "Categoria",
                HeaderText = "Categoria"
            };

            catCol.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn dorsalCol = new DataGridViewColumn
            {
                Name = "Dorsale",
                HeaderText = "Dorsale"
            };

            dorsalCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView2.Columns.Add(dataGridViewButtonColumn2);
            dataGridView2.Columns.Add(nameCol);
            dataGridView2.Columns.Add(fciCol);
            dataGridView2.Columns.Add(catCol);
            dataGridView2.Columns.Add(dorsalCol);
            
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxFilter_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            var dataTableCurrent = accessOperations.GetAccessTable(_table);
            string filterCboBox1 = this.CategoriaComboBoxFilter.SelectedItem.ToString();
            DataView dv = new DataView(dataTableCurrent, $@"Categoria = '{filterCboBox1}' ", "Categoria Desc", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv.ToTable(false, "NomeTesserato", "CodiceFCI", "Categoria", "NomeSocieta", "CodiceFiscale", "DorsaleNumero");
            this.dataGridView1.Columns["CodiceFiscale"].Visible = false;
            this.dataGridView1.Columns["NomeSocieta"].Visible = false;
            this.dataGridView1.Columns["DorsaleNumero"].Visible = false;
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn
            {
                Name = "AddButton",
                Text = "AGGIUNGI",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(6, dataGridViewButtonColumn);
        }

        //COPY 1 ROW FROM DATAGRID 1 TO DATAGRID 2
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                bool entryFound1 = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var val1 = row.Cells[2].Value.ToString();
                    var val2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (val1 == val2)
                    {
                        entryFound1 = true;
                        break;
                    }
                }
                if (!entryFound1)
                {
                    dataGridView2.Rows.Add("", $"{dataGridView1.CurrentRow.Cells[0].Value.ToString()}", $"{dataGridView1.CurrentRow.Cells[1].Value.ToString()}", $"{dataGridView1.CurrentRow.Cells[2].Value.ToString()}", $"{dataGridView1.CurrentRow.Cells[5].Value.ToString()}");
                }
            }
        }

        //REMOVE 1 ROW DATRAGRID 2
        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dataGridView2.Rows.RemoveAt(e.RowIndex);
            }
        }

        //ADD ALL ROWS TO DATAGRID 2
        private void AddAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool entryFound = false;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var val1 = row.Cells[2].Value.ToString();
                    var val2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if (val1 == val2)
                    {
                        entryFound = true;
                        break;
                    }
                }
                if (!entryFound)
                {
                    dataGridView2.Rows.Add("", $"{dataGridView1.Rows[i].Cells[0].Value.ToString()}", $"{dataGridView1.Rows[i].Cells[1].Value.ToString()}", $"{dataGridView1.Rows[i].Cells[2].Value.ToString()}", $"{dataGridView1.Rows[i].Cells[5].Value.ToString()}");
                }
            }
        }

        //DELETE ALL ROWS FROM DATAGRID 2
        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        //SAVES RECORDS IN GARA ATLETA TBL
        private void SaveButton_Click(object sender, EventArgs e)
        {

            string nomeGara = GaraNameTextBox.Text == null ? String.Empty : GaraNameTextBox.Text.ToString();
            string categoria = CategoriaComboBoxFilter.SelectedItem == null ? string.Empty : CategoriaComboBoxFilter.SelectedItem.ToString();
            try
            {
                OleDbConnection _conn = new OleDbConnection(accessOperations._accessConnectionString1);

                OleDbCommand cmd = new OleDbCommand
                {
                    Connection = _conn,
                    CommandType = CommandType.Text
                };
                OleDbCommand cmd1 = new OleDbCommand
                {
                    Connection = _conn,
                    CommandType = CommandType.Text
                };

                _conn.Open();

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    cmd.CommandText = @"INSERT INTO [GaraAtleta]([NomeGara], [CodiceFCIATLETA], [Categoria]) VALUES " +
                    " (@nomeGara, @codiceFCI, @categoria)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nomeGara", nomeGara);
                    cmd.Parameters.AddWithValue("@codiceFCI", dataGridView2.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    cmd.ExecuteNonQuery();

                }

                //ADD nomegara to Gara Table if it isn't already present

                DataTable listaGare = accessOperations.GetGaraTable(_table1);
                if (listaGare.Rows.Count == 0)
                {
                    cmd1.CommandText = @"INSERT INTO [Gara]([NomeGara]) VALUES ( @nomeGara);";
                    cmd1.Parameters.AddWithValue("@nomeGara", nomeGara);
                    cmd1.ExecuteNonQuery();
                }
                else if (listaGare.Rows.Count > 0)
                {
                    bool alreadyPresent = false;
                    foreach (DataRow row in listaGare.Rows)
                    {
                        var nomeGara1 = GaraNameTextBox.Text.ToString() ?? String.Empty;
                        var nomeGaraInsideDB = row.ItemArray[1].ToString();
                        if (nomeGara1 == nomeGaraInsideDB && nomeGara1 != "")
                        {
                            alreadyPresent = true;
                            break;
                        }
                    }
                    if (!alreadyPresent)
                    {
                        cmd1.CommandText = @"INSERT INTO [Gara]([NomeGara]) VALUES ( @nomeGara);";
                        cmd1.Parameters.AddWithValue("@nomeGara", GaraNameTextBox.Text.ToString());
                        cmd1.ExecuteNonQuery();
                    }
                }

                _conn.Close();
                string message = "Lista di gara importata con successo!";
                MessageBox.Show(message);
            }

            catch (Exception ex)
            {
                throw new Exception("ocio all'errore.... : " + ex);
            }
        }
    }
}
