#pragma checksum "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\About\AboutPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a780230b86a8063b6a8146a1c6649d4d32bad13c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_AboutPage), @"mvc.1.0.view", @"/Views/About/AboutPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a780230b86a8063b6a8146a1c6649d4d32bad13c", @"/Views/About/AboutPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658aecc9123477e88ffbbd80e4f7cff656663815", @"/Views/_ViewImports.cshtml")]
    public class Views_About_AboutPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\asvar\OneDrive\Документы\GitHub\MishaShop\MishaShop\MishaShop\Views\About\AboutPage.cshtml"
  
    ViewData["Title"] = "About page";

#line default
#line hidden
#nullable disable
            DefineSection("CssFile", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col"">
        </div>
        <div class=""col-xl-8 bg-secondary text-light"">
            <p></p>
            <h5>Кто мы?</h5>
            <p>Мы некоммерческая онлайн площадка, предоставляющая возможность художникам и начинающим модельерам продавать свои кастомные вещи.</p>
            <h5>Кто может выставлять свои товары на площадку?</h5>
            <p>Любой зарегистрированный пользователь.</p>
            <h5>Какие товары можно выставлять на продажу?</h5>
            <p>Любые части человеческого гардероба.</p>
            <h5>Как можно купить товар?</h5>
            <p>Мы являемся только посредником между покупателем и продавцом. С целью покупки надо обращаться на прямую к продавцу.</p>
            <h5>Где можно узнать более детальную информацию о товаре?</h5>
            <p>Все так же только у продавца.</p>

            <h2><strong>Важная информация!</strong></h2>
            <p>
                1.    Площадка не несет ");
            WriteLiteral(@"ответственности за качество или несоответствие описанию товара, но, если на продавца будет поступать слишком много жалоб, мы его заблокируем.
            </p>
            <p>
                2.    Выставленный товар может не иметься в наличии, если продавец не удалил товар.
            </p>
            <p></p>
            <h5>Контактная информация: 88005553535</h5>

        </div>
        <div class=""col"">
        </div>
    </div>
</div>");
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
