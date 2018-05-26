using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Mapping
{
    public class SchuelerMap : ClassMap<Schueler>
    {
        public SchuelerMap() //erstellen einer Tabelle
        {
            Id(x => x.SID).GeneratedBy.HiLo("10");
            Map(x => x.Vorname).Not.Nullable();
            Map(x => x.Nachname).Not.Nullable();
            HasMany(x => x.Foerderkurs_Schueler).KeyColumn("SID").Cascade.All().Inverse();
           
        }
    }
}
