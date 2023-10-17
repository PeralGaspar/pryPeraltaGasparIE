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
            String sql = "SELECT * FROM Usuarios";
            //Definicion de objetos de manejo de Base de Datos
            OleDbConnection Conector = new OleDbConnection();
            OleDbCommand Comandos = new OleDbCommand(sql, Conector);
            OleDbDataReader lector;
            //Cadena de connecion
            
            
            //directoryinfo

            String Connect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +"Usuarios.accdb";
            //Asignacion
            Conector.ConnectionString = Connect;
            //Abrimos base de datos
            Conector.Open();
            //Aignamos Comandos
            Comandos.Connection = Conector;
            Comandos.CommandType = CommandType.Text;
            
            //lectura de la tabla
            lector = Comandos.ExecuteReader();
            //Comprovar si existe
            if(lector.HasRows)
            {
                lector.Close();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(Comandos);
                DataTable Usuarios = new DataTable();
                adaptador.Fill(Usuarios);
                dgvUsuarios.DataSource = Usuarios;
            }
        }
    }
}
