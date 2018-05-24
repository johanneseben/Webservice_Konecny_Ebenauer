using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Mapping
{
    public class Foerderkurs_SchuelerMap : ClassMap<Foerderkurs_Schueler>
    {
        public Foerderkurs_SchuelerMap()
        {
            Id(x => x.FSID).GeneratedBy.HiLo("10");
            References(x => x.Foerderkurs).Column("FID").Not.Nullable().Not.LazyLoad();
            References(x => x.Schueler).Column("SID").Not.Nullable().Not.LazyLoad();
        }
    }
}