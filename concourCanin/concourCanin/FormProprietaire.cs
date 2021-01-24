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
    public partial class FormProprietaire : Form
    {
        private CONCOURSCANINEntities monModele;

        public FormProprietaire()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities();
        }

        // fonction qui met toute les groupbox et les button en invisible et qui clear les textbox
        private void toutInvisible()
        {
            groupBoxCodeProprietaire.Visible = false;
            groupBoxNomProprietaire.Visible = false;
            groupBoxPrenomProprietaire.Visible = false;
            groupBoxAdresseProprietaire.Visible = false;
            groupBoxVilleProprietaire.Visible = false;
            groupBoxCpPropietaire.Visible = false;

            buttonValiderAjout.Visible = false;
            buttonValiderModif.Visible = false;

            textBoxCode.Enabled = true;
            textBoxCode.Clear();
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxAdresse.Clear();
            textBoxVille.Clear();
            textBoxCP.Clear();
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
            var req = from l in monModele.PROPRIETAIREs where l.codeproprietaire == code select l;

            foreach (PROPRIETAIRE value in req)
            {
                if (value.codeproprietaire == code)
                {
                    resultat = true;
                }
            }
            return resultat;
        }

        // fonction qui charge le dgv
        private void chargerDgv()
        {
            var req = from v in monModele.PROPRIETAIREs select v;
            pROPRIETAIREBindingSource.DataSource = req.ToList();
            dgvProprietaire.DataSource = pROPRIETAIREBindingSource;
        }

        // fonction qui s'execute au chargement
        private void FormProprietaire_Load(object sender, EventArgs e)
        {
            chargerDgv();
            toutInvisible();
        }

        // fonction sur le clique du button ajouter que affiche les groupbox et le button validerAjout
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            toutInvisible();

            groupBoxCodeProprietaire.Visible = true;
            groupBoxNomProprietaire.Visible = true;
            groupBoxPrenomProprietaire.Visible = true;
            groupBoxAdresseProprietaire.Visible = true;
            groupBoxVilleProprietaire.Visible = true;
            groupBoxCpPropietaire.Visible = true;

            buttonValiderAjout.Visible = true;
        }

        // fonction sur le clique du button validerAjout qui vérifie les textbox et ajout le propriétaire
        private void buttonValiderAjout_Click(object sender, EventArgs e)
        {
            string leCP = textBoxCP.Text;
            bool leCPvalide = testCP(leCP);

            string leCode = textBoxCode.Text;
            int nbCode = leCode.Count();
            bool leCodeValide = testCode(leCode);

            if (textBoxCode.Text == "" || textBoxNom.Text == "" || textBoxPrenom.Text == ""
                || textBoxAdresse.Text == "" || textBoxVille.Text == "" || textBoxCP.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            else if (leCPvalide == false)
            {
                MessageBox.Show("le code postal n'est pas valide (deux chiffre) ! ");
            }
            else if (nbCode != 6)
            {
                MessageBox.Show("le code n'est pas valide il doit comporter 6 caractère ou chiffre ! ");
            }
            else if (leCodeValide == true)
            {
                MessageBox.Show("le code du propriétaire existe déjà veuiller le modifier ! ");
            }
            else
            {
                var unProprietaire = new PROPRIETAIRE()
                {
                    codeproprietaire = textBoxCode.Text.Trim().ToUpper(),
                    adresseproprietaire = textBoxAdresse.Text,
                    cpproprietaire = textBoxCP.Text,
                    nomproprietaire = textBoxNom.Text,
                    prenomproprietaire = textBoxPrenom.Text,
                    villeproprietaire = textBoxVille.Text,
                };

                monModele.PROPRIETAIREs.Add(unProprietaire);
                monModele.SaveChanges();

                toutInvisible();
                chargerDgv();
            }
        }

        // fonction sur le button supprimer qui supprime le propiétaire sélectionner sur le dgv
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            toutInvisible();
            string leCode = dgvProprietaire.CurrentRow.Cells[0].Value.ToString();
            string leNom = dgvProprietaire.CurrentRow.Cells[3].Value.ToString();
            string lePrenom = dgvProprietaire.CurrentRow.Cells[4].Value.ToString();

            if (dgvProprietaire.RowCount != 1)
            {
                if (MessageBox.Show("êtes vous sur de vouloir supprimer le propriétaire " + leNom.Trim() + " " + lePrenom.Trim() + "\nnuméro : " + leCode.Trim() + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var proprietaire = monModele.PROPRIETAIREs.Find(leCode);

                    var participe = from l in monModele.PARTICIPEs where l.codeproprietaire == leCode select l;
                    if (participe != null)
                    {
                        foreach (PARTICIPE value in participe)
                        {
                            monModele.PARTICIPEs.Remove((PARTICIPE)value);
                        }
                    }

                    var chien = from l in monModele.CHIENs where l.codeproprietaire == leCode select l;
                    if (chien != null)
                    {
                        foreach (CHIEN value in chien)
                        {
                            monModele.CHIENs.Remove((CHIEN)value);
                        }
                    }


                    monModele.PROPRIETAIREs.Remove(proprietaire);
                    monModele.SaveChanges();
                    chargerDgv();
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // fonction sur le button modifier qui affiche les groupbox et le button validerModif puis qui remplis les textbox avec les données du propriétaire sélectionner dans le dgv
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dgvProprietaire.RowCount != 1)
            {
                if (dgvProprietaire.CurrentRow.Selected)
                {
                    toutInvisible();

                    groupBoxCodeProprietaire.Visible = true;
                    groupBoxNomProprietaire.Visible = true;
                    groupBoxPrenomProprietaire.Visible = true;
                    groupBoxAdresseProprietaire.Visible = true;
                    groupBoxVilleProprietaire.Visible = true;
                    groupBoxCpPropietaire.Visible = true;

                    buttonValiderModif.Visible = true;

                    textBoxCode.Enabled = false;

                    string leCode = dgvProprietaire.CurrentRow.Cells[0].Value.ToString();
                    textBoxCode.Text = leCode.Trim();

                    string ladresse = dgvProprietaire.CurrentRow.Cells[1].Value.ToString();
                    textBoxAdresse.Text = ladresse.Trim();

                    string leCP = dgvProprietaire.CurrentRow.Cells[2].Value.ToString();
                    textBoxCP.Text = leCP.Trim();

                    string leNom = dgvProprietaire.CurrentRow.Cells[4].Value.ToString();
                    textBoxNom.Text = leNom.Trim();

                    string lePrenom = dgvProprietaire.CurrentRow.Cells[4].Value.ToString();
                    textBoxPrenom.Text = lePrenom.Trim();

                    string laVille = dgvProprietaire.CurrentRow.Cells[5].Value.ToString();
                    textBoxVille.Text = laVille.Trim();
                }
                else
                {
                    MessageBox.Show("Sélectionner un propriétaire dans le tableau !");
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }

        }

        // fonction sur le button validerModif qui vérifie les textbox et modifie le propriétaire
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            string leCP = textBoxCP.Text;
            bool leCPvalide = testCP(leCP);

            if (textBoxNom.Text == "" || textBoxPrenom.Text == "" || textBoxAdresse.Text == ""
                || textBoxVille.Text == "" || textBoxCP.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            else if (leCPvalide == false)
            {
                MessageBox.Show("le code postal n'est pas valide (deux chiffre) ! ");
            }
            else
            {
                string leProprietaire = textBoxCode.Text;
                var proprietaire = monModele.PROPRIETAIREs.Find(leProprietaire);

                proprietaire.adresseproprietaire = textBoxAdresse.Text;
                proprietaire.cpproprietaire = textBoxCP.Text;
                proprietaire.nomproprietaire = textBoxNom.Text;
                proprietaire.prenomproprietaire = textBoxPrenom.Text;
                proprietaire.villeproprietaire = textBoxVille.Text;

                monModele.SaveChanges();

                toutInvisible();
                chargerDgv();
            }
        }
    }
}
