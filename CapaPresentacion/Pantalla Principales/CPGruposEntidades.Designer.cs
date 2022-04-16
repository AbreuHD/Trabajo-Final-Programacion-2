namespace CapaPresentacion.Pantalla_Principales
{
    partial class CPGruposEntidades
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
            this.dGVGruposEntidades = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGruposEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVGruposEntidades
            // 
            this.dGVGruposEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGruposEntidades.Location = new System.Drawing.Point(12, 12);
            this.dGVGruposEntidades.Name = "dGVGruposEntidades";
            this.dGVGruposEntidades.Size = new System.Drawing.Size(778, 408);
            this.dGVGruposEntidades.TabIndex = 0;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(589, 435);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(154, 32);
            this.btEliminar.TabIndex = 8;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(326, 435);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(154, 32);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(58, 435);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(154, 32);
            this.btCrear.TabIndex = 6;
            this.btCrear.Text = "Crear Nuevo";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // CPGruposEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 479);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.dGVGruposEntidades);
            this.Name = "CPGruposEntidades";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CPGruposEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGruposEntidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVGruposEntidades;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCrear;
    }
}