using System.Web;
using System.Web.Mvc;

namespace LTWeb_Cinema_0307
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
