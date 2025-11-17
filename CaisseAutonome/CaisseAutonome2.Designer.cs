namespace CaisseAutonome
{
    partial class CaisseAutonome2
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.pnlScan = new System.Windows.Forms.Panel();
            this.btnPeser = new System.Windows.Forms.Button();
            this.txtCodeBarre = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlTicket = new System.Windows.Forms.Panel();
            this.lstArticles = new System.Windows.Forms.ListBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.pnlFidelite = new System.Windows.Forms.Panel();
            this.txtCarteFidelite = new System.Windows.Forms.TextBox();
            this.btnScannerCarte = new System.Windows.Forms.Button();
            this.lblFidelite = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTexte = new System.Windows.Forms.Label();
            this.lblTotalMontant = new System.Windows.Forms.Label();
            this.pnlPaiement = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEspeces = new System.Windows.Forms.Button();
            this.btnCarte = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlScan.SuspendLayout();
            this.pnlTicket.SuspendLayout();
            this.pnlFidelite.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlPaiement.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(220, 0, 0);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblBienvenue);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 90);
            this.pnlHeader.TabIndex = 0;

            // 
            // picLogo
            // 
            this.picLogo.Image = null; // Vous pouvez ajouter un logo Carrefour ici
            this.picLogo.Location = new System.Drawing.Point(20, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;

            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBienvenue.ForeColor = System.Drawing.Color.White;
            this.lblBienvenue.Location = new System.Drawing.Point(0, 0);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(1100, 90);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue à votre caisse Carrefour";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlScan
            // 
            this.pnlScan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlScan.Controls.Add(this.btnPeser);
            this.pnlScan.Controls.Add(this.txtCodeBarre);
            this.pnlScan.Controls.Add(this.lblInstruction);
            this.pnlScan.Location = new System.Drawing.Point(20, 110);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(640, 110);
            this.pnlScan.TabIndex = 1;

            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblInstruction.Location = new System.Drawing.Point(20, 10);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(600, 30);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Scannez un article ou pesez un produit :";

            // 
            // txtCodeBarre
            // 
            this.txtCodeBarre.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCodeBarre.Location = new System.Drawing.Point(20, 50);
            this.txtCodeBarre.Name = "txtCodeBarre";
            this.txtCodeBarre.Size = new System.Drawing.Size(420, 39);
            this.txtCodeBarre.TabIndex = 1;

            // 
            // btnPeser
            // 
            this.btnPeser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPeser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPeser.Location = new System.Drawing.Point(460, 50);
            this.btnPeser.Name = "btnPeser";
            this.btnPeser.Size = new System.Drawing.Size(160, 40);
            this.btnPeser.TabIndex = 2;
            this.btnPeser.Text = "Peser un article";
            this.btnPeser.UseVisualStyleBackColor = false;

            // 
            // pnlTicket
            // 
            this.pnlTicket.BackColor = System.Drawing.Color.White;
            this.pnlTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTicket.Controls.Add(this.lstArticles);
            this.pnlTicket.Controls.Add(this.lblTicket);
            this.pnlTicket.Location = new System.Drawing.Point(20, 230);
            this.pnlTicket.Name = "pnlTicket";
            this.pnlTicket.Size = new System.Drawing.Size(640, 460);
            this.pnlTicket.TabIndex = 2;

            // 
            // lblTicket
            // 
            this.lblTicket.BackColor = System.Drawing.Color.LightGray;
            this.lblTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicket.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTicket.Location = new System.Drawing.Point(0, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(638, 40);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Votre ticket";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lstArticles
            // 
            this.lstArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstArticles.Font = new System.Drawing.Font("Consolas", 14F);
            this.lstArticles.FormattingEnabled = true;
            this.lstArticles.ItemHeight = 22;
            this.lstArticles.Location = new System.Drawing.Point(10, 50);
            this.lstArticles.Name = "lstArticles";
            this.lstArticles.Size = new System.Drawing.Size(620, 396);
            this.lstArticles.TabIndex = 1;

            // 
            // pnlFidelite
            // 
            this.pnlFidelite.BackColor = System.Drawing.Color.White;
            this.pnlFidelite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFidelite.Controls.Add(this.txtCarteFidelite);
            this.pnlFidelite.Controls.Add(this.btnScannerCarte);
            this.pnlFidelite.Controls.Add(this.lblFidelite);
            this.pnlFidelite.Location = new System.Drawing.Point(680, 110);
            this.pnlFidelite.Name = "pnlFidelite";
            this.pnlFidelite.Size = new System.Drawing.Size(400, 140);
            this.pnlFidelite.TabIndex = 3;

            // 
            // lblFidelite
            // 
            this.lblFidelite.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFidelite.Location = new System.Drawing.Point(20, 10);
            this.lblFidelite.Name = "lblFidelite";
            this.lblFidelite.Size = new System.Drawing.Size(300, 30);
            this.lblFidelite.TabIndex = 0;
            this.lblFidelite.Text = "Carte de fidélité Carrefour";

            // 
            // txtCarteFidelite
            // 
            this.txtCarteFidelite.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCarteFidelite.Location = new System.Drawing.Point(20, 50);
            this.txtCarteFidelite.Name = "txtCarteFidelite";
            this.txtCarteFidelite.Size = new System.Drawing.Size(250, 36);
            this.txtCarteFidelite.TabIndex = 1;

            // 
            // btnScannerCarte
            // 
            this.btnScannerCarte.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnScannerCarte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnScannerCarte.ForeColor = System.Drawing.Color.White;
            this.btnScannerCarte.Location = new System.Drawing.Point(280, 50);
            this.btnScannerCarte.Name = "btnScannerCarte";
            this.btnScannerCarte.Size = new System.Drawing.Size(100, 36);
            this.btnScannerCarte.TabIndex = 2;
            this.btnScannerCarte.Text = "Scanner";
            this.btnScannerCarte.UseVisualStyleBackColor = false;

            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotalMontant);
            this.pnlTotal.Controls.Add(this.lblTotalTexte);
            this.pnlTotal.Location = new System.Drawing.Point(680, 270);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(400, 130);
            this.pnlTotal.TabIndex = 4;

            // 
            // lblTotalTexte
            // 
            this.lblTotalTexte.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTotalTexte.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTexte.Location = new System.Drawing.Point(20, 15);
            this.lblTotalTexte.Name = "lblTotalTexte";
            this.lblTotalTexte.Size = new System.Drawing.Size(360, 35);
            this.lblTotalTexte.TabIndex = 0;
            this.lblTotalTexte.Text = "Total à payer";

            // 
            // lblTotalMontant
            // 
            this.lblTotalMontant.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalMontant.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalMontant.Location = new System.Drawing.Point(20, 50);
            this.lblTotalMontant.Name = "lblTotalMontant";
            this.lblTotalMontant.Size = new System.Drawing.Size(360, 70);
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
            this.pnlPaiement.Location = new System.Drawing.Point(680, 420);
            this.pnlPaiement.Name = "pnlPaiement";
            this.pnlPaiement.Size = new System.Drawing.Size(400, 270);
            this.pnlPaiement.TabIndex = 5;

            // 
            // btnCarte
            // 
            this.btnCarte.BackColor = System.Drawing.Color.FromArgb(0, 180, 0);
            this.btnCarte.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCarte.ForeColor = System.Drawing.Color.White;
            this.btnCarte.Location = new System.Drawing.Point(30, 20);
            this.btnCarte.Name = "btnCarte";
            this.btnCarte.Size = new System.Drawing.Size(340, 70);
            this.btnCarte.TabIndex = 0;
            this.btnCarte.Text = "PAYER PAR CARTE";
            this.btnCarte.UseVisualStyleBackColor = false;

            // 
            // btnEspeces
            // 
            this.btnEspeces.BackColor = System.Drawing.Color.Gold;
            this.btnEspeces.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnEspeces.Location = new System.Drawing.Point(30, 100);
            this.btnEspeces.Name = "btnEspeces";
            this.btnEspeces.Size = new System.Drawing.Size(340, 70);
            this.btnEspeces.TabIndex = 1;
            this.btnEspeces.Text = "PAYER EN ESPÈCES";
            this.btnEspeces.UseVisualStyleBackColor = false;

            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(30, 190);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(340, 60);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "ANNULER LA TRANSACTION";
            this.btnAnnuler.UseVisualStyleBackColor = false;

            // 
            // FormCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.pnlPaiement);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlFidelite);
            this.Controls.Add(this.pnlTicket);
            this.Controls.Add(this.pnlScan);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCaisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caisse Carrefour - Interface Client";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlScan.ResumeLayout(false);
            this.pnlScan.PerformLayout();
            this.pnlTicket.ResumeLayout(false);
            this.pnlFidelite.ResumeLayout(false);
            this.pnlFidelite.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlPaiement.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Panel pnlScan;
        private System.Windows.Forms.Button btnPeser;
        private System.Windows.Forms.TextBox txtCodeBarre;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel pnlTicket;
        private System.Windows.Forms.ListBox lstArticles;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Panel pnlFidelite;
        private System.Windows.Forms.TextBox txtCarteFidelite;
        private System.Windows.Forms.Button btnScannerCarte;
        private System.Windows.Forms.Label lblFidelite;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTexte;
        private System.Windows.Forms.Label lblTotalMontant;
        private System.Windows.Forms.Panel pnlPaiement;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEspeces;
        private System.Windows.Forms.Button btnCarte;
    }
}
