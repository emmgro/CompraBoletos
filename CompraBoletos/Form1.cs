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
    public partial class Form1 : Form
    {
        void sqlConn() {
            string connString = "datasource=localhost;port=3306;username=root;password=;database=conciertazo";
            string Query = "SELECT * FROM conciertazo.asiento WHERE as_status= 'VENDIDO';";
            MySqlConnection conDataBase = new MySqlConnection(connString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while(myReader.Read()){
                    string vendido = myReader.GetString("as_numero");
                    listBox5.Items.Add(vendido);

                }
                //MessageBox.Show("Conexion con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al intentar conectar con la base de datos");
            }
        }
        public Form1()
        {
            InitializeComponent();
            sqlConn();
            for (int i = 0; i < listBox5.Items.Count; i++ ) {
                string aux = listBox5.Items[i].ToString();
                if(aux == "A1"){
                    btnA1.Visible = false;
                }
                if (aux == "A2")
                {
                    btnA2.Visible = false;
                }
                if (aux == "A4")
                {
                    btnA4.Visible = false;
                }
                if (aux == "A3")
                {
                    btnA3.Visible = false;
                }
                if (aux == "B1")
                {
                    btnB1.Visible = false;
                }
                if (aux == "B2")
                {
                    btnB2.Visible = false;
                }
                if(aux == "B3"){
                    btnB3.Visible = false;
                }
                if (aux == "B4")
                {
                    btnB4.Visible = false;
                }
                if (aux == "C1")
                {
                    btnC1.Visible = false;
                }
                if (aux == "C2")
                {
                    btnC2.Visible = false;
                }
                if (aux == "C3")
                {
                    btnC3.Visible = false;
                }
                if (aux == "C4")
                {
                    btnC4.Visible = false;
                }
            
            }
            listBox5.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnA1.Text);
            btnA1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            if (btnA1.Visible == false) {
                btnA1.Visible = true;
            }
            if (btnA2.Visible == false)
            {
                btnA2.Visible = true;
            }
            if (btnA3.Visible == false)
            {
                btnA3.Visible = true;
            }
            if (btnA4.Visible == false)
            {
                btnA4.Visible = true;
            }
            if (btnB1.Visible == false)
            {
                btnB1.Visible = true;
            }
            if (btnB2.Visible == false)
            {
                btnB2.Visible = true;
            }
            if (btnB3.Visible == false)
            {
                btnB3.Visible = true;
            }
            if (btnB4.Visible == false)
            {
                btnB4.Visible = true;
            }
            if (btnC1.Visible == false)
            {
                btnC1.Visible = true;
            }
            if (btnC2.Visible == false)
            {
                btnC2.Visible = true;
            }
            if (btnC3.Visible == false)
            {
                btnC3.Visible = true;
            }
            if (btnC4.Visible == false)
            {
                btnC4.Visible = true;
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnA2.Text);
            btnA2.Visible = false;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnA3.Text);
            btnA3.Visible = false;
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnA4.Text);
            btnA4.Visible = false;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnB1.Text);
            btnB1.Visible = false;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnB2.Text);
            btnB2.Visible = false;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnB3.Text);
            btnB3.Visible = false;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnB4.Text);
            btnB4.Visible = false;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnC1.Text);
            btnC1.Visible = false;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnC2.Text);
            btnC2.Visible = false;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnC3.Text);
            btnC3.Visible = false;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(btnC4.Text);
            btnC4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "datasource=localhost;port=3306;username=root;password=;database=conciertazo";
            //string Query = "INSERT INTO asiento(as_status) WHERE as_numero='"+aux+"';";
            MySqlConnection conDataBase = new MySqlConnection(connString);
            
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                string concat = "";
                for (int i = 0; i < listBox5.Items.Count; i++)
                {
                    string aux = listBox5.Items[i].ToString();
                    concat = concat + aux;
                    string Query = "UPDATE asiento SET as_status='VENDIDO' WHERE as_numero= '"+aux+"';";
                    MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
                    cmdDatabase.ExecuteNonQuery();
                    string Query2 = "INSERT INTO cliente(cl_nom) VALUES('"+textBox1.Text+"');";
                    MySqlCommand cmdDatabase2 = new MySqlCommand(Query2, conDataBase);
                    cmdDatabase.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al intentar conectar con la base de datos");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            checarBoletos settingsForm = new checarBoletos();
            settingsForm.Show();
        }
    }
}
