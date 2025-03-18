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

        [ScoutingProperty(1, "Drivetrain")]
        public string drivetrain { get; set; }

        [ScoutingProperty(2, "Weight")]
        public string weight { get; set; }

        [ScoutingProperty(3, "Height")]
        public string height { get; set; }

        [ScoutingProperty(4, "ExtraNotes")]
        public string notes { get; set; }

        [ScoutingProperty(5, "TeamNumber")]
        public string teamnum { get; set; }

        [ScoutingProperty(6, "Algae")]
        public string algae { get; set; }

        [ScoutingProperty(7, "Coral")]
        public string coral { get; set; }

        [ScoutingProperty(7, "Climbable")]
        public string climb { get; set; }
    }
}