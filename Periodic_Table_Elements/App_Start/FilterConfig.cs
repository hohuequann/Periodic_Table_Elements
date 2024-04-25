using System.Web;
using System.Web.Mvc;

namespace Periodic_Table_Elements
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
