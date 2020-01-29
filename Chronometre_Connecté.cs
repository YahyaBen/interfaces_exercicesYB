using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tp_2_Interfaces_Graphiques
{
    public partial class Chronometre_Connecté : Form // Primary Key PROBLEMS - Delete done.
    {
        Int64 Count = 0;
        Temps A = new Temps();
        DateTime Date = DateTime.Now;
        public Chronometre_Connecté()
        {
            InitializeComponent();
        }
        SqlConnection Cn = new SqlConnection("Data Source = HYRKUL; Initial Catalog = HyrkulDotNet4GI; Integrated Security = True");

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Timer.Start();
            Button_Pause.Enabled = true;
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Count = 0;
            Temps A = new Temps();
            Text_Chrono.Text = A.minute(Count) + A.seconde(Count) + A.Millseconde(Count);
            DGV.Rows.Clear();
        }

        private void Button_Lap_Click(object sender, EventArgs e)
        {
            int index = int.Parse(DGV.CurrentCell.Value.ToString());
            if (Cn.State == ConnectionState.Open)
            {
               
                index++;
                string query = "insert into Table_Chronometre(Lap,Temps,Date,Time) values('"
                    + index + "','"
                    + Text_Chrono.Text.ToString() + "','"
                    + Date.ToString("d") + "','"
                    + Date.ToString("hh:mm:ss") + "')";
                SqlCommand Cmd = new SqlCommand(query, Cn);
                Cmd.ExecuteNonQuery();
            }

            DGV_Actualiser();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Count += 1;
            Text_Chrono.Text = A.minute(Count) + A.seconde(Count) + A.Millseconde(Count);
        }

        private void Chronometre_Connecté_Load(object sender, EventArgs e)
        {
            Button_Pause.Enabled = false;
            Cn.Open();
            DGV_Actualiser();
        }

        private void Button_Fermer_Click(object sender, EventArgs e)
        {
            Cn.Close();
            this.Close();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(DGV.CurrentCell.Value.ToString());
            string query = "delete from Table_Chronometre where Lap='"+index+"';";// Lap =/= Index WeEeeEeEeeW  !!! FINALLY // Primary Key !!
            SqlCommand Sele = new SqlCommand(query, Cn);
            Sele.ExecuteNonQuery();
            DGV_Actualiser();
        }

        public void DGV_Actualiser()
        {
            DGV.Rows.Clear();
            string query = "select * from Table_Chronometre";
            SqlCommand Sele = new SqlCommand(query, Cn);
            SqlDataReader rd = Sele.ExecuteReader();
            while (rd.Read())
            {
                DGV.Rows.Add(rd[0], rd[1], rd[2], rd[3]);
            }
            rd.Close();
        }
    }
}


