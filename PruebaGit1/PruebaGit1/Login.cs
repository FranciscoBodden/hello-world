using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO Usuario.Usuarios(Usuario,Password) VALUES ('" + textBox1.Text+"','"+textBox2.Text+"')";
            if(con.insert(agregar))
            {
                MessageBox.Show("Datos agregados");
              //  mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }
        Conexion con = new Conexion();
        private void Login_Load(object sender, EventArgs e)
        {
            con.conectar();
            
        }
        public void mostrarDatos()
        {
         //  con.consulta("select * from Usuarios")
        }
    }
}
