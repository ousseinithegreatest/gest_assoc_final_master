#pragma checksum "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6f6d76cf595283b999caf01377c157042057500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Associations_Delete), @"mvc.1.0.view", @"/Views/Associations/Delete.cshtml")]
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
#line 1 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\_ViewImports.cshtml"
using appli_gest_assoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\_ViewImports.cshtml"
using appli_gest_assoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f6d76cf595283b999caf01377c157042057500", @"/Views/Associations/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e774f7543d1cce8ed40ebd0f3e22cbd242eae720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Associations_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<appli_gest_assoc.Models.Association>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Suppression</h1>

<h3 class=""text-center"">Supprimer association</h3>
<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading text-center""><h3 class=""panel-title"">Supprimer une association</h3></div>
            <div class=""panel-body"">

                <div class=""form-group"">
                    <label class=""col-md-2 control-label"" for=""email"">Nom association</label>
                    <div class=""col-md-10"">
                        <input");
            BeginWriteAttribute("value", " value=\"", 624, "\"", 653, 1);
#nullable restore
#line 19 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
WriteAttributeValue("", 632, Model.NomAssociation, 632, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" readonly>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""col-md-2 control-label"" for=""email"">Année de création</label>
                    <div class=""col-md-10"">
                        <input");
            BeginWriteAttribute("value", " value=\"", 947, "\"", 975, 1);
#nullable restore
#line 25 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
WriteAttributeValue("", 955, Model.AnneeCreation, 955, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" readonly>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-md-2 control-label"" for=""email"">Téléphone 1</label>
                        <div class=""col-md-10"">
                            <input");
            BeginWriteAttribute("value", " value=\"", 1256, "\"", 1275, 1);
#nullable restore
#line 30 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
WriteAttributeValue("", 1264, Model.Tel1, 1264, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" readonly>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-2 control-label"" for=""email"">Téléphone 2</label>
                            <div class=""col-md-10"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 1576, "\"", 1595, 1);
#nullable restore
#line 35 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
WriteAttributeValue("", 1584, Model.Tel2, 1584, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" readonly>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-md-2 control-label"" for=""email"">Email</label>
                                <div class=""col-md-10"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 1910, "\"", 1930, 1);
#nullable restore
#line 40 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
WriteAttributeValue("", 1918, Model.Email, 1918, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" readonly>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-md-2 control-label"" for=""email"">Adresse</label>
                                <div class=""col-md-10"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 2286, "\"", 2308, 1);
#nullable restore
#line 46 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
WriteAttributeValue("", 2294, Model.Adresse, 2294, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" readonly>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6f6d76cf595283b999caf01377c1570420575009394", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6f6d76cf595283b999caf01377c1570420575009654", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 59 "C:\Users\Ousseini\Documents\gest_assoc-master\appli_gest_assoc\Views\Associations\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAssociation);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <input type=\"submit\" value=\"Supprimer\" class=\"btn btn-danger\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<appli_gest_assoc.Models.Association> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591