#pragma checksum "C:\Users\pca11\Desktop\Helperland\Helperland\Views\Serviceprovider\SPServicehistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305ef044e1325529efa3fcc974d4d57ab5dd7de9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Serviceprovider_SPServicehistory), @"mvc.1.0.view", @"/Views/Serviceprovider/SPServicehistory.cshtml")]
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
#line 1 "C:\Users\pca11\Desktop\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pca11\Desktop\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305ef044e1325529efa3fcc974d4d57ab5dd7de9", @"/Views/Serviceprovider/SPServicehistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Serviceprovider_SPServicehistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/IMAGES/up-down-sort.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/IMAGES/calendar2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/IMAGES/time.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/IMAGES/home.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pca11\Desktop\Helperland\Helperland\Views\Serviceprovider\SPServicehistory.cshtml"
  
    ViewData["Title"] = "SPServicehistory";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--row-table code start-->
    <div class=""container-fluid row d-none"" id=""sp-servicehistory"">
      
        <div class=""col"">
            <div class="" container-fluid d-flex justify-content-between"">
                <div class=""d-flex payment-status"">
                    <span class=""sh-heading"">Payment Status</span><select>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305ef044e1325529efa3fcc974d4d57ab5dd7de95334", async() => {
                WriteLiteral("All");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</select>
                </div>
                <div>
                    <input class=""service-history-export-btn""  type=""button"" value=""Export"" onclick=""ExportToExcel('xlsx')"">
                </div>
            </div>
            <table id=""service-history-table"" class=""table table-hover"">
                <thead>
                    <tr>
                        <th width=""33%""> Service ID ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "305ef044e1325529efa3fcc974d4d57ab5dd7de97016", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</th>
                        <th width=""33%"">  Service date </th>
                        <th width=""33%""> Customer details</th>

                    </tr>
                </thead>
                <tbody>
                    <!--1st row start-->
                    <tr>
                        <td>
                            323436
                        </td>
                        <td>
                            <p class=""date"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "305ef044e1325529efa3fcc974d4d57ab5dd7de98536", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" 09/04/2018\r\n                            </p>\r\n                            <p>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "305ef044e1325529efa3fcc974d4d57ab5dd7de99681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 12:00 - 18:00
                            </p>
                        </td>
                        <td>
                            <p>
                                David Bough
                            </p>
                            <p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "305ef044e1325529efa3fcc974d4d57ab5dd7de910997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" Musterstrabe 5,12345 Bonn
                            </p>
                        </td>
                    </tr>

                </tbody>
            </table>
        </div>
    </div>
<!--row-table code end-->
<!-- row details modal code start-->
<input class=""row-detail-hidden-input d-none"" data-target=""#service-history-row-detail-modal"""" data-toggle=""modal"" type=""button"" id=""service-history-row-detail-modal-open-button"">
<div class=""modal fade"" id=""service-history-row-detail-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModal2Label"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""margin-top:16px;"">
                <h5 class=""modal-title service-detail-body "" id=""exampleModal2Label"">Service Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>");
            WriteLiteral(@"
                </button>
            </div>
            <div class=""modal-body"">
                <div class="" d-flex service-detail-leftside"" style=""width:100%"">
                    <div style=""width:50%"">
                        <p class=""date-time-duration"" id=""servicehistoryDateTime"">05/10/2021 8:00-11:30</p>
                        <p><b>Duration:</b><span id=""servicehistoryDuration""> 3.5 Hrs</span></p>
                        <hr />
                        <p><b>Service Id:</b><span id=""servicehistoryId"">8425</span></p>
                        <p id=""serviceExtra""><b>Extras:</b> Inside cabinets</p>
                        <p id=""serviceExtra1"" class=""d-none""><b>Extras:</b> Inside cabinets</p>
                        <p id=""serviceExtra2"" class=""d-none""><b>Extras:</b> Inside fridge</p>
                        <p id=""serviceExtra3"" class=""d-none""><b>Extras:</b> Inside oven</p>
                        <p id=""serviceExtra4"" class=""d-none""><b>Extras:</b> Laundry Wash & Dry</p>
               ");
            WriteLiteral(@"         <p id=""serviceExtra5"" class=""d-none""><b>Extras:</b> interior Windows</p>
                        <p><b>Total Payment:</b> <span class=""total-payment"" id=""history-total-payment"">87,50 &euro;</span></p>
                        <hr />
                        <p><b>Customer Name:</b><span id=""servicehistoryname"">Gaurang patel</span> </p>
                        <p><b>Service Address:</b><span id=""servicehistoryAddress"">Monghibai Road Vile Parle</span> </p>

                        <p><b>Distance: </b><span id=""nservicehistoryDistance"">45km</span></p>

                        <hr />
                        <p><b>Comments</b></p>
                        <p>
                            I don't have pets at home
                        </p>
                        <hr />
                        <div id=""upcoming-service-request-modal-btns-div"">
                            <button class=""btn service-history-ok-btn"" data-dismiss=""modal"" type=""button""><span class=""glyphicon glyphicon-ok""></span>O");
            WriteLiteral(@"k</button>
                        </div>

                    </div>
                    <div style=""width:50%"">
                        <iframe width=""233"" height=""400"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""
                                src=""https://www.openstreetmap.org/export/embed.html?bbox=72.48727798461915%2C23.032188951217627%2C72.52744674682619%2C23.05979267762741&amp;layer=mapnik""></iframe>
                        <br />
                        <small><a href=""https://www.openstreetmap.org/#map=15/23.0460/72.5074"">View Larger Map</a></small>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- row details modal code end-->
");
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
