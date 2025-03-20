using System;
using System.Threading.Tasks;
using NLog;
using NLog.Fluent;


namespace BoilerLoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {
        }


        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogError(string msg, LogEventInfo logEventInfo)
        {
            try
            {
                logger.Error()
                    .Message(msg)
                    .Property("ErrorCode", 500)
                    .Property("UserCode", logEventInfo.Properties["UserCode"])
                    .Property("FullPath", logEventInfo.Properties["FullPath"])
                    .Property("StackTrace", logEventInfo.Properties["StackTrace"])
                    .Property("Inner", logEventInfo.Properties["Inner"])
                    .Property("ExceptionType", logEventInfo.Properties["ExceptionType"])
                    .Write();
                LogManager.ThrowExceptions = true;
                LogManager.ThrowConfigExceptions = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }


        public void LogError(Exception ex, string message, int userCode)
        {
            LogError(ex, message, userCode.ToString());
        }

        public void LogError(Exception ex, string message, string UserCode)
        {
            try
            {
                var Inner = ex.InnerException;
                System.Text.StringBuilder InnerMsg = new System.Text.StringBuilder(ex.Message);
                var cnt = 1;
                while (Inner != null && cnt <= 5)
                {
                    InnerMsg.Append($" \n InnerMessage_{cnt}= " + Inner.Message);
                    Inner = Inner.InnerException;
                    cnt++;
                }
                logger.Error()
                    .Message(message)
                    .Property("ErrorCode", 500)
                    .Property("UserCode", UserCode)
                    .Property("FullPath", ex.TargetSite.ReflectedType.FullName.ToString())
                    .Property("StackTrace", ex.StackTrace.ToString())
                    .Property("Inner", InnerMsg)
                    .Property("ExceptionType", ex.GetType().ToString())
                    .Write();
                LogManager.ThrowExceptions = true;
                LogManager.ThrowConfigExceptions = true;
            }
            catch (Exception ex1)
            {
                logger.Error(ex1);
            }
        }

        public async Task LogInfo(string message, Type sourceType, string userCode)
        {
            try
            {
                await Task.Run(() => {
                    logger.Error()
                    .Message(message)
                    .Property("ErrorCode", 200)
                    .Property("UserCode", userCode)
                    .Property("FullPath", sourceType.FullName)
                    .Property("StackTrace", string.Empty)
                    .Property("Inner", string.Empty)
                    .Property("ExceptionType", string.Empty)
                    .Write();
                    LogManager.ThrowExceptions = false;
                    LogManager.ThrowConfigExceptions = false;
                }).ConfigureAwait(false);               
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogInfo(string classname, string namspace, string message)
        {
            logger.Info(message, classname, namspace);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }

        public string GetExceptionInnerMessage(Exception ex)
        {
            var Inner = ex.InnerException;
            System.Text.StringBuilder InnerMsg = new System.Text.StringBuilder(ex.Message);
            var cnt = 1;
            while (Inner != null && cnt <= 5)
            {
                InnerMsg.Append($" \n InnerMessage_{cnt}= " + Inner.Message);
                Inner = Inner.InnerException;
                cnt++;
            }
            return InnerMsg.ToString();
        }
    }
}
