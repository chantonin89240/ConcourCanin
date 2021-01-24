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
    public partial class FormNotation : Form
    {
        // variable global
        private CONCOURSCANINEntities monModele;
        string comboNonCHoisi = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

        // initialise le formulaire et l'entité concourCanin
        public FormNotation()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities();
        }

        // fonction qui met toute les groupbox et les button en invisible et qui clear les textbox
        private void toutInvisible()
        {
            groupBoxProprietaire.Visible = false;
            groupBoxChien.Visible = false;
            groupBoxNote.Visible = false;

            comboBoxProprietaire.Text = comboNonCHoisi;
            comboBoxChien.Text = comboNonCHoisi;
            textBoxNote.Clear();

            comboBoxProprietaire.Enabled = true;
            comboBoxChien.Enabled = true;

            buttonSupprimer.Visible = false;
            buttonAjouter.Visible = false;
            buttonModifier.Visible = false;
            buttonValideAjout.Visible = false;
            buttonValiderModification.Visible = false;
        }

        // fonction qui met les groupbox en invisible et qui clear les textbox
        private void groupInvisible()
        {
            groupBoxProprietaire.Visible = false;
            groupBoxChien.Visible = false;
            groupBoxNote.Visible = false;

            comboBoxProprietaire.Text = comboNonCHoisi;
            comboBoxChien.Text = comboNonCHoisi;
            textBoxNote.Clear();

            comboBoxProprietaire.Enabled = true;
            comboBoxChien.Enabled = true;

            buttonValideAjout.Visible = false;
            buttonValiderModification.Visible = false;
        }

        // fonction qui remplis les combox box 
        private void remplirComboBox()
        {
            var pro = from l in monModele.PROPRIETAIREs select l;
            var chien = from l in monModele.CHIENs select l;
            var concour = from l in monModele.CONCOURS select l;

            // combobox proprietaire
            comboBoxProprietaire.Items.Clear();
            comboBoxProprietaire.Items.Add(comboNonCHoisi);
            comboBoxProprietaire.SelectedItem = comboNonCHoisi;

            foreach (PROPRIETAIRE value in pro)
            {
                string lePro = value.nomproprietaire.Trim() + " : " + value.codeproprietaire;
                comboBoxProprietaire.Items.Add(lePro);
            }

            
            // combobox chien
            comboBoxChien.Items.Clear();
            comboBoxChien.Items.Add(comboNonCHoisi);
            comboBoxChien.SelectedItem = comboNonCHoisi;
            
            foreach (CHIEN value in chien)
            {
                string leChien = value.nomchien.Trim() + " : " + value.codechien;
                comboBoxChien.Items.Add(leChien);
            }

            // combobox concour
            comboBoxConcour.Items.Clear();
            comboBoxConcour.Items.Add(comboNonCHoisi);

            foreach (CONCOUR value in concour)
            {
                comboBoxConcour.Items.Add(value.codeconcours);
            }
        }

        // fonction qui remplis le dgv 
        private void chargerDgv(string leConcours)
        {
            var req = from v in monModele.PARTICIPEs where v.codeconcours == leConcours select v;
            pARTICIPEBindingSource.DataSource = req.ToList();
            dgvNotation.DataSource = pARTICIPEBindingSource;
        }
        
        // fonction au chargement de la page
        private void FormNotation_Load(object sender, EventArgs e)
        {
            toutInvisible();
            remplirComboBox();
            comboBoxConcour.Text = comboNonCHoisi;
        }

        // clique du bouton rechercher qui affiche dans le dgv les participant par rapport au concour sélectionner dans le combobox concour
        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            string concour = comboBoxConcour.Text;
            if (concour == comboNonCHoisi)
            {
                toutInvisible();
                MessageBox.Show("Sélectionner un concour dans la liste !");
            }
            else
            {
                var req = from v in monModele.PARTICIPEs where v.codeconcours == concour select v;
                pARTICIPEBindingSource.DataSource = req.ToList();
                dgvNotation.DataSource = pARTICIPEBindingSource;

                buttonAjouter.Visible = true;
                buttonSupprimer.Visible = true;
                buttonModifier.Visible = true;
            }

            groupInvisible();
        }

        // clique du button ajouter qui affiche les groupbox et le button valider ajout
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            toutInvisible();
            remplirComboBox();
            groupBoxProprietaire.Visible = true;
            groupBoxChien.Visible = true;
            groupBoxNote.Visible = true;

            buttonAjouter.Visible = true;
            buttonValideAjout.Visible = true;
            buttonSupprimer.Visible = true;
            buttonModifier.Visible = true;
        }

        // clique du button valider ajout qui verifie les combo et textbox puis qui ajoute la note dans la bdd
        private void buttonValideAjout_Click(object sender, EventArgs e)
        {
            string lePro = comboBoxProprietaire.Text;
            string leChien = comboBoxChien.Text;
            string leConcour = comboBoxConcour.Text;
            string note = textBoxNote.Text;


            string pro = comboBoxProprietaire.Text;
            string[] leNomPro = pro.Split(':');
            string lePropri = leNomPro[1].Trim();

            string chien = comboBoxChien.Text;
            string[] leNomChien = chien.Split(':');
            string leCodeChien = leNomChien[1].Trim();

            var notationChien = monModele.PARTICIPEs.Find(lePropri, leCodeChien, leConcour);

            // vérifie si le combobox proprietaire est sur le comboNonChoisi
            if (lePro == comboNonCHoisi)
            {
                MessageBox.Show("il faut choisir un propriétaire ! ");
            }
            // vérifie si le combobox chien est sur le comboNonChoisi
            else if (leChien == comboNonCHoisi)
            {
                MessageBox.Show("il faut choisir un chien ! ");
            }
            // vérifie si le combobox concour est sur le comboNonChoisi
            else if (leConcour == comboNonCHoisi)
            {
                MessageBox.Show("il faut choisir un concour ! ");
            }
            // vérifie si le textbox note est vide
            else if (note == "")
            {
                MessageBox.Show("il faut rentrer une note ! ");
            }
            // vérifie que la notation n'existe pas
            else if (notationChien != null)
            {
                MessageBox.Show("cette notation existe déjà ! ");
            }
            // ajoute la notation
            else
            {
                var uneNotation = new PARTICIPE()
                {
                    codeproprietaire = lePropri.Trim(),
                    codechien = leCodeChien.Trim(),
                    codeconcours = comboBoxConcour.Text.Trim(),
                    note = int.Parse(textBoxNote.Text.Trim())
                };

                monModele.PARTICIPEs.Add(uneNotation);
                monModele.SaveChanges();

                chargerDgv(leConcour);
                remplirComboBox();
                groupInvisible();
            }
        }

        // fonction qui supprime la notation sélectionné dans le dgv
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            groupInvisible();
            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvNotation.RowCount != 1)
            {
                // condition qui affiche un messageBox pour valider la suppression
                if (MessageBox.Show("êtes vous sur de vouloir supprimer cette notation ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string leProprietaire = dgvNotation.CurrentRow.Cells[0].Value.ToString();
                    string leChien = dgvNotation.CurrentRow.Cells[1].Value.ToString();
                    string leConcours = dgvNotation.CurrentRow.Cells[2].Value.ToString();

                    // récupére la notation a supprimer
                    var participe = monModele.PARTICIPEs.Find(leProprietaire, leChien, leConcours);

                    monModele.PARTICIPEs.Remove(participe);
                    monModele.SaveChanges();

                    chargerDgv(leConcours);
                    remplirComboBox();
                    groupInvisible();
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // clique du button modifier qui affiche les groupbox et le button valider modification et remplis les combo et textbox avec les données du dgv
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvNotation.RowCount != 1)
            {
                // condition qui demande a l'utilisateur de sélectionner la notation dans le dgv
                if (dgvNotation.CurrentRow.Selected)
                {
                    toutInvisible();
                    remplirComboBox();
                    groupBoxProprietaire.Visible = true;
                    groupBoxChien.Visible = true;
                    groupBoxConcour.Visible = true;
                    groupBoxNote.Visible = true;

                    comboBoxProprietaire.Enabled = false;
                    comboBoxChien.Enabled = false;

                    buttonAjouter.Visible = true;
                    buttonSupprimer.Visible = true;
                    buttonModifier.Visible = true;
                    buttonValiderModification.Visible = true;

                    string propri = dgvNotation.CurrentRow.Cells[0].Value.ToString();
                    var reqPro = from l in monModele.PROPRIETAIREs where l.codeproprietaire == propri select l;

                    foreach (PROPRIETAIRE values in reqPro)
                    {
                        string lePropri = values.nomproprietaire.Trim() + " : " + propri;
                        comboBoxProprietaire.SelectedItem = lePropri;
                    }

                    string chien = dgvNotation.CurrentRow.Cells[1].Value.ToString();
                    var reqChien = from l in monModele.CHIENs where l.codechien == chien select l;

                    foreach (CHIEN values in reqChien)
                    {
                        string leChien = values.nomchien.Trim() + " : " + chien;
                        comboBoxChien.SelectedItem = leChien;
                    }

                    string concour = dgvNotation.CurrentRow.Cells[2].Value.ToString();
                    comboBoxChien.SelectedItem = concour.Trim();

                    textBoxNote.Text = dgvNotation.CurrentRow.Cells[3].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Sélectionner une notation dans le tableau !");
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // clique du button valider modification qui verifie les combo et textbox puis qui modifie dans la bdd
        private void buttonValiderModification_Click(object sender, EventArgs e)
        {
            string leConcour = comboBoxConcour.Text;
            string laNote = textBoxNote.Text;
            bool laNoteValide = testValideNote(laNote);

            // vérifie que les combobox ne soit pas sur comboNonChoisi 
            if (comboBoxProprietaire.Text == comboNonCHoisi || comboBoxChien.Text == comboNonCHoisi || laNote == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            // vérifie si la note ne comprend que des chiffres
            else if (laNoteValide == false)
            {
                MessageBox.Show("la note n'est pas valide il ne faut que des chiffre ! ");
            }
            // modifie la notation 
            else
            {
                string propri = comboBoxProprietaire.Text;
                string[] lePropri = propri.Split(':');
                string codePropri = lePropri[1].Trim();

                string chien = comboBoxChien.Text;
                string[] leChien = chien.Split(':');
                string codeChien = leChien[1].Trim();


                var notation = monModele.PARTICIPEs.Find(codePropri, codeChien, leConcour);

                notation.note = int.Parse(laNote);

                monModele.SaveChanges();

                groupInvisible();
                chargerDgv(leConcour);
            }
        }

        // fonction qui verifie la validiter de la note
        private bool testValideNote(string laNote)
        {
            bool resultat = false;
            var MyRegex = new Regex("^[0-9]*$");

            if (MyRegex.IsMatch(laNote))
            {
                resultat = true;
            }
            else
            {
                    resultat = false;
            }
            return resultat;
        }

        // évènement au changement du combobox propriétaire
        private void comboBoxProprietaire_TextChanged(object sender, EventArgs e)
        {
            comboBoxChien.Items.Clear();
            comboBoxChien.Items.Add(comboNonCHoisi);

            string propri = comboBoxProprietaire.Text;

            if (propri == comboNonCHoisi)
            {
                var chien = from l in monModele.CHIENs select l;

                foreach (CHIEN value in chien)
                {
                    string lesChien = value.nomchien.Trim() + " : " + value.codechien;
                    comboBoxChien.Items.Add(lesChien);
                }
            }
            else
            {
                string[] lePropri = propri.Split(':');
                string codePropri = lePropri[1].Trim();

                var lesChienPro = from l in monModele.CHIENs where l.codeproprietaire == codePropri select l;

                foreach (CHIEN value in lesChienPro)
                {
                    string leChien = value.nomchien.Trim() + " : " + value.codechien;
                    comboBoxChien.Items.Add(leChien);
                }
            }  
        }

        // évènement au changement du combobox chien
        private void comboBoxChien_TextChanged(object sender, EventArgs e)
        {
            comboBoxProprietaire.Items.Clear();
            comboBoxProprietaire.Items.Add(comboNonCHoisi);

            string chien = comboBoxChien.Text;

            if (chien == comboNonCHoisi)
            {
                var leChien = from l in monModele.PROPRIETAIREs select l;

                foreach (PROPRIETAIRE value in leChien)
                {
                    string lesPropri = value.nomproprietaire.Trim() + " : " + value.codeproprietaire;
                    comboBoxProprietaire.Items.Add(lesPropri);
                }
            }
            else
            {
                string[] leChien = chien.Split(':');
                string codechien = leChien[1].Trim();

                var lesChienPro = from l in monModele.CHIENs where l.codechien == codechien select l;

                foreach (CHIEN values in lesChienPro)
                {
                    string leCodePro = values.codeproprietaire;
                    var leCodePropri = from l in monModele.PROPRIETAIREs where l.codeproprietaire == leCodePro select l;

                    foreach (PROPRIETAIRE value in leCodePropri)
                    {
                        string lesPro = value.nomproprietaire.Trim() + " : " + value.codeproprietaire;
                        comboBoxProprietaire.Items.Add(lesPro);
                    }
                }
            }
        }
    }
}
