using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryPeraltaGasparIE
{
    class clsControladorBD
    {

        String sql = "SELECT * FROM Usuarios";
        FileInfo info = new FileInfo(@"../../Resources/Usuarios.accdb");
        string ruta;


        OleDbDataReader lector;
        OleDbConnection Conector;
        OleDbCommand Comandos;

        public clsControladorBD()
        {
            ruta = info.FullName.ToString();

            Conector = new OleDbConnection();

            Comandos = new OleDbCommand(sql, Conector);
            
            String Connect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + ruta;
            //Asignacion
            Conector.ConnectionString = Connect;
            //Definicion de objetos de manejo de Base de Datos
            //Abrimos base de datos
            Conector.Open();
            //Aignamos Comandos
            Comandos.Connection = Conector;
            Comandos.CommandType = CommandType.Text;
        }

        public void Traer_Datos(DataGridView grilla)
        {
            //lectura de la tabla
            lector = Comandos.ExecuteReader();
            //Comprovar si existe
            if (lector.HasRows)
            {
                lector.Close();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(Comandos);
                DataTable Usuarios = new DataTable();
                adaptador.Fill(Usuarios);
                grilla.DataSource = Usuarios;
            }
        }
        public void Buscar_Usuario(int Usuario)
            {
                OleDbDataReader lector;
                lector = Comandos.ExecuteReader();
                if (lector.HasRows)
                {
                    bool existe = false;
                    while (lector.Read())
                    {
                        if (int.Parse(lector[0].ToString()) == Usuario)
                        {
                            MessageBox.Show("Cliente Existe",
                                "Consulta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            existe = true;
                            break;
                        }
                    }
                    if (existe == false)
                    {
                        MessageBox.Show("Cliente No Existe",
                                "Consulta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    lector.Close();
                }
            }
        public void Buscar_ID(string ID)
        {
            OleDbDataReader lector;
            lector = Comandos.ExecuteReader();
            if (lector.HasRows)
            {
                int existe = -1;
                while (lector.Read())
                {
                    if (lector[1].ToString() == ID)
                    {
                        
                        break;
                    }
                }
                if (existe == false)
                {
                    MessageBox.Show("Cliente No Existe",
                            "Consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                lector.Close();
            }
        }
    }
}
