#pragma checksum "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2588b7e2c07445d8de8eae03c2b6766e8ec0f610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Index), @"mvc.1.0.view", @"/Views/Car/Index.cshtml")]
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
#line 1 "/home/giovanni/Develop/CRUD/Views/_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/giovanni/Develop/CRUD/Views/_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2588b7e2c07445d8de8eae03c2b6766e8ec0f610", @"/Views/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd5c960da0c2a7409ff80ca277cd1104bf47573", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CRUD.Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
  
    ViewData["Title"] = "Carros Disponiveis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1> Carros Disponiveis</h1>\n\n");
#nullable restore
#line 8 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
Write(Html.ActionLink("Adicionar novo Carro","CriarCarro"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 14 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.Label("ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.Label("Marca"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.Label("Modelo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.Label("Ano"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n             <th>\n                ");
#nullable restore
#line 26 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.Label("Quilometragem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n             <th>\n                ");
#nullable restore
#line 29 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.Label("Obersevações"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n<tbody>\n\n");
#nullable restore
#line 36 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n            <td>\n                ");
#nullable restore
#line 40 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 52 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n             <td>\n            ");
#nullable restore
#line 58 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
       Write(Html.ActionLink("Apagar", "Apagar", new{id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"
           Write(Html.ActionLink("Editar","Editar", new{id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 64 "/home/giovanni/Develop/CRUD/Views/Car/Index.cshtml"

       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \n</tbody>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CRUD.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
