#pragma checksum "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf39e2e6e2801569fc0198591b2fc689d9a23c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Permission.Pages.GroupPermission.Pages_GroupPermission_Delete), @"mvc.1.0.razor-page", @"/Pages/GroupPermission/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/GroupPermission/Delete.cshtml", typeof(Permission.Pages.GroupPermission.Pages_GroupPermission_Delete), null)]
namespace Permission.Pages.GroupPermission
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\_ViewImports.cshtml"
using Permission;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf39e2e6e2801569fc0198591b2fc689d9a23c87", @"/Pages/GroupPermission/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e9dd500320f8224405eff7d909a4bbbbb4b286f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GroupPermission_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 162, true);
            WriteLiteral("\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>PixiuGroupPermission</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(223, 66, false);
#line 10 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(333, 62, false);
#line 13 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(439, 66, false);
#line 16 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(549, 62, false);
#line 19 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(655, 64, false);
#line 22 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.Extra01));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(763, 60, false);
#line 25 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.Extra01));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(867, 64, false);
#line 28 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.Extra02));

#line default
#line hidden
            EndContext();
            BeginContext(931, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(975, 60, false);
#line 31 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.Extra02));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1079, 64, false);
#line 34 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.Extra03));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1187, 60, false);
#line 37 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.Extra03));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1291, 64, false);
#line 40 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.Extra04));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1399, 60, false);
#line 43 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.Extra04));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1503, 66, false);
#line 46 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1613, 62, false);
#line 49 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1719, 66, false);
#line 52 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.DeletedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1829, 62, false);
#line 55 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.DeletedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1935, 66, false);
#line 58 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.GroupCode));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2045, 62, false);
#line 61 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.GroupCode));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2151, 71, false);
#line 64 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroupPermission.PermissionCode));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2266, 67, false);
#line 67 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroupPermission.PermissionCode));

#line default
#line hidden
            EndContext();
            BeginContext(2333, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2371, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce8e6a9919845b1b7755a167ed58630", async() => {
                BeginContext(2391, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2401, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13a169b6719e4c909c40110f0c0aaf02", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\GroupPermission\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PixiuGroupPermission.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2458, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2542, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b40f3911dd64aaf9c61d2a777697dde", async() => {
                    BeginContext(2564, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2580, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2593, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Permission.Pages.GroupPermission.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Permission.Pages.GroupPermission.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Permission.Pages.GroupPermission.DeleteModel>)PageContext?.ViewData;
        public Permission.Pages.GroupPermission.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591