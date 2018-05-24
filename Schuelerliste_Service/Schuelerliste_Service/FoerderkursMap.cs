using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Mapping
{
    public class FoerderkursMap : ClassMap<Foerderkurs>
    {
        public FoerderkursMap()
        {
            Id(x => x.FID).GeneratedBy.HiLo("10");
            Map(x => x.Foerderkurs).Not.Nullable();
            References(x => x.Klasse).Column("KID").Not.Nullable().Not.LazyLoad();
            HasMany(x => x.Foerderkurs_Schueler).KeyColumn("FID").Cascade.All().Inverse();
        }
    }
}
