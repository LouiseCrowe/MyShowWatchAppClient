#pragma checksum "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0382d658f9a348ab3db8b5294064add88571f04"
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
#line 1 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/alltvshows")]
    public partial class AllTvShows : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All TV Shows I\'m tracking</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Here\'s a list of all your TV Shows!</p>");
#nullable restore
#line 10 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
 if (shows == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Show Title</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
             foreach (var show in shows)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
                         show.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#nullable restore
#line 30 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
                                   $"showdetail/{show.Title}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(15, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\AllTvShows.razor"
       


    private Show[] shows;

    protected override async Task OnInitializedAsync()
    {
        shows = await Http.GetFromJsonAsync<Show[]>("Show");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
