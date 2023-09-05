using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomUtilZT.Text == "" || MotDePasseZT.Text == "")
            {
                MessageBox.Show("Infocomplete!!!");
            }
            else if(NomUtilZT.Text == "Admin" && MotDePasseZT.Text == "Admin")
            {
                Gestion Obj = new Gestion();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreurs!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NomUtilZT.Text = "";
            MotDePasseZT.Text = "";
        }
    }
}
