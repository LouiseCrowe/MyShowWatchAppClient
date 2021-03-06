#pragma checksum "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf1608cef43332807f4a88fccdf00362a18b9215"
// <auto-generated/>
#pragma warning disable 1591
namespace MyShowWatch.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allshows")]
    public partial class AllShows : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenComponent<MyShowWatch.Client.Shared.SearchForTitle>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<br>");
#nullable restore
#line 12 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
 if (shows == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<h3>Summary info for All Shows</h3>\r\n    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Show Type</th>\r\n                <th>How Many</th></tr></thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#nullable restore
#line 29 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                               "/alltvshows"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, "TV Shows");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                     shows.Count(s => s.ShowType == ShowType.TVShow)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 35 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                               "/allmovies"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, "Movies");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                     shows.Count(s => s.ShowType == ShowType.Movie)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 41 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                               "/alldocumentaries"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, "Documentaries");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 43 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                     shows.Count(s => s.ShowType == ShowType.Documentary)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "<td>Total shows</td>\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 47 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                     shows.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "<h3>All shows I\'m tracking</h3>\r\n    ");
            __builder.OpenElement(42, "table");
            __builder.AddAttribute(43, "class", "table table-striped");
            __builder.AddMarkupContent(44, "<thead><tr><th>Show Title</th>\r\n                <th>Details</th></tr></thead>\r\n        ");
            __builder.OpenElement(45, "tbody");
#nullable restore
#line 61 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
             foreach (var show in shows)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "tr");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 65 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                         show.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "href", 
#nullable restore
#line 68 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
                                   $"showdetail/{show.Title}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(53, "class", "btn btn-info table-btn");
            __builder.AddMarkupContent(54, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\AllShows.razor"
       

    private List<Show> shows { get; set; }

    private static readonly String baseURL = "https://localhost:5001/Show/";

    protected override async Task OnInitializedAsync()
    {
        shows = await Http.GetFromJsonAsync<List<Show>>(baseURL + "all");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
