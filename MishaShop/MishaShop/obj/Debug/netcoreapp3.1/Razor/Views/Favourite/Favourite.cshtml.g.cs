#pragma checksum "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ce75cf0079538f9dc65856307a439b4661dd10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favourite_Favourite), @"mvc.1.0.view", @"/Views/Favourite/Favourite.cshtml")]
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
#line 1 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\_ViewImports.cshtml"
using MishaShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ce75cf0079538f9dc65856307a439b4661dd10", @"/Views/Favourite/Favourite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658aecc9123477e88ffbbd80e4f7cff656663815", @"/Views/_ViewImports.cshtml")]
    public class Views_Favourite_Favourite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FavouriteGoods>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <style>\r\n        .outline {\r\n            border: 2px solid black;\r\n            padding: 0 10px;\r\n        }\r\n    </style>\r\n");
#nullable restore
#line 8 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
  
    ViewBag.Title = "Favourite";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("CssFile", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
 foreach (var good in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""album py-5 bg-light"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""card mb-4 shadow-sm"">
                            <img class=""bd-placeholder-img card-img-top""");
            BeginWriteAttribute("src", " src=\"", 1407, "\"", 1496, 1);
#nullable restore
#line 29 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 1413, Url.Content($"~/Catalog/CustomerImages/{good.good.FileName.Replace(".", "")}.jpg"), 1413, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\">Информация о товаре</p>\r\n                                <p class=\"card-text outline\">");
#nullable restore
#line 32 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
                                                        Write(good.good.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">размер:");
#nullable restore
#line 33 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
                                                       Write(good.good.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 34 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
                                                Write(good.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">номер продавца:");
#nullable restore
#line 35 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
                                                               Write(good.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2052, "\"", 2157, 3);
            WriteAttributeValue("", 2062, "location.href=\'", 2062, 15, true);
#nullable restore
#line 36 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 2077, Url.Action("DeleteFromFavourite", "Favourite", new {id = @good.id.ToString()}), 2077, 79, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2156, "\'", 2156, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Удалить из избранного</button>\r\n                                <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2268, "\"", 2348, 3);
            WriteAttributeValue("", 2278, "location.href=\'", 2278, 15, true);
#nullable restore
#line 37 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 2293, Url.Action("BuyPage", "Buy", new { id = good.GoodId}), 2293, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2347, "\'", 2347, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Купить</button>\r\n                                <div class=\"d-flex justify-content-between align-items-center\">\r\n                                    <small class=\"text-muted\">Цена ");
#nullable restore
#line 39 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
                                                              Write(good.good.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" р </small>\r\n                                </div>\r\n                            </div>    \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 47 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Favourite\Favourite.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FavouriteGoods>> Html { get; private set; }
    }
}
#pragma warning restore 1591
