namespace pryPeraltaGasparIE
{
    partial class frmCarpetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetas));
            this.listaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(174, 23);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(181, 190);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.Location = new System.Drawing.Point(13, 23);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(126, 23);
            this.btnCarpetas.TabIndex = 2;
            this.btnCarpetas.Text = "Seleccionar Carpeta";
            this.btnCarpetas.UseVisualStyleBackColor = true;
            this.btnCarpetas.Click += new System.EventHandler(this.btnCarpetas_Click);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.Location = new System.Drawing.Point(13, 70);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(135, 129);
            this.lblEjemplo.TabIndex = 3;
            this.lblEjemplo.Text = "Dirreciòn";
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(386, 26);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(139, 187);
            this.txtShow.TabIndex = 4;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(16, 400);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(14, 283);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(203, 111);
            this.txtWrite.TabIndex = 6;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(117, 244);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 7;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(11, 244);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nombre del Archivo";
            // 
            // frmCarpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.btnCarpetas);
            this.Controls.Add(this.lstFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarpetas";
            this.Text = "frmCarpetas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog listaCarpetas;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Button btnCarpetas;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label lblNom;
    }
}