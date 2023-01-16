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
    public partial class MatchGroupByDurationMinutesTypeQueryBuilder : GraphQlQueryBuilder<MatchGroupByDurationMinutesTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "durationMinutes", IsComplex = true },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "avgImp" },
                new FieldMetadata { Name = "avgGoldPerMinute" },
                new FieldMetadata { Name = "avgExperiencePerMinute" },
                new FieldMetadata { Name = "avgKDA" },
                new FieldMetadata { Name = "avgKills" },
                new FieldMetadata { Name = "avgDeaths" },
                new FieldMetadata { Name = "avgAssists" },
                new FieldMetadata { Name = "lastMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "firstMatchDateTime", IsComplex = true }
            };

        protected override string TypeName { get { return "MatchGroupByDurationMinutesType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchGroupByDurationMinutesTypeQueryBuilder WithDurationMinutes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationMinutes", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptDurationMinutes()
        {
            return ExceptField("durationMinutes");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgGoldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgGoldPerMinute()
        {
            return ExceptField("avgGoldPerMinute");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgExperiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgExperiencePerMinute()
        {
            return ExceptField("avgExperiencePerMinute");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgKda(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKDA", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgKda()
        {
            return ExceptField("avgKDA");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgKills()
        {
            return ExceptField("avgKills");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgDeaths()
        {
            return ExceptField("avgDeaths");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgAssists()
        {
            return ExceptField("avgAssists");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }
    }
}
