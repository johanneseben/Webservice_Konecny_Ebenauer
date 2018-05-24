using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Foerderkurs_Schueler
    {
        public virtual int FSID { get; set; }
        public virtual Schueler Schueler { get; set; }
        public virtual Foerderkurs Foerderkurs { get; set; }


        public Foerderkurs_Schueler()
        {

        }
    }
}
