using System;
 

namespace HelperExtentionLayer.Log_Helper
{
    public interface ILogger
    {
        /// <summary>
        /// Information
        /// </summary>
        /// <param name="message"></param>
        void information(string message);
        void Information(string fmt, params object[] vars);
        void Information(Exception exception, string fmt, params object[] vars);
        /// <summary>
        /// Warning
        /// </summary>
        /// <param name="message"></param>
        void Warning(string message);
        void Warning(string fmt, params object[] vars);
        void Warning(Exception exception, string fmt, params object[] vars);
        /// <summary>
        /// Errors
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
        void Error(string fmt, params object[] vars);
        void Errorr(Exception exception, string fmt, params object[] vars);
        /// <summary>
        /// Trace Api
        /// </summary>
        /// <param name="componentName"></param>
        /// <param name="method"></param>
        /// <param name="timeSpan"></param>
        void TraceApi(string componentName, string method, TimeSpan timeSpan);
        void TraceApi(string componentName, string method, TimeSpan timeSpan, string properties);
        void TraceApi(string componenentName, string method, TimeSpan timeSpan, string fmt, params object[] vars);

    }
}
