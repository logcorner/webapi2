using System.Diagnostics;
using System.Web.Http.ExceptionHandling;

namespace WebApi.Exceptions
{
    public class UnhandledExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            var log = context.Exception.Message;
            Debug.WriteLine($"EXCEPTION LOGGED: {log}");
        }
    }
}