#pragma checksum "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6604e2902fae8284cbc79d05641d845b6c8f773"
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
    public partial class FilterMoviesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row p-5 bg-warning m-2");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-2");
            __builder.AddMarkupContent(6, "<label for=\"MovieTitle\" class=\"sr-only\">Nombre Pelicula</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "MovieTitle");
            __builder.AddAttribute(11, "placeholder", "Buscar Pelicula");
            __builder.AddAttribute(12, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 9 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                                                   (KeyboardEventArgs e) =>
                MovieNameKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                             MovieTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MovieTitle = __value, MovieTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddMarkupContent(18, "<label for=\"CategorySelected\" class=\"sr-only\">Categoria</label>\r\n        ");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "id", "CategorySelected");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                                  CategorySelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CategorySelected = __value, CategorySelected));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "0");
            __builder.AddContent(26, "Seleccione una categoria");
            __builder.CloseElement();
#nullable restore
#line 18 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
             foreach (var item in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 20 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                               item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, 
#nullable restore
#line 20 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                        item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-inline");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "checkbox");
            __builder.AddAttribute(37, "class", "form-check-input");
            __builder.AddAttribute(38, "id", "estrenos");
            __builder.AddAttribute(39, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                                                 FuturosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FuturosEstrenos = __value, FuturosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddMarkupContent(42, "<label for=\"estrenos\" class=\"form-check-label\">Futuros Estrenos</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "checkbox");
            __builder.AddAttribute(48, "class", "form-check-input");
            __builder.AddAttribute(49, "id", "cartelera");
            __builder.AddAttribute(50, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                                                  EnCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EnCartelera = __value, EnCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.AddMarkupContent(53, "<label for=\"cartelera\" class=\"form-check-label\">En Cartelera</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "checkbox");
            __builder.AddAttribute(59, "class", "form-check-input");
            __builder.AddAttribute(60, "id", "mejorCalificadas");
            __builder.AddAttribute(61, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                                                         MejorCalificadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MejorCalificadas = __value, MejorCalificadas));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.AddMarkupContent(64, "<label for=\"mejorcalificadas\" class=\"form-check-label\">Mejor Calificadas</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "d-grid gap-2 d-md-flex justify-content-center");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                                CargarNuevasPeliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "Filtrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-danger");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                               LimpiarCampos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Limpiar Campos");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.OpenComponent<CrAgPeliculas.App.Client.Components.MoviesComponents.PostersMoviesComponent>(80);
            __builder.AddAttribute(81, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<CrAgPeliculas.App.Shared.Entity.Movie>>(
#nullable restore
#line 47 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "IsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
                                                 IsAdmin

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
      

    [Parameter] public bool IsAdmin {get;set;}

    public List<Movie> Movies;


    string MovieTitle = "";
    string CategorySelected = "";
    private bool FuturosEstrenos = false;
    private bool EnCartelera = false;
    private bool MejorCalificadas = false;


    //No hay una lista verdadera conectada con este sevicio....................
    private List<Category> Categories = new List<Category>();
    //--------------------------------------------------------------------------

    private void MovieNameKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            CargarNuevasPeliculas();
        }
    }

    private void CargarNuevasPeliculas()
    {
        Movies = Movies.Where(m => m.Title.ToLower().Contains(MovieTitle.ToLower())).ToList();
    }

    private void LimpiarCampos()
    {
        Movies = new List<Movie>();
        MovieTitle = "";
        CategorySelected = "0";
        FuturosEstrenos = false;
        EnCartelera = false;
        MejorCalificadas = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositories repository { get; set; }
    }
}
#pragma warning restore 1591
