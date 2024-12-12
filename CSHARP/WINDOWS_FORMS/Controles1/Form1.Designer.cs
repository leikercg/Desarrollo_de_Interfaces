namespace Controles1
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonSegundo = new System.Windows.Forms.RadioButton();
            this.radioButtonPrimero = new System.Windows.Forms.RadioButton();
            this.groupBoxCiclo = new System.Windows.Forms.GroupBox();
            this.checkBoxDaw = new System.Windows.Forms.CheckBox();
            this.checkBoxDam = new System.Windows.Forms.CheckBox();
            this.buttonMostratMatricula = new System.Windows.Forms.Button();
            this.checkBoxAceptarCondiciones = new System.Windows.Forms.CheckBox();
            this.groupBoxFormato = new System.Windows.Forms.GroupBox();
            this.radioButtonTamaño = new System.Windows.Forms.RadioButton();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.groupBoxCiclo.SuspendLayout();
            this.groupBoxFormato.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Orange;
            this.btn_Cerrar.Location = new System.Drawing.Point(615, 364);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(105, 48);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.click_cerrar);
            this.btn_Cerrar.MouseEnter += new System.EventHandler(this.entrar_btn);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(205, 85);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(153, 20);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce tu nombre";
            // 
            // btn_saludar
            // 
            this.btn_saludar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_saludar.Location = new System.Drawing.Point(100, 364);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(105, 48);
            this.btn_saludar.TabIndex = 3;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = false;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hola";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonSegundo);
            this.groupBox.Controls.Add(this.radioButtonPrimero);
            this.groupBox.Location = new System.Drawing.Point(103, 140);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(152, 118);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Curso";
            // 
            // radioButtonSegundo
            // 
            this.radioButtonSegundo.AutoSize = true;
            this.radioButtonSegundo.Location = new System.Drawing.Point(11, 63);
            this.radioButtonSegundo.Name = "radioButtonSegundo";
            this.radioButtonSegundo.Size = new System.Drawing.Size(35, 17);
            this.radioButtonSegundo.TabIndex = 1;
            this.radioButtonSegundo.TabStop = true;
            this.radioButtonSegundo.Text = "2º";
            this.radioButtonSegundo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrimero
            // 
            this.radioButtonPrimero.AutoSize = true;
            this.radioButtonPrimero.Location = new System.Drawing.Point(11, 30);
            this.radioButtonPrimero.Name = "radioButtonPrimero";
            this.radioButtonPrimero.Size = new System.Drawing.Size(35, 17);
            this.radioButtonPrimero.TabIndex = 0;
            this.radioButtonPrimero.TabStop = true;
            this.radioButtonPrimero.Text = "1º";
            this.radioButtonPrimero.UseVisualStyleBackColor = true;
            // 
            // groupBoxCiclo
            // 
            this.groupBoxCiclo.Controls.Add(this.checkBoxDaw);
            this.groupBoxCiclo.Controls.Add(this.checkBoxDam);
            this.groupBoxCiclo.Location = new System.Drawing.Point(320, 140);
            this.groupBoxCiclo.Name = "groupBoxCiclo";
            this.groupBoxCiclo.Size = new System.Drawing.Size(186, 118);
            this.groupBoxCiclo.TabIndex = 6;
            this.groupBoxCiclo.TabStop = false;
            this.groupBoxCiclo.Text = "Ciclo";
            // 
            // checkBoxDaw
            // 
            this.checkBoxDaw.AutoSize = true;
            this.checkBoxDaw.Location = new System.Drawing.Point(20, 63);
            this.checkBoxDaw.Name = "checkBoxDaw";
            this.checkBoxDaw.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDaw.TabIndex = 1;
            this.checkBoxDaw.Text = "DAW";
            this.checkBoxDaw.UseVisualStyleBackColor = true;
            // 
            // checkBoxDam
            // 
            this.checkBoxDam.AutoSize = true;
            this.checkBoxDam.Location = new System.Drawing.Point(20, 31);
            this.checkBoxDam.Name = "checkBoxDam";
            this.checkBoxDam.Size = new System.Drawing.Size(50, 17);
            this.checkBoxDam.TabIndex = 0;
            this.checkBoxDam.Text = "DAM";
            this.checkBoxDam.UseVisualStyleBackColor = true;
            // 
            // buttonMostratMatricula
            // 
            this.buttonMostratMatricula.Enabled = false;
            this.buttonMostratMatricula.Location = new System.Drawing.Point(405, 78);
            this.buttonMostratMatricula.Name = "buttonMostratMatricula";
            this.buttonMostratMatricula.Size = new System.Drawing.Size(278, 23);
            this.buttonMostratMatricula.TabIndex = 7;
            this.buttonMostratMatricula.Text = "Mostrar Matrícula";
            this.buttonMostratMatricula.UseVisualStyleBackColor = true;
            this.buttonMostratMatricula.Click += new System.EventHandler(this.buttonMostratMatricula_Click);
            // 
            // checkBoxAceptarCondiciones
            // 
            this.checkBoxAceptarCondiciones.AutoSize = true;
            this.checkBoxAceptarCondiciones.Location = new System.Drawing.Point(572, 112);
            this.checkBoxAceptarCondiciones.Name = "checkBoxAceptarCondiciones";
            this.checkBoxAceptarCondiciones.Size = new System.Drawing.Size(124, 17);
            this.checkBoxAceptarCondiciones.TabIndex = 8;
            this.checkBoxAceptarCondiciones.Text = "Aceptar Condiciones";
            this.checkBoxAceptarCondiciones.UseVisualStyleBackColor = true;
            this.checkBoxAceptarCondiciones.CheckedChanged += new System.EventHandler(this.checkBoxAceptarCondiciones_CheckedChanged);
            // 
            // groupBoxFormato
            // 
            this.groupBoxFormato.Controls.Add(this.radioButtonTamaño);
            this.groupBoxFormato.Controls.Add(this.radioButtonColor);
            this.groupBoxFormato.Location = new System.Drawing.Point(558, 140);
            this.groupBoxFormato.Name = "groupBoxFormato";
            this.groupBoxFormato.Size = new System.Drawing.Size(200, 118);
            this.groupBoxFormato.TabIndex = 9;
            this.groupBoxFormato.TabStop = false;
            this.groupBoxFormato.Text = "Formato";
            // 
            // radioButtonTamaño
            // 
            this.radioButtonTamaño.AutoSize = true;
            this.radioButtonTamaño.Location = new System.Drawing.Point(3, 62);
            this.radioButtonTamaño.Name = "radioButtonTamaño";
            this.radioButtonTamaño.Size = new System.Drawing.Size(101, 17);
            this.radioButtonTamaño.TabIndex = 1;
            this.radioButtonTamaño.TabStop = true;
            this.radioButtonTamaño.Text = "Cambiar tamaño";
            this.radioButtonTamaño.UseVisualStyleBackColor = true;
            this.radioButtonTamaño.CheckedChanged += new System.EventHandler(this.radioButtonTamaño_CheckedChanged);
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Location = new System.Drawing.Point(3, 30);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(89, 17);
            this.radioButtonColor.TabIndex = 0;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Cambiar color";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            this.radioButtonColor.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFormato);
            this.Controls.Add(this.checkBoxAceptarCondiciones);
            this.Controls.Add(this.buttonMostratMatricula);
            this.Controls.Add(this.groupBoxCiclo);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxCiclo.ResumeLayout(false);
            this.groupBoxCiclo.PerformLayout();
            this.groupBoxFormato.ResumeLayout(false);
            this.groupBoxFormato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonSegundo;
        private System.Windows.Forms.RadioButton radioButtonPrimero;
        private System.Windows.Forms.GroupBox groupBoxCiclo;
        private System.Windows.Forms.CheckBox checkBoxDam;
        private System.Windows.Forms.CheckBox checkBoxDaw;
        private System.Windows.Forms.Button buttonMostratMatricula;
        private System.Windows.Forms.CheckBox checkBoxAceptarCondiciones;
        private System.Windows.Forms.GroupBox groupBoxFormato;
        private System.Windows.Forms.RadioButton radioButtonTamaño;
        private System.Windows.Forms.RadioButton radioButtonColor;
    }
}

