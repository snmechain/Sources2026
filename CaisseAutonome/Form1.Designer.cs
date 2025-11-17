namespace CaisseAutonome
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur Windows Form

        private void InitializeComponent()
        {
            lblTitre = new Label();
            groupScan = new GroupBox();
            txtCodeBarre = new TextBox();
            btnScanner = new Button();
            lblScan = new Label();
            groupTicket = new GroupBox();
            lstTicket = new ListBox();
            groupTotal = new GroupBox();
            lblTotal = new Label();
            btnPayerCB = new Button();
            btnPayerEspeces = new Button();
            btnAnnuler = new Button();
            groupScan.SuspendLayout();
            groupTicket.SuspendLayout();
            groupTotal.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitre.ForeColor = Color.DarkBlue;
            lblTitre.Location = new Point(12, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(776, 50);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "CAISSE AUTONOME - SUPERMARCHÉ";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupScan
            // 
            groupScan.Controls.Add(txtCodeBarre);
            groupScan.Controls.Add(btnScanner);
            groupScan.Controls.Add(lblScan);
            groupScan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupScan.Location = new Point(12, 70);
            groupScan.Name = "groupScan";
            groupScan.Size = new Size(370, 150);
            groupScan.TabIndex = 1;
            groupScan.TabStop = false;
            groupScan.Text = "Zone de scan";
            // 
            // txtCodeBarre
            // 
            txtCodeBarre.Font = new Font("Segoe UI", 12F);
            txtCodeBarre.Location = new Point(20, 61);
            txtCodeBarre.Name = "txtCodeBarre";
            txtCodeBarre.Size = new Size(220, 34);
            txtCodeBarre.TabIndex = 1;
            // 
            // btnScanner
            // 
            btnScanner.BackColor = Color.LightSkyBlue;
            btnScanner.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnScanner.Location = new Point(250, 61);
            btnScanner.Name = "btnScanner";
            btnScanner.Size = new Size(100, 34);
            btnScanner.TabIndex = 2;
            btnScanner.Text = "Scanner";
            btnScanner.UseVisualStyleBackColor = false;
            // 
            // lblScan
            // 
            lblScan.Font = new Font("Segoe UI", 10F);
            lblScan.Location = new Point(20, 35);
            lblScan.Name = "lblScan";
            lblScan.Size = new Size(200, 23);
            lblScan.TabIndex = 0;
            lblScan.Text = "Code-barres de l'article :";
            // 
            // groupTicket
            // 
            groupTicket.Controls.Add(lstTicket);
            groupTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupTicket.Location = new Point(400, 70);
            groupTicket.Name = "groupTicket";
            groupTicket.Size = new Size(388, 400);
            groupTicket.TabIndex = 2;
            groupTicket.TabStop = false;
            groupTicket.Text = "Ticket en cours";
            // 
            // lstTicket
            // 
            lstTicket.Font = new Font("Consolas", 12F);
            lstTicket.FormattingEnabled = true;
            lstTicket.ItemHeight = 23;
            lstTicket.Location = new Point(20, 35);
            lstTicket.Name = "lstTicket";
            lstTicket.Size = new Size(350, 326);
            lstTicket.TabIndex = 0;
            // 
            // groupTotal
            // 
            groupTotal.Controls.Add(lblTotal);
            groupTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupTotal.Location = new Point(12, 230);
            groupTotal.Name = "groupTotal";
            groupTotal.Size = new Size(370, 100);
            groupTotal.TabIndex = 3;
            groupTotal.TabStop = false;
            groupTotal.Text = "Montant total";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkGreen;
            lblTotal.Location = new Point(20, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(330, 40);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "0,00 €";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPayerCB
            // 
            btnPayerCB.BackColor = Color.LightGreen;
            btnPayerCB.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPayerCB.Location = new Point(12, 350);
            btnPayerCB.Name = "btnPayerCB";
            btnPayerCB.Size = new Size(370, 50);
            btnPayerCB.TabIndex = 4;
            btnPayerCB.Text = "Payer par CARTE";
            btnPayerCB.UseVisualStyleBackColor = false;
            // 
            // btnPayerEspeces
            // 
            btnPayerEspeces.BackColor = Color.Gold;
            btnPayerEspeces.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPayerEspeces.Location = new Point(12, 410);
            btnPayerEspeces.Name = "btnPayerEspeces";
            btnPayerEspeces.Size = new Size(370, 50);
            btnPayerEspeces.TabIndex = 5;
            btnPayerEspeces.Text = "Payer en ESPÈCES";
            btnPayerEspeces.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.IndianRed;
            btnAnnuler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(12, 470);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(776, 40);
            btnAnnuler.TabIndex = 6;
            btnAnnuler.Text = "Annuler la transaction";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 530);
            Controls.Add(btnAnnuler);
            Controls.Add(btnPayerEspeces);
            Controls.Add(btnPayerCB);
            Controls.Add(groupTotal);
            Controls.Add(groupTicket);
            Controls.Add(groupScan);
            Controls.Add(lblTitre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caisse autonome - Supermarché";
            groupScan.ResumeLayout(false);
            groupScan.PerformLayout();
            groupTicket.ResumeLayout(false);
            groupTotal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox groupScan;
        private System.Windows.Forms.TextBox txtCodeBarre;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.GroupBox groupTicket;
        private System.Windows.Forms.ListBox lstTicket;
        private System.Windows.Forms.GroupBox groupTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPayerCB;
        private System.Windows.Forms.Button btnPayerEspeces;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
