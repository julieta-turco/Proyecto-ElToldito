using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();
            string sql = "select * from Factura";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
