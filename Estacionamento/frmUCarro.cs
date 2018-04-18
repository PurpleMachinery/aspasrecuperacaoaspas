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
    public partial class frmUCarro : Form
    {
        public frmUCarro()
        {
            InitializeComponent();
        }

        private void cmbId_Click(object sender, EventArgs e)
        {
            cmbId.Items.Clear();
            String sql = "select pk_idCarro from carros";
            Conn conn = new Conn();
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            while (data.Read())
            {
                cmbId.Items.Add(data.GetInt32(0));
            }
            conn.getConnection().Close();
        }

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            String sql = "select modelo, cor, placa, fk_idCliente from carros where pk_idCarro = " + cmbId.Text;
            Conn conn = new Conn();
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            data.Read();
            txtModelo.Text = data.GetString(0);
            txtCor.Text = data.GetString(1);
            txtPlaca.Text = data.GetString(2);
            cmbCliente.Text = "" + data.GetInt32(3);
            conn.getConnection().Close();
        }

        private void cmbCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.Items.Clear();
            Conn conn = new Conn();
            String sql = "select pk_idCliente from clientes";
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            while (data.Read())
            {
                cmbCliente.Items.Add(data.GetInt32(0));
            }
            conn.getConnection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCor.Text == "" || txtModelo.Text == "" || txtPlaca.Text == "" || cmbId.Text == "" || cmbCliente.Text == "")
            {
                return;
            }
            else
            {
                String sql = "update carros set modelo = '" + txtModelo.Text + "', cor = '" + txtCor.Text + "', fk_idCliente = '" + cmbCliente.Text + "', placa = '" + txtPlaca.Text + "' where pk_idCarro = " + cmbId.Text;
                Conn conn = new Conn();
                SqlCommand comando = new SqlCommand(sql, conn.getConnection());
                conn.getConnection().Open();
                comando.ExecuteNonQuery();
                conn.getConnection().Close();
            }
        }
    }
}
