using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concourCanin
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccueil accueil = new FormAccueil();
            accueil.MdiParent = this;
            fermerForme();
            accueil.Show();
        }

        private void chienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChien chien = new FormChien();
            chien.MdiParent = this;
            fermerForme();
            chien.Show();
        }

        private void propriétaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProprietaire proprietaire = new FormProprietaire();
            proprietaire.MdiParent = this;
            fermerForme();
            proprietaire.Show();
        }

        // méthode qui récupére la collection de formulaire et qui regarde si au moins un et ouvert et les ferme
        public void fermerForme()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void lesConcoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConcour concour = new FormConcour();
            concour.MdiParent = this;
            fermerForme();
            concour.Show();
        }

        private void notationDesConcoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotation note = new FormNotation();
            note.MdiParent = this;
            fermerForme();
            note.Show();
        }
    }
}
