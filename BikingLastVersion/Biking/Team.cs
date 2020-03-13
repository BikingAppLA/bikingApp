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
    public partial class Team : Form
    {
        public static DataTable _table = new DataTable();
       
        public Team()
        {
            InitializeComponent();

        }

        private void ReturnButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Runner1_Click(object sender, EventArgs e)
        {
            RunnerList runnerList = new RunnerList(this);
            runnerList.FormClosed += new FormClosedEventHandler(RunnerList_FormClosed);
            this.Hide();
            runnerList.ShowDialog();
        }

        void RunnerList_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        
    }
}
