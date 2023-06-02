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
    public partial class PlayerHeroesPerformanceMatchesRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _matchIds;
        private InputPropertyInfo _leagueId;
        private InputPropertyInfo _seriesId;
        private InputPropertyInfo _teamId;
        private InputPropertyInfo _isParsed;
        private InputPropertyInfo _isLeague;
        private InputPropertyInfo _isTeam;
        private InputPropertyInfo _minDuration;
        private InputPropertyInfo _maxDuration;
        private InputPropertyInfo _startDateTime;
        private InputPropertyInfo _endDateTime;
        private InputPropertyInfo _gameModeIds;
        private InputPropertyInfo _lobbyTypeIds;
        private InputPropertyInfo _gameVersionIds;
        private InputPropertyInfo _minGameVersionId;
        private InputPropertyInfo _maxGameVersionId;
        private InputPropertyInfo _regionIds;
        private InputPropertyInfo _rankIds;
        private InputPropertyInfo _isStats;
        private InputPropertyInfo _heroIds;
        private InputPropertyInfo _laneIds;
        private InputPropertyInfo _roleIds;
        private InputPropertyInfo _positionIds;
        private InputPropertyInfo _awardIds;
        private InputPropertyInfo _isParty;
        private InputPropertyInfo _isRadiant;
        private InputPropertyInfo _partyCounts;
        private InputPropertyInfo _hasAward;
        private InputPropertyInfo _withFriendSteamAccountIds;
        private InputPropertyInfo _withEnemySteamAccountIds;
        private InputPropertyInfo _withFriendHeroIds;
        private InputPropertyInfo _withEnemyHeroIds;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> MatchIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_matchIds.Value; }
            set { _matchIds = new InputPropertyInfo { Name = "matchIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> LeagueId
        {
            get { return (QueryBuilderParameter<int?>)_leagueId.Value; }
            set { _leagueId = new InputPropertyInfo { Name = "leagueId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> SeriesId
        {
            get { return (QueryBuilderParameter<long?>)_seriesId.Value; }
            set { _seriesId = new InputPropertyInfo { Name = "seriesId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> TeamId
        {
            get { return (QueryBuilderParameter<int?>)_teamId.Value; }
            set { _teamId = new InputPropertyInfo { Name = "teamId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsParsed
        {
            get { return (QueryBuilderParameter<bool?>)_isParsed.Value; }
            set { _isParsed = new InputPropertyInfo { Name = "isParsed", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsLeague
        {
            get { return (QueryBuilderParameter<bool?>)_isLeague.Value; }
            set { _isLeague = new InputPropertyInfo { Name = "isLeague", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsTeam
        {
            get { return (QueryBuilderParameter<bool?>)_isTeam.Value; }
            set { _isTeam = new InputPropertyInfo { Name = "isTeam", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MinDuration
        {
            get { return (QueryBuilderParameter<int?>)_minDuration.Value; }
            set { _minDuration = new InputPropertyInfo { Name = "minDuration", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MaxDuration
        {
            get { return (QueryBuilderParameter<int?>)_maxDuration.Value; }
            set { _maxDuration = new InputPropertyInfo { Name = "maxDuration", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> StartDateTime
        {
            get { return (QueryBuilderParameter<long?>)_startDateTime.Value; }
            set { _startDateTime = new InputPropertyInfo { Name = "startDateTime", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> EndDateTime
        {
            get { return (QueryBuilderParameter<long?>)_endDateTime.Value; }
            set { _endDateTime = new InputPropertyInfo { Name = "endDateTime", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> GameModeIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_gameModeIds.Value; }
            set { _gameModeIds = new InputPropertyInfo { Name = "gameModeIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> LobbyTypeIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_lobbyTypeIds.Value; }
            set { _lobbyTypeIds = new InputPropertyInfo { Name = "lobbyTypeIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> GameVersionIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_gameVersionIds.Value; }
            set { _gameVersionIds = new InputPropertyInfo { Name = "gameVersionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MinGameVersionId
        {
            get { return (QueryBuilderParameter<int?>)_minGameVersionId.Value; }
            set { _minGameVersionId = new InputPropertyInfo { Name = "minGameVersionId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MaxGameVersionId
        {
            get { return (QueryBuilderParameter<int?>)_maxGameVersionId.Value; }
            set { _maxGameVersionId = new InputPropertyInfo { Name = "maxGameVersionId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> RegionIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_regionIds.Value; }
            set { _regionIds = new InputPropertyInfo { Name = "regionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> RankIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_rankIds.Value; }
            set { _rankIds = new InputPropertyInfo { Name = "rankIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsStats
        {
            get { return (QueryBuilderParameter<bool?>)_isStats.Value; }
            set { _isStats = new InputPropertyInfo { Name = "isStats", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> HeroIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_heroIds.Value; }
            set { _heroIds = new InputPropertyInfo { Name = "heroIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> LaneIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_laneIds.Value; }
            set { _laneIds = new InputPropertyInfo { Name = "laneIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> RoleIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_roleIds.Value; }
            set { _roleIds = new InputPropertyInfo { Name = "roleIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<MatchPlayerPositionType>>))]
        #endif
        public QueryBuilderParameter<IList<MatchPlayerPositionType>> PositionIds
        {
            get { return (QueryBuilderParameter<IList<MatchPlayerPositionType>>)_positionIds.Value; }
            set { _positionIds = new InputPropertyInfo { Name = "positionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> AwardIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_awardIds.Value; }
            set { _awardIds = new InputPropertyInfo { Name = "awardIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsParty
        {
            get { return (QueryBuilderParameter<bool?>)_isParty.Value; }
            set { _isParty = new InputPropertyInfo { Name = "isParty", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsRadiant
        {
            get { return (QueryBuilderParameter<bool?>)_isRadiant.Value; }
            set { _isRadiant = new InputPropertyInfo { Name = "isRadiant", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> PartyCounts
        {
            get { return (QueryBuilderParameter<IList<int>>)_partyCounts.Value; }
            set { _partyCounts = new InputPropertyInfo { Name = "partyCounts", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> HasAward
        {
            get { return (QueryBuilderParameter<bool?>)_hasAward.Value; }
            set { _hasAward = new InputPropertyInfo { Name = "hasAward", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> WithFriendSteamAccountIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_withFriendSteamAccountIds.Value; }
            set { _withFriendSteamAccountIds = new InputPropertyInfo { Name = "withFriendSteamAccountIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> WithEnemySteamAccountIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_withEnemySteamAccountIds.Value; }
            set { _withEnemySteamAccountIds = new InputPropertyInfo { Name = "withEnemySteamAccountIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> WithFriendHeroIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_withFriendHeroIds.Value; }
            set { _withFriendHeroIds = new InputPropertyInfo { Name = "withFriendHeroIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<int>>))]
        #endif
        public QueryBuilderParameter<IList<int>> WithEnemyHeroIds
        {
            get { return (QueryBuilderParameter<IList<int>>)_withEnemyHeroIds.Value; }
            set { _withEnemyHeroIds = new InputPropertyInfo { Name = "withEnemyHeroIds", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_matchIds.Name != null) yield return _matchIds;
            if (_leagueId.Name != null) yield return _leagueId;
            if (_seriesId.Name != null) yield return _seriesId;
            if (_teamId.Name != null) yield return _teamId;
            if (_isParsed.Name != null) yield return _isParsed;
            if (_isLeague.Name != null) yield return _isLeague;
            if (_isTeam.Name != null) yield return _isTeam;
            if (_minDuration.Name != null) yield return _minDuration;
            if (_maxDuration.Name != null) yield return _maxDuration;
            if (_startDateTime.Name != null) yield return _startDateTime;
            if (_endDateTime.Name != null) yield return _endDateTime;
            if (_gameModeIds.Name != null) yield return _gameModeIds;
            if (_lobbyTypeIds.Name != null) yield return _lobbyTypeIds;
            if (_gameVersionIds.Name != null) yield return _gameVersionIds;
            if (_minGameVersionId.Name != null) yield return _minGameVersionId;
            if (_maxGameVersionId.Name != null) yield return _maxGameVersionId;
            if (_regionIds.Name != null) yield return _regionIds;
            if (_rankIds.Name != null) yield return _rankIds;
            if (_isStats.Name != null) yield return _isStats;
            if (_heroIds.Name != null) yield return _heroIds;
            if (_laneIds.Name != null) yield return _laneIds;
            if (_roleIds.Name != null) yield return _roleIds;
            if (_positionIds.Name != null) yield return _positionIds;
            if (_awardIds.Name != null) yield return _awardIds;
            if (_isParty.Name != null) yield return _isParty;
            if (_isRadiant.Name != null) yield return _isRadiant;
            if (_partyCounts.Name != null) yield return _partyCounts;
            if (_hasAward.Name != null) yield return _hasAward;
            if (_withFriendSteamAccountIds.Name != null) yield return _withFriendSteamAccountIds;
            if (_withEnemySteamAccountIds.Name != null) yield return _withEnemySteamAccountIds;
            if (_withFriendHeroIds.Name != null) yield return _withFriendHeroIds;
            if (_withEnemyHeroIds.Name != null) yield return _withEnemyHeroIds;
        }
    }
}
