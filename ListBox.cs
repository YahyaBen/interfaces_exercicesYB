using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tp_2_Interfaces_Graphiques
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        SqlConnection Cnx = new SqlConnection("Data Source = HYRKUL; Initial Catalog = HyrkulDotNet4GI; Integrated Security = True");

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from ListerBox(Texte) where Texte ='"+Liste_Box.SelectedIndex.ToString()+"');";
            SqlCommand Insert = new SqlCommand(query, Cnx);
            Insert.ExecuteNonQuery();
            Afficher();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            string query = "insert into ListerBox(Texte) values('" + Text_Add.Text + "');";
            SqlCommand Insert = new SqlCommand(query, Cnx);
            Insert.ExecuteNonQuery();
            Afficher();
        }

        private void Button_Vider_Click(object sender, EventArgs e)
        {

        }

        private void Button_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Cnx.Close();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            
            Cnx.Open();
            Afficher();
        }

        public void Afficher()
        {
            string query = "select * from ListerBox";
            SqlCommand Insert = new SqlCommand(query, Cnx);
            SqlDataReader rd = Insert.ExecuteReader();
            while(rd.Read())
            {
                Liste_Box.Items.Add(rd[0]);
            }
            rd.Close();
        }
    }
}
