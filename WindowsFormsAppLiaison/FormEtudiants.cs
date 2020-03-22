using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLiaison
{
    public partial class FormEtudiants : Form
    {
        public FormEtudiants()
        {
            InitializeComponent();
        }

        private void etudiantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mASTERCCI2020DataSet);

        }

        private void FormEtudiants_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mASTERCCI2020DataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etudiantTableAdapter.Fill(this.mASTERCCI2020DataSet.Etudiant);

        }
    }
}
