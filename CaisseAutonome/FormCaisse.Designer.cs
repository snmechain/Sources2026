namespace CaisseAutonome
{
    partial class FormCaisse
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur Windows Form

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.pnlScan = new System.Windows.Forms.Panel();
            this.txtCodeBarre = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlTicket = new System.Windows.Forms.Panel();
            this.lstArticles = new System.Windows.Forms.ListBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTexte = new System.Windows.Forms.Label();
            this.lblTotalMontant = new System.Windows.Forms.Label();
            this.pnlPaiement = new System.Windows.Forms.Panel();
            this.btnCarte = new System.Windows.Forms.Button();
            this.btnEspeces = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlScan.SuspendLayout();
            this.pnlTicket.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlPaiement.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(220, 0, 0);
            this.pnlHeader.Controls.Add(this.lblBienvenue);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 80);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBienvenue.ForeColor = System.Drawing.Color.White;
            this.lblBienvenue.Location = new System.Drawing.Point(0, 0);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(1000, 80);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue à votre caisse Carrefour";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlScan
            // 
            this.pnlScan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlScan.Controls.Add(this.txtCodeBarre);
            this.pnlScan.Controls.Add(this.lblInstruction);
            this.pnlScan.Location = new System.Drawing.Point(20, 100);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(600, 90);
            this.pnlScan.TabIndex = 1;

            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblInstruction.Location = new System.Drawing.Point(20, 10);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(560, 30);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Scannez vos articles ou entrez un code-barres :";

            // 
            // txtCodeBarre
            // 
            this.txtCodeBarre.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCodeBarre.Location = new System.Drawing.Point(20, 45);
            this.txtCodeBarre.Name = "txtCodeBarre";
            this.txtCodeBarre.Size = new System.Drawing.Size(560, 39);
            this.txtCodeBarre.TabIndex = 1;

            // 
            // pnlTicket
            // 
            this.pnlTicket.BackColor = System.Drawing.Color.White;
            this.pnlTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTicket.Controls.Add(this.lstArticles);
            this.pnlTicket.Controls.Add(this.lblTicket);
            this.pnlTicket.Location = new System.Drawing.Point(20, 200);
            this.pnlTicket.Name = "pnlTicket";
            this.pnlTicket.Size = new System.Drawing.Size(600, 450);
            this.pnlTicket.TabIndex = 2;

            // 
            // lblTicket
            // 
            this.lblTicket.BackColor = System.Drawing.Color.LightGray;
            this.lblTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicket.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTicket.ForeColor = System.Drawing.Color.Black;
            this.lblTicket.Location = new System.Drawing.Point(0, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(598, 40);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Votre ticket";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lstArticles
            // 
            this.lstArticles.BackColor = System.Drawing.Color.White;
            this.lstArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstArticles.Font = new System.Drawing.Font("Consolas", 14F);
            this.lstArticles.FormattingEnabled = true;
            this.lstArticles.ItemHeight = 22;
            this.lstArticles.Location = new System.Drawing.Point(10, 50);
            this.lstArticles.Name = "lstArticles";
            this.lstArticles.Size = new System.Drawing.Size(580, 374);
            this.lstArticles.TabIndex = 1;

            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotalMontant);
            this.pnlTotal.Controls.Add(this.lblTotalTexte);
            this.pnlTotal.Location = new System.Drawing.Point(640, 100);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(340, 150);
            this.pnlTotal.TabIndex = 3;

            // 
            // lblTotalTexte
            // 
            this.lblTotalTexte.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTotalTexte.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTexte.Location = new System.Drawing.Point(20, 20);
            this.lblTotalTexte.Name = "lblTotalTexte";
            this.lblTotalTexte.Size = new System.Drawing.Size(300, 40);
            this.lblTotalTexte.TabIndex = 0;
            this.lblTotalTexte.Text = "Total à payer";

            // 
            // lblTotalMontant
            // 
            this.lblTotalMontant.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalMontant.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalMontant.Location = new System.Drawing.Point(20, 60);
            this.lblTotalMontant.Name = "lblTotalMontant";
            this.lblTotalMontant.Size = new System.Drawing.Size(300, 70);
            this.lblTotalMontant.TabIndex = 1;
            this.lblTotalMontant.Text = "0,00 €";
            this.lblTotalMontant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // pnlPaiement
            // 
            this.pnlPaiement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPaiement.Controls.Add(this.btnAnnuler);
            this.pnlPaiement.Controls.Add(this.btnEspeces);
            this.pnlPaiement.Controls.Add(this.btnCarte);
            this.pnlPaiement.Location = new System.Drawing.Point(640, 270);
            this.pnlPaiement.Name = "pnlPaiement";
            this.pnlPaiement.Size = new System.Drawing.Size(340, 380);
            this.pnlPaiement.TabIndex = 4;

            // 
            // btnCarte
            // 
            this.btnCarte.BackColor = System.Drawing.Color.FromArgb(0, 180, 0);
            this.btnCarte.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCarte.ForeColor = System.Drawing.Color.White;
            this.btnCarte.Location = new System.Drawing.Point(20, 30);
            this.btnCarte.Name = "btnCarte";
            this.btnCarte.Size = new System.Drawing.Size(300, 90);
            this.btnCarte.TabIndex = 0;
            this.btnCarte.Text = "PAYER PAR CARTE";
            this.btnCarte.UseVisualStyleBackColor = false;

            // 
            // btnEspeces
            // 
            this.btnEspeces.BackColor = System.Drawing.Color.Gold;
            this.btnEspeces.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnEspeces.Location = new System.Drawing.Point(20, 140);
            this.btnEspeces.Name = "btnEspeces";
            this.btnEspeces.Size = new System.Drawing.Size(300, 90);
            this.btnEspeces.TabIndex = 1;
            this.btnEspeces.Text = "PAYER EN ESPÈCES";
            this.btnEspeces.UseVisualStyleBackColor = false;

            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(20, 260);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(300, 80);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "ANNULER LA TRANSACTION";
            this.btnAnnuler.UseVisualStyleBackColor = false;

            // 
            // FormCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.pnlPaiement);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlTicket);
            this.Controls.Add(this.pnlScan);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCaisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caisse Carrefour - Interface Client";
            this.pnlHeader.ResumeLayout(false);
            this.pnlScan.ResumeLayout(false);
            this.pnlScan.PerformLayout();
            this.pnlTicket.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlPaiement.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Panel pnlScan;
        private System.Windows.Forms.TextBox txtCodeBarre;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel pnlTicket;
        private System.Windows.Forms.ListBox lstArticles;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTexte;
        private System.Windows.Forms.Label lblTotalMontant;
        private System.Windows.Forms.Panel pnlPaiement;
        private System.Windows.Forms.Button btnCarte;
        private System.Windows.Forms.Button btnEspeces;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
