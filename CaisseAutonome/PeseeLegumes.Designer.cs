namespace CaisseAutonome
{
    partial class PeseeLegumes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblTitre = new Label();
            pnlProduits = new FlowLayoutPanel();
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
            images = new ImageList(components);
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
            pnlHeader.Size = new Size(1108, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.Dock = DockStyle.Fill;
            lblTitre.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(0, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(1108, 80);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Sélectionnez un produit à peser";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlProduits
            // 
            pnlProduits.AutoScroll = true;
            pnlProduits.BackColor = Color.WhiteSmoke;
            pnlProduits.Location = new Point(20, 100);
            pnlProduits.Name = "pnlProduits";
            pnlProduits.Padding = new Padding(10);
            pnlProduits.Size = new Size(650, 847);
            pnlProduits.TabIndex = 1;
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
            pnlBalance.Location = new Point(690, 100);
            pnlBalance.Name = "pnlBalance";
            pnlBalance.Size = new Size(390, 400);
            pnlBalance.TabIndex = 2;
            // 
            // lblProduitSelectionne
            // 
            lblProduitSelectionne.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProduitSelectionne.Location = new Point(10, 15);
            lblProduitSelectionne.Name = "lblProduitSelectionne";
            lblProduitSelectionne.Size = new Size(370, 40);
            lblProduitSelectionne.TabIndex = 0;
            lblProduitSelectionne.Text = "Aucun produit sélectionné";
            lblProduitSelectionne.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPoidsTexte
            // 
            lblPoidsTexte.Font = new Font("Segoe UI", 14F);
            lblPoidsTexte.Location = new Point(20, 90);
            lblPoidsTexte.Name = "lblPoidsTexte";
            lblPoidsTexte.Size = new Size(150, 30);
            lblPoidsTexte.TabIndex = 1;
            lblPoidsTexte.Text = "Poids mesuré :";
            // 
            // lblPoidsValeur
            // 
            lblPoidsValeur.Font = new Font("Consolas", 22F, FontStyle.Bold);
            lblPoidsValeur.ForeColor = Color.RoyalBlue;
            lblPoidsValeur.Location = new Point(180, 80);
            lblPoidsValeur.Name = "lblPoidsValeur";
            lblPoidsValeur.Size = new Size(180, 50);
            lblPoidsValeur.TabIndex = 2;
            lblPoidsValeur.Text = "0.000 kg";
            lblPoidsValeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrixKgTexte
            // 
            lblPrixKgTexte.Font = new Font("Segoe UI", 14F);
            lblPrixKgTexte.Location = new Point(20, 160);
            lblPrixKgTexte.Name = "lblPrixKgTexte";
            lblPrixKgTexte.Size = new Size(150, 30);
            lblPrixKgTexte.TabIndex = 3;
            lblPrixKgTexte.Text = "Prix / Kg :";
            // 
            // lblPrixKgValeur
            // 
            lblPrixKgValeur.Font = new Font("Consolas", 22F, FontStyle.Bold);
            lblPrixKgValeur.ForeColor = Color.DarkOrange;
            lblPrixKgValeur.Location = new Point(180, 150);
            lblPrixKgValeur.Name = "lblPrixKgValeur";
            lblPrixKgValeur.Size = new Size(180, 50);
            lblPrixKgValeur.TabIndex = 4;
            lblPrixKgValeur.Text = "0,00 €";
            lblPrixKgValeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTexte
            // 
            lblTotalTexte.Font = new Font("Segoe UI", 14F);
            lblTotalTexte.Location = new Point(20, 230);
            lblTotalTexte.Name = "lblTotalTexte";
            lblTotalTexte.Size = new Size(150, 30);
            lblTotalTexte.TabIndex = 5;
            lblTotalTexte.Text = "Total :";
            // 
            // lblTotalValeur
            // 
            lblTotalValeur.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblTotalValeur.ForeColor = Color.ForestGreen;
            lblTotalValeur.Location = new Point(10, 260);
            lblTotalValeur.Name = "lblTotalValeur";
            lblTotalValeur.Size = new Size(370, 100);
            lblTotalValeur.TabIndex = 6;
            lblTotalValeur.Text = "0,00 €";
            lblTotalValeur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.ForestGreen;
            btnValider.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnValider.ForeColor = Color.White;
            btnValider.Location = new Point(690, 520);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(390, 60);
            btnValider.TabIndex = 3;
            btnValider.Text = "VALIDER";
            btnValider.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.Firebrick;
            btnAnnuler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(690, 590);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(390, 60);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // images
            // 
            images.ColorDepth = ColorDepth.Depth32Bit;
            images.ImageSize = new Size(128, 128);
            images.TransparentColor = Color.Transparent;
            // 
            // PeseeLegumes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 1031);
            Controls.Add(btnAnnuler);
            Controls.Add(btnValider);
            Controls.Add(pnlBalance);
            Controls.Add(pnlProduits);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PeseeLegumes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesée - Carrefour";
            Load += PeseeLegumes_Load;
            pnlHeader.ResumeLayout(false);
            pnlBalance.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.FlowLayoutPanel pnlProduits;
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
        private System.Windows.Forms.ImageList images;
    }
}
