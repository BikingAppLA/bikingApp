using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biking
{
    public partial class MainForm : Form
    {
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        OpenFileDialog ofd1 = new OpenFileDialog();
        ExcelOperations excelOperations = new ExcelOperations();
        AccessOperations accessOperations = new AccessOperations();
        public static DataTable accessTbl = new DataTable();
        public static DataTable excelTbl = new DataTable();
        public string filterCboBox;

        public MainForm()
        {
            InitializeComponent();
            DataGridView dataGridView1 = new DataGridView();

            var tbl = accessOperations.GetAccessTable(accessTbl);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                var val = tbl.Rows[i].ItemArray.GetValue(5);

                if (!comboBoxFilter.Items.Contains(val))
                {
                    comboBoxFilter.Items.Add(val);
                }
            }
        }

        private void Directory_Click_1(object sender, EventArgs e)
        {
            var fileName = excelOperations.DirectoryClick();
            DataTable excelTbl = excelOperations.GetDataTableFromExcel(fileName);

            textboxDirectory.Text = fileName;
            dataGridView1.DataSource = excelTbl;
        }

        
        private void AccessExportButton_Click(object sender, EventArgs e)
        {
            var path = excelOperations.DirectoryClick();
            var excelTbl = excelOperations.GetDataTableFromExcel(path);
            var accessTbl = accessOperations.ExportToAccessDB(excelTbl);
            dataGridView1.DataSource = accessTbl;
            accessOperations.GetAccessTable(accessTbl);
            this.dataGridView1.Columns["DorsaleNumero"].Visible = false;
        }

        private void ClearDbButton_Click(object sender, EventArgs e)
        {
            accessOperations.ClearRunner();
            string message = "Database pulito!";
            MessageBox.Show(message);
            dataGridView1.DataSource = accessTbl;
            accessOperations.GetAccessTable(accessTbl);
            this.dataGridView1.Columns["DorsaleNumero"].Visible = false;
        }

        private void AccessDbShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accessTbl;
            accessOperations.GetAccessTable(accessTbl);
            this.dataGridView1.Columns["DorsaleNumero"].Visible = false;
        }

        void RunnerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = accessTbl;
            accessOperations.GetAccessTable(accessTbl);
            this.dataGridView1.Columns["DorsaleNumero"].Visible = false;
            this.Show();
        }

        void AddForm_FormClosed(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accessTbl;
            accessOperations.GetAccessTable(accessTbl);
            this.Show();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource != accessTbl)
            {
                string message = "Stai provando a modificare il file Excel! Seleziona il tasto Access db Show per modificare il file giusto!";
                MessageBox.Show(message);
            }
            else
            {
                EDITForm crudForm = new EDITForm(accessTbl);
                crudForm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                crudForm.textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                crudForm.textBox10.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                crudForm.textBox9.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                crudForm.textBox8.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                crudForm.textBox7.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                crudForm.textBox4.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                crudForm.textBox5.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                crudForm.textBox6.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                crudForm.textBox12.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                crudForm.textBox13.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                crudForm.textBox14.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                crudForm.textBox15.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
                crudForm.textBox16.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
                crudForm.textBox17.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
                crudForm.textBox18.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();

                crudForm.FormClosed += new FormClosedEventHandler(EditForm_FormClosed);
                this.Hide();
                crudForm.ShowDialog();
            }
        }

        void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = accessTbl;
            accessOperations.GetAccessTable(accessTbl);
            this.Show();
        }

        private void ComboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string filterCboBox = this.comboBoxFilter.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(textboxDirectory.Text))
            {
                var fileName = textboxDirectory.Text;
                var a = new ExcelOperations();
                var dataTable = a.GetDataTableFromExcel(fileName);

                DataView dv = new DataView(dataTable, $@"Categoria = '{filterCboBox}' ", "Categoria Desc", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv.ToTable(false, "NomeTesserato", "CodiceFCI", "Categoria", "DorsaleNumero", "DataNascita", "NomeSocieta", "Sesso", "CodiceFiscale");
                this.dataGridView1.Columns["DorsaleNumero"].Visible = false;
            }
            else
            {
                string message = "Devi selezionare un file! NON PUOI FILTRARE IL NULLA, CAPRA!";
                MessageBox.Show(message);
            }
        }

        private void CreaGaraBtn_Click(object sender, EventArgs e)
        {
            var tbl = accessOperations.GetAccessTable(accessTbl);
            Gara runnerList = new Gara(accessTbl);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        private void AddRunnerButton_Click(object sender, EventArgs e)
        {
            
            AddForm addForm = new AddForm(accessTbl);
            addForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
            this.Hide();
            addForm.ShowDialog();
        }

        private void CreaProvaButton_Click(object sender, EventArgs e)
        {
            Prova prova = new Prova();
            prova.FormClosed += new FormClosedEventHandler(CreaProva_FormClosed);
            this.Hide();
            prova.ShowDialog();
        }

        void CreaProva_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

