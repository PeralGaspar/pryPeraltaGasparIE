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
        public string[] usuarios = {"Gaspar", "Profe"};
        public string[] contraseña = { "Shedinja", "123"};
        public Int32 cod = -1;
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContraseña.Text;
            Int32 ID = control.Buscar_ID(user);
            if (control.Buscar_Contraseña(password, ID) == true)
            {
                Form menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            intentos += 1;
            if (intentos == 3)
            {
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
