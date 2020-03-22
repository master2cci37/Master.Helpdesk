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

namespace WindowsFormsAppLiaison
{
    public partial class FormAssistant : Form
    {
        public FormAssistant()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAssistant_Load(object sender, EventArgs e)
        {
            
             comboBoxRole.DisplayMember = "Libelle";
             comboBoxRole.ValueMember = "RoleID";

            var listeRole = new List<Role>
            {
                new Role{RoleID=1,Libelle="Chef"},
                new Role{RoleID=2,Libelle="Assistant"},
            };

            comboBoxRole.DataSource = listeRole;
            
            // chargement assistants
            dataGridViewAssistants.DataSource =
                new ServiceHelpDesk().GetAllAssistants();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // tache de fond  
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHeure.Text =
                DateTime.Now.ToString("hh:mm:ss");
        }

        private void buttonMaster_Click(object sender, EventArgs e)
        {
            Process siteMaster = new Process();
            siteMaster.StartInfo.FileName = "iexplore";
            siteMaster.StartInfo.Arguments = "https://www.cci.univ-tours.fr/";
            siteMaster.Start();
        }
    }

    public class Role
    {
        public int RoleID { get;   set; }
        public string Libelle { get;   set; }
    }
}
