using System.Globalization;
using System.Threading;

namespace WebApi.Helper
{
    public class Helper
    {
        public static CultureInfo GetCurrentCulture()
        {
            if (Thread.CurrentThread.CurrentCulture != new CultureInfo("fr-FR"))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("fr");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            }
            return Thread.CurrentThread.CurrentCulture;
        }
    }
}