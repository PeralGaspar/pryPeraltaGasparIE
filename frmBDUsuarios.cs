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
using System.IO;

namespace pryPeraltaGasparIE
{
    public partial class frmBDUsuarios : Form
    {
        public frmBDUsuarios()
        {
            InitializeComponent();
        }
        clsControladorBD controlador = new clsControladorBD();
        private void frmBDUsuarios_Load(object sender, EventArgs e)
        {
            controlador.Traer_Datos(dgvUsuarios);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 ID = Int32.Parse(txtBuscar.Text);
            controlador.Buscar_Usuario(ID);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nom = txtUsuario.Text;
            string contra = txtContraseña.Text;
            controlador.Agregar(nom, contra);
            dgvUsuarios.Columns.Clear();
            controlador.Traer_Datos(dgvUsuarios);
        }
    }
}
