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
    public class MainMessage : ScoutingMessageBase
    {
        [ScoutingProperty(0, "teamNumber")]
        public string TeamNumber { get; set; }

        [ScoutingProperty(1, "allianceColor")]
        public string AllianceColour { get; set; }

        [ScoutingProperty(2, "matchNumber")] 
        public string MatchNumber { get; set; }

        [ScoutingProperty(3, "scoutName")]
        public string ScoutName { get; set; }

        [ScoutingProperty(4, "Shoot %")]
        public string disabled { get; set; }

        [ScoutingProperty(5, "Pass %")]
        public string autoL1 { get; set; }

        [ScoutingProperty(6, "Defend %")]
        public string autoL2 { get; set; }

        [ScoutingProperty(7, "Collect %")]
        public string autoL3 { get; set; }

        [ScoutingProperty(8, "Disabled %")]
        public string autoL4 { get; set; }

        [ScoutingProperty(9, "Climb %")]
        public string autoProcessor { get; set; }

        [ScoutingProperty(10, "notes")]
        public string notes { get; set; }

    }
}
