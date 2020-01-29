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
    public partial class Incrementation : Form
    {
        public Incrementation()
        {
            InitializeComponent();
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            int A = int.Parse(Text_Saisie.Text);
            A++;
            Text_Saisie.Text = A.ToString();
        }

        private void Button_Moin_Click(object sender, EventArgs e)
        {
            int A = int.Parse(Text_Saisie.Text);
            A--;
            Text_Saisie.Text = A.ToString();
        }
    }
}
