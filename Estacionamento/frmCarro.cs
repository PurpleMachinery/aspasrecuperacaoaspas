using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estacionamento
{
    public partial class frmCarro : Form
    {
        public frmCarro()
        {
            InitializeComponent();
        }

        private void frmCarro_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            String sql = "select pk_idCliente from clientes";
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            while(data.Read())
            {
                cmbCliente.Items.Add(data.GetInt32(0));
            }
            conn.getConnection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCor.Text == "" || txtModelo.Text == "" || txtPlaca.Text == "" || cmbCliente.Text == "")
            {
                return;
            }
            else
            {
                Conn conn = new Conn();
                String sql = "insert into carros (modelo, cor, placa, fk_idCliente) values ('" + txtModelo.Text + "','" + txtCor.Text + "','" + txtPlaca.Text + "','" + cmbCliente.Text + "')";
                SqlCommand comando = new SqlCommand(sql, conn.getConnection());
                conn.getConnection().Open();
                comando.ExecuteNonQuery();
                conn.getConnection().Close();
            }
        }
    }
}
