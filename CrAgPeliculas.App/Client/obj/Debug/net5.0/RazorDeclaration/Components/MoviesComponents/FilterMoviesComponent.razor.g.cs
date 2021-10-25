// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CrAgPeliculas.App.Client.Components.MoviesComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.MoviesComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.StaffComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.AdminComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.CategoryComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class FilterMoviesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\FilterMoviesComponent.razor"
      

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
