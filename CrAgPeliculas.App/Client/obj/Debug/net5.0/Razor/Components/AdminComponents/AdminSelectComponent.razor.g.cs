#pragma checksum "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c1260a025c881aeee7ffaba7c2fc61f423a2c3"
// <auto-generated/>
#pragma warning disable 1591
namespace CrAgPeliculas.App.Client.Components.AdminComponents
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
    public partial class AdminSelectComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "col-3 bg-warning");
#nullable restore
#line 4 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
         foreach (var item in NotSelectedList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                            () => Selected(item) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                                                    item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-3 bg-danger");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-success");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                                                  SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, 
#nullable restore
#line 11 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                                                              SelectAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-success");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                                                  DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 12 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                                                                DeselectAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "col-4 bg-warning");
#nullable restore
#line 16 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
         foreach (var item in SelectedList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                            () => NotSelected(item) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
                                                       item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminSelectComponent.razor"
      

    [Parameter] public List<MultiSelectorModel> NotSelectedList { get; set; }= new List<MultiSelectorModel>();
    [Parameter] public List<MultiSelectorModel> SelectedList { get; set; } = new List<MultiSelectorModel>();

    private string SelectAllText = ">>";
    private string DeselectAllText = "<<";

    private void Selected(MultiSelectorModel item) 
    {
        NotSelectedList.Remove(item);
        SelectedList.Add(item);
    }

    private void NotSelected(MultiSelectorModel item)
    {
        SelectedList.Remove(item);
        NotSelectedList.Add(item);
    }

    private void SelectAll()
    {
        SelectedList.AddRange(NotSelectedList);
        NotSelectedList.Clear();
    }

    private void DeselectAll()
    {
        NotSelectedList.AddRange(SelectedList);
        SelectedList.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
