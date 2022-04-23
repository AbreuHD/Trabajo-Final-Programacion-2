namespace CapaPresentacion.Pantallas_Secundarias
{
    partial class PSGrupoEntidades
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbInfoPantalla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBDescripcion = new System.Windows.Forms.TextBox();
            this.tBComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBEstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBEliminable = new System.Windows.Forms.CheckBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(257, 481);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 38);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbInfoPantalla
            // 
            this.lbInfoPantalla.AutoSize = true;
            this.lbInfoPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoPantalla.Location = new System.Drawing.Point(16, 38);
            this.lbInfoPantalla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoPantalla.Name = "lbInfoPantalla";
            this.lbInfoPantalla.Size = new System.Drawing.Size(260, 29);
            this.lbInfoPantalla.TabIndex = 1;
            this.lbInfoPantalla.Text = "Crear Grupo Entidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // tBDescripcion
            // 
            this.tBDescripcion.Location = new System.Drawing.Point(77, 165);
            this.tBDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBDescripcion.Name = "tBDescripcion";
            this.tBDescripcion.Size = new System.Drawing.Size(255, 22);
            this.tBDescripcion.TabIndex = 3;
            this.tBDescripcion.Validated += new System.EventHandler(this.tBDescripcion_Validated);
            // 
            // tBComentario
            // 
            this.tBComentario.Location = new System.Drawing.Point(77, 236);
            this.tBComentario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBComentario.Name = "tBComentario";
            this.tBComentario.Size = new System.Drawing.Size(255, 22);
            this.tBComentario.TabIndex = 5;
            this.tBComentario.Validated += new System.EventHandler(this.tBComentario_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comentario";
            // 
            // cBEstatus
            // 
            this.cBEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBEstatus.FormattingEnabled = true;
            this.cBEstatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cBEstatus.Location = new System.Drawing.Point(77, 299);
            this.cBEstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBEstatus.Name = "cBEstatus";
            this.cBEstatus.Size = new System.Drawing.Size(255, 24);
            this.cBEstatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estatus";
            // 
            // cBEliminable
            // 
            this.cBEliminable.AutoSize = true;
            this.cBEliminable.Location = new System.Drawing.Point(227, 348);
            this.cBEliminable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBEliminable.Name = "cBEliminable";
            this.cBEliminable.Size = new System.Drawing.Size(92, 20);
            this.cBEliminable.TabIndex = 8;
            this.cBEliminable.Text = "Eliminable";
            this.cBEliminable.UseVisualStyleBackColor = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // PSGrupoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 554);
            this.Controls.Add(this.cBEliminable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBEstatus);
            this.Controls.Add(this.tBComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInfoPantalla);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PSGrupoEntidades";
            this.Text = "PSGrupoEntidades";
            this.Load += new System.EventHandler(this.PSGrupoEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbInfoPantalla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBDescripcion;
        private System.Windows.Forms.TextBox tBComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBEstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cBEliminable;
        private System.Windows.Forms.ErrorProvider epError;
    }
}