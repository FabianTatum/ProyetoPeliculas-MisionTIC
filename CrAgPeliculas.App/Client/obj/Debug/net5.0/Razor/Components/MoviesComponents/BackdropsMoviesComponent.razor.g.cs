#pragma checksum "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ce2e77988dc7b530d8f6c4c3bf8c151483e9fc"
// <auto-generated/>
#pragma warning disable 1591
namespace CrAgPeliculas.App.Client.Components.MoviesComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.MoviesComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.StaffComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.AdminComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.CategoryComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class BackdropsMoviesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
 if (Movies == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Cargando...</h1>");
#nullable restore
#line 4 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "carouselExampleCaptions");
            __builder.AddAttribute(3, "class", "col-lg-8 my-2 carousel slide bg-black");
            __builder.AddAttribute(4, "data-bs-ride", "carousel");
            __builder.AddMarkupContent(5, @"<div class=""carousel-indicators""><button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button></div>

      ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "carousel-inner");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "carousel-item active");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 20 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                    Movies[0].Backdrop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "d-none d-lg-block w-100 rounded mx-auto");
            __builder.AddAttribute(13, "alt", 
#nullable restore
#line 20 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                                                                                            Movies[0].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n          ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 21 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                    Movies[0].Backdrop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "d-md-block d-lg-none w-100 rounded mx-auto");
            __builder.AddAttribute(18, "alt", 
#nullable restore
#line 21 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                                                                                               Movies[0].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n          ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "carousel-caption d-none d-md-block");
            __builder.OpenElement(22, "h5");
            __builder.AddAttribute(23, "class", "fs-1");
            __builder.AddContent(24, 
#nullable restore
#line 23 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                              Movies[0].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, 
#nullable restore
#line 24 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                Movies[0].Score.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "carousel-item");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", 
#nullable restore
#line 28 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                     Movies[1].Backdrop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "d-none d-lg-block w-100 rounded mx-auto");
            __builder.AddAttribute(34, "alt", 
#nullable restore
#line 28 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                                                                                              Movies[1].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n          ");
            __builder.OpenElement(36, "img");
            __builder.AddAttribute(37, "src", 
#nullable restore
#line 29 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                     Movies[1].Backdrop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "class", "d-md-block d-lg-none w-100 rounded mx-auto");
            __builder.AddAttribute(39, "alt", 
#nullable restore
#line 29 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                                                                                                 Movies[1].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n          ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "carousel-caption d-none d-md-block");
            __builder.OpenElement(43, "h5");
            __builder.AddAttribute(44, "class", "fs-1");
            __builder.AddContent(45, 
#nullable restore
#line 31 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                              Movies[1].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, 
#nullable restore
#line 32 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                Movies[1].Score.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "carousel-item");
            __builder.OpenElement(52, "img");
            __builder.AddAttribute(53, "src", 
#nullable restore
#line 36 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                     Movies[2].Backdrop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "class", "d-none d-lg-block w-100 rounded mx-auto");
            __builder.AddAttribute(55, "alt", 
#nullable restore
#line 36 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                                                                                               Movies[2].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n          ");
            __builder.OpenElement(57, "img");
            __builder.AddAttribute(58, "src", 
#nullable restore
#line 37 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                     Movies[2].Backdrop

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(59, "class", "d-md-block d-lg-none w-100 rounded mx-auto");
            __builder.AddAttribute(60, "alt", 
#nullable restore
#line 37 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                                                                                                  Movies[2].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n          ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "carousel-caption d-none d-md-block");
            __builder.OpenElement(64, "h5");
            __builder.AddAttribute(65, "class", "fs-1");
            __builder.AddContent(66, 
#nullable restore
#line 39 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                              Movies[2].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "p");
            __builder.AddContent(69, 
#nullable restore
#line 40 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
                Movies[2].Score.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n      ");
            __builder.AddMarkupContent(71, "<button class=\"carousel-control-prev\" type=\"button\" data-bs-target=\"#carouselExampleCaptions\" data-bs-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n        <span class=\"visually-hidden\">Previous</span></button>\r\n      ");
            __builder.AddMarkupContent(72, "<button class=\"carousel-control-next\" type=\"button\" data-bs-target=\"#carouselExampleCaptions\" data-bs-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n        <span class=\"visually-hidden\">Next</span></button>");
            __builder.CloseElement();
#nullable restore
#line 54 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\BackdropsMoviesComponent.razor"
       

  [Parameter] public List<Movie> Movies { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
