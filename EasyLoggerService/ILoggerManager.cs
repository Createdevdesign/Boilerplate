using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoilerLoggerService
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);

        void LogError(Exception ex, string message,string UserCode);
        void LogError(Exception ex, string message, int userCode);

        void LogError(string msg, LogEventInfo logEventInfo);
        void LogInfo(string classname, string namspace, string message);

        string GetExceptionInnerMessage(Exception ex);

        Task LogInfo(string message, Type sourceType, string userCode);
    }
}
