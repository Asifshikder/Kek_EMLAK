#pragma checksum "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96437d2f297bb7e69ae496913d982ef70cdc80d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserProfile), @"mvc.1.0.view", @"/Views/User/UserProfile.cshtml")]
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
#line 1 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\_ViewImports.cshtml"
using KEK_Emlak.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\_ViewImports.cshtml"
using KEK_Emlak.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96437d2f297bb7e69ae496913d982ef70cdc80d1", @"/Views/User/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f35c7e58179fa20a3e23e9a0105645c5ee1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KEK_Emlak.Web.Models.UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Human.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("340"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:19px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
  
    ViewData["Title"] = "UserProfile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div style=""padding:10px"">
            <div style=""background-color:#f1f1f1;border-radius:15px"">
                <div style=""padding:20px"">
                    <div class=""text-left"">
                        <h4>");
#nullable restore
#line 13 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    </div>
                    <div style=""background-color:#ffdae7;border-radius:15px"">
                        <div style=""padding:10px"">
                            <div class=""row"">

                                <div class=""col-md-6"">
");
#nullable restore
#line 20 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                     if (Model.UserImage == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96437d2f297bb7e69ae496913d982ef70cdc80d15973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 1084, "\"", 1119, 1);
#nullable restore
#line 27 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
WriteAttributeValue("", 1090, Url.Content(Model.UserImage), 1090, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"340\" />\r\n");
#nullable restore
#line 28 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <div>\r\n                                        <p>??sim Soyisim   : ");
#nullable restore
#line 33 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Email        : ");
#nullable restore
#line 34 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Telefon Numaras?? : ");
#nullable restore
#line 35 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                         Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Adres      : ");
#nullable restore
#line 36 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Kullan??c?? Detay      : ");
#nullable restore
#line 37 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                             Write(Model.UserTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 47 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
     if (Model.UserTypeId == 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-12"" style=""background-color:#d4d4d4;border-radius:10px"">
            <div style=""padding:10px"">
                <div class=""card-title"" style=""margin-top:10px"">
                    <h5>Emlaklar</h5>
                    <hr />
                </div>
                <div style=""background-color:#dafbeb;border-radius:10px; padding:15px"">
                    <div style=""margin:10px"">
                        <div class=""row"">
");
#nullable restore
#line 58 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                             foreach (var item in Model.Product)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-3"">
                                    <div style=""background-color:#e9d4d4;border-color:#000000;border-radius:10px;margin:10px"">
                                        <div style=""padding:10px"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2876, "\"", 2918, 2);
            WriteAttributeValue("", 2883, "/Product/Details?id=", 2883, 20, true);
#nullable restore
#line 63 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
WriteAttributeValue("", 2903, item.ProductId, 2903, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div>\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 3033, "\"", 3070, 1);
#nullable restore
#line 65 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
WriteAttributeValue("", 3039, Url.Content(item.DisplayImage), 3039, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"150\" width=\"200\" style=\"border-radius:19px\" />\r\n                                                </div>\r\n                                                <div><h6 class=\"text-dark\">");
#nullable restore
#line 67 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\r\n                                                <div><p class=\"text-danger\">???");
#nullable restore
#line 68 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                                            </a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 73 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                             if (Model.Product.Count == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-12"">
                                    <div class=""text-center"" style=""padding:10px"">
                                        <p class=""text-danger"">??r??n Bulunamad??</p>
                                    </div>
                                </div>
");
#nullable restore
#line 81 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 89 "C:\Users\Kubilay\Desktop\KEK_Emlak\KEK_Emlak\KEK_Emlak.Web\Views\User\UserProfile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KEK_Emlak.Web.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
