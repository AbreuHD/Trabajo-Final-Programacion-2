namespace CapaPresentacion.Pantallas_Secundarias.TiposEntidades
{
    partial class PSTiposEntidades
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
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tBComentario = new System.Windows.Forms.TextBox();
            this.lbComentario = new System.Windows.Forms.Label();
            this.cBGrupoEntidad = new System.Windows.Forms.ComboBox();
            this.lbIDGrupoEntidad = new System.Windows.Forms.Label();
            this.lbSStatus = new System.Windows.Forms.Label();
            this.cBEstatus = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cBEliminable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipal.Location = new System.Drawing.Point(20, 22);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(178, 24);
            this.lbPrincipal.TabIndex = 0;
            this.lbPrincipal.Text = "Crear tipo entidades";
            this.lbPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(66, 90);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(58, 116);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(204, 20);
            this.tbDescripcion.TabIndex = 3;
            // 
            // tBComentario
            // 
            this.tBComentario.Location = new System.Drawing.Point(58, 174);
            this.tBComentario.Name = "tBComentario";
            this.tBComentario.Size = new System.Drawing.Size(204, 20);
            this.tBComentario.TabIndex = 5;
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComentario.Location = new System.Drawing.Point(66, 148);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(86, 18);
            this.lbComentario.TabIndex = 4;
            this.lbComentario.Text = "Comentario";
            // 
            // cBGrupoEntidad
            // 
            this.cBGrupoEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGrupoEntidad.FormattingEnabled = true;
            this.cBGrupoEntidad.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBGrupoEntidad.Location = new System.Drawing.Point(58, 231);
            this.cBGrupoEntidad.Name = "cBGrupoEntidad";
            this.cBGrupoEntidad.Size = new System.Drawing.Size(204, 21);
            this.cBGrupoEntidad.TabIndex = 6;
            // 
            // lbIDGrupoEntidad
            // 
            this.lbIDGrupoEntidad.AutoSize = true;
            this.lbIDGrupoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDGrupoEntidad.Location = new System.Drawing.Point(66, 210);
            this.lbIDGrupoEntidad.Name = "lbIDGrupoEntidad";
            this.lbIDGrupoEntidad.Size = new System.Drawing.Size(99, 18);
            this.lbIDGrupoEntidad.TabIndex = 7;
            this.lbIDGrupoEntidad.Text = "GrupoEntidad";
            // 
            // lbSStatus
            // 
            this.lbSStatus.AutoSize = true;
            this.lbSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSStatus.Location = new System.Drawing.Point(66, 265);
            this.lbSStatus.Name = "lbSStatus";
            this.lbSStatus.Size = new System.Drawing.Size(58, 18);
            this.lbSStatus.TabIndex = 9;
            this.lbSStatus.Text = "Estatus";
            // 
            // cBEstatus
            // 
            this.cBEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBEstatus.FormattingEnabled = true;
            this.cBEstatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cBEstatus.Location = new System.Drawing.Point(58, 286);
            this.cBEstatus.Name = "cBEstatus";
            this.cBEstatus.Size = new System.Drawing.Size(204, 21);
            this.cBEstatus.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(203, 408);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 30);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cBEliminable
            // 
            this.cBEliminable.AutoSize = true;
            this.cBEliminable.Location = new System.Drawing.Point(189, 326);
            this.cBEliminable.Name = "cBEliminable";
            this.cBEliminable.Size = new System.Drawing.Size(73, 17);
            this.cBEliminable.TabIndex = 11;
            this.cBEliminable.Text = "Eliminable";
            this.cBEliminable.UseVisualStyleBackColor = true;
            // 
            // PSTiposEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.cBEliminable);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbSStatus);
            this.Controls.Add(this.cBEstatus);
            this.Controls.Add(this.lbIDGrupoEntidad);
            this.Controls.Add(this.cBGrupoEntidad);
            this.Controls.Add(this.tBComentario);
            this.Controls.Add(this.lbComentario);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbPrincipal);
            this.Name = "PSTiposEntidades";
            this.Text = "PSTiposEntidades";
            this.Load += new System.EventHandler(this.PSTiposEntidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tBComentario;
        private System.Windows.Forms.Label lbComentario;
        private System.Windows.Forms.ComboBox cBGrupoEntidad;
        private System.Windows.Forms.Label lbIDGrupoEntidad;
        private System.Windows.Forms.Label lbSStatus;
        private System.Windows.Forms.ComboBox cBEstatus;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox cBEliminable;
    }
}