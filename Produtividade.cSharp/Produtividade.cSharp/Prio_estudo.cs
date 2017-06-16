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
    public partial class Prio_estudo : Form
    {
        public Prio_estudo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dado1 = Casa.combo1;
            label13.Text = dado1;
            var dado2 = Casa.combo2;
            label14.Text = dado2;
            var dado3 = Casa.combo3;
            label15.Text = dado3;
            var dado4 = Casa.combo4;
            label16.Text = dado4;
            var dado5 = Casa.combo5;
            label17.Text = dado5;
            var dado6 = Casa.combo6;
            label18.Text = dado6;
            var dado7 = Casa.combo7;
            label19.Text = dado7;
            var dado8 = Casa.combo8;
            label20.Text = dado8;
            var dado9 = Casa.combo9;
            label21.Text = dado9;
            var dado10 = Casa.combo10;
            label22.Text = dado10;
            var dado11 = Casa.combo11;
            label23.Text = dado11;
            var dado12 = Casa.combo12;
            label24.Text = dado12;

        }
    }
}
