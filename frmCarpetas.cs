using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPeraltaGasparIE
{
    public partial class frmCarpetas : Form
    {
        public frmCarpetas()
        {
            InitializeComponent();
        }
        public string ruta = "";

        private void btnCarpetas_Click(object sender, EventArgs e)
        {
            
            listaCarpetas.ShowDialog();
            ruta = listaCarpetas.SelectedPath;
            lblEjemplo.Text = ruta;
            string[] files = Directory.GetFiles(ruta);
            foreach (string file in files)
            {
                lstFiles.Items.Add(Path.GetFileName(file));
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nom = ruta + "/" + txtArchivo.Text;
            StreamWriter manejoArchivo = new StreamWriter(nom);
            manejoArchivo.Write(txtWrite.Text);
            manejoArchivo.Close();
            MessageBox.Show("Se genero el archivo");
        }
    }
}
