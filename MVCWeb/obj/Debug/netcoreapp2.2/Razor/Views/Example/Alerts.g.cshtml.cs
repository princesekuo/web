#pragma checksum "D:\Code\BootstrapLearning\MVCWeb\Views\Example\Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1040b629d8388df4210254f31b169f62a5654e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Example_Alerts), @"mvc.1.0.view", @"/Views/Example/Alerts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Example/Alerts.cshtml", typeof(AspNetCore.Views_Example_Alerts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1040b629d8388df4210254f31b169f62a5654e38", @"/Views/Example/Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdba035f1b2be063c899ce31d4be1ae664b23310", @"/Views/_ViewImports.cshtml")]
    public class Views_Example_Alerts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Code\BootstrapLearning\MVCWeb\Views\Example\Alerts.cshtml"
  
    ViewData["Title"] = "訊息提示框";

#line default
#line hidden
            BeginContext(41, 474, true);
            WriteLiteral(@"
 <!-- HTML -->
 <div class=""alert alert-success "">
    <strong>成功!</strong> 指定操作成功提示信息。
  </div>
  <div class=""alert alert-info "">
    <strong>信息!</strong> 請注意此訊息。
  </div>
  <div class=""alert alert-warning alert-dismissible"">
    <strong>警告!</strong> 即將超過登入時間上限！
  </div>
  <div class=""alert alert-danger alert-dismissible fade show"">
    <button type=""button"" class=""close"" data-dismiss=""alert"">&times;</button>
    <strong>錯誤!</strong> 您已超過登入時間上限！
  </div>");
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
