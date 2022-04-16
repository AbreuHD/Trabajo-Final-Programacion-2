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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbInfoPantalla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBDescripcion = new System.Windows.Forms.TextBox();
            this.tBComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBEstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBEliminable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(193, 391);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 31);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbInfoPantalla
            // 
            this.lbInfoPantalla.AutoSize = true;
            this.lbInfoPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoPantalla.Location = new System.Drawing.Point(12, 31);
            this.lbInfoPantalla.Name = "lbInfoPantalla";
            this.lbInfoPantalla.Size = new System.Drawing.Size(203, 24);
            this.lbInfoPantalla.TabIndex = 1;
            this.lbInfoPantalla.Text = "Crear Grupo Entidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // tBDescripcion
            // 
            this.tBDescripcion.Location = new System.Drawing.Point(58, 134);
            this.tBDescripcion.Name = "tBDescripcion";
            this.tBDescripcion.Size = new System.Drawing.Size(192, 20);
            this.tBDescripcion.TabIndex = 3;
            // 
            // tBComentario
            // 
            this.tBComentario.Location = new System.Drawing.Point(58, 192);
            this.tBComentario.Name = "tBComentario";
            this.tBComentario.Size = new System.Drawing.Size(192, 20);
            this.tBComentario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comentario";
            // 
            // cBEstatus
            // 
            this.cBEstatus.FormattingEnabled = true;
            this.cBEstatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cBEstatus.Location = new System.Drawing.Point(58, 243);
            this.cBEstatus.Name = "cBEstatus";
            this.cBEstatus.Size = new System.Drawing.Size(192, 21);
            this.cBEstatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estatus";
            // 
            // cBEliminable
            // 
            this.cBEliminable.AutoSize = true;
            this.cBEliminable.Location = new System.Drawing.Point(170, 283);
            this.cBEliminable.Name = "cBEliminable";
            this.cBEliminable.Size = new System.Drawing.Size(73, 17);
            this.cBEliminable.TabIndex = 8;
            this.cBEliminable.Text = "Eliminable";
            this.cBEliminable.UseVisualStyleBackColor = true;
            // 
            // PSGrupoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.cBEliminable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBEstatus);
            this.Controls.Add(this.tBComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInfoPantalla);
            this.Controls.Add(this.btnAceptar);
            this.Name = "PSGrupoEntidades";
            this.Text = "PSGrupoEntidades";
            this.Load += new System.EventHandler(this.PSGrupoEntidades_Load);
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
    }
}