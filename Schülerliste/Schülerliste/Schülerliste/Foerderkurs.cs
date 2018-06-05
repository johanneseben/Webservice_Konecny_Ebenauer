using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schülerliste.Models
{
    public class Foerderkurs
    {
        public virtual int FID { get; set; }
        public virtual string FoerderkursName { get; set; }

        public virtual ICollection<FoerderkursSchueler> FoerderkursSchueler { get; set; }

        public Foederkurs()
        {
            this.FoederkursSchueler = new HashSet<FoerderkursSchueler>();
        }
    }
}
