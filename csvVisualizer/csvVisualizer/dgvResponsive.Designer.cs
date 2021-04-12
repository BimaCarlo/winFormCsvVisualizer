
namespace csvVisualizer
{
    partial class dgvResponsive
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.aprifile = new System.Windows.Forms.OpenFileDialog();
            this.lblTesto = new System.Windows.Forms.Label();
            this.btnCarica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 442);
            this.dgv.TabIndex = 0;
            this.dgv.SizeChanged += new System.EventHandler(this.dgv_SizeChanged);
            // 
            // aprifile
            // 
            this.aprifile.FileName = "openFileDialog1";
            // 
            // lblTesto
            // 
            this.lblTesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTesto.AutoSize = true;
            this.lblTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTesto.Location = new System.Drawing.Point(12, 465);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(0, 17);
            this.lblTesto.TabIndex = 1;
            // 
            // btnCarica
            // 
            this.btnCarica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarica.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCarica.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarica.Location = new System.Drawing.Point(713, 463);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(75, 23);
            this.btnCarica.TabIndex = 2;
            this.btnCarica.Text = "Carica Dati";
            this.btnCarica.UseVisualStyleBackColor = false;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // dgvResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.dgv);
            this.Name = "dgvResponsive";
            this.Text = "VISUALIZZATORE CSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.OpenFileDialog aprifile;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Button btnCarica;
    }
}

