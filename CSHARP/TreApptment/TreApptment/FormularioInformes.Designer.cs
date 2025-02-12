﻿namespace Treapptment
{
    partial class FormularioInformes
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
            this.dataGridViewInformes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.textBoxFechaCrea = new System.Windows.Forms.TextBox();
            this.textBoxMedico = new System.Windows.Forms.TextBox();
            this.textBoxCentro = new System.Windows.Forms.TextBox();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.textBoxIdInforme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFechaMod = new System.Windows.Forms.TextBox();
            this.textBoxRecomendaciones = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInformes
            // 
            this.dataGridViewInformes.AllowUserToAddRows = false;
            this.dataGridViewInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformes.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewInformes.Location = new System.Drawing.Point(51, 135);
            this.dataGridViewInformes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInformes.Name = "dataGridViewInformes";
            this.dataGridViewInformes.ReadOnly = true;
            this.dataGridViewInformes.RowHeadersWidth = 51;
            this.dataGridViewInformes.RowTemplate.Height = 24;
            this.dataGridViewInformes.Size = new System.Drawing.Size(856, 263);
            this.dataGridViewInformes.TabIndex = 0;
            this.dataGridViewInformes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInformes_CellDoubleClick);
            this.dataGridViewInformes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewInformes_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Fecha Crea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Id Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Médico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Centro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id Informe";
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Location = new System.Drawing.Point(150, 47);
            this.textBoxIdPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdPaciente.Name = "textBoxIdPaciente";
            this.textBoxIdPaciente.Size = new System.Drawing.Size(110, 20);
            this.textBoxIdPaciente.TabIndex = 35;
            // 
            // textBoxFechaCrea
            // 
            this.textBoxFechaCrea.Location = new System.Drawing.Point(150, 70);
            this.textBoxFechaCrea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFechaCrea.Name = "textBoxFechaCrea";
            this.textBoxFechaCrea.Size = new System.Drawing.Size(110, 20);
            this.textBoxFechaCrea.TabIndex = 34;
            // 
            // textBoxMedico
            // 
            this.textBoxMedico.Location = new System.Drawing.Point(404, 22);
            this.textBoxMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMedico.Name = "textBoxMedico";
            this.textBoxMedico.Size = new System.Drawing.Size(192, 20);
            this.textBoxMedico.TabIndex = 33;
            // 
            // textBoxCentro
            // 
            this.textBoxCentro.Location = new System.Drawing.Point(404, 47);
            this.textBoxCentro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCentro.Name = "textBoxCentro";
            this.textBoxCentro.Size = new System.Drawing.Size(192, 20);
            this.textBoxCentro.TabIndex = 32;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(404, 72);
            this.textBoxMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(192, 20);
            this.textBoxMotivo.TabIndex = 31;
            // 
            // textBoxIdInforme
            // 
            this.textBoxIdInforme.Location = new System.Drawing.Point(150, 24);
            this.textBoxIdInforme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdInforme.Name = "textBoxIdInforme";
            this.textBoxIdInforme.Size = new System.Drawing.Size(110, 20);
            this.textBoxIdInforme.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fecha Mod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Recomendaciones";
            // 
            // textBoxFechaMod
            // 
            this.textBoxFechaMod.Location = new System.Drawing.Point(150, 93);
            this.textBoxFechaMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFechaMod.Name = "textBoxFechaMod";
            this.textBoxFechaMod.Size = new System.Drawing.Size(110, 20);
            this.textBoxFechaMod.TabIndex = 45;
            // 
            // textBoxRecomendaciones
            // 
            this.textBoxRecomendaciones.Location = new System.Drawing.Point(404, 95);
            this.textBoxRecomendaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRecomendaciones.Name = "textBoxRecomendaciones";
            this.textBoxRecomendaciones.Size = new System.Drawing.Size(192, 20);
            this.textBoxRecomendaciones.TabIndex = 44;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(713, 27);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(56, 19);
            this.buttonEditar.TabIndex = 48;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(713, 70);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(56, 19);
            this.buttonGuardar.TabIndex = 49;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormularioInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 485);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFechaMod);
            this.Controls.Add(this.textBoxRecomendaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdPaciente);
            this.Controls.Add(this.textBoxFechaCrea);
            this.Controls.Add(this.textBoxMedico);
            this.Controls.Add(this.textBoxCentro);
            this.Controls.Add(this.textBoxMotivo);
            this.Controls.Add(this.textBoxIdInforme);
            this.Controls.Add(this.dataGridViewInformes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioInformes";
            this.Text = "FormularioInformes";
            this.Load += new System.EventHandler(this.FormularioInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInformes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdPaciente;
        private System.Windows.Forms.TextBox textBoxFechaCrea;
        private System.Windows.Forms.TextBox textBoxMedico;
        private System.Windows.Forms.TextBox textBoxCentro;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.TextBox textBoxIdInforme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFechaMod;
        private System.Windows.Forms.TextBox textBoxRecomendaciones;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}