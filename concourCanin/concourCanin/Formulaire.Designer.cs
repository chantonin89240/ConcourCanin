
namespace concourCanin
{
    partial class Formulaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesConcoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notationDesConcoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.concoursToolStripMenuItem,
            this.chienToolStripMenuItem,
            this.propriétaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // concoursToolStripMenuItem
            // 
            this.concoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesConcoursToolStripMenuItem,
            this.notationDesConcoursToolStripMenuItem});
            this.concoursToolStripMenuItem.Name = "concoursToolStripMenuItem";
            this.concoursToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.concoursToolStripMenuItem.Text = "Concours";
            // 
            // chienToolStripMenuItem
            // 
            this.chienToolStripMenuItem.Name = "chienToolStripMenuItem";
            this.chienToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.chienToolStripMenuItem.Text = "Chien";
            this.chienToolStripMenuItem.Click += new System.EventHandler(this.chienToolStripMenuItem_Click);
            // 
            // propriétaireToolStripMenuItem
            // 
            this.propriétaireToolStripMenuItem.Name = "propriétaireToolStripMenuItem";
            this.propriétaireToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.propriétaireToolStripMenuItem.Text = "Propriétaires";
            this.propriétaireToolStripMenuItem.Click += new System.EventHandler(this.propriétaireToolStripMenuItem_Click);
            // 
            // lesConcoursToolStripMenuItem
            // 
            this.lesConcoursToolStripMenuItem.Name = "lesConcoursToolStripMenuItem";
            this.lesConcoursToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.lesConcoursToolStripMenuItem.Text = "Liste des Concours";
            this.lesConcoursToolStripMenuItem.Click += new System.EventHandler(this.lesConcoursToolStripMenuItem_Click);
            // 
            // notationDesConcoursToolStripMenuItem
            // 
            this.notationDesConcoursToolStripMenuItem.Name = "notationDesConcoursToolStripMenuItem";
            this.notationDesConcoursToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.notationDesConcoursToolStripMenuItem.Text = "Notation des Concours";
            this.notationDesConcoursToolStripMenuItem.Click += new System.EventHandler(this.notationDesConcoursToolStripMenuItem_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 713);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulaire";
            this.Text = "Concours Canin";
            this.Shown += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesConcoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notationDesConcoursToolStripMenuItem;
    }
}

