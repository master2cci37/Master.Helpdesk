namespace WindowsFormsAppLiaison
{
    partial class FormAssistant
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.dataGridViewAssistants = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHeure = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.assistantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.téléphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMaster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssistants)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(647, 387);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(113, 32);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(30, 26);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(37, 17);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Rôle";
            // 
            // labelNom
            // 
            this.labelNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(479, 26);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNom.AutoCompleteCustomSource.AddRange(new string[] {
            "DURANT",
            "DUPONT"});
            this.textBoxNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNom.Location = new System.Drawing.Point(562, 28);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(209, 22);
            this.textBoxNom.TabIndex = 2;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(107, 26);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(263, 24);
            this.comboBoxRole.TabIndex = 3;
            // 
            // dataGridViewAssistants
            // 
            this.dataGridViewAssistants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAssistants.AutoGenerateColumns = false;
            this.dataGridViewAssistants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssistants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assistantIDDataGridViewTextBoxColumn,
            this.missionDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.fonctionDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.téléphoneDataGridViewTextBoxColumn});
            this.dataGridViewAssistants.DataSource = this.assistantBindingSource;
            this.dataGridViewAssistants.Location = new System.Drawing.Point(33, 95);
            this.dataGridViewAssistants.Name = "dataGridViewAssistants";
            this.dataGridViewAssistants.RowHeadersWidth = 51;
            this.dataGridViewAssistants.RowTemplate.Height = 24;
            this.dataGridViewAssistants.Size = new System.Drawing.Size(727, 272);
            this.dataGridViewAssistants.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHeure});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHeure
            // 
            this.toolStripStatusLabelHeure.Name = "toolStripStatusLabelHeure";
            this.toolStripStatusLabelHeure.Size = new System.Drawing.Size(63, 20);
            this.toolStripStatusLabelHeure.Text = "12:00:00";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // assistantIDDataGridViewTextBoxColumn
            // 
            this.assistantIDDataGridViewTextBoxColumn.DataPropertyName = "AssistantID";
            this.assistantIDDataGridViewTextBoxColumn.HeaderText = "AssistantID";
            this.assistantIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assistantIDDataGridViewTextBoxColumn.Name = "assistantIDDataGridViewTextBoxColumn";
            this.assistantIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // missionDataGridViewTextBoxColumn
            // 
            this.missionDataGridViewTextBoxColumn.DataPropertyName = "Mission";
            this.missionDataGridViewTextBoxColumn.HeaderText = "Mission";
            this.missionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.missionDataGridViewTextBoxColumn.Name = "missionDataGridViewTextBoxColumn";
            this.missionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // fonctionDataGridViewTextBoxColumn
            // 
            this.fonctionDataGridViewTextBoxColumn.DataPropertyName = "Fonction";
            this.fonctionDataGridViewTextBoxColumn.HeaderText = "Fonction";
            this.fonctionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fonctionDataGridViewTextBoxColumn.Name = "fonctionDataGridViewTextBoxColumn";
            this.fonctionDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // téléphoneDataGridViewTextBoxColumn
            // 
            this.téléphoneDataGridViewTextBoxColumn.DataPropertyName = "Téléphone";
            this.téléphoneDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.téléphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.téléphoneDataGridViewTextBoxColumn.Name = "téléphoneDataGridViewTextBoxColumn";
            this.téléphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataSource = typeof(WindowsFormsAppLiaison.Assistant);
            // 
            // buttonMaster
            // 
            this.buttonMaster.Location = new System.Drawing.Point(469, 387);
            this.buttonMaster.Name = "buttonMaster";
            this.buttonMaster.Size = new System.Drawing.Size(128, 32);
            this.buttonMaster.TabIndex = 6;
            this.buttonMaster.Text = "Site Master";
            this.buttonMaster.UseVisualStyleBackColor = true;
            this.buttonMaster.Click += new System.EventHandler(this.buttonMaster_Click);
            // 
            // FormAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMaster);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewAssistants);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormAssistant";
            this.Text = "Gestion des assistants";
            this.Load += new System.EventHandler(this.FormAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssistants)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.DataGridView dataGridViewAssistants;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn téléphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHeure;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonMaster;
    }
}

