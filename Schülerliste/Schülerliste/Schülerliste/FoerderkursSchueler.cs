using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful_Secure_Auftrag_Test.Models
{
    public class FoerderkursSchueler
    {
        public virtual int FSID { get; set; }
        public virtual Foerderkurs Foerderkurs { get; set; }
        public virtual Schueler Schueler { get; set; }

        public FoerderkursSchueler()
        {

        }
    }
}