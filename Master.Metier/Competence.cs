using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Master.Metier
{
    public class Competence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//  Identity / None 
        public int CompetenceID { get; set; }

    }
}