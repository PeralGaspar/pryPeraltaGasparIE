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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int intentos = 0;
        clsControladorBD control = new clsControladorBD();
        clsLogs logs = new clsLogs();
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContraseña.Text;
            if (control.Buscar_Contraseña(user, password) == true)
            {
                logs.RegistroLogInicioSesion(true);
                Form menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            intentos += 1;
            if (intentos == 3)
            {
                logs.RegistroLogInicioSesion(false);
                txtContraseña.Enabled = false;
                txtUsuario.Enabled = false;
                MessageBox.Show("Demasiados Intentos Fallidos.",
                                "Bloqueo Automatico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
