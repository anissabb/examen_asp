#pragma checksum "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79df2251a01172fc9626754e37dd06d296218f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logement_Index), @"mvc.1.0.view", @"/Views/Logement/Index.cshtml")]
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
#line 1 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\_ViewImports.cshtml"
using projet_ecoTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\_ViewImports.cshtml"
using projet_ecoTravel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79df2251a01172fc9626754e37dd06d296218f4", @"/Views/Logement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5252066e2de5be293f5e13690110eee88d4132ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Logement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC.Models.LogementModelView.LogementListItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e79df2251a01172fc9626754e37dd06d296218f43483", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdLogement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomLogement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.adresseRue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.adresseNumero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.adresseCodePostal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.adressePays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescriptionCourte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescriptionLongue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombrePieces));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrixNuit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Capacite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalleBain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Wc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Balcon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AirConditionne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Wifi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MiniBar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnimauxAdmis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Piscine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lattitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 82 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdLogement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomLogement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.adresseRue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.adresseNumero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.adresseCodePostal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.adressePays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescriptionCourte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescriptionLongue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombrePieces));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrixNuit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Capacite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalleBain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Wc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Balcon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AirConditionne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Wifi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiniBar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnimauxAdmis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Piscine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lattitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.IdLogement}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 155 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.IdLogement }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 156 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.IdLogement }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 159 "C:\Users\a.bojabah\Documents\projet_ecoTravel\projet_ecoTravel\Views\Logement\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC.Models.LogementModelView.LogementListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
