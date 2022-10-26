using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            //OleDbConnection con = new OleDbConnection(cadena);
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión Exitosa");
                    btnSalir.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
            con.Close();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            btnSalir.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=toldito;Uid=root;Pwd=Enigma28";
            
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión Exitosa");
                    btnSalir.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=Toldito;Uid=sa;Pwd=Enigma28";

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión Exitosa");
                    btnSalir.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
