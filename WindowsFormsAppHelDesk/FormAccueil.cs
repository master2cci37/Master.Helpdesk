using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHelDesk
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mbox 
            MessageBox.Show
               ("Application v1.0.01.20",
               "Master.HelpDesk",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information

               );
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListe fListe = new FormListe();
            fListe.Show();
        }

        private void assistantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAssistant fAssistants
                = new FormAssistant();

            fAssistants.Show();
        }
        /// <summary>
        /// Gestion unique des actions accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionCentralisee(object sender, EventArgs e)
        {
            //var s = sender.GetType().ToString();
            switch (sender.GetType().ToString())
            {
                case "System.Windows.Forms.ToolStripMenuItem":
                    var menu = (ToolStripMenuItem)sender;
                    
                    if (menu.Name == "quitterToolStripMenuItem")
                    {
                        this.Close();
                    } 
                    else if (menu.Name == "listeToolStripMenuItem")
                    {
                        FormAssistant fa = new FormAssistant();
                        fa.Show();
                    }
                    else if (menu.Name == "listeToolStripMenuItem1")
                    {
                        FormTickets  ft = new FormTickets ();
                        ft.Show();
                    }
                    else if (menu.Name == "siteInternetToolStripMenuItem")
                    {
                        Process pgrm = new Process();
                        pgrm.StartInfo.FileName = "iexplore";
                        pgrm.StartInfo.Arguments = "www.cci.univ-tours.fr/";
                        pgrm.Start();

                        MessageBox.Show("execution site master");
                    }
                    else

                        MessageBox.Show("menu");
                    break;
                case "":
                    break;

                default:
                    MessageBox.Show("En chantier !!!");
                    break;
            }


        }
    }
}










