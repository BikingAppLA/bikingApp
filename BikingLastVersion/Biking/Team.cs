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

        public delegate void delPassData(TextBox text);

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
    }
}
