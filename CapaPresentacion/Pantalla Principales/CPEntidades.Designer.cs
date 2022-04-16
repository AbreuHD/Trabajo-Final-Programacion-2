namespace CapaPresentacion
{
    partial class CPEntidades
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
            this.dGEntidades = new System.Windows.Forms.DataGridView();
            this.btCrear = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dGEntidades
            // 
            this.dGEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGEntidades.Location = new System.Drawing.Point(12, 12);
            this.dGEntidades.Name = "dGEntidades";
            this.dGEntidades.Size = new System.Drawing.Size(776, 388);
            this.dGEntidades.TabIndex = 0;
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(55, 406);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(154, 32);
            this.btCrear.TabIndex = 2;
            this.btCrear.Text = "Crear Nuevo";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(323, 406);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(154, 32);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(586, 406);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(154, 32);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // FEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.dGEntidades);
            this.Name = "FEntidades";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGEntidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGEntidades;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
    }
}

