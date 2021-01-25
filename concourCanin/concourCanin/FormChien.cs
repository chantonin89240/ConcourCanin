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
    public partial class FormChien : Form
    {
        // variable global
        private CONCOURSCANINEntities monModele;
        string comboNonCHoisi = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
        int nbType = 0; // variable pour savoir quelle table (chien, race, batard) afficher dans le dgv

        // initialisation du formulaire et de l'entité concourCanin
        public FormChien()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities();
        }

        // fonction qui charge le dgv en fonction du type de chien demander
        private void chargerDgv(int nb)
        {
            dgvChien.DataSource = null;
            // adapte la taille de toute les colonne en fill
            DataGridViewAutoSizeColumnMode size = DataGridViewAutoSizeColumnMode.Fill;

            // affiche tout les chiens dans le dgv
            if (nb == 0)
            {
                var req = from v in monModele.CHIENs orderby v.codeproprietaire select v;
                //cHIENBindingSource.DataSource = req.ToList();
                dgvChien.DataSource = req.ToList();

                dgvChien.Columns[0].HeaderText = "Code du Chien";
                dgvChien.Columns[1].HeaderText = "Code du Propriétaire";
                dgvChien.Columns[2].HeaderText = "Date de Naissance du Chien";
                dgvChien.Columns[3].HeaderText = "Nom du Chien";

                dgvChien.Columns[4].Visible = false;
                dgvChien.Columns[5].Visible = false;

                foreach (DataGridViewColumn c in dgvChien.Columns)
                {
                    c.AutoSizeMode = size;
                }
            }
            // affiche les chiens de race dans le dgv
            else if (nb == 1)
            {
                
                var req = from v in monModele.VUERACEs select v;
                cHIENBindingSource.DataSource = req.ToList();
                dgvChien.DataSource = cHIENBindingSource;

                dgvChien.Columns[4].HeaderText = "Race du Chien";
                dgvChien.Columns[5].HeaderText = "Robe du Chien";

                foreach (DataGridViewColumn c in dgvChien.Columns)
                {
                    c.AutoSizeMode = size;
                }
            }
            // affiche les chiens batard dans le dgv
            else if (nb == 2)
            {
                var req = from v in monModele.VUEBATARDs select v;
                cHIENBindingSource.DataSource = req.ToList();
                dgvChien.DataSource = cHIENBindingSource;

                dgvChien.Columns[4].HeaderText = "Caractéristique";

                foreach (DataGridViewColumn c in dgvChien.Columns)
                {
                    c.AutoSizeMode = size;
                }
            }
            // en cas d'erreur
            else
            {
                MessageBox.Show("il n'y a pas de chiens ! ");
            }
            
        }

        // fonction qui clear et ajoute la variable comboNonChoisi au combobox 
        private void comboClear()
        {
            // récupére tout les proprietaire
            var pro = from l in monModele.PROPRIETAIREs select l;

            // combobox proprietaire
            comboBoxProprietaire.Items.Clear();
            comboBoxProprietaire.Items.Add(comboNonCHoisi);
            comboBoxProprietaire.SelectedItem = comboNonCHoisi;

            foreach (PROPRIETAIRE value in pro)
            {
                string lePro = value.nomproprietaire.Trim() + " : " + value.codeproprietaire;
                comboBoxProprietaire.Items.Add(lePro);
            }

            // combobox type du chien
            comboBoxType.Items.Clear();
            comboBoxType.Items.Add(comboNonCHoisi);
            comboBoxType.Items.Add("Race");
            comboBoxType.Items.Add("Batard");
            comboBoxType.SelectedItem = comboNonCHoisi;
        }

        // fonction qui cache les groupbox et les button valider
        private void cacherTout()
        {
            // Visible pour cacher l'élément
            groupBoxChampChien.Visible = false;
            groupBoxCaracteristique.Visible = false;

            buttonValiderAjout.Visible = false;
            buttonValiderModif.Visible = false;

            // Enabled pour pouvoir écrire dans l'élément
            textBoxCode.Enabled = true;
            comboBoxProprietaire.Enabled = true;
            comboBoxType.Enabled = true;

            // Clear pour effacer le contenu de l'élément
            textBoxCode.Clear();
            textBoxNom.Clear(); 

            textBoxRace.Clear();
            textBoxCaracteristique.Clear();
            textBoxRobe.Clear();

            // SelectedItem pour définir l'élément sélectionner par le combobox
            comboBoxProprietaire.SelectedItem = comboNonCHoisi;
            comboBoxType.SelectedItem = comboNonCHoisi;

            // Now pour séléectionner la date du jour
            DateTime ladate = DateTime.Now;
            dateTimePicker1.Value = ladate;

        }

        // fonction qui cache les textbox et label du groupbox caracteristique
        private void cacherCaracteristique()
        {
            labelRace.Visible = false;
            textBoxRace.Visible = false;

            labelCaracteristique.Visible = false;
            textBoxCaracteristique.Visible = false;

            labelRobe.Visible = false;
            textBoxRobe.Visible = false;

            textBoxRace.Clear();
            textBoxCaracteristique.Clear();
            textBoxRobe.Clear();
        }

        // fonction qui test si le code chien n'existe pas
        private bool testValiditerCode(string codeChien)
        {
            bool testChien = true;

            var notationChien = from v in monModele.CHIENs select v;
            foreach (CHIEN values in notationChien)
            {
                if (values.codechien == codeChien)
                {
                    testChien = false;
                }
            }
            return testChien;
        }

        // fonction au chargement de la page
        private void FormChien_Load(object sender, EventArgs e)
        {
            int nb = 0;
            chargerDgv(nb);
            cacherTout();
            comboClear();
        }

        // fonction au clique du button afficher les race
        private void buttonAfficherRace_Click(object sender, EventArgs e)
        {
            int nb = 1;
            chargerDgv(nb);
            cacherTout();
        }

        // fonction au clique du button afficher tout les chiens
        private void buttonAfficherTout_Click(object sender, EventArgs e)
        {
            int nb = 0;
            chargerDgv(nb);
            cacherTout();
        }

        // fonction au clique du button afficher les batard
        private void buttonAfficherBatard_Click(object sender, EventArgs e)
        {
            int nb = 2;
            chargerDgv(nb);
            cacherTout();
        }

        // fonction qui affiche les champs pour ajouter le chien
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            cacherTout();

            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvChien.RowCount != 1)
            {
              
                groupBoxChampChien.Visible = true;
                groupBoxCaracteristique.Visible = true;

                cacherCaracteristique();

                buttonValiderAjout.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // fonction qui verifie les champs et qui ajout le chien
        private void buttonValiderAjout_Click(object sender, EventArgs e)
        {
            string leCodeChien = textBoxCode.Text;

            string pro = comboBoxProprietaire.Text;
            string[] leNomPro = pro.Split(':');
            string lePropri = leNomPro[1].Trim();

            bool testChien = testValiditerCode(leCodeChien);

            // vérifie que les textbox ne soit pas vide
            if (textBoxCode.Text == "" || textBoxNom.Text == "")
            {
                MessageBox.Show("certains champs ne sont pas remplis ! ");
            }
            // vérifie que le combobox proprietaire ne soit pas le comboNonChoisi
            else if (comboBoxProprietaire.Text == comboNonCHoisi)
            {
                MessageBox.Show("vous n'avait pas choisi de propriétaire ! ");
            }
            // vérifie que le combobox type ne soit pas le comboNonChoisi
            else if (comboBoxType.Text == comboNonCHoisi)
            {
                MessageBox.Show("vous n'avait pas choisi de type pour le chien ! ");
            }
            // vérifie que si le combobox type soit sur race que les textbox ne soit pas vide
            else if (comboBoxType.Text == "Race" && textBoxRace.Text == "" || comboBoxType.Text == "Race" && textBoxRobe.Text == "")
            {
                MessageBox.Show("un champ du type n'est pas remplis ! ");
            }
            // vérifie que si le combobox type soit sur batard que le textbox ne soit pas vide
            else if (comboBoxType.Text == "Batard" && textBoxCaracteristique.Text == "")
            {
                MessageBox.Show("le champ du type n'est pas remplis ! ");
            }
            // vérifie si le code du chien existe déjà 
            else if (testChien == false)
            {
                MessageBox.Show("le code du chien existe déjà ! ");
            }
            // ajoute le chien en fonction de sont type
            else
            {
                //  ajoute un chien de type race
                if (nbType == 1)
                {
                    var unChien = new DERACE()
                    {
                        codechien = textBoxCode.Text,
                        codeproprietaire = lePropri,
                        ddnchien = DateTime.Parse(dateTimePicker1.Text),
                        nomchien = textBoxNom.Text,
                        race = textBoxRace.Text,
                        robe = textBoxRobe.Text
                    };
                    
                    monModele.CHIENs.Add(unChien);
                    monModele.SaveChanges();
                }
                // ajoute un chien de type batard
                else if(nbType == 2)
                {
                    var unChien = new BATARD()
                    {
                        codechien = textBoxCode.Text,
                        codeproprietaire = lePropri,
                        ddnchien = DateTime.Parse(dateTimePicker1.Text),
                        nomchien = textBoxNom.Text,
                        caracteristiques = textBoxCaracteristique.Text
                    };

                    monModele.CHIENs.Add(unChien);
                    monModele.SaveChanges();
                }
                else
                {
                    MessageBox.Show("il y a une erreur ! ");
                }

                int nbChien = 0;
                chargerDgv(nbChien);
                cacherTout();
            }
        }

        // fonction qui demande a l'utilisateur avec un messageBox puis qui supprime le chiens si accepter
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvChien.RowCount != 1)
            {
                string leCodeChien = dgvChien.CurrentRow.Cells[0].Value.ToString();
                string leCodeProprietaire = dgvChien.CurrentRow.Cells[1].Value.ToString();
                string leNom = dgvChien.CurrentRow.Cells[3].Value.ToString();

                // messagebox pour valider par l'utilisateur la suppression du chien
                if (MessageBox.Show("êtes vous sur de vouloir supprimer le chien " + leNom.Trim() + "\nnuméro : " + leCodeChien.Trim() + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // récupére le chien pour le supprimer
                    var chien = monModele.CHIENs.Find(leCodeChien, leCodeProprietaire);
                    // récupére les note lier au chien et les supprime
                    var participe = from l in monModele.PARTICIPEs where l.codechien == leCodeChien select l;
                    if (participe != null)
                    {
                        foreach (PARTICIPE value in participe)
                        {
                            monModele.PARTICIPEs.Remove((PARTICIPE)value);
                        }
                    }

                    monModele.CHIENs.Remove(chien);
                    monModele.SaveChanges();
                    int nb = 0;
                    chargerDgv(nb);
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // fonction qui remplis les champs avec les caractéristique du champs depuis le dgv pour la modification
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            // condition si le dgv a plus de 1 élément (la première ligne vide du dgv étant compter)
            if (dgvChien.RowCount != 1)
            {
                // condition qui demande a l'utilisateur de sélectionner le chien dans le dgv
                if (dgvChien.CurrentRow.Selected)
                {
                    cacherTout();

                    groupBoxChampChien.Visible = true;
                    groupBoxCaracteristique.Visible = true;

                    // on ne peut pas modifier le code du chien et du proprietaire ainsi que le type
                    textBoxCode.Enabled = false;
                    comboBoxProprietaire.Enabled = false;
                    comboBoxType.Enabled = false;

                    cacherCaracteristique();

                    buttonValiderModif.Visible = true;

                    // récupération des données pour remplis les éléments
                    string leCodeChien = dgvChien.CurrentRow.Cells[0].Value.ToString();
                    textBoxCode.Text = leCodeChien.Trim();

                    string leCodePropri = dgvChien.CurrentRow.Cells[1].Value.ToString();
                    var reqPro = from l in monModele.PROPRIETAIREs where l.codeproprietaire == leCodePropri select l;

                    foreach (PROPRIETAIRE values in reqPro)
                    {
                        string lePropri = values.nomproprietaire.Trim() + " : " + leCodePropri;
                        comboBoxProprietaire.SelectedItem = lePropri;
                    }

                    dateTimePicker1.Text = dgvChien.CurrentRow.Cells[2].Value.ToString();

                    string leNomChien = dgvChien.CurrentRow.Cells[3].Value.ToString();
                    textBoxNom.Text = leNomChien.Trim();
                    
                    var recupChienRace = from l in monModele.VUERACEs where l.codechien == leCodeChien select l;
                    var recupChienBatard = from l in monModele.VUEBATARDs where l.codechien == leCodeChien select l;

                    int nbChien = recupChienRace.Count();

                    // vérifie si le chien sélectionner et de race ou batard
                    if (nbChien > 0)
                    {
                        comboBoxType.SelectedItem = "Race";

                        foreach (VUERACE values in recupChienRace)
                        {
                            string laRace = values.race;
                            textBoxRace.Text = laRace.Trim();

                            string laRobe = values.robe;
                            textBoxRobe.Text = laRobe.Trim();

                            nbType = 1;
                        }
                    }
                    else
                    {
                        comboBoxType.SelectedItem = "Batard";

                        foreach (VUEBATARD values in recupChienBatard)
                        {
                            string laCaract = values.caracteristiques;
                            textBoxCaracteristique.Text = laCaract.Trim();
                        }

                        nbType = 2;
                    }
                }
                else
                {
                    MessageBox.Show("Sélectionner un chien dans le tableau !");
                }
            }
            else
            {
                MessageBox.Show("Le tableau est vide !");
            }
        }

        // fonction qui vérifie les champs puis qui modifie le chiens 
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            string leCodeChien = textBoxCode.Text;

            string pro = comboBoxProprietaire.Text;
            string[] leNomPro = pro.Split(':');

            // vérifie si le textbox n'est pas vide
            if (textBoxNom.Text == "")
            {
                MessageBox.Show("le champs du nom n'est pas remplis ! ");
            }
            // vérifie si le combobox type n'est pas sur comboNonChoisi
            else if (comboBoxType.Text == comboNonCHoisi)
            {
                MessageBox.Show("vous n'avait pas choisi de type pour le chien ! ");
            }
            // vérifie si le combobox type est sur race que les textbox ne soit pas vide
            else if (comboBoxType.Text == "Race" && textBoxRace.Text == "" || comboBoxType.Text == "Race" && textBoxRobe.Text == "")
            {
                MessageBox.Show("un champ du type n'est pas remplis ! ");
            }
            // vérifie si le combobox type est sur batard que les textbox ne soit pas vide
            else if (comboBoxType.Text == "Batard" && textBoxCaracteristique.Text == "")
            {
                MessageBox.Show("le champ du type n'est pas remplis ! ");
            }
            // modifie le chien 
            else
            {
                string codePropri = leNomPro[1].Trim();
                DateTime ddn = DateTime.Parse(dateTimePicker1.Text);
                string nom = textBoxNom.Text;

                // modifie le chien si il est de race
                if (nbType == 1)
                {
                    monModele.upadteChienRace(leCodeChien, codePropri, ddn, nom, textBoxRace.Text, textBoxRobe.Text);
                    monModele = null;
                    monModele = new CONCOURSCANINEntities();

                }
                // sinon modifie le chien si il est batard
                else if (nbType == 2)
                {
                    monModele.upadteChienBatard(leCodeChien, codePropri, ddn, nom, textBoxCaracteristique.Text);
                    monModele = null;
                    monModele = new CONCOURSCANINEntities();
                }
                else
                {
                    MessageBox.Show("il y a une erreur ! ");
                }

                int nbChien = 0;

                chargerDgv(nbChien);
                cacherTout();
            }
        }

        // fonction qui définie les textbox a afficher en fonction du combobox
        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            cacherCaracteristique();
            string type = comboBoxType.Text;
            
            // si le type sélectionner et race alors on affiche les textbox lier 
            if (type == "Race")
            {
                labelRace.Visible = true;
                textBoxRace.Visible = true;

                labelRobe.Visible = true;
                textBoxRobe.Visible = true;

                nbType = 1;
            }
            // si le type sélectionner et batard alors on affiche le textbox lier 
            else if (type == "Batard")
            {
                labelCaracteristique.Visible = true;
                textBoxCaracteristique.Visible = true;

                nbType = 2;
            }
            // sinon si le comboNonChoisi est sélectionner alors on cache les textbox
            else
            {
                cacherCaracteristique();
                nbType = 0;
            }
        }
    }
}
