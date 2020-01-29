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
    public partial class GalculeVoyage : Form
    {
        public GalculeVoyage()
        {
            InitializeComponent();
        }

        private void GalculeVoyage_Load(object sender, EventArgs e)
        {

        }

        private void Button_Calculer_Click(object sender, EventArgs e)
        {
            int A = int.Parse(Text_Consomation.Text);
            int B = int.Parse(Text_Kilometres.Text);
            int C = int.Parse(Text_PrixEss.Text);

            Label_Resulat.Text =
                " " + (A * B * C)/100+ " Euro's";
        }
    }
}
