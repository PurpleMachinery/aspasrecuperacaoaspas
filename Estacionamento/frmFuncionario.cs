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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "" || txtNome.Text == "" || txtTelefone.Text == ""||txtRegistro.Text == "")
            {
                return;
            }
            else
            {
                String sql = "insert into funcionarios (nome, telefone, cpf, registro) values ('" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtCPF.Text + "','"+txtRegistro.Text+"')";
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
