#pragma checksum "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e612557ab3f902b418fd790b8a954c59830c6a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_QuestionDelete), @"mvc.1.0.view", @"/Views/People/QuestionDelete.cshtml")]
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
#line 1 "C:\Users\mking10\dev\Week 12\NewPeople\Views\_ViewImports.cshtml"
using NewPeople;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 12\NewPeople\Views\_ViewImports.cshtml"
using NewPeople.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e612557ab3f902b418fd790b8a954c59830c6a13", @"/Views/People/QuestionDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19e4ba95c4c7c9920bfa1a99e012225e0c960eb", @"/Views/_ViewImports.cshtml")]
    public class Views_People_QuestionDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<People>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
  
    ViewData["Title"] = "QuestionDelete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Are you sure you want to delete ");
#nullable restore
#line 6 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
                               Write(Model.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
                                                Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h1>\r\n<p>Id: ");
#nullable restore
#line 7 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
  Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email: ");
#nullable restore
#line 8 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
     Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Phone: ");
#nullable restore
#line 9 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
     Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 225, "\"", 256, 2);
            WriteAttributeValue("", 232, "/people/delete/", 232, 15, true);
#nullable restore
#line 11 "C:\Users\mking10\dev\Week 12\NewPeople\Views\People\QuestionDelete.cshtml"
WriteAttributeValue("", 247, Model.id, 247, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<People> Html { get; private set; }
    }
}
#pragma warning restore 1591