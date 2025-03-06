using BluetoothLibrary;
using BluetoothLibrary.Log;
using BluetoothLibrary.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowedApplication
{
    public class CSVManager : InstanceManagerBase
    {
        public uint ErrorMax { get; set; } = 30;
        public static bool MainMess = true;
        private string _DesiredName;

        public dynamic CurrentLog { get => _Log; }

        private List<string> _Errors = new List<string>();

        private readonly object ERROR_LOCK = new object();

        private dynamic _Log;

        public int ErrorCount { get => _Errors.Count; }

        public CSVManager(string path)
        {
            if (MainMess)
            {
                _Log = new CSVScoutingLog<MainMessage>(path);
            }
            else
            {
                _Log = new CSVScoutingLog<PitMessage>(path);
            }

            var sep = ".";
            var index = path.LastIndexOf(sep);
            _DesiredName = index > -1 ? path.Substring(0, index) : path;
        }

        private void _RaiseError(string text)
        {
            lock (ERROR_LOCK)
            {
                text = $"{DateTime.Now:HH:mm} - {text}";
                _Errors.Insert(0, text);
                if (_Errors.Count > ErrorMax)
                    _Errors.RemoveAt(_Errors.Count - 1);
            }
        }

        public string GetErrorAt(int i)
        {
            lock (ERROR_LOCK)
            {
                return (i >= 0 && i < _Errors.Count) ? _Errors[i] : null;
            }
        }

        protected override void ConfigureInstance(BluetoothInstance i)
        {
            i.Timeout = TimeSpan.FromSeconds(3);
        }

        protected override void WriteLog(string s)
        {
            ScoutingMessageBase m;
            try
            {
                Console.WriteLine($"MainMess: {MainMess}");
                Console.WriteLine($"Received Message: {s}");
                m = MainMess ?
                    ScoutingMessageBase.FromCSV<MainMessage>(s) :
                    ScoutingMessageBase.FromCSV<PitMessage>(s);
            }
            catch
            {
                _RaiseError("Error: Bad scouting message");
                return;
            }

            if (!CurrentLog.Init())
            {
                _RaiseError("Error: Bad log file, creating new one");
                do
                {
                    _Log = MainMess ?
                        new CSVScoutingLog<MainMessage>(CurrentLog.GetUseablePath(_DesiredName)) :
                        new CSVScoutingLog<PitMessage>(CurrentLog.GetUseablePath(_DesiredName));
                } while (!CurrentLog.Init());

                var name = CurrentLog.FileName;
                var index = name.LastIndexOf(Path.DirectorySeparatorChar);
                _RaiseError($"Resolved: created new log file ({name.Substring(index + 1)})");
            }

            if (!CurrentLog.Write(m))
            {
                _RaiseError("Error: Couldn't write log message");
            }
        }
    }
}
