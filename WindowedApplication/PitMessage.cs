using BluetoothLibrary.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowedApplication
{
    /// <summary>
    /// Pit Scouting message used in 2024
    /// </summary>
    public class PitMessage : ScoutingMessageBase
    {
        [ScoutingProperty(0, "GroundIntake")]
        public string ground { get; set; }

        [ScoutingProperty(1, "Swerve")]
        public string swerve { get; set; }

        [ScoutingProperty(2, "Turret")]
        public string turret { get; set; }

        [ScoutingProperty(3, "Weight")]
        public string weight { get; set; }

        [ScoutingProperty(4, "Length")]
        public string length { get; set; }

        [ScoutingProperty(5, "Width")]
        public string width { get; set; }

        [ScoutingProperty(6, "Balls")]
        public string balls { get; set; }

        [ScoutingProperty(7, "ExtraNotes")]
        public string extraNotesInput { get; set; }

        [ScoutingProperty(8, "TeamNumber")]
        public string teamNumberInput { get; set; }

        [ScoutingProperty(9, "bump")]
        public string bump { get; set; }

        [ScoutingProperty(10, "trench")]
        public string trench { get; set; }

        [ScoutingProperty(11, "climb")]
        public string climb { get; set; }

    }
}