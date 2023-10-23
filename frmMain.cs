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
        clsControladorBD control = new clsControladorBD();
        public string[] usuarios = {"Gaspar", "Profe"};
        public string[] contraseña = { "Shedinja", "123"};
        public Int32 cod = -1;
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            

            if (txtContraseña.Text == contraseña[cod])
            {
                Form menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            

            if (usuarios.Contains(txtUsuario.Text))
            {
                for (int i = 0; i < usuarios.Length; i++)
                {
                    if (usuarios[i] == txtUsuario.Text)
                    {
                        cod = i;
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContraseña.Text;
        }
    }
}
