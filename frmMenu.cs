using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPeraltaGasparIE
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        clsLogs logs = new clsLogs();
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAseguradores_Click(object sender, EventArgs e)
        {
            logs.RegistroLogInicioSesion(true, "Ingreso a Aseguradores");
            this.Hide();
            Form aseguradores = new frmCargar();
            aseguradores.Show();
        }

        private void btnCarpetas_Click(object sender, EventArgs e)
        {

            logs.RegistroLogInicioSesion(true, "Ingreso a Carpetas");
            this.Hide();
            Form carpetas = new frmCarpetas();
            carpetas.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

            logs.RegistroLogInicioSesion(true, "Ingreso a Proveedores");
            this.Hide();
            Form proveedores = new frmProvedores();
            proveedores.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            logs.RegistroLogInicioSesion(true, "Ingreso a Usuarios");
            this.Hide();
            Form usuarios = new frmBDUsuarios();
            usuarios.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            logs.RegistroLogInicioSesion(true, "Cierre de Aplicacion");
            this.Close();
        }
    }
}
