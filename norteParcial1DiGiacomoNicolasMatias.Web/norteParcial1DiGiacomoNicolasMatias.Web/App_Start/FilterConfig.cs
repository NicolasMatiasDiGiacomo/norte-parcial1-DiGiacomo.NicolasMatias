using System.Web;
using System.Web.Mvc;

namespace norteParcial1DiGiacomoNicolasMatias.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
