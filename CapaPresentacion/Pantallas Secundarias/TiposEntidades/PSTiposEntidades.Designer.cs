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
            this.components = new System.ComponentModel.Container();
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
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipal.Location = new System.Drawing.Point(27, 27);
            this.lbPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(231, 29);
            this.lbPrincipal.TabIndex = 0;
            this.lbPrincipal.Text = "Crear tipo entidades";
            this.lbPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(88, 111);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(77, 143);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(271, 22);
            this.tbDescripcion.TabIndex = 3;
            this.tbDescripcion.Validated += new System.EventHandler(this.tbDescripcion_Validated);
            // 
            // tBComentario
            // 
            this.tBComentario.Location = new System.Drawing.Point(77, 214);
            this.tBComentario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBComentario.Name = "tBComentario";
            this.tBComentario.Size = new System.Drawing.Size(271, 22);
            this.tBComentario.TabIndex = 5;
            this.tBComentario.Validated += new System.EventHandler(this.tBComentario_Validated);
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComentario.Location = new System.Drawing.Point(88, 182);
            this.lbComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(107, 24);
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
            this.cBGrupoEntidad.Location = new System.Drawing.Point(77, 284);
            this.cBGrupoEntidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBGrupoEntidad.Name = "cBGrupoEntidad";
            this.cBGrupoEntidad.Size = new System.Drawing.Size(271, 24);
            this.cBGrupoEntidad.TabIndex = 6;
            // 
            // lbIDGrupoEntidad
            // 
            this.lbIDGrupoEntidad.AutoSize = true;
            this.lbIDGrupoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDGrupoEntidad.Location = new System.Drawing.Point(88, 258);
            this.lbIDGrupoEntidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDGrupoEntidad.Name = "lbIDGrupoEntidad";
            this.lbIDGrupoEntidad.Size = new System.Drawing.Size(127, 24);
            this.lbIDGrupoEntidad.TabIndex = 7;
            this.lbIDGrupoEntidad.Text = "GrupoEntidad";
            // 
            // lbSStatus
            // 
            this.lbSStatus.AutoSize = true;
            this.lbSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSStatus.Location = new System.Drawing.Point(88, 326);
            this.lbSStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSStatus.Name = "lbSStatus";
            this.lbSStatus.Size = new System.Drawing.Size(70, 24);
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
            this.cBEstatus.Location = new System.Drawing.Point(77, 352);
            this.cBEstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBEstatus.Name = "cBEstatus";
            this.cBEstatus.Size = new System.Drawing.Size(271, 24);
            this.cBEstatus.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(271, 502);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 37);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cBEliminable
            // 
            this.cBEliminable.AutoSize = true;
            this.cBEliminable.Location = new System.Drawing.Point(252, 401);
            this.cBEliminable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBEliminable.Name = "cBEliminable";
            this.cBEliminable.Size = new System.Drawing.Size(92, 20);
            this.cBEliminable.TabIndex = 11;
            this.cBEliminable.Text = "Eliminable";
            this.cBEliminable.UseVisualStyleBackColor = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // PSTiposEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PSTiposEntidades";
            this.Text = "PSTiposEntidades";
            this.Load += new System.EventHandler(this.PSTiposEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
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
        private System.Windows.Forms.ErrorProvider epError;
    }
}