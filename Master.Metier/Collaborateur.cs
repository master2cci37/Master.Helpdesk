using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Metier
{

    public class Collaborateur:Personne
    {
        public int CollaborateurID
        {
            get => default;
            set
            {
            }
        }

        public int Matricule { get; set; }

        private string commentaire = "";

        public string Commentaire {
            get { return this.commentaire; }
            set { commentaire = value; }
        }




        public string Role
        {
            get => default;
            set
            {
            }
        }

        public string Contact
        {
            get => default;
            set
            {
            }
        }
         

        public int NumDeService
        {
            get => default;
            set
            {
            }
        }
        public string Mission
        {
            get => default;
            set
            {
            }
        }
    }
}
