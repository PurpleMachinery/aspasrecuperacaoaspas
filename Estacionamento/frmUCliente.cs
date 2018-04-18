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
    public partial class frmUCliente : Form
    {
        public frmUCliente()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "" || txtNome.Text == "" || txtTelefone.Text == "" || cmbId.Text == "")
            {
                return;
            }
            else
            {
                String sql = "update clientes set nome = '" + txtNome.Text + "', cpf = '" + txtCPF.Text + "', telefone = '" + txtTelefone.Text + "' where pk_idCliente = '" + cmbId.Text;
                Conn conn = new Conn();
                SqlCommand comando = new SqlCommand(sql, conn.getConnection());
                conn.getConnection().Open();
                comando.ExecuteNonQuery();
                conn.getConnection().Close();
            }
        }

        private void cmbId_Click(object sender, EventArgs e)
        {
            cmbId.Items.Clear();
            String sql = "select pk_idCliente from clientes";
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
            String sql = "select nome, cpf, telefone from clientes where pk_idCliente = " + cmbId.Text;
            Conn conn = new Conn();
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            data.Read();
            txtNome.Text = data.GetString(0);
            txtCPF.Text = data.GetString(1);
            txtTelefone.Text = data.GetString(2);
            conn.getConnection().Close();
        }
    }
}
