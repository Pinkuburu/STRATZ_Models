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
    public partial class MatchPlaybackDataWardEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlaybackDataWardEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "indexId" },
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "positionX" },
                new FieldMetadata { Name = "positionY" },
                new FieldMetadata { Name = "fromPlayer" },
                new FieldMetadata { Name = "wardType" },
                new FieldMetadata { Name = "action" },
                new FieldMetadata { Name = "playerDestroyed" }
            };

        protected override string TypeName { get { return "MatchPlaybackDataWardEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlaybackDataWardEventTypeQueryBuilder WithIndexId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("indexId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptIndexId()
        {
            return ExceptField("indexId");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithFromPlayer(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fromPlayer", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptFromPlayer()
        {
            return ExceptField("fromPlayer");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithWardType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wardType", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptWardType()
        {
            return ExceptField("wardType");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithAction(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("action", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptAction()
        {
            return ExceptField("action");
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder WithPlayerDestroyed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("playerDestroyed", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataWardEventTypeQueryBuilder ExceptPlayerDestroyed()
        {
            return ExceptField("playerDestroyed");
        }
    }
}
