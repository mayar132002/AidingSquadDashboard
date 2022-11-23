using System.Web;
using System.Web.Mvc;

namespace AidingSquad_DashBoard
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
