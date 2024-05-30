namespace Figuras_Geometricas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.EXPORTAR = new System.Windows.Forms.Button();
            this.DIBUJAR = new System.Windows.Forms.Button();
            this.INFO = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.DATOS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ESFERA = new System.Windows.Forms.RadioButton();
            this.PRISMA = new System.Windows.Forms.RadioButton();
            this.POLIREG = new System.Windows.Forms.RadioButton();
            this.CUBO = new System.Windows.Forms.RadioButton();
            this.RECTÁNGULO = new System.Windows.Forms.RadioButton();
            this.CÍRCULO = new System.Windows.Forms.RadioButton();
            this.TRIÁNGULO = new System.Windows.Forms.RadioButton();
            this.POLIIRREG = new System.Windows.Forms.RadioButton();
            this.CUADRADO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.INFORMACION = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CALCULAR);
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.EXPORTAR);
            this.groupBox1.Controls.Add(this.DIBUJAR);
            this.groupBox1.Controls.Add(this.INFO);
            this.groupBox1.Controls.Add(this.GUARDAR);
            this.groupBox1.Controls.Add(this.DATOS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ESFERA);
            this.groupBox1.Controls.Add(this.PRISMA);
            this.groupBox1.Controls.Add(this.POLIREG);
            this.groupBox1.Controls.Add(this.CUBO);
            this.groupBox1.Controls.Add(this.RECTÁNGULO);
            this.groupBox1.Controls.Add(this.CÍRCULO);
            this.groupBox1.Controls.Add(this.TRIÁNGULO);
            this.groupBox1.Controls.Add(this.POLIIRREG);
            this.groupBox1.Controls.Add(this.CUADRADO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CALCULAR
            // 
            this.CALCULAR.Location = new System.Drawing.Point(364, 107);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(75, 23);
            this.CALCULAR.TabIndex = 20;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(283, 107);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.LIMPIAR.TabIndex = 19;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // EXPORTAR
            // 
            this.EXPORTAR.Location = new System.Drawing.Point(189, 107);
            this.EXPORTAR.Name = "EXPORTAR";
            this.EXPORTAR.Size = new System.Drawing.Size(75, 23);
            this.EXPORTAR.TabIndex = 18;
            this.EXPORTAR.Text = "EXPORTAR";
            this.EXPORTAR.UseVisualStyleBackColor = true;
            // 
            // DIBUJAR
            // 
            this.DIBUJAR.Location = new System.Drawing.Point(108, 107);
            this.DIBUJAR.Name = "DIBUJAR";
            this.DIBUJAR.Size = new System.Drawing.Size(75, 23);
            this.DIBUJAR.TabIndex = 17;
            this.DIBUJAR.Text = "DIBUJAR";
            this.DIBUJAR.UseVisualStyleBackColor = true;
            this.DIBUJAR.Click += new System.EventHandler(this.DIBUJAR_Click);
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(10, 107);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(92, 23);
            this.INFO.TabIndex = 16;
            this.INFO.Text = "INFORMACIÓN";
            this.INFO.UseVisualStyleBackColor = true;
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(364, 78);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.GUARDAR.TabIndex = 15;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            // 
            // DATOS
            // 
            this.DATOS.Location = new System.Drawing.Point(284, 80);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(74, 20);
            this.DATOS.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO, ETC";
            // 
            // ESFERA
            // 
            this.ESFERA.AutoSize = true;
            this.ESFERA.Location = new System.Drawing.Point(374, 54);
            this.ESFERA.Name = "ESFERA";
            this.ESFERA.Size = new System.Drawing.Size(67, 17);
            this.ESFERA.TabIndex = 13;
            this.ESFERA.TabStop = true;
            this.ESFERA.Text = "ESFERA";
            this.ESFERA.UseVisualStyleBackColor = true;
            this.ESFERA.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // PRISMA
            // 
            this.PRISMA.AutoSize = true;
            this.PRISMA.Location = new System.Drawing.Point(302, 54);
            this.PRISMA.Name = "PRISMA";
            this.PRISMA.Size = new System.Drawing.Size(66, 17);
            this.PRISMA.TabIndex = 12;
            this.PRISMA.TabStop = true;
            this.PRISMA.Text = "PRISMA";
            this.PRISMA.UseVisualStyleBackColor = true;
            // 
            // POLIREG
            // 
            this.POLIREG.AutoSize = true;
            this.POLIREG.Location = new System.Drawing.Point(297, 31);
            this.POLIREG.Name = "POLIREG";
            this.POLIREG.Size = new System.Drawing.Size(136, 17);
            this.POLIREG.TabIndex = 11;
            this.POLIREG.TabStop = true;
            this.POLIREG.Text = "POLÍGONO REGULAR";
            this.POLIREG.UseVisualStyleBackColor = true;
            // 
            // CUBO
            // 
            this.CUBO.AutoSize = true;
            this.CUBO.Location = new System.Drawing.Point(241, 54);
            this.CUBO.Name = "CUBO";
            this.CUBO.Size = new System.Drawing.Size(55, 17);
            this.CUBO.TabIndex = 10;
            this.CUBO.TabStop = true;
            this.CUBO.Text = "CUBO";
            this.CUBO.UseVisualStyleBackColor = true;
            // 
            // RECTÁNGULO
            // 
            this.RECTÁNGULO.AutoSize = true;
            this.RECTÁNGULO.Location = new System.Drawing.Point(192, 31);
            this.RECTÁNGULO.Name = "RECTÁNGULO";
            this.RECTÁNGULO.Size = new System.Drawing.Size(99, 17);
            this.RECTÁNGULO.TabIndex = 9;
            this.RECTÁNGULO.TabStop = true;
            this.RECTÁNGULO.Text = "RECTÁNGULO";
            this.RECTÁNGULO.UseVisualStyleBackColor = true;
            // 
            // CÍRCULO
            // 
            this.CÍRCULO.AutoSize = true;
            this.CÍRCULO.Location = new System.Drawing.Point(163, 54);
            this.CÍRCULO.Name = "CÍRCULO";
            this.CÍRCULO.Size = new System.Drawing.Size(72, 17);
            this.CÍRCULO.TabIndex = 8;
            this.CÍRCULO.TabStop = true;
            this.CÍRCULO.Text = "CÍRCULO";
            this.CÍRCULO.UseVisualStyleBackColor = true;
            // 
            // TRIÁNGULO
            // 
            this.TRIÁNGULO.AutoSize = true;
            this.TRIÁNGULO.Location = new System.Drawing.Point(98, 31);
            this.TRIÁNGULO.Name = "TRIÁNGULO";
            this.TRIÁNGULO.Size = new System.Drawing.Size(88, 17);
            this.TRIÁNGULO.TabIndex = 7;
            this.TRIÁNGULO.TabStop = true;
            this.TRIÁNGULO.Text = "TRIÁNGULO";
            this.TRIÁNGULO.UseVisualStyleBackColor = true;
            // 
            // POLIIRREG
            // 
            this.POLIIRREG.AutoSize = true;
            this.POLIIRREG.Location = new System.Drawing.Point(10, 54);
            this.POLIIRREG.Name = "POLIIRREG";
            this.POLIIRREG.Size = new System.Drawing.Size(147, 17);
            this.POLIIRREG.TabIndex = 6;
            this.POLIIRREG.TabStop = true;
            this.POLIIRREG.Text = "POLÍGONO IRREGULAR";
            this.POLIIRREG.UseVisualStyleBackColor = true;
            // 
            // CUADRADO
            // 
            this.CUADRADO.AutoSize = true;
            this.CUADRADO.Location = new System.Drawing.Point(10, 31);
            this.CUADRADO.Name = "CUADRADO";
            this.CUADRADO.Size = new System.Drawing.Size(86, 17);
            this.CUADRADO.TabIndex = 5;
            this.CUADRADO.TabStop = true;
            this.CUADRADO.Text = "CUADRADO";
            this.CUADRADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            // 
            // IMAGEN
            // 
            this.IMAGEN.BackgroundImage = global::Figuras_Geometricas.Properties.Resources.triangulo;
            this.IMAGEN.Location = new System.Drawing.Point(12, 160);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(265, 286);
            this.IMAGEN.TabIndex = 1;
            this.IMAGEN.TabStop = false;
            // 
            // INFORMACION
            // 
            this.INFORMACION.Location = new System.Drawing.Point(297, 161);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(194, 285);
            this.INFORMACION.TabIndex = 2;
            this.INFORMACION.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 467);
            this.Controls.Add(this.INFORMACION);
            this.Controls.Add(this.IMAGEN);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ESFERA;
        private System.Windows.Forms.RadioButton PRISMA;
        private System.Windows.Forms.RadioButton POLIREG;
        private System.Windows.Forms.RadioButton CUBO;
        private System.Windows.Forms.RadioButton RECTÁNGULO;
        private System.Windows.Forms.RadioButton CÍRCULO;
        private System.Windows.Forms.RadioButton TRIÁNGULO;
        private System.Windows.Forms.RadioButton POLIIRREG;
        private System.Windows.Forms.RadioButton CUADRADO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button EXPORTAR;
        private System.Windows.Forms.Button DIBUJAR;
        private System.Windows.Forms.Button INFO;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.TextBox DATOS;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.RichTextBox INFORMACION;
    }
}

