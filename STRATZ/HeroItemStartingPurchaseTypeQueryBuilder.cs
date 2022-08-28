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
    public partial class HeroItemStartingPurchaseTypeQueryBuilder : GraphQlQueryBuilder<HeroItemStartingPurchaseTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId" },
                new FieldMetadata { Name = "week" },
                new FieldMetadata { Name = "bracketBasicIds" },
                new FieldMetadata { Name = "position" },
                new FieldMetadata { Name = "events", IsComplex = true, QueryBuilderType = typeof(HeroItemStartingPurchaseObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "count", IsComplex = true }
            };

        protected override string TypeName { get { return "HeroItemStartingPurchaseType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroItemStartingPurchaseTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroItemStartingPurchaseTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroItemStartingPurchaseTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HeroItemStartingPurchaseTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public HeroItemStartingPurchaseTypeQueryBuilder WithEvents(HeroItemStartingPurchaseObjectTypeQueryBuilder heroItemStartingPurchaseObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("events", alias, heroItemStartingPurchaseObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseTypeQueryBuilder ExceptEvents()
        {
            return ExceptField("events");
        }

        public HeroItemStartingPurchaseTypeQueryBuilder WithCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("count", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseTypeQueryBuilder ExceptCount()
        {
            return ExceptField("count");
        }
    }
}
