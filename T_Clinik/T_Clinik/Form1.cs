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
namespace T_Clinik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Pacijent pac = new Pacijent();
            pac.Adresa = txbAdresa.Text;
            pac.Ime = txbName.Text;
            if (rbtnM.Checked)
            {
                pac.Pol = true;
            }
            else 
            {
                pac.Pol = false;
            }

            pac.Prezime = txbSurname.Text;
            pac.Rodjenje = dTpBirth.Value;
            pac.Telefon = Convert.ToInt32(telefon.Text);

            SqlConnection sc = new SqlConnection("Data Source=MOJ-SI-JE\\SQLEXPRESS;Integrated Security=True");
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doktoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
