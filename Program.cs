using log4net;
using log4net.Config;
using System;

namespace StringExtensions
{
    class Program
    {
        private static readonly ILog log =
        LogManager.GetLogger(typeof(Program));

        static void Main ()
        {
            BasicConfigurator.Configure();
            log.Info("info");
            log.Error("error");
            log.Warn("warn");
        }
    }
}
