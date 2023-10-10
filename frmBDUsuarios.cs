using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryPeraltaGasparIE
{
    public partial class frmBDUsuarios : Form
    {
        public frmBDUsuarios()
        {
            InitializeComponent();
        }

        private void frmBDUsuarios_Load(object sender, EventArgs e)
        {
            //Definicion de objetos de manejo de Base de Datos
            OleDbConnection Conector = new OleDbConnection();
            OleDbCommand Comandos = new OleDbCommand();
            OleDbDataReader lector;
            //Cadena de connecion
            String Connect = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=@../../"+ "Resources/Usuarios.accdb";
            //Asignacion
            Conector.ConnectionString = Connect;
            //Abrimos base de datos
            Conector.Open();
            //Aignamos Comandos
            Comandos.Connection = Conector;
            Comandos.CommandType = CommandType.TableDirect;
            Comandos.CommandText = "Usuarios";
            //lectura de la tabla
            lector = Comandos.ExecuteReader();
            //Comprovar si existe
            if(lector.HasRows)
            {
                String datos = "";

                while(lector.Read())
                {
                    datos += lector.GetInt32(0).ToString() + ", " + lector.GetString(1) + lector.GetString(2);
                }
                //Mostrar Datos
                lblTest.Text = datos;
            }
        }
    }
}
