using BluetoothLibrary.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowedApplication
{
    /// <summary>
    /// Scouting message used in 2024
    /// </summary>
    public class Message2022 : ScoutingMessageBase
    {
        [ScoutingProperty(0, "teamNumber")]
        public string TeamNumber { get; set; }

        [ScoutingProperty(1, "allianceColor")]
        public string AllianceColour { get; set; }

        [ScoutingProperty(2, "matchNumber")]
        public string MatchNumber { get; set; }

        [ScoutingProperty(3, "scoutName")]
        public string ScoutName { get; set; }

        [ScoutingProperty(4, "disabled")]
        public string disabled { get; set; }

        [ScoutingProperty(5, "autoL1")]
        public string autoL1 { get; set; }

        [ScoutingProperty(6, "autoL2")]
        public string autoL2 { get; set; }

        [ScoutingProperty(7, "autoL3")]
        public string autoL3 { get; set; }

        [ScoutingProperty(8, "autoL4")]
        public string autoL4 { get; set; }

        [ScoutingProperty(9, "autoProcessor")]
        public string autoProcessor { get; set; }

        [ScoutingProperty(10, "autoNet")]
        public string autoNet { get; set; }

        [ScoutingProperty(11, "teleopL1")]
        public string teleopL1 { get; set; }

        [ScoutingProperty(12, "teleopL2")]
        public string teleopL2 { get; set; }

        [ScoutingProperty(13, "teleopL3")]
        public string teleopL3 { get; set; }

        [ScoutingProperty(14, "teleopL4")]
        public string teleopL4 { get; set; }

        [ScoutingProperty(15, "teleopProcessor")]
        public string teleopProcessor { get; set; }

        [ScoutingProperty(16, "teleopNet")]
        public string teleopNet { get; set; }

        [ScoutingProperty(17, "defensePercent")]
        public string defensePercent { get; set; }

        [ScoutingProperty(18, "climbSpeed")]
        public string climbSpeed { get; set; }

        [ScoutingProperty(19, "notes")]
        public string notes { get; set; }

    }
}
