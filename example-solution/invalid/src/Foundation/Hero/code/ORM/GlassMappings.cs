using Glass.Mapper.Sc.Maps;
using Helixbase.Feature.Hero.Models;

namespace Helixbase.Feature.Hero.ORM
{
    public class GlassMappings : SitecoreGlassMap<IHero>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.Hero.TemplateId);
                config.Field(f => f.HeroTitle).FieldName("Hero Title");
                config.Field(f => f.HeroImages).FieldName("Hero Images");
            });
        }
    }
}