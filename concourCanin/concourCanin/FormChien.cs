﻿using System;
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
        private CONCOURSCANINEntities monModele;
        string comboNonCHoisi = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
        int nbType = 0;

        public FormChien()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities();
        }

        // fonction qui charge le dgv en fonction du type de chien demander
        private void chargerDgv(int nb)
        {
            DataGridViewAutoSizeColumnMode size = DataGridViewAutoSizeColumnMode.Fill;

            // affiche tout les chiens dans le dgv
            if (nb == 0)
            {
                var req = from v in monModele.CHIENs orderby v.codeproprietaire select v;
                cHIENBindingSource.DataSource = req.ToList();
                dgvChien.DataSource = cHIENBindingSource;

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
            groupBoxChampChien.Visible = false;
            groupBoxCaracteristique.Visible = false;

            buttonValiderAjout.Visible = false;
            buttonValiderModif.Visible = false;

            textBoxCode.Enabled = true;
            comboBoxProprietaire.Enabled = true;
            comboBoxType.Enabled = true;

            textBoxCode.Clear();
            textBoxNom.Clear(); 

            textBoxRace.Clear();
            textBoxCaracteristique.Clear();
            textBoxRobe.Clear();

            comboBoxProprietaire.SelectedItem = comboNonCHoisi;
            comboBoxType.SelectedItem = comboNonCHoisi;

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
            
            if (textBoxCode.Text == "" || textBoxNom.Text == "")
            {
                MessageBox.Show("certains champs ne sont pas remplis ! ");
            }
            else if (comboBoxProprietaire.Text == comboNonCHoisi)
            {
                MessageBox.Show("vous n'avait pas choisi de propriétaire ! ");
            }
            else if (comboBoxType.Text == comboNonCHoisi)
            {
                MessageBox.Show("vous n'avait pas choisi de type pour le chien ! ");
            }
            else if (comboBoxType.Text == "Race" && textBoxRace.Text == "" || comboBoxType.Text == "Race" && textBoxRobe.Text == "")
            {
                MessageBox.Show("un champ du type n'est pas remplis ! ");
            }
            else if (comboBoxType.Text == "Batard" && textBoxCaracteristique.Text == "")
            {
                MessageBox.Show("le champ du type n'est pas remplis ! ");
            }
            else if (testChien == false)
            {
                MessageBox.Show("le code du chien existe déjà ! ");
            }
            else
            {
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
            if (dgvChien.RowCount != 1)
            {
                string leCodeChien = dgvChien.CurrentRow.Cells[0].Value.ToString();
                string leCodeProprietaire = dgvChien.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("êtes vous sur de vouloir supprimer le chien numéro : " + leCodeChien.Trim() + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var chien = monModele.CHIENs.Find(leCodeChien, leCodeProprietaire);
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
            

            if (dgvChien.RowCount != 1)
            {
                if (dgvChien.CurrentRow.Selected)
                {
                    cacherTout();

                    groupBoxChampChien.Visible = true;
                    groupBoxCaracteristique.Visible = true;

                    textBoxCode.Enabled = false;
                    comboBoxProprietaire.Enabled = false;
                    comboBoxType.Enabled = false;

                    cacherCaracteristique();

                    buttonValiderModif.Visible = true;

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

            if (textBoxNom.Text == "")
            {
                MessageBox.Show("le champs du nom n'est pas remplis ! ");
            }
            else if (comboBoxType.Text == comboNonCHoisi)
            {
                MessageBox.Show("vous n'avait pas choisi de type pour le chien ! ");
            }
            else if (comboBoxType.Text == "Race" && textBoxRace.Text == "" || comboBoxType.Text == "Race" && textBoxRobe.Text == "")
            {
                MessageBox.Show("un champ du type n'est pas remplis ! ");
            }
            else if (comboBoxType.Text == "Batard" && textBoxCaracteristique.Text == "")
            {
                MessageBox.Show("le champ du type n'est pas remplis ! ");
            }
            else
            {
                string codePropri = leNomPro[1];
                DateTime ddn = DateTime.Parse(dateTimePicker1.Text);
                string nom = textBoxNom.Text;


                if (nbType == 1)
                {
                    var chien = monModele.VUERACEs.Find(leCodeChien, codePropri);

                    chien.ddnchien = ddn;
                    chien.nomchien = nom;
                    chien.race = textBoxRace.Text;
                    chien.robe = textBoxRobe.Text;

                    monModele.SaveChanges();
                }
                else if (nbType == 2)
                {
                    var chien = monModele.VUEBATARDs.Find(leCodeChien, codePropri);

                    chien.ddnchien = ddn;
                    chien.nomchien = nom;
                    chien.caracteristiques = textBoxCaracteristique.Text;

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

        // fonction qui définie les textbox a afficher en fonction du combobox
        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            cacherCaracteristique();
            string type = comboBoxType.Text;
            
            if (type == "Race")
            {
                labelRace.Visible = true;
                textBoxRace.Visible = true;

                labelRobe.Visible = true;
                textBoxRobe.Visible = true;

                nbType = 1;
            }
            else if (type == "Batard")
            {
                labelCaracteristique.Visible = true;
                textBoxCaracteristique.Visible = true;

                nbType = 2;
            }
            else
            {
                cacherCaracteristique();
                nbType = 0;
            }
        }
    }
}
