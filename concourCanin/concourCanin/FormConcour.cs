using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace concourCanin
{
    public partial class FormConcour : Form
    {
        // variable global 
        private CONCOURSCANINEntities monModele;

        // initialise le formualire et l'entité concourCanin
        public FormConcour()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities();
        }

        // fonction qui met toute les groupbox et les button en invisible et qui clear les textbox et mais le calendrier a la date du jour
        private void toutInvisible()
        {
            // rend invisible
            groupBoxCodeConcour.Visible = false;
            groupBoxCoucourVille.Visible = false;
            groupBoxConcourCP.Visible = false;
            groupBoxConcourAdresse.Visible = false;
            groupBoxConcourSalle.Visible = false;
            groupBoxConcourDate.Visible = false;

            buttonValiderAjout.Visible = false;
            buttonValiderModif.Visible = false;

            // ne peut pas interagire avec le composant
            textBoxCode.Enabled = true;

            // efface le contenu de l'élément
            textBoxVille.Clear();
            textBoxCP.Clear();
            textBoxSalle.Clear();
            textBoxAdresse.Clear();
            textBoxCode.Clear();
            DateTime ladate = DateTime.Now;
            dateConcour.Value = ladate;
        }

        // fonction qui charge le dgv en récupérer la liste des concours dans le bdd
        private void chargerDgv()
        {
            var req = from v in monModele.CONCOURS select v;
            cONCOURBindingSource.DataSource = req.ToList();
            dgvConcours.DataSource = cONCOURBindingSource;
        }

        // fonction qui verifie la validiter du code postal
        private bool testCP(string cp)
        {
            bool resultat = false;
            var MyRegex = new Regex("^[0-9]*$");

            if (MyRegex.IsMatch(cp))
            {
                int nbTel = cp.Count();
                if (nbTel == 2)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }

        // fonction qui verifie si le code existe déjà
        private bool testCode(string code)
        {
            bool resultat = false;
            code = code.Trim().ToUpper();
            var req = from l in monModele.CONCOURS where l.codeconcours == code select l;
            
            foreach (CONCOUR value in req)
            {
                if(value.codeconcours == code)
                {
                    resultat = true;
                }
            }
            return resultat;
        }

        // fonction au chargement de la page
        private void FormConcour_Load(object sender, EventArgs e)
        {
            chargerDgv();
            toutInvisible();
        }

        // clique sur le bouton ajouter qui affiche les groupbox et le button valider ajout
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            toutInvisible();

            groupBoxCodeConcour.Visible = true;
            groupBoxCoucourVille.Visible = true;
            groupBoxConcourCP.Visible = true;
            groupBoxConcourAdresse.Visible = true;
            groupBoxConcourSalle.Visible = true;
            groupBoxConcourDate.Visible = true;

            buttonValiderAjout.Visible = true;
        }

        // clique du bouton valider ajout qui verifie les textbox et ajoute dans la bdd
        private void buttonValiderAjout_Click(object sender, EventArgs e)
        {
            string leCP = textBoxCP.Text;
            bool leCPvalide = testCP(leCP);
            string leCode = textBoxCode.Text;
            int nbCode = leCode.Count();
            bool leCodeValide = testCode(leCode);

            // vérifie si les textbox sont vide
            if (textBoxVille.Text == "" || textBoxCP.Text == "" || textBoxSalle.Text == ""
               || textBoxAdresse.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            // vérifie si le code postal est valide
            else if (leCPvalide == false)
            {
                MessageBox.Show("le code postal n'est pas valide (deux chiffre) ! ");
            }
            // vérifie si le code fait 6 caractère pour éviter les espace ou qu'il ne dépace 
            else if (nbCode != 6)
            {
                MessageBox.Show("le code n'est pas valide il doit comporter 6 caractère ou chiffre ! ");
            }
            // vérifie si le code est valide
            else if (leCodeValide == true)
            {
                MessageBox.Show("le code du concour existe déjà veuiller le modifier ! ");
            }
            // ajout le concour
            else
            {
                var unConcour = new CONCOUR()
                {
                codeconcours = textBoxCode.Text.Trim().ToUpper(),
                adresseconcours = textBoxAdresse.Text,
                cpconcours = textBoxCP.Text,
                dateconcours = DateTime.Parse(dateConcour.Text),
                salleconcours = textBoxSalle.Text,
                villeconcours = textBoxVille.Text,
                };

            monModele.CONCOURS.Add(unConcour);
            monModele.SaveChanges();

            toutInvisible();
            chargerDgv();
            }
        }

        // supprimer le concour sélectionner dans le dgv
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            toutInvisible();
            string leConcours = dgvConcours.CurrentRow.Cells[0].Value.ToString();

            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvConcours.RowCount != 1)
            {
                // messageBox pour valider la suppression 
                if (MessageBox.Show("êtes vous sur de vouloir supprimer le concours numéro : " + leConcours.Trim() + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // récupére le concour
                    var concour = monModele.CONCOURS.Find(leConcours);
                    // récupére les notation lier au concour pour les supprimer
                    var participe = from l in monModele.PARTICIPEs where l.codeconcours == leConcours select l;
                    if (participe != null)
                    {
                        foreach (PARTICIPE value in participe)
                        {
                            monModele.PARTICIPEs.Remove((PARTICIPE)value);
                        }
                    }
                    monModele.CONCOURS.Remove(concour);
                    monModele.SaveChanges();
                    chargerDgv();
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // clique sur le button modifier qui ajoute le concour sélectionner dans les textbox et afficher les groupebox et le button valider modification
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvConcours.RowCount != 1)
            {
                // condition qui demande a l'utilisateur de sélectionner le concour dans le dgv 
                if (dgvConcours.CurrentRow.Selected)
                {
                    toutInvisible();

                    groupBoxCodeConcour.Visible = true;
                    textBoxCode.Enabled = false;
                    groupBoxCoucourVille.Visible = true;
                    groupBoxConcourCP.Visible = true;
                    groupBoxConcourAdresse.Visible = true;
                    groupBoxConcourSalle.Visible = true;
                    groupBoxConcourDate.Visible = true;

                    buttonValiderModif.Visible = true;

                    string leCode = dgvConcours.CurrentRow.Cells[0].Value.ToString();
                    textBoxCode.Text = leCode.Trim();

                    string ladresse = dgvConcours.CurrentRow.Cells[1].Value.ToString();
                    textBoxAdresse.Text = ladresse.Trim();

                    string leCP = dgvConcours.CurrentRow.Cells[2].Value.ToString();
                    textBoxCP.Text = leCP.Trim();

                    dateConcour.Text = dgvConcours.CurrentRow.Cells[3].Value.ToString();

                    string laSalle = dgvConcours.CurrentRow.Cells[4].Value.ToString();
                    textBoxSalle.Text = laSalle.Trim();

                    string laVille = dgvConcours.CurrentRow.Cells[5].Value.ToString();
                    textBoxVille.Text = laVille.Trim();
                }
                else
                {
                    MessageBox.Show("Sélectionner un concour dans le tableau !");
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }  
        }

        // clique sur le button valider modification qui verifie les textbox et ajoute dans la bbb
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            string leCP = textBoxCP.Text;
            bool leCPvalide = testCP(leCP);

            // vérifie si les textbox sont vide
            if (textBoxVille.Text == "" || textBoxCP.Text == "" || textBoxSalle.Text == ""
               || textBoxAdresse.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            // vérifie que le code postal soit valide
            else if (leCPvalide == false)
            {
                MessageBox.Show("le code postal n'est pas valide (deux chiffre) ! ");
            }
            // modifie le concour 
            else
            {
                string leConcours = textBoxCode.Text;
                var concour = monModele.CONCOURS.Find(leConcours);

                concour.adresseconcours = textBoxAdresse.Text;
                concour.cpconcours = textBoxCP.Text;
                concour.dateconcours = DateTime.Parse(dateConcour.Text);
                concour.salleconcours = textBoxSalle.Text;
                concour.villeconcours = textBoxVille.Text;

                monModele.SaveChanges();

                toutInvisible();
                chargerDgv();
            }
        }
    }
}
