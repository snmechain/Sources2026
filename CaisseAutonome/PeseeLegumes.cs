using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaisseAutonome
{
    public partial class PeseeLegumes : Form
    {
        public PeseeLegumes()
        {
            InitializeComponent();
        }

        private void PeseeLegumes_Load(object sender, EventArgs e)
        {
            ChargerImagesEtBoutons();
        }

        private void ChargerImagesEtBoutons()
        {
            AjouterProduit("Pommes", "pommes.png");
            AjouterProduit("Bananes", "bananes.png");
            AjouterProduit("Oranges", "oranges.png");
            AjouterProduit("Raisins", "raisins.png");
            AjouterProduit("Tomates", "tomates.png");
            AjouterProduit("Carottes", "carottes.png");
            AjouterProduit("Pommes de terre", "pommesdeterres.png");
            AjouterProduit("Concombres", "concombres.png");
            AjouterProduit("Pastèques", "pasteques.png");
        }

        private void AjouterProduit(string nom, string imageFile)
        {
            // Chargement de l'image
            string path = System.IO.Path.Combine(Application.StartupPath, "Images", imageFile);
            Image img = Image.FromFile(path);

            // Création du bouton
            Button btn = new Button();
            btn.Width = 200;
            btn.Height = 200;
            btn.Margin = new Padding(10);
            btn.BackColor = Color.White;
            btn.Tag = nom;
            btn.Text = nom;

            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ImageAlign = ContentAlignment.TopCenter;

            btn.Image = new Bitmap(img, new Size(150, 150));

            btn.Click += BtnProduit_Click;

            pnlProduits.Controls.Add(btn);
        }

        private void BtnProduit_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                string produit = b.Tag.ToString();
                lblProduitSelectionne.Text = produit;

                // ici tu ajouteras : lecture du prix/kg, lecture du poids, etc.
            }
        }

        
    }
}
