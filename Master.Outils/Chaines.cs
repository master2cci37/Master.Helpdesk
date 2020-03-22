using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Outils
{
    /// <summary>
    /// Gestion des chaines
    /// </summary>
    public class Chaines
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Chaines()
        {
        }

        /// <summary>
        /// Retourne la chaine inversée
        /// </summary>
        /// <param name="s">Chaine à traiter</param>
        /// <returns></returns>
        public string GetPalyndrome(string s)
        {
            string stemp = " ";
            for (int i = s.Length-1; i >= 0; i--)
            {
                stemp = stemp + s[i];
            }
            return stemp;
        }



        public int GetLength(string s)
        {
            return 1;
        }

        /// <summary>
        /// Retourne un tableau d'entiers
        /// </summary>
        /// <returns></returns>
        public int[] GetTableauEntier()
        {
            int[] ti = new int[5] { 1, 2, 3, 4, 5 };
            int i3 = ti[2];
            return ti;
        }



    }
}
