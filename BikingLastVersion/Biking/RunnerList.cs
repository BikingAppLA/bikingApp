using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biking
{
    public partial class RunnerList : Form
    {
        static AccessOperations accessOperations = new AccessOperations();
        static public DataTable _tbl = new DataTable();
        public static DataTable _table1 = new DataTable();
        Team _team;
        DataTable listaGare = accessOperations.GetGaraAtletaTable(_table1);

        public RunnerList(Team team)
        {
            InitializeComponent();
            _team = team;
            string emptyItem = "";

            //Populate combobox category (filter)
            for (int i = 0; i < listaGare.Rows.Count; i++)
            {
                var val = listaGare.Rows[i].ItemArray.GetValue(3);

                if (!CategoriaComboBox.Items.Contains(val))
                {
                    CategoriaComboBox.Items.Add(val);
                }
            }
            CategoriaComboBox.Items.Add(emptyItem);
        }

        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoriaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string filterCboBox = this.CategoriaComboBox.SelectedItem.ToString();
            var dataTable = accessOperations.GetAccessTable(_tbl);

            DataView dv = new DataView(dataTable, $@"Categoria = '{filterCboBox}' ", "Categoria Desc", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv.ToTable(false, "NomeTesserato", "CodiceFCI", "Categoria", "DataNascita", "NomeSocieta", "CodiceFiscale");
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _team.Nome1Team1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            _team.CodiceFCI1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}

