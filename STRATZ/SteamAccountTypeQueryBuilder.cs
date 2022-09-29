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
    public partial class SteamAccountTypeQueryBuilder : GraphQlQueryBuilder<SteamAccountTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "profileUri" },
                new FieldMetadata { Name = "realName" },
                new FieldMetadata { Name = "timeCreated", IsComplex = true },
                new FieldMetadata { Name = "countryCode" },
                new FieldMetadata { Name = "stateCode" },
                new FieldMetadata { Name = "cityId" },
                new FieldMetadata { Name = "communityVisibleState" },
                new FieldMetadata { Name = "name" },
                new FieldMetadata { Name = "lastLogOff", IsComplex = true },
                new FieldMetadata { Name = "avatar" },
                new FieldMetadata { Name = "primaryClanId", IsComplex = true },
                new FieldMetadata { Name = "isDotaPlusSubscriber" },
                new FieldMetadata { Name = "dotaAccountLevel", IsComplex = true },
                new FieldMetadata { Name = "rankShift", IsComplex = true },
                new FieldMetadata { Name = "isAnonymous" },
                new FieldMetadata { Name = "isStratzAnonymous" },
                new FieldMetadata { Name = "seasonRank", IsComplex = true },
                new FieldMetadata { Name = "seasonLeaderboardRank", IsComplex = true },
                new FieldMetadata { Name = "seasonLeaderboardDivisionId", IsComplex = true },
                new FieldMetadata { Name = "proSteamAccount", IsComplex = true, QueryBuilderType = typeof(ProSteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "smurfFlag", IsComplex = true },
                new FieldMetadata { Name = "lastMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "lastMatchRegionId", IsComplex = true },
                new FieldMetadata { Name = "battlepass", IsComplex = true, QueryBuilderType = typeof(SteamAccountBattlePassTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "SteamAccountType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamAccountTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public SteamAccountTypeQueryBuilder WithProfileUri(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("profileUri", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptProfileUri()
        {
            return ExceptField("profileUri");
        }

        public SteamAccountTypeQueryBuilder WithRealName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("realName", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptRealName()
        {
            return ExceptField("realName");
        }

        public SteamAccountTypeQueryBuilder WithTimeCreated(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("timeCreated", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptTimeCreated()
        {
            return ExceptField("timeCreated");
        }

        public SteamAccountTypeQueryBuilder WithCountryCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("countryCode", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptCountryCode()
        {
            return ExceptField("countryCode");
        }

        public SteamAccountTypeQueryBuilder WithStateCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stateCode", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptStateCode()
        {
            return ExceptField("stateCode");
        }

        public SteamAccountTypeQueryBuilder WithCityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cityId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptCityId()
        {
            return ExceptField("cityId");
        }

        public SteamAccountTypeQueryBuilder WithCommunityVisibleState(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("communityVisibleState", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptCommunityVisibleState()
        {
            return ExceptField("communityVisibleState");
        }

        public SteamAccountTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public SteamAccountTypeQueryBuilder WithLastLogOff(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastLogOff", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptLastLogOff()
        {
            return ExceptField("lastLogOff");
        }

        public SteamAccountTypeQueryBuilder WithAvatar(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avatar", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptAvatar()
        {
            return ExceptField("avatar");
        }

        public SteamAccountTypeQueryBuilder WithPrimaryClanId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("primaryClanId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptPrimaryClanId()
        {
            return ExceptField("primaryClanId");
        }

        public SteamAccountTypeQueryBuilder WithIsDotaPlusSubscriber(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isDotaPlusSubscriber", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptIsDotaPlusSubscriber()
        {
            return ExceptField("isDotaPlusSubscriber");
        }

        public SteamAccountTypeQueryBuilder WithDotaAccountLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dotaAccountLevel", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptDotaAccountLevel()
        {
            return ExceptField("dotaAccountLevel");
        }

        public SteamAccountTypeQueryBuilder WithRankShift(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rankShift", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptRankShift()
        {
            return ExceptField("rankShift");
        }

        public SteamAccountTypeQueryBuilder WithIsAnonymous(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isAnonymous", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptIsAnonymous()
        {
            return ExceptField("isAnonymous");
        }

        public SteamAccountTypeQueryBuilder WithIsStratzAnonymous(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isStratzAnonymous", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptIsStratzAnonymous()
        {
            return ExceptField("isStratzAnonymous");
        }

        public SteamAccountTypeQueryBuilder WithSeasonRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seasonRank", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptSeasonRank()
        {
            return ExceptField("seasonRank");
        }

        public SteamAccountTypeQueryBuilder WithSeasonLeaderboardRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seasonLeaderboardRank", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptSeasonLeaderboardRank()
        {
            return ExceptField("seasonLeaderboardRank");
        }

        public SteamAccountTypeQueryBuilder WithSeasonLeaderboardDivisionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seasonLeaderboardDivisionId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptSeasonLeaderboardDivisionId()
        {
            return ExceptField("seasonLeaderboardDivisionId");
        }

        public SteamAccountTypeQueryBuilder WithProSteamAccount(ProSteamAccountTypeQueryBuilder proSteamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("proSteamAccount", alias, proSteamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptProSteamAccount()
        {
            return ExceptField("proSteamAccount");
        }

        public SteamAccountTypeQueryBuilder WithSmurfFlag(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("smurfFlag", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptSmurfFlag()
        {
            return ExceptField("smurfFlag");
        }

        public SteamAccountTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public SteamAccountTypeQueryBuilder WithLastMatchRegionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchRegionId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptLastMatchRegionId()
        {
            return ExceptField("lastMatchRegionId");
        }

        public SteamAccountTypeQueryBuilder WithBattlepass(SteamAccountBattlePassTypeQueryBuilder steamAccountBattlePassTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("battlepass", alias, steamAccountBattlePassTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTypeQueryBuilder ExceptBattlepass()
        {
            return ExceptField("battlepass");
        }
    }
}
