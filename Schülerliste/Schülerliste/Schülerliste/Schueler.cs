using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful_Secure_Auftrag_Test.Models
{
    public class Schueler
    {
        public virtual int SID { get; set; }
        public virtual string Vorname { get; set; }
        public virtual string Nachname { get; set; }

        public virtual ICollection<FoerderkursSchueler> FoerderkursSchueler { get; set; }

        public Schueler()
        {
            this.FoerderkursSchueler = new HashSet<FoerderkursSchueler>();
        }
    }
}