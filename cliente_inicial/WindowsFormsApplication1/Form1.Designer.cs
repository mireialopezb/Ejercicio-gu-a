namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mayusculas = new System.Windows.Forms.RadioButton();
            this.Palindromo = new System.Windows.Forms.RadioButton();
            this.altura = new System.Windows.Forms.TextBox();
            this.Altura_text = new System.Windows.Forms.Label();
            this.Alto = new System.Windows.Forms.RadioButton();
            this.desconectar_button = new System.Windows.Forms.Button();
            this.conectar_button = new System.Windows.Forms.Button();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.Cont_Button = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 54);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.button2.Location = new System.Drawing.Point(428, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cont);
            this.groupBox1.Controls.Add(this.Cont_Button);
            this.groupBox1.Controls.Add(this.Mayusculas);
            this.groupBox1.Controls.Add(this.Palindromo);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.Altura_text);
            this.groupBox1.Controls.Add(this.Alto);
            this.groupBox1.Controls.Add(this.desconectar_button);
            this.groupBox1.Controls.Add(this.conectar_button);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(633, 368);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Mayusculas
            // 
            this.Mayusculas.AutoSize = true;
            this.Mayusculas.Location = new System.Drawing.Point(155, 222);
            this.Mayusculas.Name = "Mayusculas";
            this.Mayusculas.Size = new System.Drawing.Size(249, 21);
            this.Mayusculas.TabIndex = 15;
            this.Mayusculas.TabStop = true;
            this.Mayusculas.Text = "Convierte mi nombre a mayúsculas";
            this.Mayusculas.UseVisualStyleBackColor = true;
            // 
            // Palindromo
            // 
            this.Palindromo.AutoSize = true;
            this.Palindromo.Location = new System.Drawing.Point(155, 195);
            this.Palindromo.Name = "Palindromo";
            this.Palindromo.Size = new System.Drawing.Size(238, 21);
            this.Palindromo.TabIndex = 14;
            this.Palindromo.TabStop = true;
            this.Palindromo.Text = "Dime si mi nombre es palíndromo";
            this.Palindromo.UseVisualStyleBackColor = true;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(155, 167);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 22);
            this.altura.TabIndex = 13;
            // 
            // Altura_text
            // 
            this.Altura_text.AutoSize = true;
            this.Altura_text.Location = new System.Drawing.Point(95, 167);
            this.Altura_text.Name = "Altura_text";
            this.Altura_text.Size = new System.Drawing.Size(45, 17);
            this.Altura_text.TabIndex = 12;
            this.Altura_text.Text = "Altura";
            // 
            // Alto
            // 
            this.Alto.AutoSize = true;
            this.Alto.Location = new System.Drawing.Point(155, 140);
            this.Alto.Name = "Alto";
            this.Alto.Size = new System.Drawing.Size(128, 21);
            this.Alto.TabIndex = 11;
            this.Alto.TabStop = true;
            this.Alto.Text = "Dime si soy alto";
            this.Alto.UseVisualStyleBackColor = true;
            // 
            // desconectar_button
            // 
            this.desconectar_button.Location = new System.Drawing.Point(156, 309);
            this.desconectar_button.Name = "desconectar_button";
            this.desconectar_button.Size = new System.Drawing.Size(124, 23);
            this.desconectar_button.TabIndex = 10;
            this.desconectar_button.Text = "Desconectar";
            this.desconectar_button.UseVisualStyleBackColor = true;
            this.desconectar_button.Click += new System.EventHandler(this.desconectar_button_Click);
            // 
            // conectar_button
            // 
            this.conectar_button.Location = new System.Drawing.Point(28, 309);
            this.conectar_button.Name = "conectar_button";
            this.conectar_button.Size = new System.Drawing.Size(114, 23);
            this.conectar_button.TabIndex = 9;
            this.conectar_button.Text = "Conectar";
            this.conectar_button.UseVisualStyleBackColor = true;
            this.conectar_button.Click += new System.EventHandler(this.conectar_button_Click);
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(155, 112);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(220, 21);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 84);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(207, 21);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // Cont_Button
            // 
            this.Cont_Button.Location = new System.Drawing.Point(428, 97);
            this.Cont_Button.Name = "Cont_Button";
            this.Cont_Button.Size = new System.Drawing.Size(149, 51);
            this.Cont_Button.TabIndex = 7;
            this.Cont_Button.Text = "¿Cuántas consultas he hecho?";
            this.Cont_Button.UseVisualStyleBackColor = true;
            this.Cont_Button.Click += new System.EventHandler(this.Cont_Button_Click);
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Location = new System.Drawing.Point(425, 167);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(46, 17);
            this.cont.TabIndex = 16;
            this.cont.Text = "teeext";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Button desconectar_button;
        private System.Windows.Forms.Button conectar_button;
        private System.Windows.Forms.RadioButton Mayusculas;
        private System.Windows.Forms.RadioButton Palindromo;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Label Altura_text;
        private System.Windows.Forms.RadioButton Alto;
        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.Button Cont_Button;
    }
}

