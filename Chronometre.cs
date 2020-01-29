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
    public partial class Chronometre : Form
    {

        
        Int64 Count = 0;
        int Lap = 1;
        Temps A = new Temps();
        DateTime Date = DateTime.Today;
        // 
        public Chronometre()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Count = 0;
            Temps A = new Temps();
            Text_Chrono.Text = A.minute(Count)+A.seconde(Count)+A.Millseconde(Count);
            DGV.Rows.Clear();
        }

        private void Button_Lap_Click(object sender, EventArgs e)
        {
            DGV.Rows.Add(Lap,Text_Chrono.Text,Date.ToString("d"));
            Lap++;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Count += 1;
            Text_Chrono.Text = A.minute(Count) + A.seconde(Count) + A.Millseconde(Count);
        }
    }
}
