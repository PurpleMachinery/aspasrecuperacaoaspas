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
    public partial class frmDFuncionario : Form
    {
        public frmDFuncionario()
        {
            InitializeComponent();
        }

        private void cmbId_Click(object sender, EventArgs e)
        {
            cmbId.Items.Clear();
            String sql = "select pk_idFuncionario from funcionarios";
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            String sqlErr = "delete from funcionarios where pk_idfuncionario = " + cmbId.Text;
            SqlCommand comandoErr = new SqlCommand(sqlErr, conn.getConnection());
            conn.getConnection().Open();
            comandoErr.ExecuteNonQuery();
            conn.getConnection().Close();

            txtCPF.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtRegistro.Text = "";
            cmbId.Text = "";
        }

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            String sql = "select nome, cpf, telefone, registro from funcionarios where pk_idFuncionario = " + cmbId.Text;
            Conn conn = new Conn();
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            data.Read();
            txtNome.Text = data.GetString(0);
            txtCPF.Text = data.GetString(1);
            txtTelefone.Text = data.GetString(2);
            txtRegistro.Text = ""+ data.GetInt32(3);
            conn.getConnection().Close();
        }
    }
}
