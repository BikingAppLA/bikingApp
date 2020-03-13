using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biking
{
    class AccessOperations : ExcelOperations
    {
        readonly OpenFileDialog ofd1 = new OpenFileDialog();
        readonly ExcelOperations exc = new ExcelOperations();

        //CHANGE THIS _accessConnectionString1 on Data Source= *current directory of the access database*
        public string _accessConnectionString1 = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\antonelli_lorenzo\source\repos\BIKING_REPO\BikingREPO\bikingApp\BikingCorrect.accdb;";

        public DataTable GetAccessTable(DataTable accessTbl)
        {
            OleDbConnection conn = new OleDbConnection(_accessConnectionString1);

            OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM [Runner]", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd1);

            conn.Open();
            accessTbl.Clear();
            adapter.Fill(accessTbl);

            conn.Close();

            return accessTbl;
        }

        public DataTable GetGaraTable(DataTable dataTable)
        {
            OleDbConnection conn = new OleDbConnection(_accessConnectionString1);

            OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM [Gara]", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd1);

            conn.Open();
            dataTable.Clear();
            adapter.Fill(dataTable);
            conn.Close();

            return dataTable;
        }

        public DataTable GetGaraAtletaTable(DataTable dataTable)
        {
            OleDbConnection conn = new OleDbConnection(_accessConnectionString1);

            OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM [GaraATLETA]", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd1);

            conn.Open();
            dataTable.Clear();
            adapter.Fill(dataTable);
            conn.Close();

            return dataTable;
        }

        public DataTable GetTeamTable(DataTable dataTable)
        {
            OleDbConnection conn = new OleDbConnection(_accessConnectionString1);

            OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM [Team]", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd1);

            conn.Open();
            dataTable.Clear();
            adapter.Fill(dataTable);
            conn.Close();

            return dataTable;
        }

        public void ClearRunner()
        {

            OleDbConnection conn = new OleDbConnection(_accessConnectionString1);
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conn,
                CommandType = CommandType.Text
            };
            conn.Open();
            cmd.CommandText = "DELETE FROM Runner";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable ExportToAccessDB(DataTable tblImported)
        {
            try
            {
                ClearRunner();
                OleDbConnection _conn = new OleDbConnection(_accessConnectionString1);

                OleDbCommand cmd = new OleDbCommand
                {
                    Connection = _conn,
                    CommandType = CommandType.Text
                };

                _conn.Open();

                for (int i = 0; i < tblImported.Rows.Count; i++)
                {
                    cmd.CommandText = @"INSERT INTO [Runner]([" + tblImported.Columns[0].ColumnName.Trim() + "],["
                    + tblImported.Columns[1].ColumnName.Trim() + "],["
                    + tblImported.Columns[2].ColumnName.Trim() + "],["
                    + tblImported.Columns[3].ColumnName.Trim() + "],["
                    + tblImported.Columns[4].ColumnName.Trim() + "],["
                    + tblImported.Columns[5].ColumnName.Trim() + "],["
                    + tblImported.Columns[6].ColumnName.Trim() + "],["
                    + tblImported.Columns[7].ColumnName.Trim() + "],["
                    + tblImported.Columns[8].ColumnName.Trim() + "],["
                    + tblImported.Columns[9].ColumnName.Trim() + "],["
                    + tblImported.Columns[10].ColumnName.Trim() + "],["
                    + tblImported.Columns[11].ColumnName.Trim() + "],["
                    + tblImported.Columns[12].ColumnName.Trim() + "],["
                    + tblImported.Columns[13].ColumnName.Trim() + "],["
                    + tblImported.Columns[14].ColumnName.Trim() + "],["
                    + tblImported.Columns[15].ColumnName.Trim() + "],["
                    + tblImported.Columns[16].ColumnName.Trim() + "]) VALUES " +
                    " (@add0, @add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, " +
                    "  @add10, @add11, @add12, @add13, @add14, @add15, @add16)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@add0", tblImported.Rows[i].ItemArray.GetValue(0));
                    cmd.Parameters.AddWithValue("@add1", tblImported.Rows[i].ItemArray.GetValue(1));
                    cmd.Parameters.AddWithValue("@add2", tblImported.Rows[i].ItemArray.GetValue(2));
                    cmd.Parameters.AddWithValue("@add3", tblImported.Rows[i].ItemArray.GetValue(3));
                    cmd.Parameters.AddWithValue("@add4", tblImported.Rows[i].ItemArray.GetValue(4));
                    cmd.Parameters.AddWithValue("@add5", tblImported.Rows[i].ItemArray.GetValue(5));
                    cmd.Parameters.AddWithValue("@add6", tblImported.Rows[i].ItemArray.GetValue(6));
                    cmd.Parameters.AddWithValue("@add7", tblImported.Rows[i].ItemArray.GetValue(7));
                    cmd.Parameters.AddWithValue("@add8", tblImported.Rows[i].ItemArray.GetValue(8));
                    cmd.Parameters.AddWithValue("@add9", tblImported.Rows[i].ItemArray.GetValue(9));
                    cmd.Parameters.AddWithValue("@add10", tblImported.Rows[i].ItemArray.GetValue(10));
                    cmd.Parameters.AddWithValue("@add11", tblImported.Rows[i].ItemArray.GetValue(11));
                    cmd.Parameters.AddWithValue("@add12", tblImported.Rows[i].ItemArray.GetValue(12));
                    cmd.Parameters.AddWithValue("@add13", tblImported.Rows[i].ItemArray.GetValue(13));
                    cmd.Parameters.AddWithValue("@add14", tblImported.Rows[i].ItemArray.GetValue(14));
                    cmd.Parameters.AddWithValue("@add15", tblImported.Rows[i].ItemArray.GetValue(15));
                    cmd.Parameters.AddWithValue("@add16", tblImported.Rows[i].ItemArray.GetValue(16));

                    cmd.ExecuteNonQuery();
                }

                _conn.Close();

                string message = "File importato con successo!";
                MessageBox.Show(message);
                return tblImported;
            }

            catch (Exception ex)
            {
                throw new Exception("ERRORE DI SBAGLIO? EGOLO...  " + ex);
            }
        }
    }
}

