
namespace concourCanin
{
    partial class FormProprietaire
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
            this.dgvProprietaire = new System.Windows.Forms.DataGridView();
            this.codeproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHIENsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPRIETAIREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxCodeProprietaire = new System.Windows.Forms.GroupBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.buttonValiderAjout = new System.Windows.Forms.Button();
            this.groupBoxAdresseProprietaire = new System.Windows.Forms.GroupBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.groupBoxCpPropietaire = new System.Windows.Forms.GroupBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.groupBoxPrenomProprietaire = new System.Windows.Forms.GroupBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.groupBoxVilleProprietaire = new System.Windows.Forms.GroupBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.groupBoxNomProprietaire = new System.Windows.Forms.GroupBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETAIREBindingSource)).BeginInit();
            this.groupBoxCodeProprietaire.SuspendLayout();
            this.groupBoxAdresseProprietaire.SuspendLayout();
            this.groupBoxCpPropietaire.SuspendLayout();
            this.groupBoxPrenomProprietaire.SuspendLayout();
            this.groupBoxVilleProprietaire.SuspendLayout();
            this.groupBoxNomProprietaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProprietaire
            // 
            this.dgvProprietaire.AutoGenerateColumns = false;
            this.dgvProprietaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProprietaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproprietaireDataGridViewTextBoxColumn,
            this.adresseproprietaireDataGridViewTextBoxColumn,
            this.cpproprietaireDataGridViewTextBoxColumn,
            this.nomproprietaireDataGridViewTextBoxColumn,
            this.prenomproprietaireDataGridViewTextBoxColumn,
            this.villeproprietaireDataGridViewTextBoxColumn,
            this.cHIENsDataGridViewTextBoxColumn});
            this.dgvProprietaire.DataSource = this.pROPRIETAIREBindingSource;
            this.dgvProprietaire.Location = new System.Drawing.Point(12, 47);
            this.dgvProprietaire.Name = "dgvProprietaire";
            this.dgvProprietaire.Size = new System.Drawing.Size(1276, 230);
            this.dgvProprietaire.TabIndex = 1;
            // 
            // codeproprietaireDataGridViewTextBoxColumn
            // 
            this.codeproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeproprietaireDataGridViewTextBoxColumn.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.HeaderText = "Numéro du Proprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.Name = "codeproprietaireDataGridViewTextBoxColumn";
            // 
            // adresseproprietaireDataGridViewTextBoxColumn
            // 
            this.adresseproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresseproprietaireDataGridViewTextBoxColumn.DataPropertyName = "adresseproprietaire";
            this.adresseproprietaireDataGridViewTextBoxColumn.HeaderText = "Adresse du Proprietaire";
            this.adresseproprietaireDataGridViewTextBoxColumn.Name = "adresseproprietaireDataGridViewTextBoxColumn";
            // 
            // cpproprietaireDataGridViewTextBoxColumn
            // 
            this.cpproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpproprietaireDataGridViewTextBoxColumn.DataPropertyName = "cpproprietaire";
            this.cpproprietaireDataGridViewTextBoxColumn.HeaderText = "Code Postal du Proprietaire";
            this.cpproprietaireDataGridViewTextBoxColumn.Name = "cpproprietaireDataGridViewTextBoxColumn";
            // 
            // nomproprietaireDataGridViewTextBoxColumn
            // 
            this.nomproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomproprietaireDataGridViewTextBoxColumn.DataPropertyName = "nomproprietaire";
            this.nomproprietaireDataGridViewTextBoxColumn.HeaderText = "Nom du Proprietaire";
            this.nomproprietaireDataGridViewTextBoxColumn.Name = "nomproprietaireDataGridViewTextBoxColumn";
            // 
            // prenomproprietaireDataGridViewTextBoxColumn
            // 
            this.prenomproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomproprietaireDataGridViewTextBoxColumn.DataPropertyName = "prenomproprietaire";
            this.prenomproprietaireDataGridViewTextBoxColumn.HeaderText = "Prenom du Proprietaire";
            this.prenomproprietaireDataGridViewTextBoxColumn.Name = "prenomproprietaireDataGridViewTextBoxColumn";
            // 
            // villeproprietaireDataGridViewTextBoxColumn
            // 
            this.villeproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeproprietaireDataGridViewTextBoxColumn.DataPropertyName = "villeproprietaire";
            this.villeproprietaireDataGridViewTextBoxColumn.HeaderText = "Ville du Proprietaire";
            this.villeproprietaireDataGridViewTextBoxColumn.Name = "villeproprietaireDataGridViewTextBoxColumn";
            // 
            // cHIENsDataGridViewTextBoxColumn
            // 
            this.cHIENsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cHIENsDataGridViewTextBoxColumn.DataPropertyName = "CHIENs";
            this.cHIENsDataGridViewTextBoxColumn.HeaderText = "CHIENs";
            this.cHIENsDataGridViewTextBoxColumn.Name = "cHIENsDataGridViewTextBoxColumn";
            this.cHIENsDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROPRIETAIREBindingSource
            // 
            this.pROPRIETAIREBindingSource.DataSource = typeof(concourCanin.PROPRIETAIRE);
            // 
            // groupBoxCodeProprietaire
            // 
            this.groupBoxCodeProprietaire.Controls.Add(this.textBoxCode);
            this.groupBoxCodeProprietaire.Location = new System.Drawing.Point(10, 411);
            this.groupBoxCodeProprietaire.Name = "groupBoxCodeProprietaire";
            this.groupBoxCodeProprietaire.Size = new System.Drawing.Size(401, 100);
            this.groupBoxCodeProprietaire.TabIndex = 14;
            this.groupBoxCodeProprietaire.TabStop = false;
            this.groupBoxCodeProprietaire.Text = "Code du Propriétaire :";
            this.groupBoxCodeProprietaire.Visible = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(7, 43);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(388, 20);
            this.textBoxCode.TabIndex = 0;
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(799, 661);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(126, 39);
            this.buttonValiderModif.TabIndex = 20;
            this.buttonValiderModif.Text = "Valider la Modification";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Visible = false;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // buttonValiderAjout
            // 
            this.buttonValiderAjout.Location = new System.Drawing.Point(351, 661);
            this.buttonValiderAjout.Name = "buttonValiderAjout";
            this.buttonValiderAjout.Size = new System.Drawing.Size(126, 39);
            this.buttonValiderAjout.TabIndex = 19;
            this.buttonValiderAjout.Text = "Valider l\'Ajout";
            this.buttonValiderAjout.UseVisualStyleBackColor = true;
            this.buttonValiderAjout.Visible = false;
            this.buttonValiderAjout.Click += new System.EventHandler(this.buttonValiderAjout_Click);
            // 
            // groupBoxAdresseProprietaire
            // 
            this.groupBoxAdresseProprietaire.Controls.Add(this.textBoxAdresse);
            this.groupBoxAdresseProprietaire.Location = new System.Drawing.Point(10, 529);
            this.groupBoxAdresseProprietaire.Name = "groupBoxAdresseProprietaire";
            this.groupBoxAdresseProprietaire.Size = new System.Drawing.Size(401, 100);
            this.groupBoxAdresseProprietaire.TabIndex = 17;
            this.groupBoxAdresseProprietaire.TabStop = false;
            this.groupBoxAdresseProprietaire.Text = "Adresse du Propriétaire :";
            this.groupBoxAdresseProprietaire.Visible = false;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(6, 44);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(389, 20);
            this.textBoxAdresse.TabIndex = 1;
            // 
            // groupBoxCpPropietaire
            // 
            this.groupBoxCpPropietaire.Controls.Add(this.textBoxCP);
            this.groupBoxCpPropietaire.Location = new System.Drawing.Point(885, 529);
            this.groupBoxCpPropietaire.Name = "groupBoxCpPropietaire";
            this.groupBoxCpPropietaire.Size = new System.Drawing.Size(401, 100);
            this.groupBoxCpPropietaire.TabIndex = 18;
            this.groupBoxCpPropietaire.TabStop = false;
            this.groupBoxCpPropietaire.Text = "Code Postal du Propriétaire :";
            this.groupBoxCpPropietaire.Visible = false;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(6, 44);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(389, 20);
            this.textBoxCP.TabIndex = 1;
            // 
            // groupBoxPrenomProprietaire
            // 
            this.groupBoxPrenomProprietaire.Controls.Add(this.textBoxPrenom);
            this.groupBoxPrenomProprietaire.Location = new System.Drawing.Point(885, 411);
            this.groupBoxPrenomProprietaire.Name = "groupBoxPrenomProprietaire";
            this.groupBoxPrenomProprietaire.Size = new System.Drawing.Size(401, 100);
            this.groupBoxPrenomProprietaire.TabIndex = 16;
            this.groupBoxPrenomProprietaire.TabStop = false;
            this.groupBoxPrenomProprietaire.Text = "Prénom du Propiétaire :";
            this.groupBoxPrenomProprietaire.Visible = false;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(6, 43);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(389, 20);
            this.textBoxPrenom.TabIndex = 0;
            // 
            // groupBoxVilleProprietaire
            // 
            this.groupBoxVilleProprietaire.Controls.Add(this.textBoxVille);
            this.groupBoxVilleProprietaire.Location = new System.Drawing.Point(443, 529);
            this.groupBoxVilleProprietaire.Name = "groupBoxVilleProprietaire";
            this.groupBoxVilleProprietaire.Size = new System.Drawing.Size(401, 100);
            this.groupBoxVilleProprietaire.TabIndex = 15;
            this.groupBoxVilleProprietaire.TabStop = false;
            this.groupBoxVilleProprietaire.Text = "Ville du Propriétaire :";
            this.groupBoxVilleProprietaire.Visible = false;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(7, 44);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(389, 20);
            this.textBoxVille.TabIndex = 0;
            // 
            // groupBoxNomProprietaire
            // 
            this.groupBoxNomProprietaire.Controls.Add(this.textBoxNom);
            this.groupBoxNomProprietaire.Location = new System.Drawing.Point(443, 411);
            this.groupBoxNomProprietaire.Name = "groupBoxNomProprietaire";
            this.groupBoxNomProprietaire.Size = new System.Drawing.Size(401, 100);
            this.groupBoxNomProprietaire.TabIndex = 13;
            this.groupBoxNomProprietaire.TabStop = false;
            this.groupBoxNomProprietaire.Text = "Nom du Propriétaire :";
            this.groupBoxNomProprietaire.Visible = false;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(7, 43);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(388, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(799, 327);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(126, 39);
            this.buttonModifier.TabIndex = 12;
            this.buttonModifier.Text = "Modifier le Concour";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(577, 327);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(126, 39);
            this.buttonSupprimer.TabIndex = 11;
            this.buttonSupprimer.Text = "Supprimer le Concour";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(351, 327);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(126, 39);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "Ajouter un Concour";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // FormProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.groupBoxCodeProprietaire);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonValiderAjout);
            this.Controls.Add(this.groupBoxAdresseProprietaire);
            this.Controls.Add(this.groupBoxCpPropietaire);
            this.Controls.Add(this.groupBoxPrenomProprietaire);
            this.Controls.Add(this.groupBoxVilleProprietaire);
            this.Controls.Add(this.groupBoxNomProprietaire);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dgvProprietaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProprietaire";
            this.Text = "Bienvenu sur la Liste des Propriétaires";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProprietaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETAIREBindingSource)).EndInit();
            this.groupBoxCodeProprietaire.ResumeLayout(false);
            this.groupBoxCodeProprietaire.PerformLayout();
            this.groupBoxAdresseProprietaire.ResumeLayout(false);
            this.groupBoxAdresseProprietaire.PerformLayout();
            this.groupBoxCpPropietaire.ResumeLayout(false);
            this.groupBoxCpPropietaire.PerformLayout();
            this.groupBoxPrenomProprietaire.ResumeLayout(false);
            this.groupBoxPrenomProprietaire.PerformLayout();
            this.groupBoxVilleProprietaire.ResumeLayout(false);
            this.groupBoxVilleProprietaire.PerformLayout();
            this.groupBoxNomProprietaire.ResumeLayout(false);
            this.groupBoxNomProprietaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProprietaire;
        private System.Windows.Forms.BindingSource pROPRIETAIREBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHIENsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxCodeProprietaire;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Button buttonValiderAjout;
        private System.Windows.Forms.GroupBox groupBoxAdresseProprietaire;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.GroupBox groupBoxCpPropietaire;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.GroupBox groupBoxPrenomProprietaire;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.GroupBox groupBoxVilleProprietaire;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.GroupBox groupBoxNomProprietaire;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
    }
}