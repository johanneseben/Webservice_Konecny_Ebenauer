using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Foerderkurs
    {
        public virtual int FoerderkursID { get; set; }
        public virtual Foerderkurs Foerderkurs { get; set; }

        [JsonIgnore]
        public virtual ICollection<Foerderkurs_Schueler> Foerderkurs_Schueler { get; set; }

        public Foerderkurs()
        {
            this.Foerderkurs_Schueler = new HashSet<Foerderkurs_Schueler>();
        }
    }
}
