namespace AppVuelos
{
    partial class frmRepBasicos
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
            this.btnPais = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPais
            // 
            this.btnPais.Location = new System.Drawing.Point(73, 62);
            this.btnPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(165, 28);
            this.btnPais.TabIndex = 0;
            this.btnPais.Text = "Reportes Basicos";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reportes ClientesVUELOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRepBasicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPais);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRepBasicos";
            this.Text = "ReportesBasicos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Button button1;
    }
}