using NLog;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Web.Http.Tracing;

namespace TravelPrototype.Log
{
    public class LogWriter : ITraceWriter
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void Trace(HttpRequestMessage request, string category, TraceLevel level, Action<TraceRecord> traceAction)
        {
            TraceRecord traceRecord = new TraceRecord(request, category, level);
            traceAction(traceRecord);
            var traceString = GetTraceString(traceRecord);
            System.Diagnostics.Trace.WriteLine(traceString);
            logger.Log(LogLevel.Fatal, traceString);
        }

        private String GetTraceString(TraceRecord traceRecord){
            return String.Format(
                    "{0} {1}: Category={2}, Level={3} {4} {5} {6} {7}",
                    traceRecord.Request != null
                        ? traceRecord.Request.Method.ToString()
                        : string.Empty,
                    traceRecord.Request != null
                        ? traceRecord.Request.RequestUri.ToString()
                        : string.Empty,
                    traceRecord.Category,
                    traceRecord.Level,
                    traceRecord.Kind,
                    traceRecord.Operator,
                    traceRecord.Operation,
                    traceRecord.Exception != null
                        ? traceRecord.Exception.GetBaseException().Message
                        : !string.IsNullOrEmpty(traceRecord.Message)
                            ? traceRecord.Message
                            : string.Empty
                );
               
        }

        

    }
}