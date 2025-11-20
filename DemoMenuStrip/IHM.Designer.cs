namespace DemoMenuStrip
{
    partial class IHM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IHM));
            menuStrip1 = new MenuStrip();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            réseauToolStripMenuItem = new ToolStripMenuItem();
            liaisonSérieToolStripMenuItem = new ToolStripMenuItem();
            afficheurToolStripMenuItem = new ToolStripMenuItem();
            lectuerCodeBarreToolStripMenuItem = new ToolStripMenuItem();
            baseDeDonnéesToolStripMenuItem = new ToolStripMenuItem();
            connecterToolStripMenuItem = new ToolStripMenuItem();
            baseParDéfautToolStripMenuItem = new ToolStripMenuItem();
            baseDeSecoursToolStripMenuItem = new ToolStripMenuItem();
            lireToutToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { configurationToolStripMenuItem, baseDeDonnéesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { réseauToolStripMenuItem, liaisonSérieToolStripMenuItem, afficheurToolStripMenuItem, lectuerCodeBarreToolStripMenuItem });
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(114, 24);
            configurationToolStripMenuItem.Text = "Configuration";
            // 
            // réseauToolStripMenuItem
            // 
            réseauToolStripMenuItem.Name = "réseauToolStripMenuItem";
            réseauToolStripMenuItem.Size = new Size(218, 26);
            réseauToolStripMenuItem.Text = "Réseau";
            // 
            // liaisonSérieToolStripMenuItem
            // 
            liaisonSérieToolStripMenuItem.Name = "liaisonSérieToolStripMenuItem";
            liaisonSérieToolStripMenuItem.Size = new Size(218, 26);
            liaisonSérieToolStripMenuItem.Text = "Liaison Série";
            // 
            // afficheurToolStripMenuItem
            // 
            afficheurToolStripMenuItem.Name = "afficheurToolStripMenuItem";
            afficheurToolStripMenuItem.Size = new Size(218, 26);
            afficheurToolStripMenuItem.Text = "Afficheur";
            // 
            // lectuerCodeBarreToolStripMenuItem
            // 
            lectuerCodeBarreToolStripMenuItem.Name = "lectuerCodeBarreToolStripMenuItem";
            lectuerCodeBarreToolStripMenuItem.Size = new Size(218, 26);
            lectuerCodeBarreToolStripMenuItem.Text = "Lectuer Code Barre";
            // 
            // baseDeDonnéesToolStripMenuItem
            // 
            baseDeDonnéesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connecterToolStripMenuItem, lireToutToolStripMenuItem, supprimerToolStripMenuItem });
            baseDeDonnéesToolStripMenuItem.Name = "baseDeDonnéesToolStripMenuItem";
            baseDeDonnéesToolStripMenuItem.Size = new Size(135, 24);
            baseDeDonnéesToolStripMenuItem.Text = "Base de données";
            // 
            // connecterToolStripMenuItem
            // 
            connecterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { baseParDéfautToolStripMenuItem, baseDeSecoursToolStripMenuItem });
            connecterToolStripMenuItem.Name = "connecterToolStripMenuItem";
            connecterToolStripMenuItem.Size = new Size(161, 26);
            connecterToolStripMenuItem.Text = "Connecter";
            // 
            // baseParDéfautToolStripMenuItem
            // 
            baseParDéfautToolStripMenuItem.Name = "baseParDéfautToolStripMenuItem";
            baseParDéfautToolStripMenuItem.Size = new Size(197, 26);
            baseParDéfautToolStripMenuItem.Text = "Base par défaut";
            // 
            // baseDeSecoursToolStripMenuItem
            // 
            baseDeSecoursToolStripMenuItem.Name = "baseDeSecoursToolStripMenuItem";
            baseDeSecoursToolStripMenuItem.Size = new Size(197, 26);
            baseDeSecoursToolStripMenuItem.Text = "Base de secours";
            // 
            // lireToutToolStripMenuItem
            // 
            lireToutToolStripMenuItem.Name = "lireToutToolStripMenuItem";
            lireToutToolStripMenuItem.Size = new Size(161, 26);
            lireToutToolStripMenuItem.Text = "Lire tout";
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(161, 26);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripEDT";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // IHM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "IHM";
            Text = "Demo menus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem réseauToolStripMenuItem;
        private ToolStripMenuItem liaisonSérieToolStripMenuItem;
        private ToolStripMenuItem afficheurToolStripMenuItem;
        private ToolStripMenuItem lectuerCodeBarreToolStripMenuItem;
        private ToolStripMenuItem baseDeDonnéesToolStripMenuItem;
        private ToolStripMenuItem connecterToolStripMenuItem;
        private ToolStripMenuItem baseParDéfautToolStripMenuItem;
        private ToolStripMenuItem baseDeSecoursToolStripMenuItem;
        private ToolStripMenuItem lireToutToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
