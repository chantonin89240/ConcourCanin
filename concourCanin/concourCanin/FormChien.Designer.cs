
namespace concourCanin
{
    partial class FormChien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvChien = new System.Windows.Forms.DataGridView();
            this.buttonAfficherRace = new System.Windows.Forms.Button();
            this.buttonAfficherTout = new System.Windows.Forms.Button();
            this.buttonAfficherBatard = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonValiderAjout = new System.Windows.Forms.Button();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.groupBoxChampChien = new System.Windows.Forms.GroupBox();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelProprietaire = new System.Windows.Forms.Label();
            this.labelCodeChien = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.groupBoxCaracteristique = new System.Windows.Forms.GroupBox();
            this.textBoxRobe = new System.Windows.Forms.TextBox();
            this.textBoxCaracteristique = new System.Windows.Forms.TextBox();
            this.textBoxRace = new System.Windows.Forms.TextBox();
            this.labelRobe = new System.Windows.Forms.Label();
            this.labelCaracteristique = new System.Windows.Forms.Label();
            this.labelRace = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.cHIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dERACEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChien)).BeginInit();
            this.groupBoxChampChien.SuspendLayout();
            this.groupBoxCaracteristique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERACEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChien
            // 
            this.dgvChien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChien.Location = new System.Drawing.Point(12, 46);
            this.dgvChien.Name = "dgvChien";
            this.dgvChien.Size = new System.Drawing.Size(1276, 150);
            this.dgvChien.TabIndex = 0;
            // 
            // buttonAfficherRace
            // 
            this.buttonAfficherRace.Location = new System.Drawing.Point(250, 223);
            this.buttonAfficherRace.Name = "buttonAfficherRace";
            this.buttonAfficherRace.Size = new System.Drawing.Size(181, 39);
            this.buttonAfficherRace.TabIndex = 1;
            this.buttonAfficherRace.Text = "Afficher les Chiens de Race";
            this.buttonAfficherRace.UseVisualStyleBackColor = true;
            this.buttonAfficherRace.Click += new System.EventHandler(this.buttonAfficherRace_Click);
            // 
            // buttonAfficherTout
            // 
            this.buttonAfficherTout.Location = new System.Drawing.Point(575, 223);
            this.buttonAfficherTout.Name = "buttonAfficherTout";
            this.buttonAfficherTout.Size = new System.Drawing.Size(181, 39);
            this.buttonAfficherTout.TabIndex = 2;
            this.buttonAfficherTout.Text = "Afficher Tous les Chiens";
            this.buttonAfficherTout.UseVisualStyleBackColor = true;
            this.buttonAfficherTout.Click += new System.EventHandler(this.buttonAfficherTout_Click);
            // 
            // buttonAfficherBatard
            // 
            this.buttonAfficherBatard.Location = new System.Drawing.Point(900, 223);
            this.buttonAfficherBatard.Name = "buttonAfficherBatard";
            this.buttonAfficherBatard.Size = new System.Drawing.Size(181, 39);
            this.buttonAfficherBatard.TabIndex = 3;
            this.buttonAfficherBatard.Text = "Afficher les Chiens Batard";
            this.buttonAfficherBatard.UseVisualStyleBackColor = true;
            this.buttonAfficherBatard.Click += new System.EventHandler(this.buttonAfficherBatard_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(380, 360);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(135, 46);
            this.buttonAjout.TabIndex = 4;
            this.buttonAjout.Text = "Ajouter Chien";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(600, 360);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(135, 46);
            this.buttonSupprimer.TabIndex = 5;
            this.buttonSupprimer.Text = "Supprimer Chien";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(820, 360);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(135, 46);
            this.buttonModifier.TabIndex = 6;
            this.buttonModifier.Text = "Modifier Chien";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonValiderAjout
            // 
            this.buttonValiderAjout.Location = new System.Drawing.Point(220, 360);
            this.buttonValiderAjout.Name = "buttonValiderAjout";
            this.buttonValiderAjout.Size = new System.Drawing.Size(135, 46);
            this.buttonValiderAjout.TabIndex = 7;
            this.buttonValiderAjout.Text = "Valider Ajout";
            this.buttonValiderAjout.UseVisualStyleBackColor = true;
            this.buttonValiderAjout.Click += new System.EventHandler(this.buttonValiderAjout_Click);
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(980, 360);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(135, 46);
            this.buttonValiderModif.TabIndex = 8;
            this.buttonValiderModif.Text = "Valider Modification";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // groupBoxChampChien
            // 
            this.groupBoxChampChien.Controls.Add(this.comboBoxProprietaire);
            this.groupBoxChampChien.Controls.Add(this.dateTimePicker1);
            this.groupBoxChampChien.Controls.Add(this.textBoxNom);
            this.groupBoxChampChien.Controls.Add(this.labelNom);
            this.groupBoxChampChien.Controls.Add(this.labelDateNaissance);
            this.groupBoxChampChien.Controls.Add(this.labelProprietaire);
            this.groupBoxChampChien.Controls.Add(this.labelCodeChien);
            this.groupBoxChampChien.Controls.Add(this.textBoxCode);
            this.groupBoxChampChien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChampChien.Location = new System.Drawing.Point(16, 443);
            this.groupBoxChampChien.Name = "groupBoxChampChien";
            this.groupBoxChampChien.Size = new System.Drawing.Size(758, 267);
            this.groupBoxChampChien.TabIndex = 9;
            this.groupBoxChampChien.TabStop = false;
            this.groupBoxChampChien.Text = "Données du Chien :";
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(187, 103);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(485, 21);
            this.comboBoxProprietaire.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(485, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(187, 221);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(485, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(31, 221);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(80, 13);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom du Chien :";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(31, 162);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(104, 13);
            this.labelDateNaissance.TabIndex = 3;
            this.labelDateNaissance.Text = "Date de Naissance :";
            // 
            // labelProprietaire
            // 
            this.labelProprietaire.AutoSize = true;
            this.labelProprietaire.Location = new System.Drawing.Point(31, 103);
            this.labelProprietaire.Name = "labelProprietaire";
            this.labelProprietaire.Size = new System.Drawing.Size(121, 13);
            this.labelProprietaire.TabIndex = 2;
            this.labelProprietaire.Text = "Numéro du Propriètaire :";
            // 
            // labelCodeChien
            // 
            this.labelCodeChien.AutoSize = true;
            this.labelCodeChien.Location = new System.Drawing.Point(31, 46);
            this.labelCodeChien.Name = "labelCodeChien";
            this.labelCodeChien.Size = new System.Drawing.Size(88, 13);
            this.labelCodeChien.TabIndex = 1;
            this.labelCodeChien.Text = "Code du Chiens :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(187, 43);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(485, 20);
            this.textBoxCode.TabIndex = 0;
            // 
            // groupBoxCaracteristique
            // 
            this.groupBoxCaracteristique.Controls.Add(this.textBoxRobe);
            this.groupBoxCaracteristique.Controls.Add(this.textBoxCaracteristique);
            this.groupBoxCaracteristique.Controls.Add(this.textBoxRace);
            this.groupBoxCaracteristique.Controls.Add(this.labelRobe);
            this.groupBoxCaracteristique.Controls.Add(this.labelCaracteristique);
            this.groupBoxCaracteristique.Controls.Add(this.labelRace);
            this.groupBoxCaracteristique.Controls.Add(this.labelType);
            this.groupBoxCaracteristique.Controls.Add(this.comboBoxType);
            this.groupBoxCaracteristique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCaracteristique.Location = new System.Drawing.Point(790, 443);
            this.groupBoxCaracteristique.Name = "groupBoxCaracteristique";
            this.groupBoxCaracteristique.Size = new System.Drawing.Size(494, 267);
            this.groupBoxCaracteristique.TabIndex = 10;
            this.groupBoxCaracteristique.TabStop = false;
            this.groupBoxCaracteristique.Text = "Caractéristique du Chien :";
            // 
            // textBoxRobe
            // 
            this.textBoxRobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRobe.Location = new System.Drawing.Point(124, 168);
            this.textBoxRobe.Name = "textBoxRobe";
            this.textBoxRobe.Size = new System.Drawing.Size(284, 20);
            this.textBoxRobe.TabIndex = 7;
            // 
            // textBoxCaracteristique
            // 
            this.textBoxCaracteristique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaracteristique.Location = new System.Drawing.Point(161, 122);
            this.textBoxCaracteristique.Name = "textBoxCaracteristique";
            this.textBoxCaracteristique.Size = new System.Drawing.Size(284, 20);
            this.textBoxCaracteristique.TabIndex = 6;
            // 
            // textBoxRace
            // 
            this.textBoxRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRace.Location = new System.Drawing.Point(124, 79);
            this.textBoxRace.Name = "textBoxRace";
            this.textBoxRace.Size = new System.Drawing.Size(284, 20);
            this.textBoxRace.TabIndex = 5;
            // 
            // labelRobe
            // 
            this.labelRobe.AutoSize = true;
            this.labelRobe.Location = new System.Drawing.Point(51, 175);
            this.labelRobe.Name = "labelRobe";
            this.labelRobe.Size = new System.Drawing.Size(39, 13);
            this.labelRobe.TabIndex = 4;
            this.labelRobe.Text = "Robe :";
            // 
            // labelCaracteristique
            // 
            this.labelCaracteristique.AutoSize = true;
            this.labelCaracteristique.Location = new System.Drawing.Point(51, 125);
            this.labelCaracteristique.Name = "labelCaracteristique";
            this.labelCaracteristique.Size = new System.Drawing.Size(83, 13);
            this.labelCaracteristique.TabIndex = 3;
            this.labelCaracteristique.Text = "Caractéristique :";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(51, 82);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(39, 13);
            this.labelRace.TabIndex = 2;
            this.labelRace.Text = "Race :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(174, 22);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(87, 13);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type du Chiens :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(276, 19);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(212, 21);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.TextChanged += new System.EventHandler(this.comboBoxType_TextChanged);
            // 
            // cHIENBindingSource
            // 
            this.cHIENBindingSource.DataSource = typeof(concourCanin.CHIEN);
            // 
            // dERACEBindingSource
            // 
            this.dERACEBindingSource.DataSource = typeof(concourCanin.DERACE);
            // 
            // FormChien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.groupBoxCaracteristique);
            this.Controls.Add(this.groupBoxChampChien);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonValiderAjout);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonAfficherBatard);
            this.Controls.Add(this.buttonAfficherTout);
            this.Controls.Add(this.buttonAfficherRace);
            this.Controls.Add(this.dgvChien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChien";
            this.Text = "Bienvenu sur la Liste des Chiens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChien)).EndInit();
            this.groupBoxChampChien.ResumeLayout(false);
            this.groupBoxChampChien.PerformLayout();
            this.groupBoxCaracteristique.ResumeLayout(false);
            this.groupBoxCaracteristique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERACEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChien;
        private System.Windows.Forms.BindingSource cHIENBindingSource;
        private System.Windows.Forms.Button buttonAfficherRace;
        private System.Windows.Forms.Button buttonAfficherTout;
        private System.Windows.Forms.Button buttonAfficherBatard;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonValiderAjout;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.GroupBox groupBoxChampChien;
        private System.Windows.Forms.GroupBox groupBoxCaracteristique;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelRobe;
        private System.Windows.Forms.Label labelCaracteristique;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.TextBox textBoxRobe;
        private System.Windows.Forms.TextBox textBoxCaracteristique;
        private System.Windows.Forms.TextBox textBoxRace;
        private System.Windows.Forms.Label labelCodeChien;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelProprietaire;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.BindingSource dERACEBindingSource;
    }
}