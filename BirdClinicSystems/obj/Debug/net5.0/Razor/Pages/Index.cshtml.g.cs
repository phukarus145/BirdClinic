#pragma checksum "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71725ef78ef6974022b6f344b4612e0f6a604d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BirdClinicSystems.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace BirdClinicSystems.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71725ef78ef6974022b6f344b4612e0f6a604d7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e822a900075d90ab8bd94866f8c418a1353eb870", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    * {
        box-sizing: border-box;
    }

    .clear {
        clear: both;
    }

    /* HEARDER */
    html, body {
        font-family: 'Times New Roman', Times, serif;
    }

    .header img {
        width: 250px;
    }

    .header ul {
        /* xóa dấu chấm tròn chỉnh kiểu phần danh sách  list style none mât
        circle| disc | square | decimal |lower-alpha*/
        list-style: none;
        background-color: black;
        padding: 15px 0;
        margin: 5px 0 10px;
    }

    .header a {
        text-decoration: none;
        color: white;
        font-size: 18px;
    }

    .header ul li {
        /* display inline dùng để trên 1 hàng */
        display: inline;
        margin: 0 10px;
        /* top bottom, right left: */
        /* margin: 20px;
       /* margin-top: 20px; */
        /* top bottom=10px; right, left=20; */
        /* top 10 ; 20: bottom  right, leght:15px*/
        /* margin: 10px 15px 20px; */
        /* top, right b");
            WriteLiteral(@"ottom, left; */
        /* margin: 10px 15px 20px 25px; */
    }
    /* CAROUSEL */
    .carousel {
        background-image: url(""../img/istockphoto-536877951-1024x1024.jpg"");
        background-repeat: no-repeat;
        /* height: 550px; */
        background-size: cover;
        height: 750px;
        width: 100%;
        background-position: center center;
    }

    /* InTRO */
    .intro__text {
        font-size: 20px;
        margin: 25px 0 40px;
    }

        .intro__text span {
            color: red;
            font-weight: bold;
        }

    /* .intro__left {
         float: left;
         width: 50%;
        }
        .intro__right {
          float: left;
          width: 50%;
                } */

    .intro__left, .intro__right {
        float: left;
        width: 50%;
    }

    .intro__smallItem {
        float: left;
        width: 50%;
    }

    .intro_item {
        padding: 0 20px 35px;
    }

        .intro_item img {
            w");
            WriteLiteral(@"idth: 100%;
            display: block;
        }

    .intro__item img {
        width: 100%;
        display: block;
    }



    /* PRODUCTS
    float trên 1 hàng*/
    .product {
        margin-bottom: 70px;
    }

        .product h2 {
            text-align: center;
            font-size: 30px;
        }

    .products_item {
        float: left;
        width: 25%;
        /* margin: 0 10px ; */
        padding: 0 10px;
    }

        .products_item img {
            width: 100%;
        }

        .products_item h3 {
            font-size: 25px;
        }

        .products_item p {
            font-size: 17px;
        }

        .products_item button {
            background-color: red;
            border: 1px solid red;
            color: white;
            padding: 5px 10px;
            border-radius: 5px;
            /* border-radius:  định nghĩa độ công */
            margin-top: 15px;
        }
    /* banner */
    .banner {
        background-");
            WriteLiteral(@"image: url(""../img/istockphoto-536877951-1024x1024.jpg"");
        /* background-repeat: no-repeat; */
        /* nếu dùng size cover thì ko cần dùng repaet */
        height: 500px;
        background-size: cover;
        position: relative;
    }

    .banner_circle {
        width: 300px;
        height: 300px;
        background-color: rgba(131, 41, 39, 0.8);
        color: white;
        border-radius: 50%;
        text-align: center;
        position: absolute;
        /* absoilute con */
        /* position:relative; */
        /* relative cha */
        /* top left right bottom */
        top: 20px;
        left: 320px;
        /* border-radius dung để chuyển thành hình tròn */
        /* opacity:0.8; làm mwof nó và thẻ con trong đó */
    }

        .banner_circle p {
            font-size: 20px;
            margin: 0 0 10px;
        }

            .banner_circle p:first-child {
                font-size: 30px;
                margin: 50px 0 0;
            }

      ");
            WriteLiteral(@"      .banner_circle p:nth-child(2) {
                font-size: 80px;
                margin: 0;
            }

    /* SERVICES */
    .services {
        margin: 20px 0 10px;
    }

    .service_content {
        width: 70%;
        /* 100%-70 = 30 */
        margin: auto;
        /* margin 15%
      margin 15% thụt vào mỗi bên 15 % */
        text-align: center;
    }

    .services__items {
        float: left;
        width: 33.33%;
        padding: 0 15px;
    }

        .services__items i {
            font-size: 40px;
            /* margin: 10x  0; */
        }

        .services__items h2 {
            margin: 10px 0;
        }

        .services__items p {
            margin: 0;
        }




    /* footer */

</style>
<div class=""site-wrap"">

    <div class=""carousel"" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""");
            WriteLiteral("col-md-7 text-center\" style=\"margin-top: 300px\" data-aos=\"fade\">\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

    <div class=""site-section bg-light"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 mx-auto text-center mb-5 section-heading"">
                    <h2 class=""mt-3 mb-5"">List Room</h2>
                </div>
            </div>
            <div class=""row"">

");
#nullable restore
#line 254 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\Index.cshtml"
                 foreach (var item in Model.RoomList)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-4   mb-5"">
                        <div class=""card"" style=""width:300px"">
                            <img class=""card-img-top"" style=""height:200px; width:300px"" alt=""Card image cap"">
                            <div class=""card-body"">
                                <h2 class="" mt-1 mb-1 text-center card-title"">  ");
#nullable restore
#line 261 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\Index.cshtml"
                                                                           Write(item.roomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                                <p class=\"card-text\">Price: ");
#nullable restore
#line 263 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\Index.cshtml"
                                                       Write(item.roomNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a href=\"/Booking/Shopping\" class=\"btn btn-primary\">Booking</a>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 269 "C:\Code\BirdClinicSystems\BirdClinicSystems\Pages\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""py-5 bg-light quick-contact-info"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 text-center"">
                    <div>
                        <span class=""icon-room text-white h2 d-block""></span>
                        <h2>Location</h2>
                        <p class=""mb-0"">Ho Chi Minh City <br>  10 Le Van Viet Street</p>
                    </div>
                </div>
                <div class=""col-md-4 text-center"">
                    <div>
                        <span class=""icon-clock-o text-white h2 d-block""></span>
                        <h2>Service Times</h2>
                        <p class=""mb-0"">
                          Check In  8:00AM 
                          Check Out 17:00PM
                        </p>
                    </div>
                </div>
                <div class=""col-md-4 text-center"">
                    <div>
           ");
            WriteLiteral(@"             <span class=""icon-comments text-white h2 d-block""></span>
                        <h2>Get In Touch</h2>
                        <p class=""mb-0"">
                            Email: birdclinic@yoursite.com <br>
                            Phone: (123) 456789                            
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <footer class=""border-top footer text-muted"">
        <div class=""container"">
            &copy; 2022 - Bird - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71725ef78ef6974022b6f344b4612e0f6a604d712785", async() => {
                WriteLiteral("Privacy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </footer>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
