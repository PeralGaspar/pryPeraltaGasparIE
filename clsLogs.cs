using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace pryPeraltaGasparIE
{
    class clsLogs
    {
        String sql = "SELECT * FROM Logs";
        FileInfo info = new FileInfo(@"../../Resources/Usuarios.accdb");
        string ruta;
        public string EstadoConexion = "Conectado";


        OleDbDataReader lector;
        OleDbConnection Conector;
        OleDbCommand Comandos;
        OleDbDataAdapter adaptador;
        DataSet objDataSet;
        public clsLogs()
        {
            try
            {
                ruta = info.FullName.ToString();

                Conector = new OleDbConnection();

                Comandos = new OleDbCommand(sql, Conector);

                String Connect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + ruta;
                Conector.ConnectionString = Connect;
                Conector.Open();
                Comandos.Connection = Conector;
                Comandos.CommandType = CommandType.Text;
                objDataSet = new DataSet();
            }
            catch (Exception error)
            {
                EstadoConexion = error.Message;
            }
        }
        public void RegistroLogInicioSesion(bool exito)
        {
            try
            {
                Comandos = new OleDbCommand();

                Comandos.Connection = Conector;
                Comandos.CommandType = System.Data.CommandType.TableDirect;
                Comandos.CommandText = "Logs";

                adaptador = new OleDbDataAdapter(Comandos);

                adaptador.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                if (exito == true)
                {
                    nuevoRegistro["Descripcion"] = "Inicio exitoso";
                }
                if (exito == false)
                {
                    nuevoRegistro["Descripcion"] = "Inicio Fallido";
                }


                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptador);
                adaptador.Update(objDataSet, "Logs");

                EstadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {

                EstadoConexion = error.Message;
            }

        }
    }
}
