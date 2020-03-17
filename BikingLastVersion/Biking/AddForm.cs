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
    public partial class AddForm : Form
    {
        AccessOperations accessOperations = new AccessOperations();
        public DataTable _updatedDataTable;

        public AddForm(DataTable dataTable)
        {
            InitializeComponent();
            _updatedDataTable = dataTable;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(accessOperations._accessConnectionString1);
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conn,
                CommandType = CommandType.Text
            };
            try
            {
                cmd.CommandText = @"INSERT INTO [Runner] ([IdGara], [NomeGara], [DorsaleNumero], [NomeTesserato], [CodiceFCI], [Categoria], " +
                    "[CodiceUci], [Nazionalità], [DataNascita], [NomeSocieta], [CodiceSocieta], [CodiceFiscale], [Sesso],[Note], [Cognome], [Nome], " +
                    "[Riserva], [Tempo], [Punti]) " +
                    "VALUES (@IdGara, @NomeGara, @DorsaleNumero, @NomeTesserato, @CodiceFCI, @Categoria, @CodiceUci, @Nazionalità, " +
                    "@DataNascita, @NomeSocieta, @CodiceSocieta, @CodiceFiscale, @Sesso, @Note, @Cognome, @Nome, @Riserva, @Tempo, @Punti)";

                conn.Open();
            }

            catch (Exception ex)
            {
                throw new Exception("ERRORE:    " + ex);
            }

            try
            {
                #region parameters

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@IdGara", this.textBox2.Text.ToString());

                cmd.Parameters.AddWithValue("@NomeGara", this.textBox3.Text.ToString());

                cmd.Parameters.AddWithValue("@DorsaleNumero", this.textBox11.Text.ToString());

                cmd.Parameters.AddWithValue("@NomeTesserato", this.textBox10.Text.ToString());

                cmd.Parameters.AddWithValue("@CodiceFCI", this.textBox9.Text.ToString());

                cmd.Parameters.AddWithValue("@Categoria", this.textBox8.Text.ToString());

                cmd.Parameters.AddWithValue("@CodiceUci", this.textBox7.Text.ToString());

                cmd.Parameters.AddWithValue("@Nazionalità", this.textBox4.Text.ToString());

                cmd.Parameters.AddWithValue("@DataNascita", this.textBox5.Text.ToString());

                cmd.Parameters.AddWithValue("@NomeSocieta", this.textBox6.Text.ToString());

                cmd.Parameters.AddWithValue("@CodiceSocieta", this.textBox12.Text.ToString());

                cmd.Parameters.AddWithValue("@CodiceFiscale", this.textBox13.Text.ToString());

                cmd.Parameters.AddWithValue("@Sesso", this.textBox14.Text.ToString());

                cmd.Parameters.AddWithValue("@Note", this.textBox15.Text.ToString());

                cmd.Parameters.AddWithValue("@Cognome", this.textBox16.Text.ToString());

                cmd.Parameters.AddWithValue("@Nome", this.textBox17.Text.ToString());

                cmd.Parameters.AddWithValue("@Riserva", this.textBox18.Text.ToString());

                cmd.Parameters.AddWithValue("@Tempo", this.textBox19.Text.ToString());

                cmd.Parameters.AddWithValue("@Punti", this.textBox20.Text.ToString());

                cmd.ExecuteNonQuery();
                #endregion
                conn.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("DOVE XE BUGO? .... :" + ex);
            }
            this.Close();
        }
    }
}
