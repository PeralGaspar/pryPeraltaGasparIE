﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string leerlinea = "";
            string[] separarDatos = new string[0];
            StreamReader grilla = new StreamReader("C:/Users/Alumnos/source/repos/pryPeraltaGasparIE/Resources/Listado de aseguradores.csv");
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
            StreamWriter objSw = new StreamWriter("ejemploProveedor", true);
            objSw.WriteLine(txtNum.Text);
            
            objSw.Close();
            MessageBox.Show("Registrado");
            txtNum.Text = "";
            txtNum.Focus();
        }
    }
}
