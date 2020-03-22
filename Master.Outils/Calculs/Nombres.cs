using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Outils.Calculs
{
   public static class Nombres
    {
        public static void Test()
        {
            // inference de type
            var r = 12 / 0.5m;
            var o = new { ID = 1, Nom = "Boss" };
            Console.WriteLine(o.Nom );
        }

    }
}
