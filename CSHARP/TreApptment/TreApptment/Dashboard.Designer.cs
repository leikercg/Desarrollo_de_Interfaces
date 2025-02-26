namespace Treapptment
{
    partial class Dashboard
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
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonAgregarPaciente = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonBuscarPaciente = new System.Windows.Forms.Button();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMedicamentos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(868, 363);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(133, 37);
            this.buttonCerrarSesion.TabIndex = 0;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonAgregarPaciente
            // 
            this.buttonAgregarPaciente.Location = new System.Drawing.Point(76, 363);
            this.buttonAgregarPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregarPaciente.Name = "buttonAgregarPaciente";
            this.buttonAgregarPaciente.Size = new System.Drawing.Size(133, 37);
            this.buttonAgregarPaciente.TabIndex = 1;
            this.buttonAgregarPaciente.Text = "Agregar Paciente";
            this.buttonAgregarPaciente.UseVisualStyleBackColor = true;
            this.buttonAgregarPaciente.Click += new System.EventHandler(this.buttonAgregarPaciente_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(436, 58);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(337, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // buttonBuscarPaciente
            // 
            this.buttonBuscarPaciente.Location = new System.Drawing.Point(780, 50);
            this.buttonBuscarPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarPaciente.Name = "buttonBuscarPaciente";
            this.buttonBuscarPaciente.Size = new System.Drawing.Size(133, 37);
            this.buttonBuscarPaciente.TabIndex = 3;
            this.buttonBuscarPaciente.Text = "Buscar Nombre";
            this.buttonBuscarPaciente.UseVisualStyleBackColor = true;
            this.buttonBuscarPaciente.Click += new System.EventHandler(this.buttonBuscarPaciente_Click);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToAddRows = false;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Calle,
            this.Ciudad,
            this.Codigo_postal,
            this.Telefono1,
            this.Telefono2,
            this.Telefono3});
            this.dataGridViewPacientes.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(76, 105);
            this.dataGridViewPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.RowHeadersWidth = 51;
            this.dataGridViewPacientes.RowTemplate.Height = 24;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(925, 204);
            this.dataGridViewPacientes.TabIndex = 4;
            this.dataGridViewPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellDoubleClick);
            this.dataGridViewPacientes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPacientes_CellMouseDown);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.MinimumWidth = 6;
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 125;
            // 
            // Codigo_postal
            // 
            this.Codigo_postal.HeaderText = "Codigo Postal";
            this.Codigo_postal.MinimumWidth = 6;
            this.Codigo_postal.Name = "Codigo_postal";
            this.Codigo_postal.ReadOnly = true;
            this.Codigo_postal.Width = 125;
            // 
            // Telefono1
            // 
            this.Telefono1.HeaderText = "Telefono 1";
            this.Telefono1.MinimumWidth = 6;
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Width = 125;
            // 
            // Telefono2
            // 
            this.Telefono2.HeaderText = "Telefono 2";
            this.Telefono2.MinimumWidth = 6;
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            this.Telefono2.Width = 125;
            // 
            // Telefono3
            // 
            this.Telefono3.HeaderText = "Telefono 3";
            this.Telefono3.MinimumWidth = 6;
            this.Telefono3.Name = "Telefono3";
            this.Telefono3.ReadOnly = true;
            this.Telefono3.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduce el nombre o parte del nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para mostrar todos los pacientes realiza una búsqueda en blanco";
            // 
            // buttonMedicamentos
            // 
            this.buttonMedicamentos.Location = new System.Drawing.Point(460, 363);
            this.buttonMedicamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMedicamentos.Name = "buttonMedicamentos";
            this.buttonMedicamentos.Size = new System.Drawing.Size(152, 37);
            this.buttonMedicamentos.TabIndex = 7;
            this.buttonMedicamentos.Text = "Ver medicamentos";
            this.buttonMedicamentos.UseVisualStyleBackColor = true;
            this.buttonMedicamentos.Click += new System.EventHandler(this.buttonMedicamentos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.buttonMedicamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.buttonBuscarPaciente);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonAgregarPaciente);
            this.Controls.Add(this.buttonCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Escritorio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonAgregarPaciente;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonBuscarPaciente;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMedicamentos;
    }
}