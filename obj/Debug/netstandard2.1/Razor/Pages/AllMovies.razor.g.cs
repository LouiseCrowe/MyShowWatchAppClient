#pragma checksum "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db5452cd33e25b85f2923fe06281efc79bf8e60"
// <auto-generated/>
#pragma warning disable 1591
namespace MyShowWatch.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allmovies")]
    public partial class AllMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenComponent<MyShowWatch.Client.Shared.SearchForTitle>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(4, "<h3>All movies I\'m tracking</h3>");
#nullable restore
#line 14 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
 if (movies == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Show Title</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 29 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
             foreach (var show in movies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 32 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
                         show.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", 
#nullable restore
#line 34 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
                                   $"showdetail/{show.Title}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "btn btn-info table-btn");
            __builder.AddMarkupContent(18, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\BLAZOR\CA3 - Copy\MyShowWatch\MyShowWatch\Client\Pages\AllMovies.razor"
       

    private static readonly String baseURL = "https://localhost:5001/Show/";

    private List<Show> movies;

    protected override async Task OnInitializedAsync()
    {
        movies = await Http.GetFromJsonAsync<List<Show>>(baseURL + "allmovies");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
