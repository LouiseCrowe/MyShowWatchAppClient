#pragma checksum "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ee837404f4fa77c763c948d8bf24378c6e1e371"
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
#line 2 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ShowOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All shows I\'m tracking</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Here\'s a list of all your shows!</p>");
#nullable restore
#line 10 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
 if (shows == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Title</th>\r\n                <th>Show Type</th>\r\n                <th>Where it\'s at</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
             foreach (var show in shows)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 29 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
                         show.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
                         show.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
                         show.ShowType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Pages\ShowOverview.razor"
       


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
