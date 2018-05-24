using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Schueler
    {
        public virtual int SID { get; set; }
        public virtual string Vorname { get; set; }
        public virtual string Nachname { get; set; }
        [JsonIgnore]
        public virtual ICollection<Foerderkurs_Schueler> Foerderkurs_Schueler { get; set; }

        public Schueler()
        {
            this.Foerderkurs_Schueler = new HashSet<foerderkurs_Schueler>();
        }
    }
}