#pragma checksum "D:\Code\BootstrapLearning\MVCWeb\Views\Example\Badges.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4658630cf1a0247802022dbefca6c8ab035c1149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Example_Badges), @"mvc.1.0.view", @"/Views/Example/Badges.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Example/Badges.cshtml", typeof(AspNetCore.Views_Example_Badges))]
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
#line 1 "D:\Code\BootstrapLearning\MVCWeb\Views\_ViewImports.cshtml"
using MVCWeb;

#line default
#line hidden
#line 2 "D:\Code\BootstrapLearning\MVCWeb\Views\_ViewImports.cshtml"
using MVCWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4658630cf1a0247802022dbefca6c8ab035c1149", @"/Views/Example/Badges.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdba035f1b2be063c899ce31d4be1ae664b23310", @"/Views/_ViewImports.cshtml")]
    public class Views_Example_Badges : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Code\BootstrapLearning\MVCWeb\Views\Example\Badges.cshtml"
  
    ViewData["Title"] = "Badges";

#line default
#line hidden
            BeginContext(42, 487, true);
            WriteLiteral(@"
 <!-- HTML -->
<h5>本周重點 <span class=""badge badge-pill badge-default"">默認</span></h5>
<p>
<h5>本周重點<span class=""badge badge-pill badge-primary"">亮點工作</span></h5>
<p>
<h5>On schedule Item<span class=""badge badge-pill badge-success"">成功</span></h5>
<p>
<h5>Trouble Shooting<span class=""badge badge-pill badge-info"">訊息</span></h5>
<p>
<h5>恐超過估算時間<span class=""badge badge-pill badge-warning"">警告</span></h5>
<p>
<h5>Delay Item<span class=""badge badge-pill badge-danger"">危險</span></h5>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591