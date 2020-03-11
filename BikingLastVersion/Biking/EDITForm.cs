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
    public partial class EDITForm : Form
    {
        AccessOperations accessOperations = new AccessOperations();
        static public DataTable _updatedDataTable;

        public EDITForm(DataTable dataTable)
        {
            InitializeComponent();
            DataTable _updatedDataTable = dataTable;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(accessOperations._accessConnectionString1);
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conn,
                CommandType = CommandType.Text
            };

            cmd.CommandText = "UPDATE [Runner] SET [IdGara] = @IdGara, [NomeGara] = @NomeGara, [NomeTesserato] = @NomeTesserato, [CodiceFci] = @CodiceFci, [Categoria] = @Categoria, [CodiceUci] = @CodiceUci, [Nazionalità] = @Nazionalità, [DataNascita] = @DataNascita, [NomeSocieta] = @NomeSocieta, [CodiceSocieta] = @CodiceSocieta, [CodiceFiscale] = @CodiceFiscale, [Sesso] = @Sesso, [Note] = @Note, [Cognome] = @Cognome, [Nome] = @Nome, [Riserva] = @Riserva WHERE [CodiceFiscale] = @CodiceFiscale;";

            conn.Open();

                #region parameters
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@IdGara", textBox2.Text);

                cmd.Parameters.AddWithValue("@NomeGara", textBox3.Text);

                cmd.Parameters.AddWithValue("@NomeTesserato", textBox10.Text);

                cmd.Parameters.AddWithValue("@CodiceFCI", textBox9.Text);

                cmd.Parameters.AddWithValue("@Categoria", textBox8.Text);

                cmd.Parameters.AddWithValue("@CodiceUci", textBox7.Text);

                cmd.Parameters.AddWithValue("@Nazionalità", textBox4.Text);

                cmd.Parameters.AddWithValue("@DataNascita", textBox5.Text);

                cmd.Parameters.AddWithValue("@NomeSocieta", textBox6.Text);

                cmd.Parameters.AddWithValue("@CodiceSocieta", textBox12.Text);

                cmd.Parameters.AddWithValue("@CodiceFiscale", textBox13.Text);

                cmd.Parameters.AddWithValue("@Sesso", textBox14.Text);

                cmd.Parameters.AddWithValue("@Note", textBox15.Text);

                cmd.Parameters.AddWithValue("@Cognome", textBox16.Text);

                cmd.Parameters.AddWithValue("@Nome", textBox17.Text);

                cmd.Parameters.AddWithValue("@Riserva", textBox18.Text);

                cmd.ExecuteNonQuery();
                #endregion
                conn.Close();
            
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(accessOperations._accessConnectionString1);
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conn,
                CommandType = CommandType.Text
            };

            cmd.CommandText = "DELETE FROM [Runner] WHERE [CodiceFiscale] = @CodiceFiscale;";

            conn.Open();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@CodiceFiscale", textBox13.Text);

            var confirmResult = MessageBox.Show("Vuoi davvero eliminare questo atleta?", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();

                string message = "Atleta Eliminato!";

                MessageBox.Show(message);

                conn.Close();

                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
