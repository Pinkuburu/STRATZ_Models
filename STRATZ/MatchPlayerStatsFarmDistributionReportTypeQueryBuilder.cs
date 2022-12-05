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
    public partial class MatchPlayerStatsFarmDistributionReportTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerStatsFarmDistributionReportTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "creepType", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "creepLocation", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "neutralLocation", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "ancientLocation", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "buildings", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "buyBackGold" },
                new FieldMetadata { Name = "abandonGold" },
                new FieldMetadata { Name = "bountyGold", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "other", IsComplex = true, QueryBuilderType = typeof(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchPlayerStatsFarmDistributionReportType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithCreepType(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("creepType", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptCreepType()
        {
            return ExceptField("creepType");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithCreepLocation(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("creepLocation", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptCreepLocation()
        {
            return ExceptField("creepLocation");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithNeutralLocation(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("neutralLocation", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptNeutralLocation()
        {
            return ExceptField("neutralLocation");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithAncientLocation(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("ancientLocation", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptAncientLocation()
        {
            return ExceptField("ancientLocation");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithBuildings(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("buildings", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptBuildings()
        {
            return ExceptField("buildings");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithBuyBackGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("buyBackGold", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptBuyBackGold()
        {
            return ExceptField("buyBackGold");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithAbandonGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("abandonGold", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptAbandonGold()
        {
            return ExceptField("abandonGold");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithBountyGold(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("bountyGold", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptBountyGold()
        {
            return ExceptField("bountyGold");
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder WithOther(MatchPlayerStatsFarmDistributionObjectTypeQueryBuilder matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("other", alias, matchPlayerStatsFarmDistributionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsFarmDistributionReportTypeQueryBuilder ExceptOther()
        {
            return ExceptField("other");
        }
    }
}
