namespace Ejemplo
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
            this.agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.corte1 = new System.Windows.Forms.TextBox();
            this.corte2 = new System.Windows.Forms.TextBox();
            this.corte3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            this.calcular_nota = new System.Windows.Forms.Button();
            this.definitiva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(212, 169);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(125, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Cargar BD";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Corte 1 (35%)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Corte 2 (35%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Corte 3 (30%)";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(91, 86);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(80, 20);
            this.nombre.TabIndex = 8;
            // 
            // corte1
            // 
            this.corte1.Location = new System.Drawing.Point(212, 86);
            this.corte1.Name = "corte1";
            this.corte1.Size = new System.Drawing.Size(80, 20);
            this.corte1.TabIndex = 9;
            // 
            // corte2
            // 
            this.corte2.Location = new System.Drawing.Point(321, 86);
            this.corte2.Name = "corte2";
            this.corte2.Size = new System.Drawing.Size(80, 20);
            this.corte2.TabIndex = 10;
            // 
            // corte3
            // 
            this.corte3.Location = new System.Drawing.Point(423, 86);
            this.corte3.Name = "corte3";
            this.corte3.Size = new System.Drawing.Size(80, 20);
            this.corte3.TabIndex = 11;
            this.corte3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota Definitiva";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(35, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 13);
            this.label.TabIndex = 14;
            this.label.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(24, 86);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(51, 20);
            this.id.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Por favor las notas decimales separarlas con comas ";
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(363, 169);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(140, 23);
            this.borrar.TabIndex = 17;
            this.borrar.Text = "Limpiar Campos";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // calcular_nota
            // 
            this.calcular_nota.Location = new System.Drawing.Point(31, 169);
            this.calcular_nota.Name = "calcular_nota";
            this.calcular_nota.Size = new System.Drawing.Size(140, 23);
            this.calcular_nota.TabIndex = 18;
            this.calcular_nota.Text = "Calcular nota final";
            this.calcular_nota.UseVisualStyleBackColor = true;
            this.calcular_nota.Click += new System.EventHandler(this.calcular_nota_Click);
            // 
            // definitiva
            // 
            this.definitiva.AutoSize = true;
            this.definitiva.Location = new System.Drawing.Point(547, 93);
            this.definitiva.Name = "definitiva";
            this.definitiva.Size = new System.Drawing.Size(0, 13);
            this.definitiva.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 210);
            this.Controls.Add(this.definitiva);
            this.Controls.Add(this.calcular_nota);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.corte3);
            this.Controls.Add(this.corte2);
            this.Controls.Add(this.corte1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox id;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.TextBox corte1;
        public System.Windows.Forms.TextBox corte2;
        public System.Windows.Forms.TextBox corte3;
        public System.Windows.Forms.Button agregar;
        public System.Windows.Forms.Button calcular_nota;
        public System.Windows.Forms.Button borrar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label definitiva;
    }
}

