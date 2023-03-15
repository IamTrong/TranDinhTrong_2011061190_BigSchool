using System.Web;
using System.Web.Mvc;

namespace TranDinhTrong_2011061190
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
