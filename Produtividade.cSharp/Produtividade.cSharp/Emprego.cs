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
    public partial class Emprego : Form
    {


        public Emprego()
        {
            InitializeComponent();
        }


        DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

        public static string combo12
        {
            get; set;


        }
        public static string combo11
        {
            get; set;

        }
        public static string combo10
        {
            get; set;

        }
        public static string combo9
        {
            get; set;

        }
        public static string combo8
        {
            get; set;

        }
        public static string combo7
        {
            get; set;

        }
        public static string combo6
        {
            get; set;

        }
        public static string combo5
        {
            get; set;

        }
        public static string combo4
        {
            get; set;

        }
        public static string combo3
        {
            get; set;

        }
        public static string combo2
        {
            get; set;

        }
        public static string combo1
        {
            get; set;

        }

        private void Emprego_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            combo1 = cmbQntPrio1.Text;
            combo2 = cmbprio2.Text;
            combo3 = cmbprio3.Text;
            combo4 = cmbprio4.Text;
            combo5 = cmbprio5.Text;
            combo6 = cmbprio6.Text;
            combo7 = cmbprio7.Text;
            combo8 = cmbprio8.Text;
            combo9 = cmbprio9.Text;
            combo10 = cmbprio10.Text;
            combo11 = cmbprio11.Text;
            combo12 = cmbprio12.Text;

            MessageBox.Show("informado com sucesso !!!");
        }
    }
}
