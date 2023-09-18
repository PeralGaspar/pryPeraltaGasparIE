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
    public partial class frmCargar : Form
    {
        public frmCargar()
        {
            InitializeComponent();
        }
        public bool BanderaNum = false;
        public bool BanderaEnt = false;
        public bool BanderaDir = false;
        public bool BanderaAper = false;
        public bool BanderaNExp = false;
        public bool BanderaJuz = false;
        public bool BanderaJur = false;
        public bool BanderaRes = false;

        private void button1_Click(object sender, EventArgs e)
        {
            string leerlinea = "";
            string[] separarDatos = new string[0];
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            StreamReader grilla = new StreamReader(@"../../" + "Resources/Listado de aseguradores.csv");
            leerlinea = grilla.ReadLine();
            separarDatos = leerlinea.Split(';');
            foreach (String var in separarDatos)
            {
                dataGridView1.Columns.Add(var, var);
            }
            while (grilla.EndOfStream == false)
                {
                leerlinea = grilla.ReadLine();
                separarDatos = leerlinea.Split(';');
                dataGridView1.Rows.Add(separarDatos);
                }
            grilla.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nuevo = "";
            StreamWriter objSw = new StreamWriter(@"../../" + "Resources/Listado de aseguradores.csv", true);
            nuevo = txtNum.Text + ";" + txtEnt.Text + ";" + txtAper.Text + ";" + txtNExpe + ";"
                + txtJuz.Text + ";" + txtJuriz.Text + ";" + txtDir.Text + ";" + txtRespon.Text;
            objSw.WriteLine(nuevo);
            
            objSw.Close();
            MessageBox.Show("Registrado");
            txtNum.Text = "";
            txtAper.Text = "";
            txtDir.Text = "";
            txtEnt.Text = "";
            txtJuriz.Text = "";
            txtJuz.Text = "";
            txtNExpe.Text = "";
            txtRespon.Text = "";
            txtNum.Focus();
            txtAper.Focus();
            txtDir.Focus();
            txtEnt.Focus();
            txtJuriz.Focus();
            txtJuz.Focus();
            txtNExpe.Focus();
            txtRespon.Focus();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            BanderaNum = false;
            if (Int32.TryParse(txtNum.Text, out Int32 result))
            {
                BanderaNum = true;
            }
        }
    }
}
