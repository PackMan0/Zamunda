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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LoginForm
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
    
    #line 4 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginForm/ForgotPassword.ForgottenPassword.cshtml")]
    public partial class ForgotPassword_ForgottenPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ForgotPasswordViewModel>
    {
        public ForgotPassword_ForgottenPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 176), Tuple.Create("\"", 199)
            
            #line 6 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 184), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 184), false)
);

WriteLiteral(">\n\n<h3>");

            
            #line 8 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
Write(Html.Resource("ForgotPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 10 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
 if (Model.EmailSent)
{

            
            #line default
            #line hidden
WriteLiteral("    <p>");

            
            #line 12 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
  Write(Html.Resource("ForgotPasswordRequestSent"));

            
            #line default
            #line hidden
WriteLiteral(" <i>");

            
            #line 12 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                 Write(Html.Encode(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</i></p>\n");

            
            #line 13 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <p>");

            
            #line 14 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
  Write(Html.Resource("ForgotPasswordRequestSentUseLink"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 15 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 434), Tuple.Create("\"", 460)
            
            #line 16 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 441), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 441), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">");

            
            #line 16 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                     Write(Html.Resource("ForgotPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 17 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
}
else
{
    using (Html.BeginForm("SendPasswordResetEmail", "LoginForm"))
    {


            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 23 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
      Write(Html.Resource("EnterLoginEmailAddress"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 24 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t<label>");

            
            #line 26 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
              Write(Html.Resource("ForgotPasswordEmail"));

            
            #line default
            #line hidden
WriteLiteral("</label>\n");

WriteLiteral("\t\t\t");

            
            #line 27 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
       Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n            </div>\n");

            
            #line 30 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("      <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 31 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                               Write(Html.Resource("ForgotPasswordSendButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 32 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n");

        }
    }
}
#pragma warning restore 1591
