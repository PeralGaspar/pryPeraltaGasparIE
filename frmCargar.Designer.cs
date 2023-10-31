
namespace pryPeraltaGasparIE
{
    partial class frmCargar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtRespon = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtJuriz = new System.Windows.Forms.TextBox();
            this.txtJuz = new System.Windows.Forms.TextBox();
            this.txtNExpe = new System.Windows.Forms.TextBox();
            this.txtAper = new System.Windows.Forms.TextBox();
            this.txtEnt = new System.Windows.Forms.TextBox();
            this.lblRespon = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblJuriz = new System.Windows.Forms.Label();
            this.lblJuz = new System.Windows.Forms.Label();
            this.lblNExpe = new System.Windows.Forms.Label();
            this.lblAper = new System.Windows.Forms.Label();
            this.lblEnt = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 210);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(380, 186);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 35);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(106, 26);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(6, 29);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(19, 13);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Nº";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnVerificar);
            this.grpDatos.Controls.Add(this.txtRespon);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtJuriz);
            this.grpDatos.Controls.Add(this.txtJuz);
            this.grpDatos.Controls.Add(this.txtNExpe);
            this.grpDatos.Controls.Add(this.txtAper);
            this.grpDatos.Controls.Add(this.txtEnt);
            this.grpDatos.Controls.Add(this.lblRespon);
            this.grpDatos.Controls.Add(this.lblDir);
            this.grpDatos.Controls.Add(this.lblJuriz);
            this.grpDatos.Controls.Add(this.lblJuz);
            this.grpDatos.Controls.Add(this.lblNExpe);
            this.grpDatos.Controls.Add(this.lblAper);
            this.grpDatos.Controls.Add(this.lblEnt);
            this.grpDatos.Controls.Add(this.lblNum);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.txtNum);
            this.grpDatos.Location = new System.Drawing.Point(12, 243);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(502, 235);
            this.grpDatos.TabIndex = 5;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(275, 186);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(88, 35);
            this.btnVerificar.TabIndex = 19;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtRespon
            // 
            this.txtRespon.Location = new System.Drawing.Point(380, 135);
            this.txtRespon.Name = "txtRespon";
            this.txtRespon.Size = new System.Drawing.Size(100, 20);
            this.txtRespon.TabIndex = 18;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(380, 94);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 20);
            this.txtDir.TabIndex = 17;
            // 
            // txtJuriz
            // 
            this.txtJuriz.Location = new System.Drawing.Point(380, 62);
            this.txtJuriz.Name = "txtJuriz";
            this.txtJuriz.Size = new System.Drawing.Size(100, 20);
            this.txtJuriz.TabIndex = 16;
            // 
            // txtJuz
            // 
            this.txtJuz.Location = new System.Drawing.Point(380, 26);
            this.txtJuz.Name = "txtJuz";
            this.txtJuz.Size = new System.Drawing.Size(100, 20);
            this.txtJuz.TabIndex = 15;
            // 
            // txtNExpe
            // 
            this.txtNExpe.Location = new System.Drawing.Point(106, 135);
            this.txtNExpe.Name = "txtNExpe";
            this.txtNExpe.Size = new System.Drawing.Size(100, 20);
            this.txtNExpe.TabIndex = 14;
            // 
            // txtAper
            // 
            this.txtAper.Location = new System.Drawing.Point(106, 98);
            this.txtAper.Name = "txtAper";
            this.txtAper.Size = new System.Drawing.Size(100, 20);
            this.txtAper.TabIndex = 13;
            // 
            // txtEnt
            // 
            this.txtEnt.Location = new System.Drawing.Point(106, 62);
            this.txtEnt.Name = "txtEnt";
            this.txtEnt.Size = new System.Drawing.Size(100, 20);
            this.txtEnt.TabIndex = 12;
            // 
            // lblRespon
            // 
            this.lblRespon.AutoSize = true;
            this.lblRespon.Location = new System.Drawing.Point(227, 138);
            this.lblRespon.Name = "lblRespon";
            this.lblRespon.Size = new System.Drawing.Size(121, 13);
            this.lblRespon.TabIndex = 11;
            this.lblRespon.Text = "Liquidador Responsable";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(227, 97);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 10;
            this.lblDir.Text = "Dirección";
            // 
            // lblJuriz
            // 
            this.lblJuriz.AutoSize = true;
            this.lblJuriz.Location = new System.Drawing.Point(227, 65);
            this.lblJuriz.Name = "lblJuriz";
            this.lblJuriz.Size = new System.Drawing.Size(62, 13);
            this.lblJuriz.TabIndex = 9;
            this.lblJuriz.Text = "Jurizdicción";
            // 
            // lblJuz
            // 
            this.lblJuz.AutoSize = true;
            this.lblJuz.Location = new System.Drawing.Point(232, 29);
            this.lblJuz.Name = "lblJuz";
            this.lblJuz.Size = new System.Drawing.Size(47, 13);
            this.lblJuz.TabIndex = 8;
            this.lblJuz.Text = "Juzgado";
            // 
            // lblNExpe
            // 
            this.lblNExpe.AutoSize = true;
            this.lblNExpe.Location = new System.Drawing.Point(6, 138);
            this.lblNExpe.Name = "lblNExpe";
            this.lblNExpe.Size = new System.Drawing.Size(75, 13);
            this.lblNExpe.TabIndex = 7;
            this.lblNExpe.Text = "Nº Expediente";
            // 
            // lblAper
            // 
            this.lblAper.AutoSize = true;
            this.lblAper.Location = new System.Drawing.Point(6, 101);
            this.lblAper.Name = "lblAper";
            this.lblAper.Size = new System.Drawing.Size(47, 13);
            this.lblAper.TabIndex = 6;
            this.lblAper.Text = "Apertura";
            // 
            // lblEnt
            // 
            this.lblEnt.AutoSize = true;
            this.lblEnt.Location = new System.Drawing.Point(6, 65);
            this.lblEnt.Name = "lblEnt";
            this.lblEnt.Size = new System.Drawing.Size(43, 13);
            this.lblEnt.TabIndex = 5;
            this.lblEnt.Text = "Entidad";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(36, 102);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 35);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(36, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Location = new System.Drawing.Point(6, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(149, 49);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Seleccione una fila para modificar o elminar";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Location = new System.Drawing.Point(520, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 235);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja y Modificacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(556, 489);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 35);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(21, 489);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 35);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCargar
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(693, 536);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Aseguradores";
            this.Load += new System.EventHandler(this.frmCargar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtRespon;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtJuriz;
        private System.Windows.Forms.TextBox txtJuz;
        private System.Windows.Forms.TextBox txtNExpe;
        private System.Windows.Forms.TextBox txtAper;
        private System.Windows.Forms.TextBox txtEnt;
        private System.Windows.Forms.Label lblRespon;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblJuriz;
        private System.Windows.Forms.Label lblJuz;
        private System.Windows.Forms.Label lblNExpe;
        private System.Windows.Forms.Label lblAper;
        private System.Windows.Forms.Label lblEnt;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}