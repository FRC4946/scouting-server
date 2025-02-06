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
        [ScoutingProperty(0, "GroundIntake")]
        public string TeamNumber { get; set; }

        [ScoutingProperty(1, "Drivetrain")]
        public string AllianceColour { get; set; }

        [ScoutingProperty(2, "Weight")]
        public string MatchNumber { get; set; }

        [ScoutingProperty(3, "Height")]
        public string ScoutName { get; set; }

        [ScoutingProperty(4, "ExtraNotes")]
        public string disabled { get; set; }

        [ScoutingProperty(5, "TeamNumber")]
        public string autoL1 { get; set; }

        [ScoutingProperty(6, "Algae")]
        public string autoL2 { get; set; }

        [ScoutingProperty(7, "Coral")]
        public string autoL3 { get; set; }
    }
}