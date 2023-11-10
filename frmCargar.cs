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
        clsLogs logs = new clsLogs();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNum.Text, txtEnt.Text, txtAper.Text, txtNExpe.Text, txtJuz.Text, txtJuriz.Text,txtDir.Text, txtRespon.Text);
           
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
            btnGrabar.Enabled = false;
            txtNum.Enabled = true;
            txtAper.Enabled = true;
            txtDir.Enabled = true;
            txtEnt.Enabled = true;
            txtJuriz.Enabled = true;
            txtJuz.Enabled = true;
            txtNExpe.Enabled = true;
            txtRespon.Enabled = true;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(txtNum.Text, out Int32 result)&& txtNExpe.Text != null
                &&txtAper.Text !=null && txtDir.Text != null && txtRespon.Text != null && txtEnt.Text != null && txtJuz.Text != null
                && txtJuriz.Text != null && btnGrabar.Enabled == false)
            {
                btnGrabar.Enabled = true;
                txtNum.Enabled = false;
                txtAper.Enabled = false;
                txtDir.Enabled = false;
                txtEnt.Enabled = false;
                txtJuriz.Enabled = false;
                txtJuz.Enabled = false;
                txtNExpe.Enabled = false;
                txtRespon.Enabled = false;
                btnVerificar.Text = "Editar Datos";
                MessageBox.Show("Datos Validos");
            }
            else
            {
                btnGrabar.Enabled = false;
                txtNum.Enabled = true;
                txtAper.Enabled = true;
                txtDir.Enabled = true;
                txtEnt.Enabled = true;
                txtJuriz.Enabled = true;
                txtJuz.Enabled = true;
                txtNExpe.Enabled = true;
                txtRespon.Enabled = true;
                btnVerificar.Text = "Verificar";
                MessageBox.Show("Edicion de Datos Habilitada");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 ID = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[ID].SetValues(txtNum.Text, txtEnt.Text,txtAper.Text,txtNExpe.Text,txtJuz.Text,txtJuriz.Text,txtDir,txtRespon.Text);
            MessageBox.Show("Fila Modificada");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 ID = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(ID);
            MessageBox.Show("Fila Elimonada");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter sWriter = new StreamWriter
                    (@"../../" + "Resources/Lista Aseguradores.csv", true);

                //Escribimos los titulos al archivo
                for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        sWriter.Write(";");
                    }
                    sWriter.Write(dataGridView1.Columns[i].HeaderText);
                }
                sWriter.WriteLine();

                //Escribimos filas del gridview al archivo
                for (int j = 0; j <= dataGridView1.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        sWriter.WriteLine();
                    }

                    dr = dataGridView1.Rows[j];

                    for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            sWriter.Write(";");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //Reemplazamos nuevas lineas con espacios
                        value = value.Replace(Environment.NewLine, " ");

                        sWriter.Write(value);
                    }
                }
                sWriter.Close();
                MessageBox.Show("Exported succesfully.");
                logs.RegistroLogInicioSesion(true, "Cambios a Aseguradores");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            Int32 FilaActual = dataGridView1.CurrentRow.Index;
            txtNum.Text = dataGridView1.Rows[FilaActual].Cells[0].Value.ToString();
            txtEnt.Text = dataGridView1.Rows[FilaActual].Cells[1].Value.ToString();
            txtAper.Text = dataGridView1.Rows[FilaActual].Cells[2].Value.ToString();
            txtNExpe.Text = dataGridView1.Rows[FilaActual].Cells[3].Value.ToString();
            txtJuz.Text = dataGridView1.Rows[FilaActual].Cells[4].Value.ToString();
            txtJuriz.Text = dataGridView1.Rows[FilaActual].Cells[5].Value.ToString();
            txtDir.Text = dataGridView1.Rows[FilaActual].Cells[6].Value.ToString();
            txtRespon.Text = dataGridView1.Rows[FilaActual].Cells[7].Value.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            logs.RegistroLogInicioSesion(true, "Retorno a Menu");
            frmMenu VolverMenu = new frmMenu();
            VolverMenu.Show();
            this.Close();
        }

        private void frmCargar_Load(object sender, EventArgs e)
        {

        }
    }
}
