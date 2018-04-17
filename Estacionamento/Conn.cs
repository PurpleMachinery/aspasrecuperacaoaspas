using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Estacionamento
{
     class Conn
    {
         SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=estacionamento;Data Source=LAB-08-08");
        public SqlConnection getConnection()
        {
            return this.conn;
        }
    }
}
