#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LoginStatus
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginName.cshtml")]
    public partial class LoginStatus_LoginName : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginName()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 9 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
  
var SignOutUrl = string.Concat(Url.Action("SignOut"),string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 426), Tuple.Create("\"", 449)
            
            #line 13 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 434), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 434), false)
);

WriteLiteral(">\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n        <span>");

            
            #line 15 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
         Write(Html.Resource("LoggedAs"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 576), Tuple.Create("\"", 613)
            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 583), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral(" class=\"sf-mr-m\"");

WriteLiteral("></a>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 679), Tuple.Create("\"", 697)
            
            #line 17 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 686), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 686), false)
);

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                         Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n    </div>\n\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 816), Tuple.Create("\"", 851)
            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 823), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl ?? "#"
            
            #line default
            #line hidden
, 823), false)
);

WriteLiteral(" class=\"sf-mr-m\"");

WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                          Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 907), Tuple.Create("\"", 949)
            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 914), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 914), false)
);

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n    </div>\n</div>\n\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1067), Tuple.Create("\"", 1098)
            
            #line 26 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1075), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1075), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1160), Tuple.Create("\"", 1188)
            
            #line 27 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1168), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1168), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1251), Tuple.Create("\"", 1291)
            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1259), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1259), false)
);

WriteLiteral(" />\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1358), Tuple.Create("\"", 1404)
            
            #line 29 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1366), false)
);

WriteLiteral(" />\n\n");

            
            #line 31 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
