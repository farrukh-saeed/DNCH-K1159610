using System.Web;
using System.Web.Mvc;

namespace DNCHK_K1159610
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
