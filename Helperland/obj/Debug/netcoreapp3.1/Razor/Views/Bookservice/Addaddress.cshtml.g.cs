#pragma checksum "C:\Users\pca11\Desktop\Helperland\Helperland\Views\Bookservice\Addaddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4494944cbbf28bc95d1e2abf777d0f7f200123e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookservice_Addaddress), @"mvc.1.0.view", @"/Views/Bookservice/Addaddress.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4494944cbbf28bc95d1e2abf777d0f7f200123e8", @"/Views/Bookservice/Addaddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookservice_Addaddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cap.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("address-detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pca11\Desktop\Helperland\Helperland\Views\Bookservice\Addaddress.cshtml"
  
    ViewData["Title"] = "Addaddress";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""tab-pane fade"" id=""contact-classic-orange"" role=""tabpanel"" aria-labelledby=""contact-tab-classic-orange"">
        <div class=""your-details"" style=""width:108%;"">
            <p><strong> your contact details,so we can serve you in better way!</strong></p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4494944cbbf28bc95d1e2abf777d0f7f200123e84983", async() => {
                WriteLiteral("\r\n                <div id=\"addresslist\">\r\n                    <div class=\"address d-flex  align-items-center\">\r\n                        <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 516, "\"", 521, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""address"" />
                        <p style=""margin-left:12px; margin-top: 10px; margin-bottom: 10px;""><b>Address:</b>karnavati 112, tamoz-Dirthwz 99097<br>Phone number: 9955648797</p>
                    </div>
                    <div class=""address d-flex align-items-center"">
                        <input type=""radio""");
                BeginWriteAttribute("id", " id=\"", 857, "\"", 862, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""address"" />
                        <p style=""margin-left:12px; margin-top: 10px; margin-bottom: 10px;""><b>Address:</b>karnavati 112, tamoz-Dirthwz 99097<br>Phone number: 9955648797</p>
                    </div>
                </div>
                <button type=""button"" class=""btn add-btn "" id=""add-address-new-address-button"">+ Add New Address</button>
                <!--address box code start-->
                <div class=""add-address-box d-none"" id=""add-adress-box"">
                    <div class=""addAddress-error d-none alert alert-danger"" role=""alert"">

                    </div>
                    <div class=""address-taker-box d-flex"" style=""width:100%;"">
                        <div style=""width:45%;"">
                            <label for=""streetname"">
                                Street name
                            </label>
                            <br>
                            <input type=""text"" name=""streetname"" placeholder=""Street name"" id=""streetname""/>
 ");
                WriteLiteral(@"                       </div>
                        <div style=""width:45%;"">
                            <label for=""housename"">
                                House number
                            </label>
                            <br>

                            <input type=""text"" name=""housename"" placeholder=""House name"" id=""housename""/>
                        </div>
                    </div>
                    <div class=""address-taker-box d-flex"" style=""width:100%;"">
                        <div style=""width:45%;"">
                            <label for=""postalcode"">
                                Postal code
                            </label>
                            <br>
                            <input disabled type=""text"" name=""postalcode"" placeholder=""Postal code"" id=""postalcode""/>

                        </div>
                        <div style=""width:45%;"">
                            <label for=""city"">
                                City
             ");
                WriteLiteral(@"               </label>
                            <br>
                            <input type=""text"" name=""city"" placeholder=""City"" id=""city""/>
                        </div>
                    </div>
                    <div class=""address-taker-box tel d-flex"" style=""width:50%;"">
                        <div style=""width:90%"">
                            <label for=""phonenumber"">
                                Phone number
                            </label>
                            <br>
                            <div class=""tel-box"">
                                <span class=""tel-icon"">
                                    +49
                                </span>
                                <input type=""tel"" name=""phonenumber"" placeholder=""Phone number"" id=""phonenumber""/>
                            </div>
                        </div>

                    </div>
                    <div class=""Button"">
                        <button class=""save-btn"" type=""button"" ");
                WriteLiteral(@"onclick=""AddAddress()"" id=""add-address-save-btn"">Save</button>
                        <button class=""clear-btn"" type=""reset"" onclick=""clearAddress()"" id=""add-address-cancel-btn"">Cancel</button>
                    </div>
                </div>
                <!--address box code end-->




                <p><strong> Favorite Service Providers</strong></p>
                <hr style=""margin-top: 0%; margin-bottom: 8px;"">
                <p>you can choose your favorite service provider from the below list.</p>
                <div class=""rounded-circle d-flex  align-items-center cap-icon"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4494944cbbf28bc95d1e2abf777d0f7f200123e89967", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <p style=\"font-weight: lighter;\">Sandip Patel</p>\r\n                <button type=\"button\" class=\"btn select-btn \"><a");
                BeginWriteAttribute("href", " href=\"", 4762, "\"", 4769, 0);
                EndWriteAttribute();
                WriteLiteral(">Select</a></button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <hr>\r\n            <button type=\"button\" class=\"btn continue-btn \" id=\"add-address-continue\">Continue</button>\r\n\r\n        </div>\r\n    </div>");
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