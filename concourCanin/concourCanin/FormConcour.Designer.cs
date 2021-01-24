
namespace concourCanin
{
    partial class FormConcour
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
            this.dgvConcours = new System.Windows.Forms.DataGridView();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.groupBoxCoucourVille = new System.Windows.Forms.GroupBox();
            this.groupBoxConcourCP = new System.Windows.Forms.GroupBox();
            this.groupBoxConcourAdresse = new System.Windows.Forms.GroupBox();
            this.groupBoxConcourSalle = new System.Windows.Forms.GroupBox();
            this.groupBoxConcourDate = new System.Windows.Forms.GroupBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxSalle = new System.Windows.Forms.TextBox();
            this.dateConcour = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.buttonValiderAjout = new System.Windows.Forms.Button();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.groupBoxCodeConcour = new System.Windows.Forms.GroupBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.codeconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salleconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeconcoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTICIPEsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONCOURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcours)).BeginInit();
            this.groupBoxCoucourVille.SuspendLayout();
            this.groupBoxConcourCP.SuspendLayout();
            this.groupBoxConcourAdresse.SuspendLayout();
            this.groupBoxConcourSalle.SuspendLayout();
            this.groupBoxConcourDate.SuspendLayout();
            this.groupBoxCodeConcour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConcours
            // 
            this.dgvConcours.AutoGenerateColumns = false;
            this.dgvConcours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeconcoursDataGridViewTextBoxColumn,
            this.adresseconcoursDataGridViewTextBoxColumn,
            this.cpconcoursDataGridViewTextBoxColumn,
            this.dateconcoursDataGridViewTextBoxColumn,
            this.salleconcoursDataGridViewTextBoxColumn,
            this.villeconcoursDataGridViewTextBoxColumn,
            this.pARTICIPEsDataGridViewTextBoxColumn});
            this.dgvConcours.DataSource = this.cONCOURBindingSource;
            this.dgvConcours.Location = new System.Drawing.Point(12, 41);
            this.dgvConcours.Name = "dgvConcours";
            this.dgvConcours.Size = new System.Drawing.Size(1276, 211);
            this.dgvConcours.TabIndex = 0;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(353, 302);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(126, 39);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = "Ajouter un Concour";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(579, 302);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(126, 39);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer le Concour";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(801, 302);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(126, 39);
            this.buttonModifier.TabIndex = 2;
            this.buttonModifier.Text = "Modifier le Concour";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // groupBoxCoucourVille
            // 
            this.groupBoxCoucourVille.Controls.Add(this.textBoxVille);
            this.groupBoxCoucourVille.Location = new System.Drawing.Point(445, 386);
            this.groupBoxCoucourVille.Name = "groupBoxCoucourVille";
            this.groupBoxCoucourVille.Size = new System.Drawing.Size(401, 100);
            this.groupBoxCoucourVille.TabIndex = 3;
            this.groupBoxCoucourVille.TabStop = false;
            this.groupBoxCoucourVille.Text = "Ville du Concour :";
            this.groupBoxCoucourVille.Visible = false;
            // 
            // groupBoxConcourCP
            // 
            this.groupBoxConcourCP.Controls.Add(this.textBoxCP);
            this.groupBoxConcourCP.Location = new System.Drawing.Point(445, 504);
            this.groupBoxConcourCP.Name = "groupBoxConcourCP";
            this.groupBoxConcourCP.Size = new System.Drawing.Size(401, 100);
            this.groupBoxConcourCP.TabIndex = 4;
            this.groupBoxConcourCP.TabStop = false;
            this.groupBoxConcourCP.Text = "Code Postal du Concour :";
            this.groupBoxConcourCP.Visible = false;
            // 
            // groupBoxConcourAdresse
            // 
            this.groupBoxConcourAdresse.Controls.Add(this.textBoxAdresse);
            this.groupBoxConcourAdresse.Location = new System.Drawing.Point(887, 386);
            this.groupBoxConcourAdresse.Name = "groupBoxConcourAdresse";
            this.groupBoxConcourAdresse.Size = new System.Drawing.Size(401, 100);
            this.groupBoxConcourAdresse.TabIndex = 5;
            this.groupBoxConcourAdresse.TabStop = false;
            this.groupBoxConcourAdresse.Text = "Adresse du Concour :";
            this.groupBoxConcourAdresse.Visible = false;
            // 
            // groupBoxConcourSalle
            // 
            this.groupBoxConcourSalle.Controls.Add(this.textBoxSalle);
            this.groupBoxConcourSalle.Location = new System.Drawing.Point(12, 504);
            this.groupBoxConcourSalle.Name = "groupBoxConcourSalle";
            this.groupBoxConcourSalle.Size = new System.Drawing.Size(401, 100);
            this.groupBoxConcourSalle.TabIndex = 6;
            this.groupBoxConcourSalle.TabStop = false;
            this.groupBoxConcourSalle.Text = "Salle du Concour :";
            this.groupBoxConcourSalle.Visible = false;
            // 
            // groupBoxConcourDate
            // 
            this.groupBoxConcourDate.Controls.Add(this.dateConcour);
            this.groupBoxConcourDate.Location = new System.Drawing.Point(887, 504);
            this.groupBoxConcourDate.Name = "groupBoxConcourDate";
            this.groupBoxConcourDate.Size = new System.Drawing.Size(401, 100);
            this.groupBoxConcourDate.TabIndex = 7;
            this.groupBoxConcourDate.TabStop = false;
            this.groupBoxConcourDate.Text = "Date du Concour :";
            this.groupBoxConcourDate.Visible = false;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(7, 43);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(388, 20);
            this.textBoxVille.TabIndex = 0;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(6, 43);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(389, 20);
            this.textBoxCP.TabIndex = 0;
            // 
            // textBoxSalle
            // 
            this.textBoxSalle.Location = new System.Drawing.Point(6, 44);
            this.textBoxSalle.Name = "textBoxSalle";
            this.textBoxSalle.Size = new System.Drawing.Size(389, 20);
            this.textBoxSalle.TabIndex = 1;
            // 
            // dateConcour
            // 
            this.dateConcour.Location = new System.Drawing.Point(6, 41);
            this.dateConcour.Name = "dateConcour";
            this.dateConcour.Size = new System.Drawing.Size(389, 20);
            this.dateConcour.TabIndex = 0;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(6, 43);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(389, 20);
            this.textBoxAdresse.TabIndex = 0;
            // 
            // buttonValiderAjout
            // 
            this.buttonValiderAjout.Location = new System.Drawing.Point(353, 636);
            this.buttonValiderAjout.Name = "buttonValiderAjout";
            this.buttonValiderAjout.Size = new System.Drawing.Size(126, 39);
            this.buttonValiderAjout.TabIndex = 8;
            this.buttonValiderAjout.Text = "Valider l\'Ajout";
            this.buttonValiderAjout.UseVisualStyleBackColor = true;
            this.buttonValiderAjout.Visible = false;
            this.buttonValiderAjout.Click += new System.EventHandler(this.buttonValiderAjout_Click);
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(801, 636);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(126, 39);
            this.buttonValiderModif.TabIndex = 9;
            this.buttonValiderModif.Text = "Valider la Modification";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Visible = false;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // groupBoxCodeConcour
            // 
            this.groupBoxCodeConcour.Controls.Add(this.textBoxCode);
            this.groupBoxCodeConcour.Location = new System.Drawing.Point(12, 386);
            this.groupBoxCodeConcour.Name = "groupBoxCodeConcour";
            this.groupBoxCodeConcour.Size = new System.Drawing.Size(401, 100);
            this.groupBoxCodeConcour.TabIndex = 4;
            this.groupBoxCodeConcour.TabStop = false;
            this.groupBoxCodeConcour.Text = "Code du Concour :";
            this.groupBoxCodeConcour.Visible = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(7, 43);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(388, 20);
            this.textBoxCode.TabIndex = 0;
            // 
            // codeconcoursDataGridViewTextBoxColumn
            // 
            this.codeconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeconcoursDataGridViewTextBoxColumn.DataPropertyName = "codeconcours";
            this.codeconcoursDataGridViewTextBoxColumn.HeaderText = "Code du Concours";
            this.codeconcoursDataGridViewTextBoxColumn.Name = "codeconcoursDataGridViewTextBoxColumn";
            // 
            // adresseconcoursDataGridViewTextBoxColumn
            // 
            this.adresseconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresseconcoursDataGridViewTextBoxColumn.DataPropertyName = "adresseconcours";
            this.adresseconcoursDataGridViewTextBoxColumn.HeaderText = "Adresse du Concours";
            this.adresseconcoursDataGridViewTextBoxColumn.Name = "adresseconcoursDataGridViewTextBoxColumn";
            // 
            // cpconcoursDataGridViewTextBoxColumn
            // 
            this.cpconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpconcoursDataGridViewTextBoxColumn.DataPropertyName = "cpconcours";
            this.cpconcoursDataGridViewTextBoxColumn.HeaderText = "Code Postal du Concours";
            this.cpconcoursDataGridViewTextBoxColumn.Name = "cpconcoursDataGridViewTextBoxColumn";
            // 
            // dateconcoursDataGridViewTextBoxColumn
            // 
            this.dateconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateconcoursDataGridViewTextBoxColumn.DataPropertyName = "dateconcours";
            this.dateconcoursDataGridViewTextBoxColumn.HeaderText = "Date du Concours";
            this.dateconcoursDataGridViewTextBoxColumn.Name = "dateconcoursDataGridViewTextBoxColumn";
            // 
            // salleconcoursDataGridViewTextBoxColumn
            // 
            this.salleconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salleconcoursDataGridViewTextBoxColumn.DataPropertyName = "salleconcours";
            this.salleconcoursDataGridViewTextBoxColumn.HeaderText = "Salle du Concours";
            this.salleconcoursDataGridViewTextBoxColumn.Name = "salleconcoursDataGridViewTextBoxColumn";
            // 
            // villeconcoursDataGridViewTextBoxColumn
            // 
            this.villeconcoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeconcoursDataGridViewTextBoxColumn.DataPropertyName = "villeconcours";
            this.villeconcoursDataGridViewTextBoxColumn.HeaderText = "Ville du Concours";
            this.villeconcoursDataGridViewTextBoxColumn.Name = "villeconcoursDataGridViewTextBoxColumn";
            // 
            // pARTICIPEsDataGridViewTextBoxColumn
            // 
            this.pARTICIPEsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pARTICIPEsDataGridViewTextBoxColumn.DataPropertyName = "PARTICIPEs";
            this.pARTICIPEsDataGridViewTextBoxColumn.HeaderText = "PARTICIPEs";
            this.pARTICIPEsDataGridViewTextBoxColumn.Name = "pARTICIPEsDataGridViewTextBoxColumn";
            this.pARTICIPEsDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONCOURBindingSource
            // 
            this.cONCOURBindingSource.DataSource = typeof(concourCanin.CONCOUR);
            // 
            // FormConcour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.groupBoxCodeConcour);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonValiderAjout);
            this.Controls.Add(this.groupBoxConcourSalle);
            this.Controls.Add(this.groupBoxConcourDate);
            this.Controls.Add(this.groupBoxConcourAdresse);
            this.Controls.Add(this.groupBoxConcourCP);
            this.Controls.Add(this.groupBoxCoucourVille);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dgvConcours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConcour";
            this.Text = "Bienvenu sur la Liste des Concours";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConcour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcours)).EndInit();
            this.groupBoxCoucourVille.ResumeLayout(false);
            this.groupBoxCoucourVille.PerformLayout();
            this.groupBoxConcourCP.ResumeLayout(false);
            this.groupBoxConcourCP.PerformLayout();
            this.groupBoxConcourAdresse.ResumeLayout(false);
            this.groupBoxConcourAdresse.PerformLayout();
            this.groupBoxConcourSalle.ResumeLayout(false);
            this.groupBoxConcourSalle.PerformLayout();
            this.groupBoxConcourDate.ResumeLayout(false);
            this.groupBoxCodeConcour.ResumeLayout(false);
            this.groupBoxCodeConcour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConcours;
        private System.Windows.Forms.BindingSource cONCOURBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salleconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTICIPEsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.GroupBox groupBoxCoucourVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.GroupBox groupBoxConcourCP;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.GroupBox groupBoxConcourAdresse;
        private System.Windows.Forms.GroupBox groupBoxConcourSalle;
        private System.Windows.Forms.TextBox textBoxSalle;
        private System.Windows.Forms.GroupBox groupBoxConcourDate;
        private System.Windows.Forms.DateTimePicker dateConcour;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Button buttonValiderAjout;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.GroupBox groupBoxCodeConcour;
        private System.Windows.Forms.TextBox textBoxCode;
    }
}