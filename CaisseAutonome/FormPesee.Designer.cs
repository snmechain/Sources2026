namespace CaisseAutonome
{
    partial class FormPesee
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
            lblTitre = new Label();
            lstProduits = new ListBox();
            pnlBalance = new Panel();
            lblProduitSelectionne = new Label();
            lblPoidsTexte = new Label();
            lblPoidsValeur = new Label();
            lblPrixKgTexte = new Label();
            lblPrixKgValeur = new Label();
            lblTotalTexte = new Label();
            lblTotalValeur = new Label();
            btnValider = new Button();
            btnAnnuler = new Button();
            pnlHeader.SuspendLayout();
            pnlBalance.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 120, 215);
            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.Dock = DockStyle.Fill;
            lblTitre.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(0, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(900, 80);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Pesée des fruits et légumes";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstProduits
            // 
            lstProduits.BackColor = Color.WhiteSmoke;
            lstProduits.Font = new Font("Segoe UI", 14F);
            lstProduits.FormattingEnabled = true;
            lstProduits.ItemHeight = 31;
            lstProduits.Items.AddRange(new object[] { "🍎 Pommes", "🍌 Bananes", "🍊 Oranges", "🍇 Raisins", "\U0001f954 Pommes de terre", "\U0001f955 Carottes", "🍅 Tomates", "\U0001f952 Concombres", "🍉 Pastèque" });
            lstProduits.Location = new Point(30, 110);
            lstProduits.Name = "lstProduits";
            lstProduits.Size = new Size(350, 376);
            lstProduits.TabIndex = 1;
            // 
            // pnlBalance
            // 
            pnlBalance.BackColor = Color.White;
            pnlBalance.BorderStyle = BorderStyle.FixedSingle;
            pnlBalance.Controls.Add(lblProduitSelectionne);
            pnlBalance.Controls.Add(lblPoidsTexte);
            pnlBalance.Controls.Add(lblPoidsValeur);
            pnlBalance.Controls.Add(lblPrixKgTexte);
            pnlBalance.Controls.Add(lblPrixKgValeur);
            pnlBalance.Controls.Add(lblTotalTexte);
            pnlBalance.Controls.Add(lblTotalValeur);
            pnlBalance.Location = new Point(400, 110);
            pnlBalance.Name = "pnlBalance";
            pnlBalance.Size = new Size(480, 404);
            pnlBalance.TabIndex = 2;
            // 
            // lblProduitSelectionne
            // 
            lblProduitSelectionne.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProduitSelectionne.Location = new Point(20, 20);
            lblProduitSelectionne.Name = "lblProduitSelectionne";
            lblProduitSelectionne.Size = new Size(440, 40);
            lblProduitSelectionne.TabIndex = 0;
            lblProduitSelectionne.Text = "Sélectionnez un produit...";
            lblProduitSelectionne.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPoidsTexte
            // 
            lblPoidsTexte.Font = new Font("Segoe UI", 16F);
            lblPoidsTexte.Location = new Point(50, 100);
            lblPoidsTexte.Name = "lblPoidsTexte";
            lblPoidsTexte.Size = new Size(200, 30);
            lblPoidsTexte.TabIndex = 1;
            lblPoidsTexte.Text = "Poids mesuré :";
            // 
            // lblPoidsValeur
            // 
            lblPoidsValeur.Font = new Font("Consolas", 24F, FontStyle.Bold);
            lblPoidsValeur.ForeColor = Color.RoyalBlue;
            lblPoidsValeur.Location = new Point(260, 90);
            lblPoidsValeur.Name = "lblPoidsValeur";
            lblPoidsValeur.Size = new Size(180, 50);
            lblPoidsValeur.TabIndex = 2;
            lblPoidsValeur.Text = "0.000 kg";
            lblPoidsValeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrixKgTexte
            // 
            lblPrixKgTexte.Font = new Font("Segoe UI", 16F);
            lblPrixKgTexte.Location = new Point(50, 170);
            lblPrixKgTexte.Name = "lblPrixKgTexte";
            lblPrixKgTexte.Size = new Size(200, 40);
            lblPrixKgTexte.TabIndex = 3;
            lblPrixKgTexte.Text = "Prix / kg :";
            // 
            // lblPrixKgValeur
            // 
            lblPrixKgValeur.Font = new Font("Consolas", 24F, FontStyle.Bold);
            lblPrixKgValeur.ForeColor = Color.DarkOrange;
            lblPrixKgValeur.Location = new Point(260, 160);
            lblPrixKgValeur.Name = "lblPrixKgValeur";
            lblPrixKgValeur.Size = new Size(180, 50);
            lblPrixKgValeur.TabIndex = 4;
            lblPrixKgValeur.Text = "0,00 €";
            lblPrixKgValeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTexte
            // 
            lblTotalTexte.Font = new Font("Segoe UI", 16F);
            lblTotalTexte.Location = new Point(50, 250);
            lblTotalTexte.Name = "lblTotalTexte";
            lblTotalTexte.Size = new Size(200, 39);
            lblTotalTexte.TabIndex = 5;
            lblTotalTexte.Text = "Total à payer :";
            // 
            // lblTotalValeur
            // 
            lblTotalValeur.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblTotalValeur.ForeColor = Color.ForestGreen;
            lblTotalValeur.Location = new Point(40, 280);
            lblTotalValeur.Name = "lblTotalValeur";
            lblTotalValeur.Size = new Size(400, 80);
            lblTotalValeur.TabIndex = 6;
            lblTotalValeur.Text = "0,00 €";
            lblTotalValeur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.ForestGreen;
            btnValider.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnValider.ForeColor = Color.White;
            btnValider.Location = new Point(520, 540);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(360, 60);
            btnValider.TabIndex = 3;
            btnValider.Text = "VALIDER LE POIDS";
            btnValider.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.Firebrick;
            btnAnnuler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(30, 540);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(360, 60);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // FormPesee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 630);
            Controls.Add(btnAnnuler);
            Controls.Add(btnValider);
            Controls.Add(pnlBalance);
            Controls.Add(lstProduits);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPesee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesée - Carrefour";
            pnlHeader.ResumeLayout(false);
            pnlBalance.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ListBox lstProduits;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblProduitSelectionne;
        private System.Windows.Forms.Label lblPoidsTexte;
        private System.Windows.Forms.Label lblPoidsValeur;
        private System.Windows.Forms.Label lblPrixKgTexte;
        private System.Windows.Forms.Label lblPrixKgValeur;
        private System.Windows.Forms.Label lblTotalTexte;
        private System.Windows.Forms.Label lblTotalValeur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
