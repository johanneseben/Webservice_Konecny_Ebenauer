using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Mapping
{
    public class KlasseMap : ClassMap<Klasse>
    {
        public KlasseMap()
        {
            Id(x => x.KID).GeneratedBy.HiLo("10");
            Map(x => x.Klasse).Not.Nullable();
           
            HasMany(x => x.Klassen).KeyColumn("KID").Cascade.All().Inverse();
        }
    }
}

