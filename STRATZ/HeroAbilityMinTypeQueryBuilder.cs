// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class HeroAbilityMinTypeQueryBuilder : GraphQlQueryBuilder<HeroAbilityMinTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId" },
                new FieldMetadata { Name = "week" },
                new FieldMetadata { Name = "bracketBasicIds" },
                new FieldMetadata { Name = "position" },
                new FieldMetadata { Name = "abilityId" },
                new FieldMetadata { Name = "level" },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" }
            };

        protected override string TypeName { get { return "HeroAbilityMinType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroAbilityMinTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroAbilityMinTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroAbilityMinTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HeroAbilityMinTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public HeroAbilityMinTypeQueryBuilder WithAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("abilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptAbilityId()
        {
            return ExceptField("abilityId");
        }

        public HeroAbilityMinTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }

        public HeroAbilityMinTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public HeroAbilityMinTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityMinTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }
    }
}
