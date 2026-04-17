using BluetoothLibrary.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowedApplication
{
    /// <summary>
    /// Scouting message used in 2026
    /// </summary>
    public class MainMessage : ScoutingMessageBase
    {
        [ScoutingProperty(0, "matchNumber")] //LEAVE NAME ALONE
        public string TeamNumber { get; set; }

        [ScoutingProperty(1, "scoutName")]
        public string AllianceColour { get; set; }

        [ScoutingProperty(2, "teamNumA")]
        public string TeamNumberA { get; set; }

        [ScoutingProperty(3, "teamNumB")]
        public string TeamNumberB { get; set; }

        [ScoutingProperty(4, "offenceA")]
        public string OffenceA { get; set; }

        [ScoutingProperty(5, "offenceB")]
        public string OffenceB { get; set; }

        [ScoutingProperty(6, "defenceA")]
        public string DefenceA { get; set; }

        [ScoutingProperty(7, "defenceB")]
        public string DefenceB { get; set; }

        [ScoutingProperty(8, "driverA")]
        public string DriverA { get; set; }

        [ScoutingProperty(9, "driverB")]
        public string DriverB { get; set; }

        [ScoutingProperty(10, "notesA")]
        public string NotesA { get; set; }

        [ScoutingProperty(11, "notesB")]
        public string NotesB { get; set; }
    }
}
