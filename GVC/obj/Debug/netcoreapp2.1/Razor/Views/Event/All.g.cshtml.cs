#pragma checksum "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c28d69f3872d1e673a99c0eb3cdd624515d783"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_All), @"mvc.1.0.view", @"/Views/Event/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/All.cshtml", typeof(AspNetCore.Views_Event_All))]
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
#line 1 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\_ViewImports.cshtml"
using GVC.Views;

#line default
#line hidden
#line 2 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\_ViewImports.cshtml"
using GVC.Models;

#line default
#line hidden
#line 3 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\_ViewImports.cshtml"
using GVC.Views.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c28d69f3872d1e673a99c0eb3cdd624515d783", @"/Views/Event/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395fbfedeb0237db5098cb2ff2255781a26cb6b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventViewModelcs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/All"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(70, 191, true);
            WriteLiteral("\r\n<h2>All</h2>\r\n<style>\r\n    table tbody tr:nth-child(odd) {\r\n        background: AliceBlue;\r\n    }\r\n\r\n    table tbody tr:nth-child(even) {\r\n        background: HoneyDew;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(261, 1387, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c553df346043ccbb084dcf7e3da7da", async() => {
                BeginContext(294, 524, true);
                WriteLiteral(@"

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Event Name
                </th>
                <th>
                    Odds For First Team
                </th>
                <th>
                    Odds For Draw
                </th>
                <th>
                    Odds For Second Team
                </th>
                <th>
                    Event Start Date
                </th>
            </tr>
        </thead>




");
                EndContext();
#line 43 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
         foreach (var e in Model)
        {


#line default
#line hidden
                BeginContext(866, 97, true);
                WriteLiteral("            <tbody>\r\n\r\n                <tr>\r\n\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(964, 11, false);
#line 51 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
                   Write(e.EventName);

#line default
#line hidden
                EndContext();
                BeginContext(975, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1055, 18, false);
#line 54 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
                   Write(e.OddsForFirstTeam);

#line default
#line hidden
                EndContext();
                BeginContext(1073, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1153, 13, false);
#line 57 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
                   Write(e.OddsForDraw);

#line default
#line hidden
                EndContext();
                BeginContext(1166, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1246, 19, false);
#line 60 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
                   Write(e.OddsForSecondTeam);

#line default
#line hidden
                EndContext();
                BeginContext(1265, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1345, 16, false);
#line 63 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
                   Write(e.EventStartDate);

#line default
#line hidden
                EndContext();
                BeginContext(1361, 148, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        <div>\r\n                            <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1509, "\"", 1527, 1);
#line 67 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
WriteAttributeValue("", 1517, e.EventId, 1517, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1528, 82, true);
                WriteLiteral(" />\r\n                        </div>\r\n                </tr>\r\n            </tbody>\r\n");
                EndContext();
#line 71 "C:\Users\Iv Velichkova\Source\Repos\GVC\GVC\Views\Event\All.cshtml"
        }

#line default
#line hidden
                BeginContext(1621, 20, true);
                WriteLiteral("\r\n\r\n    </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1648, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(1654, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5c0fbeae3cc4648ba40254d67f4cd06", async() => {
                BeginContext(1719, 94, true);
                WriteLiteral("\r\n\r\n\r\n    <button type=\"submit\" class=\"pure-button pure-button-primary\">Edit Mode</button>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventViewModelcs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
