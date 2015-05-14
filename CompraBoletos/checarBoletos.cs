using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CompraBoletos
{
    public partial class checarBoletos : Form
    {
        public checarBoletos()
        {
            InitializeComponent();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            label.Text = btnA1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "datasource=localhost;port=3306;username=root;password=;database=conciertazo";
            string Query = "SELECT * FROM conciertazo.asiento WHERE as_numero= '"+label.Text+"';";
            MySqlConnection conDataBase = new MySqlConnection(connString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                string vendido = "";
                while (myReader.Read())
                {
                 vendido = myReader.GetString("as_status");
                    
                }
                if (vendido == "VENDIDO")
                {
                    MessageBox.Show("Boleto valido, puede pasar.");
                    conDataBase.Close();
                    conDataBase.Open();
                    string Query2 = "UPDATE asiento SET as_status='SIN VENDER' WHERE as_numero= '" + label.Text + "';";
                    MySqlCommand cmdDatabase2 = new MySqlCommand(Query2, conDataBase);
                    cmdDatabase2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Boleto no valido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al intentar conectar con la base de datos");
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            label.Text = btnA2.Text;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            label.Text = btnA3.Text;
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            label.Text = btnA4.Text;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            label.Text = btnB1.Text;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            label.Text = btnB2.Text;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            label.Text = btnB3.Text;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            label.Text = btnB4.Text;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            label.Text = btnC1.Text;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            label.Text = btnC2.Text;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            label.Text = btnC3.Text;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            label.Text = btnC4.Text;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
