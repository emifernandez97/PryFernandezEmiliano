using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mysql.Data.MySqlClient;
using System.Data.OleDb;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.IO;



namespace PryFernandezE
{
    internal class ClsConexionBDD
    {
        public void ConexionBaseDatos(ToolStripStatusLabel TstpBD) 
        {
            try 
            {
                string Conexion =
                "Server=127.0.0.1" +
                ";Database=juegorol" +
                ";Uid=root" +
                ";Pwd=;";

                MySqlConnection Conn = new MySqlConnection(Conexion);
                Conn.Open();

                /*
                TstpBD.Text = "Conectado";
                TstpBD.BackColor = Color.Green;
                  */
            } 
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
