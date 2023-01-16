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
    public partial class MatchReplayUploadTeamTypeQueryBuilder : GraphQlQueryBuilder<MatchReplayUploadTeamTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "name" },
                new FieldMetadata { Name = "email" },
                new FieldMetadata { Name = "teamId" },
                new FieldMetadata { Name = "creatorCaptainJackIdentityId", IsComplex = true },
                new FieldMetadata { Name = "team", IsComplex = true, QueryBuilderType = typeof(TeamTypeQueryBuilder) },
                new FieldMetadata { Name = "members", IsComplex = true, QueryBuilderType = typeof(MatchReplayUploadTeamMemberTypeQueryBuilder) },
                new FieldMetadata { Name = "isDefault" }
            };

        protected override string TypeName { get { return "MatchReplayUploadTeamType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchReplayUploadTeamTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithEmail(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("email", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptEmail()
        {
            return ExceptField("email");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithTeamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptTeamId()
        {
            return ExceptField("teamId");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithCreatorCaptainJackIdentityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("creatorCaptainJackIdentityId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptCreatorCaptainJackIdentityId()
        {
            return ExceptField("creatorCaptainJackIdentityId");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithTeam(TeamTypeQueryBuilder teamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("team", alias, teamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptTeam()
        {
            return ExceptField("team");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithMembers(MatchReplayUploadTeamMemberTypeQueryBuilder matchReplayUploadTeamMemberTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("members", alias, matchReplayUploadTeamMemberTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptMembers()
        {
            return ExceptField("members");
        }

        public MatchReplayUploadTeamTypeQueryBuilder WithIsDefault(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isDefault", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadTeamTypeQueryBuilder ExceptIsDefault()
        {
            return ExceptField("isDefault");
        }
    }
}
