using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjectMgt
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Registering syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDE1MDQ3QDMxMzgyZTM0MmUzMFo5L2pvTmdzWHhSNFh6MVRUazdzTWd1SFlwWHkwVVBPWEQxSkl2R2lqMU09");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
