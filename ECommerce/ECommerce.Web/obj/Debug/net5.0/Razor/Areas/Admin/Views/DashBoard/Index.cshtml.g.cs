#pragma checksum "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a923be1f9b6c8030951aff535f9495963636e010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DashBoard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Web.ViewConponents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a923be1f9b6c8030951aff535f9495963636e010", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2968736dbe31a6c94be6d93d385d3a6727c5ebcd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a923be1f9b6c8030951aff535f9495963636e0104183", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a923be1f9b6c8030951aff535f9495963636e0105415", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n\r\n        <!-- Preloader -->\r\n        ");
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("Preloader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- Navbar -->\r\n          ");
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
     Write(await Component.InvokeAsync("Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.navbar -->\r\n        <!-- Main Sidebar Container -->\r\n       ");
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
  Write(await Component.InvokeAsync("MainSidebar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Content Wrapper. Contains page content -->\r\n        ");
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("ContentWrapperContainsPageContent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.content-wrapper -->\r\n        ");
#nullable restore
#line 20 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("ContentWrapper"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Control Sidebar -->\r\n        ");
#nullable restore
#line 23 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("ControlSidebar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.control-sidebar -->\r\n    </div>\r\n    <!-- ./wrapper -->\r\n    ");
#nullable restore
#line 27 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\DashBoard\Index.cshtml"
Write(await Component.InvokeAsync("Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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