namespace Master.Metier.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Master.Metier.ModeleHelpDesk>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Master.Metier.ModeleHelpDesk context)
        {
            // ajout 
            var priorite = new Priorite { PrioriteID = 12, Libelle = "libelle" };
            context.Priorites.Add(priorite);
            context.SaveChanges(); 

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (context.Priorites.Count() == 0)
            {
                context.Priorites.Add(
                    new Priorite { Libelle = "Immédiat" });
                context.SaveChanges();
            }

            context.Priorites.AddOrUpdate(p=>p.PrioriteID,
                     new Priorite {PrioriteID=1,
                         Libelle = "Immédiat" });

            // Méthodes CRUD / Entity framework 
            var ctxHelpDesk = new ModeleHelpDesk();//nouvelle connexion
            ctxHelpDesk.Priorites.Add(
                new Priorite { Libelle = "Haut", 
                    PrioriteID = 2 });//insert 

            var prio1 = ctxHelpDesk.Priorites
                .Where(p => p.PrioriteID == 1).First();//retrieve
            var prio2 = ctxHelpDesk.Priorites
                .FirstOrDefault(p => p.PrioriteID == 2);//variante

            prio1.Libelle = "Bas";//update

            ctxHelpDesk.Priorites.Remove(prio1);//delete

            ctxHelpDesk.SaveChanges();//persistances 

            // jointures automatiques 
            var t1 = ctxHelpDesk.Tickets.FirstOrDefault(t => 
            t.TicketID == 1);
            var libelleprio = t1.Priorite.Libelle;
            // jointures manuelles - Join()
            



        }
    }
}
