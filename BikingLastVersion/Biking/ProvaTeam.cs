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
    public partial class ProvaTeam : Form
    {
        static AccessOperations accessOperations = new AccessOperations();

        public static DataTable _table = new DataTable();
        public static DataTable _table1 = new DataTable();
        DataTable dataTableCurrent = accessOperations.GetAccessTable(_table);

        public ProvaTeam()
        {
            InitializeComponent();

            // Populate CATEGORY Combobox

            for (int i = 0; i < dataTableCurrent.Rows.Count; i++)
            {
                var val = dataTableCurrent.Rows[i].ItemArray.GetValue(5);

                if (!CategoriaComboBoxFilter.Items.Contains(val))
                {
                    CategoriaComboBoxFilter.Items.Add(val);
                }
            }

            DataGridViewColumn nomeTeam = new DataGridViewColumn
            {
                Name = "NomeTeam",
                HeaderText = "Nome Team"
            };

            DataGridViewCheckBoxColumn booleanRemove = new DataGridViewCheckBoxColumn
            {
                Name = "Rimuovidallaista",
                HeaderText = "Rimuovi Dalla Lista"
            };

            booleanRemove.CellTemplate = new DataGridViewCheckBoxCell();
            nomeTeam.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView2.Columns.Add(nomeTeam);
            dataGridView2.Columns.Add(booleanRemove);

        }

        //Show ALL Button
        private void MostraTuttiButton_Click(object sender, EventArgs e)
        {
            var teamTbl = accessOperations.GetTeamTableFiltered(_table1);
            teamTbl.Columns.Add("Seleziona Team per la Prova", typeof(Boolean));
            dataGridView1.DataSource = teamTbl;
        }

        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTeamBTN_Click(object sender, EventArgs e)
        {
            Team teamForm = new Team();
            teamForm.FormClosed += new FormClosedEventHandler(TeamForm_FormClosed);
            this.Hide();
            teamForm.ShowDialog();
        }

        void TeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void TransferToData2BTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string val1 = dataGridView1.Rows[i].Cells[1].Value.ToString() ?? String.Empty;
                if (val1 == "True")
                {
                    dataGridView2.Rows.Add($"{dataGridView1.Rows[i].Cells[0].Value.ToString()}");
                }
                dataGridView1.Rows[i].Cells[1].Value = false;
            }
        }

        private void RemoveFromData2BTN_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                var val1 = dataGridView2.Rows[i].Cells[1].Value == null ? String.Empty : dataGridView2.Rows[i].Cells[1].Value.ToString();
                if (val1 == "True" && val1 != String.Empty)
                {
                    dataGridView2.Rows.RemoveAt(i);
                }
            }
        }

        private void SelectALLGrid1BTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var val1 = row.Cells[1].Value.ToString();
                if (val1 == "False" || string.IsNullOrWhiteSpace(val1))
                {
                    row.Cells[1].Value = true;
                }
                else
                {
                    row.Cells[1].Value = false;
                }
            }
        }

        private void SelectALLGrid2BTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dataGridView2.Rows)
            {
                var val2 = Convert.ToBoolean(rows.Cells[1].Value);
                if (val2 == false)
                {
                    rows.Cells[1].Value = true;
                }
                else
                {
                    rows.Cells[1].Value = false;
                }
            }
        }
    }
}
