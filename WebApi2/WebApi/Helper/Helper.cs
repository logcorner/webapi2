using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

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