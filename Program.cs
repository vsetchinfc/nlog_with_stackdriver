using System;
using NLog;

namespace nlog_with_stackdriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            // Log some information. This log entry will be sent to Google Stackdriver Logging.
            logger.Info("An exciting log entry for Google Cloud!");

            // Flush buffered log entries before program exit; then shutdown the logger before program exit.
            LogManager.Flush(TimeSpan.FromSeconds(15));
            LogManager.Shutdown();
        }
    }
}
