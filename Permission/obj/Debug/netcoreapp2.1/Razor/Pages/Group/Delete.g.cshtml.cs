#pragma checksum "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e2dcbe1012c3d2e5f0da47114606ba1b5c6e000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Permission.Pages.Group.Pages_Group_Delete), @"mvc.1.0.razor-page", @"/Pages/Group/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Group/Delete.cshtml", typeof(Permission.Pages.Group.Pages_Group_Delete), null)]
namespace Permission.Pages.Group
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e2dcbe1012c3d2e5f0da47114606ba1b5c6e000", @"/Pages/Group/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e9dd500320f8224405eff7d909a4bbbbb4b286f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Group_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(50, 152, true);
            WriteLiteral("\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>PixiuGroup</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(203, 56, false);
#line 10 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(259, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(303, 52, false);
#line 13 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(355, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(399, 56, false);
#line 16 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(499, 52, false);
#line 19 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(595, 54, false);
#line 22 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.Extra01));

#line default
#line hidden
            EndContext();
            BeginContext(649, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(693, 50, false);
#line 25 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.Extra01));

#line default
#line hidden
            EndContext();
            BeginContext(743, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(787, 54, false);
#line 28 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.Extra02));

#line default
#line hidden
            EndContext();
            BeginContext(841, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(885, 50, false);
#line 31 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.Extra02));

#line default
#line hidden
            EndContext();
            BeginContext(935, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(979, 54, false);
#line 34 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.Extra03));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1077, 50, false);
#line 37 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.Extra03));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1171, 54, false);
#line 40 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.Extra04));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1269, 50, false);
#line 43 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.Extra04));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1363, 56, false);
#line 46 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1463, 52, false);
#line 49 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1559, 56, false);
#line 52 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.DeletedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1659, 52, false);
#line 55 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.DeletedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1755, 56, false);
#line 58 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.GroupCode));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1855, 52, false);
#line 61 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.GroupCode));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1951, 58, false);
#line 64 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PixiuGroup.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2009, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2053, 54, false);
#line 67 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PixiuGroup.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2145, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874106427c1b4f009277805f6dd8c77e", async() => {
                BeginContext(2165, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2175, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ceb3f1065eaa4d37b17508a7e87a2c72", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "D:\DoWork\BTCC\c2c-permission-tool\Permission\Permission\Pages\Group\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PixiuGroup.Id);

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
                BeginContext(2222, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2306, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "055ca97779d8477b8489523e621e977d", async() => {
                    BeginContext(2328, 12, true);
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
                BeginContext(2344, 6, true);
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
            BeginContext(2357, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Permission.Pages.Group.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Permission.Pages.Group.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Permission.Pages.Group.DeleteModel>)PageContext?.ViewData;
        public Permission.Pages.Group.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
