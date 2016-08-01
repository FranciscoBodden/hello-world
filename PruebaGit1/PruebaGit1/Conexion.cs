using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace PruebaGit1
{
    class Conexion
    {
        SqlConnection con = new SqlConnection("Data Source=FRANCISCOBODDEN\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;

        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado al servidor");
            }
            catch
            {
                MessageBox.Show("Error al conectar al servidor");
            }
            finally
            {
                con.Close();
            }
        }

        public void consulta(string sql,string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql,con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public bool insert(string sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
