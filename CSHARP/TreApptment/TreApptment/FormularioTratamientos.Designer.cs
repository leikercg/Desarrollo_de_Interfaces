namespace Treapptment
{
    partial class FormularioTratamientos
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
            this.dataGridViewTratamientos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxMedicamentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFrecuencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdInforme = new System.Windows.Forms.TextBox();
            this.textBoxMedicamento = new System.Windows.Forms.TextBox();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.textBoxIdTratamiento = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamientos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTratamientos
            // 
            this.dataGridViewTratamientos.AllowUserToAddRows = false;
            this.dataGridViewTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTratamientos.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTratamientos.Location = new System.Drawing.Point(88, 225);
            this.dataGridViewTratamientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTratamientos.Name = "dataGridViewTratamientos";
            this.dataGridViewTratamientos.ReadOnly = true;
            this.dataGridViewTratamientos.RowHeadersWidth = 51;
            this.dataGridViewTratamientos.RowTemplate.Height = 24;
            this.dataGridViewTratamientos.Size = new System.Drawing.Size(983, 212);
            this.dataGridViewTratamientos.TabIndex = 0;
            this.dataGridViewTratamientos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTratamientos_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // comboBoxMedicamentos
            // 
            this.comboBoxMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedicamentos.FormattingEnabled = true;
            this.comboBoxMedicamentos.Location = new System.Drawing.Point(737, 105);
            this.comboBoxMedicamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMedicamentos.Name = "comboBoxMedicamentos";
            this.comboBoxMedicamentos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMedicamentos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Frecuencia (h)";
            // 
            // textBoxFrecuencia
            // 
            this.textBoxFrecuencia.Location = new System.Drawing.Point(311, 140);
            this.textBoxFrecuencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFrecuencia.Name = "textBoxFrecuencia";
            this.textBoxFrecuencia.Size = new System.Drawing.Size(252, 22);
            this.textBoxFrecuencia.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Medicamento ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Id Informe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Duración (días)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Id tratamiento";
            // 
            // textBoxIdInforme
            // 
            this.textBoxIdInforme.Location = new System.Drawing.Point(311, 68);
            this.textBoxIdInforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdInforme.Name = "textBoxIdInforme";
            this.textBoxIdInforme.Size = new System.Drawing.Size(252, 22);
            this.textBoxIdInforme.TabIndex = 53;
            // 
            // textBoxMedicamento
            // 
            this.textBoxMedicamento.Enabled = false;
            this.textBoxMedicamento.Location = new System.Drawing.Point(311, 106);
            this.textBoxMedicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMedicamento.Name = "textBoxMedicamento";
            this.textBoxMedicamento.Size = new System.Drawing.Size(252, 22);
            this.textBoxMedicamento.TabIndex = 52;
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(311, 172);
            this.textBoxDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(252, 22);
            this.textBoxDuracion.TabIndex = 3;
            // 
            // textBoxIdTratamiento
            // 
            this.textBoxIdTratamiento.Location = new System.Drawing.Point(311, 32);
            this.textBoxIdTratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdTratamiento.Name = "textBoxIdTratamiento";
            this.textBoxIdTratamiento.Size = new System.Drawing.Size(252, 22);
            this.textBoxIdTratamiento.TabIndex = 48;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(889, 71);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(133, 37);
            this.buttonEditar.TabIndex = 65;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(889, 130);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(133, 37);
            this.buttonGuardar.TabIndex = 66;
            this.buttonGuardar.Text = "Crear";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Medicamento Nombre";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1044, 71);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(133, 37);
            this.buttonCancelar.TabIndex = 68;
            this.buttonCancelar.Text = "Cancelar Edición";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormularioTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFrecuencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdInforme);
            this.Controls.Add(this.textBoxMedicamento);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.textBoxIdTratamiento);
            this.Controls.Add(this.comboBoxMedicamentos);
            this.Controls.Add(this.dataGridViewTratamientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormularioTratamientos";
            this.Text = "Formulario de Tratamientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamientos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTratamientos;
        private System.Windows.Forms.ComboBox comboBoxMedicamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFrecuencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdInforme;
        private System.Windows.Forms.TextBox textBoxMedicamento;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.TextBox textBoxIdTratamiento;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelar;
    }
}