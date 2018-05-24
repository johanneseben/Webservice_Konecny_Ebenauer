using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Klasse
    {
        public virtual int KID { get; set; }
        public virtual string Klasse { get; set; }
        [JsonIgnore]
        public virtual ICollection<Klasse> Klasse { get; set; }

        public Klasse()
        {
            this.Klasse = new HashSet<Klasse>();
        }
    }
}