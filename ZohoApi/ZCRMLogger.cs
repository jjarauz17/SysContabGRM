﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public class ZCRMLogger
    {
        private static ZCRMLogger logger;
        private static TraceSwitch logSwitch;
        private ZCRMLogger() { }


        internal static void Init()
        {
            Trace.AutoFlush = true;
            logger = new ZCRMLogger();
            logSwitch = new TraceSwitch("ZCRMLogger", "ZCRMSDK Logger");
            string minLoglevel = ZCRMConfigUtil.GetConfigValue(APIConstants.MIN_LOG_LEVEL);
            if ((minLoglevel == null) || (!APIConstants.LOGGER_LEVELS.ContainsKey(minLoglevel)))
            {
                logSwitch.Level = TraceLevel.Info;
            }
            else if (APIConstants.LOGGER_LEVELS.ContainsKey(minLoglevel))
            {
                logSwitch.Level = APIConstants.LOGGER_LEVELS[minLoglevel];
            }
            string logFile = ZCRMConfigUtil.GetConfigValue("logFilePath");
            if (string.IsNullOrEmpty(logFile))
            {
                logFile = 
                    Path.GetDirectoryName(Assembly.GetCallingAssembly().Location) + 
                    Path.DirectorySeparatorChar + "LogFile.log";
            }
            else
            {
                logFile += "LogFile.log";
            }
            DefaultTraceListener defaultTrace = new DefaultTraceListener
            {
                LogFileName = logFile
            };
            while (Trace.Listeners.Count > 0)
            {
                Trace.Listeners.RemoveAt(0);
            }
            Trace.Listeners.Add(defaultTrace);
        }

        public static void LogInfo(string message)
        {
            if (logSwitch.TraceInfo)
            {
                logger.Log(message, "INFO");
            }
        }

        public static void LogWarning(string message)
        {
            if (logSwitch.TraceWarning)
            {
                logger.Log(message, "WARNING");
            }
        }


        public static void LogError(string message)
        {
            if (logSwitch.TraceError)
            {
                logger.Log(message, "ERROR");
            }
        }

        internal static void LogError(Exception exception)
        {
            StackTrace stackTrace = new StackTrace(exception, true);
            int frameCount = stackTrace.FrameCount;
            StringBuilder errorMessage = new StringBuilder();
            for (int i = 0; i < frameCount; i++)
            {
                StackFrame frame = stackTrace.GetFrame(i);
                errorMessage.AppendLine("Exception in Type: " + frame.GetMethod().DeclaringType.Name + " at Method: " + frame.GetMethod() + " in File: " + frame.GetFileName() + " at Line: " + frame.GetFileLineNumber());
            }
            errorMessage.AppendLine(exception.Message);
            if (exception.InnerException != null)
            {
                errorMessage.AppendLine(exception.InnerException.Message);
            }
            LogError(errorMessage.ToString());

        }

        private void Log(string message, string messageHeader)
        {
            string timestamp = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            Trace.WriteLine(message, timestamp + " [" + messageHeader + "]");
        }


    }
}
