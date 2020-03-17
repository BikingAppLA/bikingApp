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

        }

        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Runner1_Click(object sender, EventArgs e)
        {
            Nome1Team.Text = "";
            RunnerList runnerList = new RunnerList(this);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        void RunnerList_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Runner2_Click(object sender, EventArgs e)
        {
            Nome2Team.Text = "";
            RunnerList runnerList = new RunnerList(this);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        private void Runner3_Click(object sender, EventArgs e)
        {
            Nome3Team.Text = "";
            RunnerList runnerList = new RunnerList(this);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        private void Runner4_Click(object sender, EventArgs e)
        {
            Nome4Team.Text = "";
            RunnerList runnerList = new RunnerList(this);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        private void Reset1Button_Click(object sender, EventArgs e)
        {
            Nome1Team.Text = "Nome";
            CodiceFCI1.Text = "CodiceFCI";
        }

        private void Reset2Button_Click(object sender, EventArgs e)
        {
            Nome2Team.Text = "Nome";
            CodiceFCI2.Text = "CodiceFCI";
        }

        private void Reset3Button_Click(object sender, EventArgs e)
        {
            Nome3Team.Text = "Nome";
            CodiceFCI3.Text = "CodiceFCI";
        }

        private void Reset4Button_Click(object sender, EventArgs e)
        {
            Nome4Team.Text = "Nome";
            CodiceFCI4.Text = "CodiceFCI";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(accessOperations._accessConnectionString1);
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conn,
                CommandType = CommandType.Text
            };

            cmd.CommandText = @"INSERT INTO [Team] ([Nome], [Runner1FCI], [Runner2FCI], [Runner3FCI], [Runner4FCI], [Categoria]) " +
                "VALUES (@Nome, @Runner1FCI, @Runner2FCI, @Runner3FCI, @Runner4FCI, @Categoria)";

            conn.Open();

            string categoria = CategoriaComboBox.SelectedItem == null ? String.Empty : this.CategoriaComboBox.SelectedItem.ToString();

            #region parameters

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Nome", this.NomeTeamTextBox.Text.ToString() ?? "");

            cmd.Parameters.AddWithValue("@Runner1FCI", this.CodiceFCI1.Text.ToString() ?? "");

            cmd.Parameters.AddWithValue("@Runner2FCI", this.CodiceFCI2.Text.ToString() ?? "");

            cmd.Parameters.AddWithValue("@Runner3FCI", this.CodiceFCI3.Text.ToString() ?? "");

            cmd.Parameters.AddWithValue("@Runner4FCI", this.CodiceFCI4.Text.ToString() ?? "");

            cmd.Parameters.AddWithValue("@Categoria", categoria ?? "");




            cmd.ExecuteNonQuery();
            #endregion
            conn.Close();
            string message = "Team importato con successo!";
            MessageBox.Show(message);
        }

    }
}
