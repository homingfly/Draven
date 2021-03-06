﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerLifetimeStats")]
    class PlayerLifetimeStats
    {
        [SerializedName("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }
        [SerializedName("previousFirstWinOfDay")]
        public DateTime PreviousFirstWinOfDay { get; set; }
        [SerializedName("userId")]
        public Int64 UserId { get; set; }
        [SerializedName("dodgeStreak")]
        public Int32 DodgeStreak { get; set; }
        [SerializedName("dodgePenaltyDate")]
        public object DodgePenaltyDate { get; set; }
        [SerializedName("playerStatsJson")]
        public object PlayerStatsJson { get; set; }
        [SerializedName("playerStats")]
        public PlayerStats PlayerStats { get; set; }
    }
}
