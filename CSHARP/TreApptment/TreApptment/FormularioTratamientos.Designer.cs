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
            this.dataGridViewTratamientos = new System.Windows.Forms.DataGridView();
            this.comboBoxMedicamentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTratamientos
            // 
            this.dataGridViewTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTratamientos.Location = new System.Drawing.Point(44, 225);
            this.dataGridViewTratamientos.Name = "dataGridViewTratamientos";
            this.dataGridViewTratamientos.RowHeadersWidth = 51;
            this.dataGridViewTratamientos.RowTemplate.Height = 24;
            this.dataGridViewTratamientos.Size = new System.Drawing.Size(705, 150);
            this.dataGridViewTratamientos.TabIndex = 0;
            // 
            // comboBoxMedicamentos
            // 
            this.comboBoxMedicamentos.FormattingEnabled = true;
            this.comboBoxMedicamentos.Location = new System.Drawing.Point(353, 73);
            this.comboBoxMedicamentos.Name = "comboBoxMedicamentos";
            this.comboBoxMedicamentos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMedicamentos.TabIndex = 1;
            // 
            // FormularioTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxMedicamentos);
            this.Controls.Add(this.dataGridViewTratamientos);
            this.Name = "FormularioTratamientos";
            this.Text = "FormularioTratamientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTratamientos;
        private System.Windows.Forms.ComboBox comboBoxMedicamentos;
    }
}