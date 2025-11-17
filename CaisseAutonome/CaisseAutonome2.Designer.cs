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
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            lblBienvenue = new Label();
            pnlScan = new Panel();
            btnPeser = new Button();
            txtCodeBarre = new TextBox();
            lblInstruction = new Label();
            pnlTicket = new Panel();
            lstArticles = new ListBox();
            lblTicket = new Label();
            pnlFidelite = new Panel();
            txtCarteFidelite = new TextBox();
            btnScannerCarte = new Button();
            lblFidelite = new Label();
            pnlTotal = new Panel();
            lblTotalMontant = new Label();
            lblTotalTexte = new Label();
            pnlPaiement = new Panel();
            btnAnnuler = new Button();
            btnEspeces = new Button();
            btnCarte = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlScan.SuspendLayout();
            pnlTicket.SuspendLayout();
            pnlFidelite.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlPaiement.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(220, 0, 0);
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Controls.Add(lblBienvenue);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 90);
            pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(20, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 70);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblBienvenue
            // 
            lblBienvenue.Dock = DockStyle.Fill;
            lblBienvenue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBienvenue.ForeColor = Color.White;
            lblBienvenue.Location = new Point(0, 0);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(1100, 90);
            lblBienvenue.TabIndex = 0;
            lblBienvenue.Text = "Bienvenue à votre caisse CIEL Market";
            lblBienvenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlScan
            // 
            pnlScan.BackColor = Color.WhiteSmoke;
            pnlScan.Controls.Add(btnPeser);
            pnlScan.Controls.Add(txtCodeBarre);
            pnlScan.Controls.Add(lblInstruction);
            pnlScan.Location = new Point(20, 110);
            pnlScan.Name = "pnlScan";
            pnlScan.Size = new Size(640, 110);
            pnlScan.TabIndex = 1;
            // 
            // btnPeser
            // 
            btnPeser.BackColor = Color.LightSkyBlue;
            btnPeser.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPeser.Location = new Point(460, 50);
            btnPeser.Name = "btnPeser";
            btnPeser.Size = new Size(160, 40);
            btnPeser.TabIndex = 2;
            btnPeser.Text = "Peser un article";
            btnPeser.UseVisualStyleBackColor = false;
            // 
            // txtCodeBarre
            // 
            txtCodeBarre.Font = new Font("Segoe UI", 18F);
            txtCodeBarre.Location = new Point(20, 50);
            txtCodeBarre.Name = "txtCodeBarre";
            txtCodeBarre.Size = new Size(420, 47);
            txtCodeBarre.TabIndex = 1;
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI", 14F);
            lblInstruction.Location = new Point(20, 10);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(600, 30);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Scannez un article ou pesez un produit :";
            // 
            // pnlTicket
            // 
            pnlTicket.BackColor = Color.White;
            pnlTicket.BorderStyle = BorderStyle.FixedSingle;
            pnlTicket.Controls.Add(lstArticles);
            pnlTicket.Controls.Add(lblTicket);
            pnlTicket.Location = new Point(20, 230);
            pnlTicket.Name = "pnlTicket";
            pnlTicket.Size = new Size(640, 460);
            pnlTicket.TabIndex = 2;
            // 
            // lstArticles
            // 
            lstArticles.BorderStyle = BorderStyle.None;
            lstArticles.Font = new Font("Consolas", 14F);
            lstArticles.FormattingEnabled = true;
            lstArticles.ItemHeight = 27;
            lstArticles.Location = new Point(10, 50);
            lstArticles.Name = "lstArticles";
            lstArticles.Size = new Size(620, 378);
            lstArticles.TabIndex = 1;
            // 
            // lblTicket
            // 
            lblTicket.BackColor = Color.LightGray;
            lblTicket.Dock = DockStyle.Top;
            lblTicket.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTicket.Location = new Point(0, 0);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(638, 40);
            lblTicket.TabIndex = 0;
            lblTicket.Text = "Votre ticket";
            lblTicket.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFidelite
            // 
            pnlFidelite.BackColor = Color.White;
            pnlFidelite.BorderStyle = BorderStyle.FixedSingle;
            pnlFidelite.Controls.Add(txtCarteFidelite);
            pnlFidelite.Controls.Add(btnScannerCarte);
            pnlFidelite.Controls.Add(lblFidelite);
            pnlFidelite.Location = new Point(680, 110);
            pnlFidelite.Name = "pnlFidelite";
            pnlFidelite.Size = new Size(400, 140);
            pnlFidelite.TabIndex = 3;
            // 
            // txtCarteFidelite
            // 
            txtCarteFidelite.Font = new Font("Segoe UI", 16F);
            txtCarteFidelite.Location = new Point(20, 50);
            txtCarteFidelite.Name = "txtCarteFidelite";
            txtCarteFidelite.Size = new Size(250, 43);
            txtCarteFidelite.TabIndex = 1;
            // 
            // btnScannerCarte
            // 
            btnScannerCarte.BackColor = Color.FromArgb(0, 120, 215);
            btnScannerCarte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnScannerCarte.ForeColor = Color.White;
            btnScannerCarte.Location = new Point(280, 50);
            btnScannerCarte.Name = "btnScannerCarte";
            btnScannerCarte.Size = new Size(100, 36);
            btnScannerCarte.TabIndex = 2;
            btnScannerCarte.Text = "Scanner";
            btnScannerCarte.UseVisualStyleBackColor = false;
            // 
            // lblFidelite
            // 
            lblFidelite.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFidelite.Location = new Point(20, 10);
            lblFidelite.Name = "lblFidelite";
            lblFidelite.Size = new Size(300, 30);
            lblFidelite.TabIndex = 0;
            lblFidelite.Text = "Carte de fidélité Carrefour";
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotalMontant);
            pnlTotal.Controls.Add(lblTotalTexte);
            pnlTotal.Location = new Point(680, 270);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(400, 130);
            pnlTotal.TabIndex = 4;
            // 
            // lblTotalMontant
            // 
            lblTotalMontant.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalMontant.ForeColor = Color.DarkGreen;
            lblTotalMontant.Location = new Point(20, 50);
            lblTotalMontant.Name = "lblTotalMontant";
            lblTotalMontant.Size = new Size(360, 70);
            lblTotalMontant.TabIndex = 1;
            lblTotalMontant.Text = "0,00 €";
            lblTotalMontant.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTexte
            // 
            lblTotalTexte.Font = new Font("Segoe UI", 18F);
            lblTotalTexte.ForeColor = Color.Gray;
            lblTotalTexte.Location = new Point(20, 15);
            lblTotalTexte.Name = "lblTotalTexte";
            lblTotalTexte.Size = new Size(360, 35);
            lblTotalTexte.TabIndex = 0;
            lblTotalTexte.Text = "Total à payer";
            // 
            // pnlPaiement
            // 
            pnlPaiement.BackColor = Color.WhiteSmoke;
            pnlPaiement.Controls.Add(btnAnnuler);
            pnlPaiement.Controls.Add(btnEspeces);
            pnlPaiement.Controls.Add(btnCarte);
            pnlPaiement.Location = new Point(680, 420);
            pnlPaiement.Name = "pnlPaiement";
            pnlPaiement.Size = new Size(400, 270);
            pnlPaiement.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.Firebrick;
            btnAnnuler.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(30, 190);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(340, 60);
            btnAnnuler.TabIndex = 2;
            btnAnnuler.Text = "ANNULER LA TRANSACTION";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEspeces
            // 
            btnEspeces.BackColor = Color.Gold;
            btnEspeces.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEspeces.Location = new Point(30, 100);
            btnEspeces.Name = "btnEspeces";
            btnEspeces.Size = new Size(340, 70);
            btnEspeces.TabIndex = 1;
            btnEspeces.Text = "PAYER EN ESPÈCES";
            btnEspeces.UseVisualStyleBackColor = false;
            // 
            // btnCarte
            // 
            btnCarte.BackColor = Color.FromArgb(0, 180, 0);
            btnCarte.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCarte.ForeColor = Color.White;
            btnCarte.Location = new Point(30, 20);
            btnCarte.Name = "btnCarte";
            btnCarte.Size = new Size(340, 70);
            btnCarte.TabIndex = 0;
            btnCarte.Text = "PAYER PAR CARTE";
            btnCarte.UseVisualStyleBackColor = false;
            // 
            // CaisseAutonome2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 720);
            Controls.Add(pnlPaiement);
            Controls.Add(pnlTotal);
            Controls.Add(pnlFidelite);
            Controls.Add(pnlTicket);
            Controls.Add(pnlScan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CaisseAutonome2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caisse Carrefour - Interface Client";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlScan.ResumeLayout(false);
            pnlScan.PerformLayout();
            pnlTicket.ResumeLayout(false);
            pnlFidelite.ResumeLayout(false);
            pnlFidelite.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlPaiement.ResumeLayout(false);
            ResumeLayout(false);
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
