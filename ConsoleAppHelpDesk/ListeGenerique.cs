#region Références
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion
namespace ConsoleAppHelpDesk
{    public class ListeGenerique<T>
    {
        private List<T> liste;
        public ListeGenerique() { liste = new List<T>(); }
        public void Ajouter(T item) { liste.Add(item); }
        public T ElementA(int rang) { return liste[rang]; }

    }
}
