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
    public partial class HeroRampageObjectTypeQueryBuilder : GraphQlQueryBuilder<HeroRampageObjectTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "matchId", IsComplex = true },
                new FieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "heroIds", IsComplex = true },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "HeroRampageObjectType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroRampageObjectTypeQueryBuilder WithMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroRampageObjectTypeQueryBuilder ExceptMatchId()
        {
            return ExceptField("matchId");
        }

        public HeroRampageObjectTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroRampageObjectTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public HeroRampageObjectTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroRampageObjectTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public HeroRampageObjectTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroRampageObjectTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public HeroRampageObjectTypeQueryBuilder WithHeroIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroRampageObjectTypeQueryBuilder ExceptHeroIds()
        {
            return ExceptField("heroIds");
        }

        public HeroRampageObjectTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroRampageObjectTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }
    }
}
