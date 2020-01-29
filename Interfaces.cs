using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_2_Interfaces_Graphiques
{
    public partial class Interfaces : Form
    {
        public Interfaces()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GalculeVoyage A = new GalculeVoyage();
            A.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chronometre B = new Chronometre();
            B.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chronometre_Connecté C = new Chronometre_Connecté();
            C.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Incrementation D = new Incrementation();
            D.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListBox E = new ListBox();
            E.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
