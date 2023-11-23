using NLog;

namespace Reservoom.Loggers
{
    public static class MyNLogger
    {
        static readonly Logger _log = LogManager.GetLogger("TestApplication");

        public static void Info(string info)
        {
            _log.Info(info);
        }

        public static void Warning(string warning)
        {
            _log.Warn(warning);
        }

        public static void Error(string error)
        {
            _log.Error(error);
        }
    }
}
