
namespace concourCanin
{
    partial class FormNotation
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
            this.dgvNotation = new System.Windows.Forms.DataGridView();
            this.codeproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codechienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONCOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTICIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonValideAjout = new System.Windows.Forms.Button();
            this.buttonValiderModification = new System.Windows.Forms.Button();
            this.groupBoxProprietaire = new System.Windows.Forms.GroupBox();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.groupBoxChien = new System.Windows.Forms.GroupBox();
            this.comboBoxChien = new System.Windows.Forms.ComboBox();
            this.groupBoxConcour = new System.Windows.Forms.GroupBox();
            this.comboBoxConcour = new System.Windows.Forms.ComboBox();
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource)).BeginInit();
            this.groupBoxProprietaire.SuspendLayout();
            this.groupBoxChien.SuspendLayout();
            this.groupBoxConcour.SuspendLayout();
            this.groupBoxNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNotation
            // 
            this.dgvNotation.AutoGenerateColumns = false;
            this.dgvNotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproprietaireDataGridViewTextBoxColumn,
            this.codechienDataGridViewTextBoxColumn,
            this.codeconcoursDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.cHIENDataGridViewTextBoxColumn,
            this.cONCOURDataGridViewTextBoxColumn});
            this.dgvNotation.DataSource = this.pARTICIPEBindingSource;
            this.dgvNotation.Location = new System.Drawing.Point(494, 50);
            this.dgvNotation.Name = "dgvNotation";
            this.dgvNotation.Size = new System.Drawing.Size(780, 267);
            this.dgvNotation.TabIndex = 0;
            // 
            // codeproprietaireDataGridViewTextBoxColumn
            // 
            this.codeproprietaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeproprietaireDataGridViewTextBoxColumn.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.HeaderText = "Numéro du Proprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.Name = "codeproprietaireDataGridViewTextBoxColumn";
            // 
            // codechienDataGridViewTextBoxColumn
            // 
            this.codechienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codechienDataGridViewTextBoxColumn.DataPropertyName = "codechien";
            this.codechienDataGridViewTextBoxColumn.HeaderText = "Numéro du Chien";
            this.codechienDataGridViewTextBoxColumn.Name = "codechienDataGridViewTextBoxColumn";
            // 
            // codeconcoursDataGridViewTextBoxColumn
            // 
            this.codeconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeconcoursDataGridViewTextBoxColumn.DataPropertyName = "codeconcours";
            this.codeconcoursDataGridViewTextBoxColumn.HeaderText = "Numéro du Concours";
            this.codeconcoursDataGridViewTextBoxColumn.Name = "codeconcoursDataGridViewTextBoxColumn";
            this.codeconcoursDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // cHIENDataGridViewTextBoxColumn
            // 
            this.cHIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cHIENDataGridViewTextBoxColumn.DataPropertyName = "CHIEN";
            this.cHIENDataGridViewTextBoxColumn.HeaderText = "CHIEN";
            this.cHIENDataGridViewTextBoxColumn.Name = "cHIENDataGridViewTextBoxColumn";
            this.cHIENDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONCOURDataGridViewTextBoxColumn
            // 
            this.cONCOURDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONCOURDataGridViewTextBoxColumn.DataPropertyName = "CONCOUR";
            this.cONCOURDataGridViewTextBoxColumn.HeaderText = "CONCOUR";
            this.cONCOURDataGridViewTextBoxColumn.Name = "cONCOURDataGridViewTextBoxColumn";
            this.cONCOURDataGridViewTextBoxColumn.Visible = false;
            // 
            // pARTICIPEBindingSource
            // 
            this.pARTICIPEBindingSource.DataSource = typeof(concourCanin.PARTICIPE);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(384, 411);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(126, 39);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter une Notation";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(804, 411);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(126, 39);
            this.buttonModifier.TabIndex = 9;
            this.buttonModifier.Text = "Modifier la Notation";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonValideAjout
            // 
            this.buttonValideAjout.Location = new System.Drawing.Point(384, 631);
            this.buttonValideAjout.Name = "buttonValideAjout";
            this.buttonValideAjout.Size = new System.Drawing.Size(126, 39);
            this.buttonValideAjout.TabIndex = 10;
            this.buttonValideAjout.Text = "Valider l\'Ajout";
            this.buttonValideAjout.UseVisualStyleBackColor = true;
            this.buttonValideAjout.Click += new System.EventHandler(this.buttonValideAjout_Click);
            // 
            // buttonValiderModification
            // 
            this.buttonValiderModification.Location = new System.Drawing.Point(804, 631);
            this.buttonValiderModification.Name = "buttonValiderModification";
            this.buttonValiderModification.Size = new System.Drawing.Size(126, 39);
            this.buttonValiderModification.TabIndex = 11;
            this.buttonValiderModification.Text = "Valider la Modification";
            this.buttonValiderModification.UseVisualStyleBackColor = true;
            this.buttonValiderModification.Click += new System.EventHandler(this.buttonValiderModification_Click);
            // 
            // groupBoxProprietaire
            // 
            this.groupBoxProprietaire.Controls.Add(this.comboBoxProprietaire);
            this.groupBoxProprietaire.Location = new System.Drawing.Point(53, 502);
            this.groupBoxProprietaire.Name = "groupBoxProprietaire";
            this.groupBoxProprietaire.Size = new System.Drawing.Size(341, 100);
            this.groupBoxProprietaire.TabIndex = 0;
            this.groupBoxProprietaire.TabStop = false;
            this.groupBoxProprietaire.Text = "Numéro du Propriétaire :";
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(6, 41);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(329, 21);
            this.comboBoxProprietaire.TabIndex = 1;
            this.comboBoxProprietaire.TextChanged += new System.EventHandler(this.comboBoxProprietaire_TextChanged);
            // 
            // groupBoxChien
            // 
            this.groupBoxChien.Controls.Add(this.comboBoxChien);
            this.groupBoxChien.Location = new System.Drawing.Point(488, 502);
            this.groupBoxChien.Name = "groupBoxChien";
            this.groupBoxChien.Size = new System.Drawing.Size(341, 100);
            this.groupBoxChien.TabIndex = 1;
            this.groupBoxChien.TabStop = false;
            this.groupBoxChien.Text = "Numéro du Chien :";
            // 
            // comboBoxChien
            // 
            this.comboBoxChien.FormattingEnabled = true;
            this.comboBoxChien.Location = new System.Drawing.Point(6, 41);
            this.comboBoxChien.Name = "comboBoxChien";
            this.comboBoxChien.Size = new System.Drawing.Size(329, 21);
            this.comboBoxChien.TabIndex = 0;
            this.comboBoxChien.TextChanged += new System.EventHandler(this.comboBoxChien_TextChanged);
            // 
            // groupBoxConcour
            // 
            this.groupBoxConcour.Controls.Add(this.comboBoxConcour);
            this.groupBoxConcour.Location = new System.Drawing.Point(63, 50);
            this.groupBoxConcour.Name = "groupBoxConcour";
            this.groupBoxConcour.Size = new System.Drawing.Size(391, 100);
            this.groupBoxConcour.TabIndex = 1;
            this.groupBoxConcour.TabStop = false;
            this.groupBoxConcour.Text = "Numéro du concour :";
            // 
            // comboBoxConcour
            // 
            this.comboBoxConcour.FormattingEnabled = true;
            this.comboBoxConcour.Location = new System.Drawing.Point(6, 45);
            this.comboBoxConcour.Name = "comboBoxConcour";
            this.comboBoxConcour.Size = new System.Drawing.Size(379, 21);
            this.comboBoxConcour.TabIndex = 2;
            // 
            // groupBoxNote
            // 
            this.groupBoxNote.Controls.Add(this.textBoxNote);
            this.groupBoxNote.Location = new System.Drawing.Point(907, 502);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(341, 100);
            this.groupBoxNote.TabIndex = 2;
            this.groupBoxNote.TabStop = false;
            this.groupBoxNote.Text = "Note :";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(6, 45);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(329, 20);
            this.textBoxNote.TabIndex = 0;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Location = new System.Drawing.Point(195, 225);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(126, 39);
            this.buttonRecherche.TabIndex = 12;
            this.buttonRecherche.Text = "Rechercher Concour";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(590, 411);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(126, 39);
            this.buttonSupprimer.TabIndex = 13;
            this.buttonSupprimer.Text = "Supprimer la Notation";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // FormNotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.groupBoxNote);
            this.Controls.Add(this.groupBoxConcour);
            this.Controls.Add(this.groupBoxChien);
            this.Controls.Add(this.groupBoxProprietaire);
            this.Controls.Add(this.buttonValiderModification);
            this.Controls.Add(this.buttonValideAjout);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dgvNotation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotation";
            this.Text = "Bienvenu sur les Notation des Concours";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource)).EndInit();
            this.groupBoxProprietaire.ResumeLayout(false);
            this.groupBoxChien.ResumeLayout(false);
            this.groupBoxConcour.ResumeLayout(false);
            this.groupBoxNote.ResumeLayout(false);
            this.groupBoxNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotation;
        private System.Windows.Forms.BindingSource pARTICIPEBindingSource;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonValideAjout;
        private System.Windows.Forms.Button buttonValiderModification;
        private System.Windows.Forms.GroupBox groupBoxProprietaire;
        private System.Windows.Forms.GroupBox groupBoxChien;
        private System.Windows.Forms.GroupBox groupBoxConcour;
        private System.Windows.Forms.GroupBox groupBoxNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.ComboBox comboBoxChien;
        private System.Windows.Forms.ComboBox comboBoxConcour;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONCOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}