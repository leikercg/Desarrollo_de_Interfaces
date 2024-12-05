namespace WF_Controles1
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSegundo = new System.Windows.Forms.RadioButton();
            this.rbPrimero = new System.Windows.Forms.RadioButton();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxDaw = new System.Windows.Forms.CheckBox();
            this.cboxDam = new System.Windows.Forms.CheckBox();
            this.btnMostrarMatricula = new System.Windows.Forms.Button();
            this.chboxAceptar = new System.Windows.Forms.CheckBox();
            this.rb800 = new System.Windows.Forms.RadioButton();
            this.rb1024 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(491, 399);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "button1";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(209, 7);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContraseña.MaxLength = 10;
            this.tbContraseña.Multiline = true;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(171, 31);
            this.tbContraseña.TabIndex = 1;
            this.tbContraseña.Text = "uno\r\n\r\n";
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escribe la contraseña: ";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Enabled = false;
            this.btnComprobar.Location = new System.Drawing.Point(637, 7);
            this.btnComprobar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(263, 48);
            this.btnComprobar.TabIndex = 3;
            this.btnComprobar.Text = "Comprobar contraseña";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(255, 139);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 16);
            this.lbMensaje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(212, 71);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(212, 128);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(132, 22);
            this.tbApellido.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSegundo);
            this.groupBox1.Controls.Add(this.rbPrimero);
            this.groupBox1.Location = new System.Drawing.Point(55, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(175, 123);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso";
            // 
            // rbSegundo
            // 
            this.rbSegundo.AutoSize = true;
            this.rbSegundo.Location = new System.Drawing.Point(48, 92);
            this.rbSegundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSegundo.Name = "rbSegundo";
            this.rbSegundo.Size = new System.Drawing.Size(40, 20);
            this.rbSegundo.TabIndex = 1;
            this.rbSegundo.TabStop = true;
            this.rbSegundo.Text = "2º";
            this.rbSegundo.UseVisualStyleBackColor = true;
            // 
            // rbPrimero
            // 
            this.rbPrimero.AutoSize = true;
            this.rbPrimero.Location = new System.Drawing.Point(48, 42);
            this.rbPrimero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPrimero.Name = "rbPrimero";
            this.rbPrimero.Size = new System.Drawing.Size(40, 20);
            this.rbPrimero.TabIndex = 0;
            this.rbPrimero.TabStop = true;
            this.rbPrimero.Text = "1º";
            this.rbPrimero.UseVisualStyleBackColor = true;
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(444, 85);
            this.lbMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(44, 16);
            this.lbMatricula.TabIndex = 10;
            this.lbMatricula.Text = "label4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cboxDaw);
            this.groupBox2.Controls.Add(this.cboxDam);
            this.groupBox2.Location = new System.Drawing.Point(304, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ciclo";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(252, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(267, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamaño";
            // 
            // cboxDaw
            // 
            this.cboxDaw.AutoSize = true;
            this.cboxDaw.Location = new System.Drawing.Point(28, 85);
            this.cboxDaw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxDaw.Name = "cboxDaw";
            this.cboxDaw.Size = new System.Drawing.Size(61, 20);
            this.cboxDaw.TabIndex = 1;
            this.cboxDaw.Text = "DAW";
            this.cboxDaw.UseVisualStyleBackColor = true;
            // 
            // cboxDam
            // 
            this.cboxDam.AutoSize = true;
            this.cboxDam.Location = new System.Drawing.Point(28, 34);
            this.cboxDam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxDam.Name = "cboxDam";
            this.cboxDam.Size = new System.Drawing.Size(59, 20);
            this.cboxDam.TabIndex = 0;
            this.cboxDam.Text = "DAM";
            this.cboxDam.UseVisualStyleBackColor = true;
            // 
            // btnMostrarMatricula
            // 
            this.btnMostrarMatricula.Location = new System.Drawing.Point(443, 137);
            this.btnMostrarMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarMatricula.Name = "btnMostrarMatricula";
            this.btnMostrarMatricula.Size = new System.Drawing.Size(357, 28);
            this.btnMostrarMatricula.TabIndex = 12;
            this.btnMostrarMatricula.Text = "Mostrar matrícula";
            this.btnMostrarMatricula.UseVisualStyleBackColor = true;
            this.btnMostrarMatricula.Click += new System.EventHandler(this.btnMostrarMatricula_Click);
            // 
            // chboxAceptar
            // 
            this.chboxAceptar.AutoSize = true;
            this.chboxAceptar.Location = new System.Drawing.Point(436, 14);
            this.chboxAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxAceptar.Name = "chboxAceptar";
            this.chboxAceptar.Size = new System.Drawing.Size(152, 20);
            this.chboxAceptar.TabIndex = 13;
            this.chboxAceptar.Text = "Aceptar condiciones";
            this.chboxAceptar.UseVisualStyleBackColor = true;
            this.chboxAceptar.CheckedChanged += new System.EventHandler(this.chboxAceptar_CheckedChanged);
            // 
            // rb800
            // 
            this.rb800.AutoSize = true;
            this.rb800.Location = new System.Drawing.Point(590, 249);
            this.rb800.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb800.Name = "rb800";
            this.rb800.Size = new System.Drawing.Size(100, 20);
            this.rb800.TabIndex = 0;
            this.rb800.TabStop = true;
            this.rb800.Text = "      800 x 600";
            this.rb800.UseVisualStyleBackColor = true;
            this.rb800.CheckedChanged += new System.EventHandler(this.rb800_CheckedChanged);
            // 
            // rb1024
            // 
            this.rb1024.AutoSize = true;
            this.rb1024.Location = new System.Drawing.Point(590, 283);
            this.rb1024.Name = "rb1024";
            this.rb1024.Size = new System.Drawing.Size(89, 20);
            this.rb1024.TabIndex = 14;
            this.rb1024.TabStop = true;
            this.rb1024.Text = "1024 x 768";
            this.rb1024.UseVisualStyleBackColor = true;
            this.rb1024.CheckedChanged += new System.EventHandler(this.rb1024_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1167, 556);
            this.Controls.Add(this.rb1024);
            this.Controls.Add(this.rb800);
            this.Controls.Add(this.chboxAceptar);
            this.Controls.Add(this.btnMostrarMatricula);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSegundo;
        private System.Windows.Forms.RadioButton rbPrimero;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxDaw;
        private System.Windows.Forms.CheckBox cboxDam;
        private System.Windows.Forms.Button btnMostrarMatricula;
        private System.Windows.Forms.CheckBox chboxAceptar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb800;
        private System.Windows.Forms.RadioButton rb1024;
    }
}

