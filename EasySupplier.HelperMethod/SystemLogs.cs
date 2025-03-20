#region System

using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Net;


#endregion System

#region Custom

#endregion Custom

namespace BoilerSupplier.HelperMethod
{
    public class SystemLogs
    {

        /// <summary>
        /// Returns generated path to logfile
        /// </summary>
        /// <returns></returns>
        protected static string GetFileName(bool info)
        {
            string folder = info ? GetInfoFolder() : GetErrorFolder();
            if (folder == null) return null;
            StringBuilder stb = new StringBuilder();
            stb.AppendFormat("{0}\\{1}{2}{3:yyyy}_{4}.txt", folder, DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"), DateTime.Now, DateTime.Now.Hour.ToString("HH"));
            return stb.ToString();
        }

        /// <summary>
        /// Gets the enable loging
        /// </summary>
        /// <returns></returns>
        protected static bool GetEnableLogging()
        {
            IDictionary dic = System.Configuration.ConfigurationManager.GetSection("ErrorHandling") as IDictionary;
            bool enableLogging = false;
            if (dic != null)
            {
                Boolean.TryParse(dic["EnableLogging"].ToString().Trim(), out enableLogging);
            }
            return enableLogging;
        }

        /// <summary>
        /// Gets the name of error loging folder
        /// </summary>
        /// <returns></returns>
        protected static string GetErrorFolder()
        {
            //IDictionary dic = System.Configuration.ConfigurationManager.GetSection("ErrorHandling") as IDictionary;
            //string folder = dic == null || dic["ErrorLogFilesDir"] == null ? "" : dic["ErrorLogFilesDir"].ToString().Trim();
            string folder = AppDomain.CurrentDomain.BaseDirectory + "/" + "Logs_Error";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        /// <summary>
        /// Gets the name of info loging folder
        /// </summary>
        /// <returns></returns>
        protected static string GetInfoFolder()
        {
            //IDictionary dic = System.Configuration.ConfigurationManager.GetSection("ErrorHandling") as IDictionary;
            //string folder = dic == null || dic["AppLogFilesDir"] == null ? "" : dic["AppLogFilesDir"].ToString().Trim();
            string folder = AppDomain.CurrentDomain.BaseDirectory + "/" + "Logs_App";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        /// <summary>
        /// An internal method for writing data to file
        /// </summary>
        /// <param name="stb">
        /// Data to be written
        /// </param>
        /// <param name="info">
        /// If true, writes to info log folder
        /// </param>
        protected static void WriteToFile(StringBuilder stb, bool info)
        {
            if (GetEnableLogging())
            {
                string path = GetFileName(info);
                if (path != null)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(stb.ToString());
                        sw.Close();
                        sw.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Logs any information to some text logfile in specific format
        /// </summary>
        /// <param name="info">
        /// String containing information to be loged
        /// </param>
        public static void LogInfo(string info)
        {
           // LogInfo(info, false);
        }

        /// <summary>
        /// Logs any information to some text logfile in specific format
        /// </summary>
        /// <param name="info">
        /// String containing information to be loged
        /// </param>
        /// /// <param name="includeAdditionalInfo">
        /// In true, additional info about request, session etc. will be included into log record
        /// </param>
        //public static void LogInfo(string info, bool includeAdditionalInfo)
        //{
        //    if (HttpContext.Current != null)
        //    {
        //        StringBuilder stb = new StringBuilder();
        //        stb.Append("<Activity>");
        //        stb.AppendLine();
        //        stb.AppendFormat("<DateTime>{0}</DateTime>", DateTime.Now);
        //        stb.AppendLine();
        //        //stb.AppendFormat("<SessionID>{0}</SessionID>", HttpContext.Current.Session.SessionID);
        //        //stb.AppendLine();
        //        stb.AppendFormat("<Summary>Some info was loged on {0} {1}</Summary>", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
        //        stb.AppendLine();
        //        stb.AppendFormat("<Page>{0}</Page>", HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.Url.PathAndQuery);
        //        stb.AppendLine();
        //        stb.AppendLine();
        //        stb.AppendFormat("<Message>{0}</Message>", info);
        //        stb.AppendLine();
        //        stb.AppendLine();
        //        if (includeAdditionalInfo)
        //        {
        //            stb.Append("<Info>");
        //            stb.AppendLine();
        //            stb.AppendFormat("<Verb>{0}</Verb>", HttpContext.Current.Request.RequestType);
        //            stb.AppendLine();
        //            stb.AppendFormat("<URL>{0}</URL>", HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.Url.PathAndQuery);
        //            stb.AppendLine();
        //            stb.AppendFormat("<HostIP>{0}</HostIP>", HttpContext.Current.Request.UserHostAddress);
        //            stb.AppendLine();
        //            if (HttpContext.Current.Request.UrlReferrer != null)
        //            {
        //                stb.AppendFormat("<ReffererURL>{0}</ReffererURL>", HttpContext.Current.Request.UrlReferrer.Host + HttpContext.Current.Request.UrlReferrer.PathAndQuery);
        //                stb.AppendLine();
        //            }
        //            stb.Append("</Info>");
        //            stb.AppendLine();
        //            if (HttpContext.Current.Request.Browser != null)
        //            {
        //                stb.Append("<Browser>");
        //                stb.AppendLine();
        //                stb.AppendFormat("<Name>{0}</Name>", HttpContext.Current.Request.Browser.Browser);
        //                stb.AppendLine();
        //                stb.AppendFormat("<Version>{0}</Version>", HttpContext.Current.Request.Browser.Version);
        //                stb.AppendLine();
        //                stb.AppendFormat("<CookieSupport>{0}</CookieSupport>", HttpContext.Current.Request.Browser.Cookies);
        //                stb.AppendLine();
        //                stb.AppendFormat("<JSSupport>{0}</JSSupport>", HttpContext.Current.Request.Browser.EcmaScriptVersion.Major > 0);
        //                stb.AppendLine();
        //                stb.AppendFormat("<Platform>{0}</Platform>", HttpContext.Current.Request.Browser.Platform);
        //                stb.AppendLine();
        //                stb.Append("</Browser>");
        //                stb.AppendLine();
        //            }

        //            if (HttpContext.Current.Session["UserID"] != null && Convert.ToString(HttpContext.Current.Session["UserID"]) != string.Empty)
        //            {
        //                stb.AppendFormat("<User type=\"User\">{0}</User>", HttpContext.Current.Session["UserID"].ToString());
        //            }
        //            else if (HttpContext.Current.Session["AdminUserID"] != null && Convert.ToString(HttpContext.Current.Session["AdminUserID"]) != string.Empty)
        //            {
        //                stb.AppendFormat("<User type=\"Admin\">{0}</User>", HttpContext.Current.Session["AdminUserID"].ToString());
        //            }
        //            else
        //            {
        //                stb.AppendFormat("<User type=\"Guest\">{0}</User>", "Guest");
        //            }

        //            stb.AppendLine();
        //            stb.AppendLine();
        //            stb.AppendFormat("<ElementsInSession>{0}</ElementsInSession>", HttpContext.Current.Session.Count);
        //            stb.AppendLine();
        //            stb.AppendFormat("<ElementsInCache>{0}</ElementsInCache>", HttpContext.Current.Cache.Count);
        //            stb.AppendLine();
        //        }
        //        stb.AppendLine();
        //        stb.AppendLine();
        //        stb.Append("</Activity>");
        //        stb.AppendLine();
        //        stb.AppendLine();
        //        lock (typeof(SystemLogs))
        //        {
        //            WriteToFile(stb, true);
        //            //WriteToFile(stb, false);
        //        }
        //    }
        //}


        /// <summary>
        /// Logs as exception pointed to some text logfile in specific format
        /// </summary>
        /// <param name="er">
        /// Exception to be loged
        /// </param>
        public static void LogException(Exception er)
        {
          ///  LogException(er, string.Empty, ErrorLevel.Error);
        }

        /// <summary>
        /// Logs as exception pointed to some text logfile in specific format
        /// </summary>
        /// <param name="er">
        /// Exception to be loged
        /// </param>
        /// <param name="strMessage">
        /// custom message to be loged
        /// </param>
        public static void LogException(Exception er, string strMessage)
        {
         //   LogException(er, string.Empty, ErrorLevel.Error);
        }

        /// <summary>
        /// Logs as exception pointed to some text logfile in specific format
        /// </summary>
        /// <param name="er">
        /// Exception to be loged
        /// </param>
        /// <param name="strMessage">
        /// custom message to be loged
        /// </param>
        /// <param name="errLevel">
        /// error level
        /// </param>
        /// <param name="userId"></param>
        /// <param name="instituteId"></param>
        //public static void LogException(Exception er, string strMessage, ErrorLevel errLevel, string userId = null, string instituteId = null)
        //{
        //    if (HttpContext.Current != null && !(er is System.Threading.ThreadAbortException))
        //    {
        //        try
        //        {
        //            StringBuilder stb = new StringBuilder();
        //            stb.Append("<Exception>");
        //            stb.AppendLine();
        //            stb.AppendFormat("<DateTime>{0}</DateTime>", DateTime.Now);
        //            stb.AppendLine();
        //            stb.AppendFormat("<SessionID>{0}</SessionID>", HttpContext.Current.Session.SessionID);
        //            stb.AppendLine();
        //            stb.AppendFormat("<Summary>An unhandled exception occured on {0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString() + "</Summary>");
        //            stb.AppendLine();
        //            if (strMessage != string.Empty)
        //            {
        //                stb.AppendFormat("<CustomMessage>{0}</CustomMessage>", strMessage);
        //                stb.AppendLine();
        //            }
        //            stb.Append("<Info>");
        //            stb.AppendLine();
        //            stb.AppendFormat("<Verb>{0}</Verb>", HttpContext.Current.Request.RequestType);
        //            stb.AppendLine();
        //            stb.AppendFormat("<URL>{0}</URL>", HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.Url.PathAndQuery);
        //            stb.AppendLine();
        //            stb.AppendFormat("<HostIP>{0}</HostIP>", HttpContext.Current.Request.UserHostAddress);
        //            stb.AppendLine();
        //            if (HttpContext.Current.Request.UrlReferrer != null)
        //            {
        //                stb.AppendFormat("<ReffererURL>{0}</ReffererURL>", HttpContext.Current.Request.UrlReferrer.Host + HttpContext.Current.Request.UrlReferrer.PathAndQuery);
        //                stb.AppendLine();
        //            }
        //            stb.Append("</Info>");
        //            stb.AppendLine();
        //            if (HttpContext.Current.Request.Browser != null)
        //            {
        //                stb.Append("<Browser>");
        //                stb.AppendLine();
        //                stb.AppendFormat("<Name>{0}</Name>", HttpContext.Current.Request.Browser.Browser);
        //                stb.AppendLine();
        //                stb.AppendFormat("<Version>{0}</Version>", HttpContext.Current.Request.Browser.Version);
        //                stb.AppendLine();
        //                stb.AppendFormat("<CookieSupport>{0}</CookieSupport>", HttpContext.Current.Request.Browser.Cookies);
        //                stb.AppendLine();
        //                stb.AppendFormat("<JSSupport>{0}</JSSupport>", HttpContext.Current.Request.Browser.EcmaScriptVersion.Major > 0);
        //                stb.AppendLine();
        //                stb.AppendFormat("<Platform>{0}</Platform>", HttpContext.Current.Request.Browser.Platform);
        //                stb.AppendLine();
        //                stb.Append("</Browser>");
        //                stb.AppendLine();
        //            }

        //            if (!string.IsNullOrEmpty(userId))
        //            {
        //                stb.AppendFormat("<User>{0}</User>", userId);
        //                stb.AppendLine();
        //            }
        //            if (!string.IsNullOrEmpty(instituteId))
        //            {
        //                stb.AppendFormat("<InstituteId>{0}</InstituteId>", instituteId);
        //                stb.AppendLine();
        //            }

        //            stb.AppendFormat("<ErrorMessage>{0}</ErrorMessage>", er.Message);

        //            if (er.InnerException != null)
        //            {
        //                stb.AppendLine();
        //                stb.AppendFormat("<InnerException>{0}</InnerException>", er.InnerException);
        //            }
        //            //if (er.StackTrace != null)
        //            //{
        //            //    stb.AppendLine();
        //            //    stb.AppendFormat("<StackTrace>{0}</StackTrace>", er.StackTrace);
        //            //}

        //            stb.AppendLine();
        //            stb.AppendLine();
        //            stb.Append("</Exception>");
        //            //stb.AppendFormat("Count of elements in Session: {0}", HttpContext.Current.Session.Count);
        //            //stb.AppendLine();
        //            //stb.AppendFormat("Count of elements in Cache: {0}", HttpContext.Current.Cache.Count);
        //            //stb.AppendLine();

        //            stb.AppendLine();
        //            stb.AppendLine();
        //            lock (typeof(SystemLogs))
        //            {
        //                WriteToFile(stb, false);
        //                //WriteToFile(stb, false);
        //            }

        //            if (errLevel == ErrorLevel.FatalError)
        //            {
        //                //Send Email to admin code
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LogException(ex);
        //        }
        //    }
        //}
    }
    /// <summary>
    /// Level of error
    /// </summary>
    public enum ErrorLevel
    {
        FatalError = 3,
        Error = 2,
        Warning = 1
    }
}
