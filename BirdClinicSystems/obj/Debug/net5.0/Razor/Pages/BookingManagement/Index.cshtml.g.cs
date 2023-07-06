#pragma checksum "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130e065b7e80f9223d2b979f51a0b81dabffd086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BirdClinicSystems.Pages.BookingManagement.Pages_BookingManagement_Index), @"mvc.1.0.razor-page", @"/Pages/BookingManagement/Index.cshtml")]
namespace BirdClinicSystems.Pages.BookingManagement
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
#line 1 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\_ViewImports.cshtml"
using BirdClinicSystems;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130e065b7e80f9223d2b979f51a0b81dabffd086", @"/Pages/BookingManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e822a900075d90ab8bd94866f8c418a1353eb870", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_BookingManagement_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"site-section bg-light\">\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "130e065b7e80f9223d2b979f51a0b81dabffd0863387", async() => {
                WriteLiteral("Create Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </p>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mx-auto text-center mb-5 section-heading"">
                <h2 class=""mt-3 mb-5"">List Booking</h2>
            </div>
        </div>
        <div class=""row"">

");
#nullable restore
#line 17 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"
             foreach (var item in Model.BookingList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6 col-lg-4   mb-5"">
                    <div class=""card"" style=""width:300px"">
                        <img class=""card-img-top"" style=""height:200px; width:300px"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h2 class="" mt-1 mb-1 text-center card-title"">  ");
#nullable restore
#line 24 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"
                                                                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                            <p class=\"card-text\">Down Payment: ");
#nullable restore
#line 26 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"
                                                          Write(item.DownPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">Time Start: ");
#nullable restore
#line 27 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"
                                                        Write(item.TimeStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">Height: ");
#nullable restore
#line 28 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"
                                                    Write(item.TotalPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">UserID: ");
#nullable restore
#line 29 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"
                                                    Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\BookingManagement\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BirdClinicSystems.Pages.BookingManagement.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BirdClinicSystems.Pages.BookingManagement.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BirdClinicSystems.Pages.BookingManagement.IndexModel>)PageContext?.ViewData;
        public BirdClinicSystems.Pages.BookingManagement.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
