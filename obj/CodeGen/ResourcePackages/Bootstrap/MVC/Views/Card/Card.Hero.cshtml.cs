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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Card
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
    
    #line 2 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Card/Card.Hero.cshtml")]
    public partial class Card_Hero : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Hero()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 121), Tuple.Create("\"", 154)
            
            #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 129), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 129), false)
, Tuple.Create(Tuple.Create(" ", 144), Tuple.Create("container", 145), true)
);

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"jumbotron\"");

WriteAttribute("style", Tuple.Create(" style=\"", 183), Tuple.Create("\"", 271)
, Tuple.Create(Tuple.Create("", 191), Tuple.Create("background:", 191), true)
, Tuple.Create(Tuple.Create(" ", 202), Tuple.Create("url(\'", 203), true)
            
            #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 208), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 208), false)
, Tuple.Create(Tuple.Create("", 230), Tuple.Create("\')", 230), true)
, Tuple.Create(Tuple.Create(" ", 232), Tuple.Create("center", 233), true)
, Tuple.Create(Tuple.Create(" ", 239), Tuple.Create("center;", 240), true)
, Tuple.Create(Tuple.Create(" ", 247), Tuple.Create("background-size:", 248), true)
, Tuple.Create(Tuple.Create(" ", 264), Tuple.Create("cover;", 265), true)
);

WriteLiteral(">\n        <h1>");

            
            #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
       Write(Html.HtmlSanitize(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h1>\n        <p>");

            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
      Write(Html.HtmlSanitize(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
         if (!string.IsNullOrEmpty(Model.ActionName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 459), Tuple.Create("\"", 500)
            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 466), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize(Model.ActionUrl)
            
            #line default
            #line hidden
, 466), false)
);

WriteLiteral(" class=\"btn btn-primary btn-lg\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
                                                                                                     Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Hero.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n</div>");

        }
    }
}
#pragma warning restore 1591
