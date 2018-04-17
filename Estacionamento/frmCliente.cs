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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                return;
            }
            else
            {
                String sql = "insert into clientes (nome, telefone, cpf) values ('" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtCPF.Text + "')";
                Conn conn = new Conn();
                SqlCommand comando = new SqlCommand(sql, conn.getConnection());
                conn.getConnection().Open();
                comando.ExecuteNonQuery();
                MessageBox.Show(sql);
                conn.getConnection().Close();
            }                    
        }
    }
}
