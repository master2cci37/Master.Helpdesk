﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLiaison
{
    public abstract class Personne
    {
        public string Nom
        {
            get => default;
            set
            {
            }
        }

        public string Prenom
        {
            get => default;
            set
            {
            }
        }

        public string Fonction
        {
            get => default;
            set
            {
            }
        }

        public string Mail
        {
            get => default;
            set
            {
            }
        }

        public int Téléphone
        {
            get => default;
            set
            {
            }
        }
    }
    public class Assistant : Personne
    {
        public int AssistantID
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



        //public List<Competence> Competences
        //{
        //    get => default;
        //    set
        //    {
        //    }
        //}
    }
    public class ServiceHelpDesk

    {

        public Personne GetAssistantByID(int id) { return null; }

        public IList<Assistant> GetAllAssistants()

        {

            var assistants = new List<Assistant> {

    new Assistant{ AssistantID = 1, Nom = "Holman", Prenom = "Minerva", Mail = "eu@ipsumprimisin.co.uk" },

    new Assistant{ AssistantID = 2, Nom = "Ashley", Prenom = "Shelley", Mail = "Donec.egestas.Aliquam@sempereratin.net" },

    new Assistant{ AssistantID = 3, Nom = "Strong", Prenom = "Stephen", Mail = "tortor@magnaa.com" },

    new Assistant{ AssistantID = 4, Nom = "Head", Prenom = "Uta", Mail = "Integer.urna.Vivamus@vestibulummassarutrum.co.uk" },

    new Assistant{ AssistantID = 5, Nom = "Bullock", Prenom = "Josiah", Mail = "Fusce@Integer.ca" },

    new Assistant{ AssistantID = 6, Nom = "Paul", Prenom = "Ori", Mail = "eu.lacus@magna.org" },

    new Assistant{ AssistantID = 7, Nom = "Shelton", Prenom = "Alec", Mail = "orci.consectetuer@afelisullamcorper.ca" },

    new Assistant{ AssistantID = 8, Nom = "Padilla", Prenom = "Hasad", Mail = "eget@eudui.edu" },

    new Assistant{ AssistantID = 9, Nom = "Foley", Prenom = "Hoyt", Mail = "mattis.Cras@odio.net" },

    new Assistant{ AssistantID = 10, Nom = "Barron", Prenom = "Cedric", Mail = "consectetuer@arcuvel.ca" },

    new Assistant{ AssistantID = 11, Nom = "Huffman", Prenom = "Jason", Mail = "eget.nisi.dictum@lacus.edu" },

    new Assistant{ AssistantID = 12, Nom = "Warner", Prenom = "Chandler", Mail = "sapien@Utsemperpretium.edu" },

    new Assistant{ AssistantID = 13, Nom = "Sims", Prenom = "Drake", Mail = "Sed@nuncestmollis.com" },

    new Assistant{ AssistantID = 14, Nom = "Reid", Prenom = "Juliet", Mail = "nascetur@vehiculaaliquet.com" },

    new Assistant{ AssistantID = 15, Nom = "Barker", Prenom = "Uma", Mail = "augue.ut@Cras.com" },

    new Assistant{ AssistantID = 16, Nom = "Albert", Prenom = "Zephr", Mail = "neque.Nullam@scelerisque.edu" },

    new Assistant{ AssistantID = 17, Nom = "Moss", Prenom = "Holmes", Mail = "vitae.sodales.at@metus.ca" },

    new Assistant{ AssistantID = 18, Nom = "Sherman", Prenom = "Maxwell", Mail = "consectetuer@eget.co.uk" },

    new Assistant{ AssistantID = 19, Nom = "Quinn", Prenom = "Camille", Mail = "accumsan.sed.facilisis@dui.ca" },

    new Assistant{ AssistantID = 20, Nom = "Marquez", Prenom = "Carla", Mail = "Pellentesque@erat.edu" },

    new Assistant{ AssistantID = 21, Nom = "Lang", Prenom = "David", Mail = "eget.odio@tortorNunc.org" },

    new Assistant{ AssistantID = 22, Nom = "Boyle", Prenom = "Kimberley", Mail = "vitae@eutellus.com" },

    new Assistant{ AssistantID = 23, Nom = "Hayden", Prenom = "Jacqueline", Mail = "vel.nisl@luctus.net" },

    new Assistant{ AssistantID = 24, Nom = "Quinn", Prenom = "Dane", Mail = "enim.Curabitur@tempor.com" },

    new Assistant{ AssistantID = 25, Nom = "Daniel", Prenom = "Alan", Mail = "amet.ante.Vivamus@ultriciesligulaNullam.ca" },

    new Assistant{ AssistantID = 26, Nom = "Yates", Prenom = "Alice", Mail = "metus@massarutrum.net" },

    new Assistant{ AssistantID = 27, Nom = "Newman", Prenom = "Emily", Mail = "dui@vulputatenisi.co.uk" },

    new Assistant{ AssistantID = 28, Nom = "Pruitt", Prenom = "Oren", Mail = "tristique.senectus@tellusnon.org" },

    new Assistant{ AssistantID = 29, Nom = "Clark", Prenom = "Caesar", Mail = "Curae.Donec.tincidunt@convallisestvitae.edu" },

    new Assistant{ AssistantID = 30, Nom = "Pennington", Prenom = "Raja", Mail = "venenatis@orci.co.uk" },

    new Assistant{ AssistantID = 31, Nom = "Mcgee", Prenom = "Christine", Mail = "Donec@justoPraesentluctus.com" },

    new Assistant{ AssistantID = 32, Nom = "Finch", Prenom = "Hakeem", Mail = "varius.ultrices.mauris@tincidunt.net" },

    new Assistant{ AssistantID = 33, Nom = "Davenport", Prenom = "Nasim", Mail = "rutrum.eu.ultrices@Nullamut.com" },

    new Assistant{ AssistantID = 34, Nom = "Williamson", Prenom = "Lunea", Mail = "Vivamus@sedlibero.ca" },

    new Assistant{ AssistantID = 35, Nom = "Moreno", Prenom = "Trevor", Mail = "fringilla.euismod.enim@duiSuspendisseac.net" },

    new Assistant{ AssistantID = 36, Nom = "Schwartz", Prenom = "Cathleen", Mail = "ipsum@Proin.net" },

    new Assistant{ AssistantID = 37, Nom = "Hunter", Prenom = "Alexander", Mail = "neque.sed@augue.com" },

    new Assistant{ AssistantID = 38, Nom = "Richardson", Prenom = "Jack", Mail = "Duis@consectetueradipiscingelit.ca" },

    new Assistant{ AssistantID = 39, Nom = "Harvey", Prenom = "Scarlet", Mail = "nonummy.Fusce@orci.edu" },

    new Assistant{ AssistantID = 40, Nom = "Savage", Prenom = "Kirby", Mail = "libero.nec.ligula@velmaurisInteger.ca" },

    new Assistant{ AssistantID = 41, Nom = "Forbes", Prenom = "Portia", Mail = "non.dapibus.rutrum@estmollis.org" },

    new Assistant{ AssistantID = 42, Nom = "Russo", Prenom = "Quentin", Mail = "nulla@quamdignissim.edu" },

    new Assistant{ AssistantID = 43, Nom = "Moore", Prenom = "Duncan", Mail = "semper.dui@non.ca" },

    new Assistant{ AssistantID = 44, Nom = "Walton", Prenom = "Latifah", Mail = "ante.dictum.mi@faucibusut.net" },

    new Assistant{ AssistantID = 45, Nom = "Gardner", Prenom = "Camden", Mail = "ullamcorper@sit.co.uk" },

    new Assistant{ AssistantID = 46, Nom = "Page", Prenom = "Nathaniel", Mail = "mauris.Morbi@sapiencursusin.co.uk" },

    new Assistant{ AssistantID = 47, Nom = "Conrad", Prenom = "Leandra", Mail = "lacus@Classaptent.net" },

    new Assistant{ AssistantID = 48, Nom = "Mays", Prenom = "Ariana", Mail = "mattis@convallis.org" },

    new Assistant{ AssistantID = 49, Nom = "Guthrie", Prenom = "Ray", Mail = "facilisis.non@VivamusnisiMauris.org" },

    new Assistant{ AssistantID = 50, Nom = "Mclaughlin", Prenom = "Charissa", Mail = "hendrerit.id@Suspendissetristique.co.uk" },

    new Assistant{ AssistantID = 51, Nom = "Golden", Prenom = "Mia", Mail = "nunc.id.enim@Quisqueornare.net" },

    new Assistant{ AssistantID = 52, Nom = "Forbes", Prenom = "Aidan", Mail = "elit.Curabitur@arcuAliquam.net" },

    new Assistant{ AssistantID = 53, Nom = "Tanner", Prenom = "Bianca", Mail = "risus@lacusMauris.com" },

    new Assistant{ AssistantID = 54, Nom = "Weiss", Prenom = "Germaine", Mail = "et@sitametdiam.com" },

    new Assistant{ AssistantID = 55, Nom = "Conley", Prenom = "Cooper", Mail = "vel.est@lobortisultricesVivamus.edu" },

    new Assistant{ AssistantID = 56, Nom = "York", Prenom = "Zane", Mail = "convallis.ante.lectus@aliquetlibero.ca" },

    new Assistant{ AssistantID = 57, Nom = "Bolton", Prenom = "Vance", Mail = "dapibus.quam.quis@pharetra.org" },

    new Assistant{ AssistantID = 58, Nom = "Melton", Prenom = "Griffith", Mail = "commodo.ipsum.Suspendisse@adipiscing.com" },

    new Assistant{ AssistantID = 59, Nom = "Goodwin", Prenom = "Althea", Mail = "nulla.Integer@neque.ca" },

    new Assistant{ AssistantID = 60, Nom = "Chavez", Prenom = "Aubrey", Mail = "convallis.dolor.Quisque@dignissimpharetra.ca" },

    new Assistant{ AssistantID = 61, Nom = "Hayden", Prenom = "Maite", Mail = "laoreet.posuere@disparturient.ca" },

    new Assistant{ AssistantID = 62, Nom = "Berry", Prenom = "Sade", Mail = "quam.quis@arcu.ca" },

    new Assistant{ AssistantID = 63, Nom = "Blackburn", Prenom = "Regina", Mail = "fringilla.est@mieleifend.com" },

    new Assistant{ AssistantID = 64, Nom = "Lawson", Prenom = "Gary", Mail = "nulla@nec.org" },

    new Assistant{ AssistantID = 65, Nom = "Sanders", Prenom = "Kelsey", Mail = "ornare.egestas.ligula@Donecsollicitudin.net" },

    new Assistant{ AssistantID = 66, Nom = "Robinson", Prenom = "Violet", Mail = "est.mollis.non@atsemmolestie.co.uk" },

    new Assistant{ AssistantID = 67, Nom = "Walton", Prenom = "Rashad", Mail = "Nam.ac@scelerisquemollis.net" },

    new Assistant{ AssistantID = 68, Nom = "Sanders", Prenom = "Gregory", Mail = "purus.in.molestie@arcuvelquam.edu" },

    new Assistant{ AssistantID = 69, Nom = "Joseph", Prenom = "Steven", Mail = "quam.Curabitur.vel@Praesenteunulla.ca" },

    new Assistant{ AssistantID = 70, Nom = "Blevins", Prenom = "Honorato", Mail = "quam.a.felis@quis.ca" },

    new Assistant{ AssistantID = 71, Nom = "Olsen", Prenom = "Cherokee", Mail = "eget.ipsum.Suspendisse@ut.edu" },

    new Assistant{ AssistantID = 72, Nom = "Grant", Prenom = "George", Mail = "Etiam.gravida@sociisnatoque.ca" },

    new Assistant{ AssistantID = 73, Nom = "Hoffman", Prenom = "Drew", Mail = "dictum@blanditviverra.edu" },

    new Assistant{ AssistantID = 74, Nom = "Clemons", Prenom = "Adele", Mail = "sed.tortor@ornareegestasligula.net" },

    new Assistant{ AssistantID = 75, Nom = "Osborne", Prenom = "Rhea", Mail = "lacus.Mauris@quisturpis.co.uk" },

    new Assistant{ AssistantID = 76, Nom = "Chaney", Prenom = "Keegan", Mail = "montes.nascetur@vel.org" },

    new Assistant{ AssistantID = 77, Nom = "Robbins", Prenom = "Jamalia", Mail = "magna.et@utdolordapibus.co.uk" },

    new Assistant{ AssistantID = 78, Nom = "Ratliff", Prenom = "Lana", Mail = "posuere@orciinconsequat.co.uk" },

    new Assistant{ AssistantID = 79, Nom = "Romero", Prenom = "Kirsten", Mail = "malesuada@molestieSed.co.uk" },

    new Assistant{ AssistantID = 80, Nom = "Houston", Prenom = "Cherokee", Mail = "Duis.elementum.dui@nibh.net" },

    new Assistant{ AssistantID = 81, Nom = "Pierce", Prenom = "Latifah", Mail = "ante.blandit.viverra@maurisidsapien.org" },

    new Assistant{ AssistantID = 82, Nom = "Ferguson", Prenom = "Preston", Mail = "ipsum.leo.elementum@euismodest.co.uk" },

    new Assistant{ AssistantID = 83, Nom = "Cardenas", Prenom = "Keegan", Mail = "Suspendisse@sedfacilisisvitae.com" },

    new Assistant{ AssistantID = 84, Nom = "Slater", Prenom = "James", Mail = "enim.gravida@noncursusnon.edu" },

    new Assistant{ AssistantID = 85, Nom = "Gaines", Prenom = "Hedwig", Mail = "malesuada.fames@iaculis.ca" },

    new Assistant{ AssistantID = 86, Nom = "Jimenez", Prenom = "Ulric", Mail = "risus.Donec@nibhvulputate.org" },

    new Assistant{ AssistantID = 87, Nom = "Morton", Prenom = "Tatiana", Mail = "Sed@euismod.net" },

    new Assistant{ AssistantID = 88, Nom = "Weiss", Prenom = "Veronica", Mail = "cursus.Nunc.mauris@pharetranibh.edu" },

    new Assistant{ AssistantID = 89, Nom = "Cooley", Prenom = "Chantale", Mail = "Donec.consectetuer@risus.net" },

    new Assistant{ AssistantID = 90, Nom = "Webster", Prenom = "Heather", Mail = "Donec.elementum.lorem@velit.org" },

    new Assistant{ AssistantID = 91, Nom = "Garcia", Prenom = "Heather", Mail = "facilisis.facilisis@Duis.edu" },

    new Assistant{ AssistantID = 92, Nom = "Shaffer", Prenom = "Russell", Mail = "nec.luctus@ami.ca" },

    new Assistant{ AssistantID = 93, Nom = "Ochoa", Prenom = "Elizabeth", Mail = "nec.euismod.in@ullamcorpernislarcu.com" },

    new Assistant{ AssistantID = 94, Nom = "Olsen", Prenom = "Zena", Mail = "risus@scelerisque.com" },

    new Assistant{ AssistantID = 95, Nom = "Greer", Prenom = "Avram", Mail = "Nam.interdum@placeratorcilacus.edu" },

    new Assistant{ AssistantID = 96, Nom = "Weaver", Prenom = "Brady", Mail = "ornare@infelis.co.uk" },

    new Assistant{ AssistantID = 97, Nom = "Koch", Prenom = "Bell", Mail = "non@Aenean.com" },

    new Assistant{ AssistantID = 98, Nom = "Bright", Prenom = "Rogan", Mail = "libero.et.tristique@Sedid.ca" },

    new Assistant{ AssistantID = 99, Nom = "Roman", Prenom = "Quail", Mail = "pellentesque.a@morbi.com" },

    new Assistant{ AssistantID = 100, Nom = "Luna", Prenom = "Abdul", Mail = "nec@loremfringilla.ca" }

};



            return assistants;

        }

    }
}
