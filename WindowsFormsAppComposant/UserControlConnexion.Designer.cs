namespace WindowsFormsAppComposant
{
    partial class UserControlConnexion
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHaut = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotPasse = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotPasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelHaut
            // 
            this.panelHaut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelHaut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHaut.Location = new System.Drawing.Point(16, 79);
            this.panelHaut.Name = "panelHaut";
            this.panelHaut.Size = new System.Drawing.Size(504, 10);
            this.panelHaut.TabIndex = 0;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(268, 281);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 2;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(374, 281);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Location = new System.Drawing.Point(16, 38);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(116, 14);
            this.labelConnexion.TabIndex = 3;
            this.labelConnexion.Text = "Connexion utilisateur";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(41, 128);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(64, 14);
            this.labelIdentifiant.TabIndex = 3;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // labelMotPasse
            // 
            this.labelMotPasse.AutoSize = true;
            this.labelMotPasse.Location = new System.Drawing.Point(41, 181);
            this.labelMotPasse.Name = "labelMotPasse";
            this.labelMotPasse.Size = new System.Drawing.Size(88, 14);
            this.labelMotPasse.TabIndex = 3;
            this.labelMotPasse.Text = "Mot de Passe : ";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(191, 122);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(279, 22);
            this.textBoxIdentifiant.TabIndex = 4;
            // 
            // textBoxMotPasse
            // 
            this.textBoxMotPasse.Location = new System.Drawing.Point(191, 176);
            this.textBoxMotPasse.Name = "textBoxMotPasse";
            this.textBoxMotPasse.Size = new System.Drawing.Size(279, 22);
            this.textBoxMotPasse.TabIndex = 4;
            // 
            // UserControlConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMotPasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelMotPasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.labelConnexion);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.panelHaut);
            this.Name = "UserControlConnexion";
            this.Size = new System.Drawing.Size(539, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHaut;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotPasse;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotPasse;
        public System.Windows.Forms.Button buttonOK;
    }
}
