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

namespace Gestion
{
    public partial class Gestion : Form
    {
        Functions Con;
        public Gestion()
        {
            InitializeComponent();
            Con = new Functions();
            ListClient();

        }
        private void ListClient()
        {
            string Req = "select * from MyClient";
            ListClientsdb.DataSource = Con.RecupererDonnees(Req);

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NomUtilZT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void search_Click(object sender, EventArgs e)
        {
            string NCIN = cin1.Text;
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=Gestion;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM MyClient WHERE CIN = @NCIN";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NCIN", NCIN);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gunaDataGridView1.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if(NomUtilZT.Text == "" || comboBox2.Text == "" || label6.Text == "" )
                {
                    MessageBox.Show("Information Incomplete!!!");
                }
                else
                {
                    string NCIN = cin1.Text;
                    string ANom = NomUtilZT.Text;
                    string Depart = comboBox2.Text;
                    string dat = date1.Text;
                    string Genre = comboBox1.Text;
                    string Req = "insert into MyClient values ('{0}','{1}','{2}','{3}','{4}')";
                    Req = string.Format(Req, NCIN, ANom, Depart, dat, Genre );
                    Con.EnvoyerDonnees(Req);
                    ListClient();
                    MessageBox.Show("Client Ajouté!!!");
                    cin1.Text = "";
                    NomUtilZT.Text = "";
                    comboBox2.Text = "";
                    date1.Text = "";
                    comboBox1.Text = "";
                }
            } 
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }

    
    }
}
