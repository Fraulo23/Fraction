namespace Fraction
{
    partial class Form1
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
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.lstFrazioni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(305, 181);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(135, 69);
            this.btnSomma.TabIndex = 0;
            this.btnSomma.Text = "Somma";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(305, 285);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(135, 52);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(307, 371);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(132, 49);
            this.btnPulisci.TabIndex = 2;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(16, 255);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(249, 22);
            this.txtN.TabIndex = 3;
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(33, 377);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(44, 16);
            this.lblRisultato.TabIndex = 4;
            this.lblRisultato.Text = "label1";
            // 
            // lstFrazioni
            // 
            this.lstFrazioni.FormattingEnabled = true;
            this.lstFrazioni.ItemHeight = 16;
            this.lstFrazioni.Location = new System.Drawing.Point(500, 41);
            this.lstFrazioni.Name = "lstFrazioni";
            this.lstFrazioni.Size = new System.Drawing.Size(482, 452);
            this.lstFrazioni.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 504);
            this.Controls.Add(this.lstFrazioni);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnSomma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.ListBox lstFrazioni;
    }
}

