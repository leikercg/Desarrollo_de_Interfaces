namespace ControlForm
{
    partial class ElegirColor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lbColor = new System.Windows.Forms.Label();
            this.labelRojo = new System.Windows.Forms.Label();
            this.labelVerde = new System.Windows.Forms.Label();
            this.labelAzul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(147, 20);
            this.hScrollBar1.Maximum = 256;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(309, 22);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.RosyBrown;
            this.lbColor.Location = new System.Drawing.Point(25, 20);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(80, 90);
            this.lbColor.TabIndex = 1;
            // 
            // labelRojo
            // 
            this.labelRojo.AutoSize = true;
            this.labelRojo.Location = new System.Drawing.Point(511, 20);
            this.labelRojo.Name = "labelRojo";
            this.labelRojo.Size = new System.Drawing.Size(36, 13);
            this.labelRojo.TabIndex = 2;
            this.labelRojo.Text = "ROJO";
            // 
            // labelVerde
            // 
            this.labelVerde.AutoSize = true;
            this.labelVerde.Location = new System.Drawing.Point(511, 52);
            this.labelVerde.Name = "labelVerde";
            this.labelVerde.Size = new System.Drawing.Size(44, 13);
            this.labelVerde.TabIndex = 3;
            this.labelVerde.Text = "VERDE";
            // 
            // labelAzul
            // 
            this.labelAzul.AutoSize = true;
            this.labelAzul.Location = new System.Drawing.Point(511, 88);
            this.labelAzul.Name = "labelAzul";
            this.labelAzul.Size = new System.Drawing.Size(35, 13);
            this.labelAzul.TabIndex = 4;
            this.labelAzul.Text = "AZUL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(147, 52);
            this.hScrollBar2.Maximum = 256;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(309, 22);
            this.hScrollBar2.TabIndex = 8;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(147, 88);
            this.hScrollBar3.Maximum = 256;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(309, 22);
            this.hScrollBar3.TabIndex = 9;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // ElegirColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAzul);
            this.Controls.Add(this.labelVerde);
            this.Controls.Add(this.labelRojo);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "ElegirColor";
            this.Size = new System.Drawing.Size(671, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label labelRojo;
        private System.Windows.Forms.Label labelVerde;
        private System.Windows.Forms.Label labelAzul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
    }
}
