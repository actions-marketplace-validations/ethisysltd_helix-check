﻿using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;
using Helixbase.Foundation.ORM.Models;

namespace Helixbase.Feature.Hero.Models
{
    public interface IHero : ISitecoreItem
    {
        string HeroTitle { get; set; }
        IEnumerable<Image> HeroImages { get; set; }
    }
}