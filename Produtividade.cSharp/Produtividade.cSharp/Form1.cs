using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produtividade.cSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void semPrioridadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            var cs = new Casa();
            cs.ShowDialog();

        }

        private void prioridadesCriadas9ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var src = new Emprego();
            src.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var es = new Estudos();
            es.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            var lz = new Lazer();
            lz.ShowDialog();
        }

        private void prioridadesCriadas3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prio = new Prio_casa();
            prio.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var prio = new Prio_emprego();
            prio.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var prio = new Prio_estudo();
            prio.ShowDialog();
        }

        private void prioridadesCriadas9ToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            var prio = new Prio_lazer();
            prio.ShowDialog();
        }
    }
}
