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
    public partial class MatchGroupByIsLeagueType
    {
        public bool? IsLeague { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? AvgImp { get; set; }
        public int? AvgGoldPerMinute { get; set; }
        public int? AvgExperiencePerMinute { get; set; }
        public decimal? AvgKda { get; set; }
        public decimal? AvgKills { get; set; }
        public decimal? AvgDeaths { get; set; }
        public decimal? AvgAssists { get; set; }
        public long? LastMatchDateTime { get; set; }
        public long? FirstMatchDateTime { get; set; }
    }
}
