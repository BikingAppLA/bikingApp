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
        }

        //Show ALL Button
        private void MostraTuttiButton_Click(object sender, EventArgs e)
        {
            var teamTbl = accessOperations.GetTeamTableFiltered(_table1);
            dataGridView1.DataSource = teamTbl;
        }

        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
