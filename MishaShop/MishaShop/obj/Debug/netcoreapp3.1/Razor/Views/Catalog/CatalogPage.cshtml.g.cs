#pragma checksum "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd2e1441e779f2ef1ed8dcbd45f72149ec9b7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_CatalogPage), @"mvc.1.0.view", @"/Views/Catalog/CatalogPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd2e1441e779f2ef1ed8dcbd45f72149ec9b7a3", @"/Views/Catalog/CatalogPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658aecc9123477e88ffbbd80e4f7cff656663815", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_CatalogPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
  
    ViewData["Title"] = "Cataloge page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .outline {\r\n        border: 2px solid black;\r\n        padding: 0 10px;\r\n    }\r\n</style>\r\n");
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
#line 21 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
  
    foreach (var item in Model.Goods)
    {
        var currentCustomer = new IdentityUser();

        foreach (var customer in Model.Users)
        {
            if(item.CustomerId == customer.Id)
            {
                currentCustomer = customer;
            }
        }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""album py-5 bg-light"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""card mb-4 shadow-sm"">
                            <img class=""bd-placeholder-img card-img-top""");
            BeginWriteAttribute("src", " src=", 1620, "", 1682, 1);
#nullable restore
#line 39 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
WriteAttributeValue("", 1625, $"CustomerImages/{item.FileName.Replace(".", "")}.jpg", 1625, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\">Информация о товаре</p>\r\n                                <p class=\"card-text outline\">");
#nullable restore
#line 42 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 43 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                                Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 44 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                                Write(currentCustomer.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 45 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                                Write(currentCustomer.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                 if (User!=null && User.IsInRole("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-danger\">Удалить</button>\r\n");
#nullable restore
#line 49 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex justify-content-between align-items-center"">
                                    <div class=""btn-group"">

                                    </div>
                                    <small class=""text-muted"">");
#nullable restore
#line 54 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\Catalog\CatalogPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
