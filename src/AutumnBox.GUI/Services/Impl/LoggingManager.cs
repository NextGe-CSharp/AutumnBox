﻿using AutumnBox.Logging.Management;

namespace AutumnBox.GUI.Services.Impl
{
    sealed class LoggingManager : ILoggingManager
    {
        public ILoggingStation LoggingStation { get; private set; }

        public LoggingManager()
        {
            Util.Debugging.LoggingStation.Instance.Work();
            LoggingStation = Util.Debugging.LoggingStation.Instance;
        }
        public void AutoInit()
        {
            Logging.Management.
                LoggingManager.SetLogStation(LoggingStation);
        }
    }
}