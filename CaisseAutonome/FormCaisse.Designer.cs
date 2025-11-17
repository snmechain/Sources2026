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
            pnlHeader = new Panel();
            lblBienvenue = new Label();
            pnlScan = new Panel();
            txtCodeBarre = new TextBox();
            lblInstruction = new Label();
            pnlTicket = new Panel();
            lstArticles = new ListBox();
            lblTicket = new Label();
            pnlTotal = new Panel();
            lblTotalMontant = new Label();
            lblTotalTexte = new Label();
            pnlPaiement = new Panel();
            btnAnnuler = new Button();
            btnEspeces = new Button();
            btnCarte = new Button();
            pnlHeader.SuspendLayout();
            pnlScan.SuspendLayout();
            pnlTicket.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlPaiement.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(220, 0, 0);
            pnlHeader.Controls.Add(lblBienvenue);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblBienvenue
            // 
            lblBienvenue.Dock = DockStyle.Fill;
            lblBienvenue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBienvenue.ForeColor = Color.White;
            lblBienvenue.Location = new Point(0, 0);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(1000, 80);
            lblBienvenue.TabIndex = 0;
            lblBienvenue.Text = "Bienvenue à votre caisse CIEL Market";
            lblBienvenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlScan
            // 
            pnlScan.BackColor = Color.WhiteSmoke;
            pnlScan.Controls.Add(txtCodeBarre);
            pnlScan.Controls.Add(lblInstruction);
            pnlScan.Location = new Point(20, 100);
            pnlScan.Name = "pnlScan";
            pnlScan.Size = new Size(600, 90);
            pnlScan.TabIndex = 1;
            // 
            // txtCodeBarre
            // 
            txtCodeBarre.Font = new Font("Segoe UI", 18F);
            txtCodeBarre.Location = new Point(20, 45);
            txtCodeBarre.Name = "txtCodeBarre";
            txtCodeBarre.Size = new Size(560, 47);
            txtCodeBarre.TabIndex = 1;
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI", 14F);
            lblInstruction.Location = new Point(20, 10);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(560, 30);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Scannez vos articles ou entrez un code-barres :";
            // 
            // pnlTicket
            // 
            pnlTicket.BackColor = Color.White;
            pnlTicket.BorderStyle = BorderStyle.FixedSingle;
            pnlTicket.Controls.Add(lstArticles);
            pnlTicket.Controls.Add(lblTicket);
            pnlTicket.Location = new Point(20, 200);
            pnlTicket.Name = "pnlTicket";
            pnlTicket.Size = new Size(600, 450);
            pnlTicket.TabIndex = 2;
            // 
            // lstArticles
            // 
            lstArticles.BackColor = Color.White;
            lstArticles.BorderStyle = BorderStyle.None;
            lstArticles.Font = new Font("Consolas", 14F);
            lstArticles.FormattingEnabled = true;
            lstArticles.ItemHeight = 27;
            lstArticles.Location = new Point(10, 50);
            lstArticles.Name = "lstArticles";
            lstArticles.Size = new Size(580, 351);
            lstArticles.TabIndex = 1;
            // 
            // lblTicket
            // 
            lblTicket.BackColor = Color.LightGray;
            lblTicket.Dock = DockStyle.Top;
            lblTicket.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTicket.ForeColor = Color.Black;
            lblTicket.Location = new Point(0, 0);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(598, 40);
            lblTicket.TabIndex = 0;
            lblTicket.Text = "Votre ticket";
            lblTicket.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(255, 255, 255);
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotalMontant);
            pnlTotal.Controls.Add(lblTotalTexte);
            pnlTotal.Location = new Point(640, 100);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(340, 150);
            pnlTotal.TabIndex = 3;
            // 
            // lblTotalMontant
            // 
            lblTotalMontant.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalMontant.ForeColor = Color.DarkGreen;
            lblTotalMontant.Location = new Point(20, 60);
            lblTotalMontant.Name = "lblTotalMontant";
            lblTotalMontant.Size = new Size(300, 70);
            lblTotalMontant.TabIndex = 1;
            lblTotalMontant.Text = "0,00 €";
            lblTotalMontant.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTexte
            // 
            lblTotalTexte.Font = new Font("Segoe UI", 18F);
            lblTotalTexte.ForeColor = Color.Gray;
            lblTotalTexte.Location = new Point(20, 20);
            lblTotalTexte.Name = "lblTotalTexte";
            lblTotalTexte.Size = new Size(300, 40);
            lblTotalTexte.TabIndex = 0;
            lblTotalTexte.Text = "Total à payer";
            // 
            // pnlPaiement
            // 
            pnlPaiement.BackColor = Color.WhiteSmoke;
            pnlPaiement.Controls.Add(btnAnnuler);
            pnlPaiement.Controls.Add(btnEspeces);
            pnlPaiement.Controls.Add(btnCarte);
            pnlPaiement.Location = new Point(640, 270);
            pnlPaiement.Name = "pnlPaiement";
            pnlPaiement.Size = new Size(340, 380);
            pnlPaiement.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.Firebrick;
            btnAnnuler.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(20, 260);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(300, 80);
            btnAnnuler.TabIndex = 2;
            btnAnnuler.Text = "ANNULER LA TRANSACTION";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEspeces
            // 
            btnEspeces.BackColor = Color.Gold;
            btnEspeces.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEspeces.Location = new Point(20, 140);
            btnEspeces.Name = "btnEspeces";
            btnEspeces.Size = new Size(300, 90);
            btnEspeces.TabIndex = 1;
            btnEspeces.Text = "PAYER EN ESPÈCES";
            btnEspeces.UseVisualStyleBackColor = false;
            // 
            // btnCarte
            // 
            btnCarte.BackColor = Color.FromArgb(0, 180, 0);
            btnCarte.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCarte.ForeColor = Color.White;
            btnCarte.Location = new Point(20, 30);
            btnCarte.Name = "btnCarte";
            btnCarte.Size = new Size(300, 90);
            btnCarte.TabIndex = 0;
            btnCarte.Text = "PAYER PAR CARTE";
            btnCarte.UseVisualStyleBackColor = false;
            // 
            // FormCaisse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 680);
            Controls.Add(pnlPaiement);
            Controls.Add(pnlTotal);
            Controls.Add(pnlTicket);
            Controls.Add(pnlScan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormCaisse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caisse Carrefour - Interface Client";
            pnlHeader.ResumeLayout(false);
            pnlScan.ResumeLayout(false);
            pnlScan.PerformLayout();
            pnlTicket.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlPaiement.ResumeLayout(false);
            ResumeLayout(false);
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
