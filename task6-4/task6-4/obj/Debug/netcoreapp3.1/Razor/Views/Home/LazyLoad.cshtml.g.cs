#pragma checksum "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dc0f98443a2b91f413adb558747e4dd104650e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LazyLoad), @"mvc.1.0.view", @"/Views/Home/LazyLoad.cshtml")]
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
#line 1 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\_ViewImports.cshtml"
using task6_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\_ViewImports.cshtml"
using task6_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc0f98443a2b91f413adb558747e4dd104650e6", @"/Views/Home/LazyLoad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e0eaa8afda2edeaecefc9b440bd881d7fe371b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LazyLoad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<task6_4.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml"
  
    ViewBag.Title = "Ленивая загрузка дисков";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\">\n    <tr><td>Книга</td><td>Автор</td><td>Страна</td></tr>\n");
#nullable restore
#line 8 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 10 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 10 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml"
                              Write(item.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 10 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml"
                                                        Write(item.Author.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n");
#nullable restore
#line 11 "C:\Users\Arina\Desktop\database6-master\task6-4\task6-4\Views\Home\LazyLoad.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<task6_4.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
