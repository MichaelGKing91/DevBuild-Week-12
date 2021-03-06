#pragma checksum "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994912025334232a760d54b29959e4c01fbe56f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dep_Detail), @"mvc.1.0.view", @"/Views/Dep/Detail.cshtml")]
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
#line 1 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\_ViewImports.cshtml"
using Bus2MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\_ViewImports.cshtml"
using Bus2MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"994912025334232a760d54b29959e4c01fbe56f1", @"/Views/Dep/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ef6f697592cfb1cf4d02db5cd428d5a6140db5", @"/Views/_ViewImports.cshtml")]
    public class Views_Dep_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\nThere are ");
#nullable restore
#line 7 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
     Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" employees in the ");
#nullable restore
#line 7 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
                                   Write(ViewBag.depart.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" department.\r\n\r\n");
#nullable restore
#line 9 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
 foreach (Employee emp in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 11 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
   Write(emp.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
                  Write(emp.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div>ID: ");
#nullable restore
#line 12 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
        Write(emp.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Phone: ");
#nullable restore
#line 13 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
           Write(emp.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Email: ");
#nullable restore
#line 14 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
           Write(emp.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>");
#nullable restore
#line 15 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
    Write(emp.department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
     if (emp.username == DAL.currentUser || DAL.currentUser == "admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><a");
            BeginWriteAttribute("href", " href=\"", 463, "\"", 524, 4);
            WriteAttributeValue("", 470, "/dep/deleteemployee?dept=", 470, 25, true);
#nullable restore
#line 18 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
WriteAttributeValue("", 495, emp.department, 495, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 510, "&empid=", 510, 7, true);
#nullable restore
#line 18 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
WriteAttributeValue("", 517, emp.id, 517, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></div>\r\n        <br />\r\n");
#nullable restore
#line 20 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 595, "\"", 641, 2);
            WriteAttributeValue("", 602, "/dep/addemployeeform/", 602, 21, true);
#nullable restore
#line 22 "C:\Users\mking10\dev\Week 12\Bus2MVC\Views\Dep\Detail.cshtml"
WriteAttributeValue("", 623, ViewBag.depart.id, 623, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Add</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
