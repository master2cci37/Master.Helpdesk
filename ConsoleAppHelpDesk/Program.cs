#region Références
//using Master.Outils;
using Master.Outils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleAppHelpDesk
{
    public enum Couleurs { Blanc, Jaune, Vert, Rouge };
    class Program
    {
        static void Main(string[] args)
        {
            #region 20/01/2020
            // Chaines c = new Chaines();

            // types valeurs
            Couleurs c = Couleurs.Vert;
            int index = (int)c;
            int i = 1;
            double d = 12.356d;
            decimal m = 50.00m;
            DateTime dt = DateTime.Now;
            DateTime dtd = new DateTime(2020, 1, 21);

            // variables
            int roleAssistant = 1;
            const double pi = 3.14;

            // opérateurs
            string g = (roleAssistant == 2) ? "Admin" : "Assistant";
            if (i < -1 && roleAssistant > 3) g = "Indefini";

            // structures - > voir cours chapitre 1 

            // methodes 
            Chaines ch = new Chaines();
            Console.WriteLine(ch.GetPalyndrome("MARIEM"));

            Console.WriteLine("Bonjour Master CCI 2020 !!!!");
            #endregion

            //  test generiques 
            Resolution r1 = new Resolution();
            r1.ResolutionID = 1;
            r1.Libelle = "Clôture";
            var r2 = new Resolution
            {
                ResolutionID = 2,
                Libelle = "Sans suite"
            };
            var r3 = new Resolution
            {
                ResolutionID = 3,
                Libelle = "Ouvert"
            };
            var r4 = new Resolution
            {
                ResolutionID = 4,
                Libelle = "Résolu"
            };
            ArrayList al = new ArrayList();
            al.Add(r1); al.Add(r2); al.Add(r3); al.Add(r4);

            //=>Console.WriteLine(al[2].Libelle); // ko 
            Console.WriteLine(((Resolution)al[2]).Libelle); //Okay!!!
            Console.WriteLine((al[2] as Resolution).Libelle); //Okay!!!

            // depuis 2005 - generiques
            List<Resolution> lr = new List<Resolution> { r1, r2, r3, r3 };
            Console.WriteLine(lr[2].Libelle);

            // classe generique
            var li = new ListeGenerique<int>();
            li.Ajouter(1); li.Ajouter(10); li.Ajouter(100);
            Console.WriteLine(li.ElementA(2));

            var lre = new ListeGenerique<Resolution>();
            lre.Ajouter(r1); lre.Ajouter(r2); lre.Ajouter(r3);
            Console.WriteLine(lre.ElementA(2).Libelle);

            #region  lecture / ecriture fichier
            StreamWriter sw = new StreamWriter(
                "fichier.txt",true );// ecriture avec ajout
            foreach (var item in lr) sw.WriteLine(item.Libelle);
            sw.Close();

            StreamReader sr = new StreamReader("fichier.txt");
            while (sr.ReadLine() != null)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            #endregion

            // formatage des chaines 

            // date 
            var today = DateTime.Now;
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(
                string.Format("Ns sommes le {0:dd/MM}",today));
            Console.WriteLine($"Ns sommes le {today}"); // Oui!!!
            // nombre 
            var pix = 3.14d;
            Console.WriteLine($"{pix:###0.00}");
            Console.WriteLine($"{lr.Count :00}");



            Console.ReadLine();
        }
    }
}
