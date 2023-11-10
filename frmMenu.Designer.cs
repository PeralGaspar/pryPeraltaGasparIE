namespace pryPeraltaGasparIE
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAseguradores = new System.Windows.Forms.Button();
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAseguradores
            // 
            this.btnAseguradores.Location = new System.Drawing.Point(76, 35);
            this.btnAseguradores.Name = "btnAseguradores";
            this.btnAseguradores.Size = new System.Drawing.Size(158, 53);
            this.btnAseguradores.TabIndex = 1;
            this.btnAseguradores.Text = "ASEGURADORES";
            this.btnAseguradores.UseVisualStyleBackColor = true;
            this.btnAseguradores.Click += new System.EventHandler(this.btnAseguradores_Click);
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.Location = new System.Drawing.Point(76, 136);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(158, 53);
            this.btnCarpetas.TabIndex = 2;
            this.btnCarpetas.Text = "CARPETAS";
            this.btnCarpetas.UseVisualStyleBackColor = true;
            this.btnCarpetas.Click += new System.EventHandler(this.btnCarpetas_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(76, 237);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(158, 53);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(76, 332);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(158, 53);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(326, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(158, 53);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnAseguradores;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(296, 430);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnCarpetas);
            this.Controls.Add(this.btnAseguradores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAseguradores;
        private System.Windows.Forms.Button btnCarpetas;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrar;
    }
}