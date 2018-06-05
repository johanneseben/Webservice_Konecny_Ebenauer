using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schülerliste.Models
{
    public class Klasse
    {
        public virtual int KID { get; set; }
        public virtual string Klassenname { get; set; }

        public virtual ICollection<Klasse> Klassen { get; set; }

        public Klasse()
        {
            this.Klassen = new HashSet<Klasse>();
        }
    }
}
