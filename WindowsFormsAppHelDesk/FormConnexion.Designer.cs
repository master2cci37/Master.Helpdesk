﻿namespace WindowsFormsAppHelDesk
{
    partial class FormConnexion
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
            this.userControlConnexion1 = new WindowsFormsAppComposant.UserControlConnexion();
            this.SuspendLayout();
            // 
            // userControlConnexion1
            // 
            this.userControlConnexion1.Location = new System.Drawing.Point(12, 26);
            this.userControlConnexion1.Name = "userControlConnexion1";
            this.userControlConnexion1.Size = new System.Drawing.Size(539, 338);
            this.userControlConnexion1.TabIndex = 0;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlConnexion1);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.ResumeLayout(false);

            userControlConnexion1.buttonOK.Text = "Valider";

        }

        #endregion

        private WindowsFormsAppComposant.UserControlConnexion userControlConnexion1;
    }
}