#pragma checksum "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1432167b3ddbdcb7086986d29ec51d56ac272ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\_ViewImports.cshtml"
using CoreMVCNew_09_08;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\_ViewImports.cshtml"
using CoreMVCNew_09_08.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1432167b3ddbdcb7086986d29ec51d56ac272ff8", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da0c90963413f8eb0449d177a54ebc8223d9eac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreMVCNew_09_08.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Emp</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 30 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 47 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 51 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 56 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 60 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 65 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
#nullable restore
#line 71 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 73 "F:\Dixita\Demos\CoreMVCNew_09-08\CoreMVCNew_09-08\Views\Home\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreMVCNew_09_08.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
