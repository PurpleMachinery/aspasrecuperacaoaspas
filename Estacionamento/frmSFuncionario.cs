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
    public partial class frmSFuncionario : Form
    {
        public frmSFuncionario()
        {
            InitializeComponent();
        }

        private void frmSFuncionario_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            String sql = "select * from funcionarios";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn.getConnection());
            DataSet set = new DataSet();
            adap.Fill(set);
            dataFuncionario.DataSource = set;
            dataFuncionario.DataMember = set.Tables[0].TableName;
        }
    }
}
