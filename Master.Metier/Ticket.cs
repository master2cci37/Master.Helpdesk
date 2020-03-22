using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Metier
{
   public  class Ticket
    {
        [Key] // cle primaire
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketID { get; set; }
        [StringLength(255)]
        public string Resume { get; set; }
        // nullable 
        public Nullable<DateTime> DateCloture { get; set; }
        public DateTime DateCreation{ get; set; }
        public DateTime DateModification { get; set; }
        public bool EstActif { get; set; }
        public int PrioriteID { get; set; }

        [ForeignKey("PrioriteID")]
        public virtual Priorite Priorite { get; set; }
        public ICollection<Historique> Historiques { get; set; } = new List<Historique>();


    }
    public class Historique
    {
        public int HistoriqueID { get; set; }
        public int TicketID { get; set; }
    }
    public class Priorite
    {
        public int PrioriteID { get; set; }
        public string Libelle { get; set; }
    }
}
