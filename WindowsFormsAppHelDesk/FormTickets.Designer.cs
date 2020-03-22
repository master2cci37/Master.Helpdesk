namespace WindowsFormsAppHelDesk
{
    partial class FormTickets
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
            this.buttonFermer = new System.Windows.Forms.Button();
            this.labelAssistant = new System.Windows.Forms.Label();
            this.labelStatut = new System.Windows.Forms.Label();
            this.textBoxAssistant = new System.Windows.Forms.TextBox();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFermer.Location = new System.Drawing.Point(638, 400);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(121, 38);
            this.buttonFermer.TabIndex = 0;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // labelAssistant
            // 
            this.labelAssistant.AutoSize = true;
            this.labelAssistant.Location = new System.Drawing.Point(22, 13);
            this.labelAssistant.Name = "labelAssistant";
            this.labelAssistant.Size = new System.Drawing.Size(75, 20);
            this.labelAssistant.TabIndex = 1;
            this.labelAssistant.Text = "Assistant";
            // 
            // labelStatut
            // 
            this.labelStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatut.AutoSize = true;
            this.labelStatut.Location = new System.Drawing.Point(374, 13);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(53, 20);
            this.labelStatut.TabIndex = 1;
            this.labelStatut.Text = "Statut";
            // 
            // textBoxAssistant
            // 
            this.textBoxAssistant.Location = new System.Drawing.Point(122, 6);
            this.textBoxAssistant.Name = "textBoxAssistant";
            this.textBoxAssistant.Size = new System.Drawing.Size(224, 26);
            this.textBoxAssistant.TabIndex = 2;
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Location = new System.Drawing.Point(486, 4);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(273, 28);
            this.comboBoxStatut.TabIndex = 3;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(26, 61);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 62;
            this.dataGridViewTickets.RowTemplate.Height = 28;
            this.dataGridViewTickets.Size = new System.Drawing.Size(733, 313);
            this.dataGridViewTickets.TabIndex = 4;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.comboBoxStatut);
            this.Controls.Add(this.textBoxAssistant);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.labelAssistant);
            this.Controls.Add(this.buttonFermer);
            this.Name = "FormTickets";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label labelAssistant;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.TextBox textBoxAssistant;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
    }
}