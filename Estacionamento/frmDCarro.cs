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
    public partial class frmDCarro : Form
    {
        public frmDCarro()
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
            String sql = "select modelo, cor, placa, fk_idCliente from carros where pk_idCarro= " + cmbId.Text;
            Conn conn = new Conn();
            SqlCommand comando = new SqlCommand(sql, conn.getConnection());
            conn.getConnection().Open();
            SqlDataReader data = comando.ExecuteReader();
            data.Read();
            txtModelo.Text = data.GetString(0);
            txtCor.Text = data.GetString(1);
            txtPlaca.Text = data.GetString(2);
            cmbCliente.Text = ""+data.GetInt32(3);
            conn.getConnection().Close();
        }
    }
}
