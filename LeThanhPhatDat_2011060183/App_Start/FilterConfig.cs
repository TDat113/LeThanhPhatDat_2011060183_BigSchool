using System.Web;
using System.Web.Mvc;

namespace LeThanhPhatDat_2011060183
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
