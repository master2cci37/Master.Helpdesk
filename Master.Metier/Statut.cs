using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Metier
{
    public class Statut
    {
        private List<Statut> liste = new List<Statut>
        {
         new Statut {StatutID=10,Libelle="Nouveau"}
        };
        public int StatutID
        {
            get => default;
            set
            {
            }
        }
        public string Libelle
        {
            get => default;
            set
            {
            }
        }

        public Statut this[int statut]
        {
            get
            {
                foreach (var item in liste)
                {
                    if (statut == item.StatutID)
                        return item;
                }
                return null;
            }

        }

        public Statut this[string statut]
        {
            get
            {
                foreach (var item in liste)
                {
                    if ( item.Libelle.ToLower()
                        .Contains(statut ))
                        return item;
                }
                return null;
            }

        }
    }
}
