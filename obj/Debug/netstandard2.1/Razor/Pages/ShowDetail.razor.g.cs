#pragma checksum "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ec10162d1138130f25a4fe2b1ab41a2648a507"
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
#line 2 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/showdetail/{Title}")]
    public partial class ShowDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
 if (SelectedShow.ShowType == ShowType.Movie)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                            SelectedShow.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " - Movie");
            __builder.CloseElement();
#nullable restore
#line 10 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
 if (SelectedShow.ShowType == ShowType.TVShow)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "class", "page-title");
            __builder.AddContent(6, 
#nullable restore
#line 14 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                            SelectedShow.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " - TV Show");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
 if (SelectedShow.ShowType == ShowType.Documentary)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "h1");
            __builder.AddAttribute(9, "class", "page-title");
            __builder.AddContent(10, 
#nullable restore
#line 19 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                            SelectedShow.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " - Documentary");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group row");
            __builder.AddMarkupContent(14, "<label class=\"col-6 col-sm-3 col-form-label\">Watched already?</label>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col");
#nullable restore
#line 25 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
         if (SelectedShow.WatchStatus == WatchStatus.Watched)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<label type=\"text\" readonly class=\"form-control-plaintext\">Watched</label>");
#nullable restore
#line 28 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }
        else if (SelectedShow.WatchStatus == WatchStatus.Watching)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<label type=\"text\" readonly class=\"form-control-plaintext\">Watching</label>");
#nullable restore
#line 32 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<label type=\"text\" readonly class=\"form-control-plaintext\">Not watched</label>");
#nullable restore
#line 36 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group row");
            __builder.AddMarkupContent(23, "<label class=\"col-6 col-sm-3 col-form-label\">Is show available?</label>\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col");
#nullable restore
#line 45 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
         if (SelectedShow.Availability == Availability.Available)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>");
#nullable restore
#line 48 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }
        else if (SelectedShow.Availability == Availability.AwaitingRelease)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
             if (SelectedShow.ReleaseDate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "label");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "readonly", true);
            __builder.AddAttribute(30, "class", "form-control-plaintext");
            __builder.AddMarkupContent(31, "\r\n                    Not yet, release date is ");
            __builder.AddContent(32, 
#nullable restore
#line 54 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                              SelectedShow.ReleaseDate.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 56 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<label type=\"text\" readonly class=\"form-control-plaintext\">\r\n                    Awaiting release date\r\n                </label>");
#nullable restore
#line 62 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<label type=\"text\" readonly class=\"form-control-plaintext\">\r\n                No further releases planned\r\n            </label>");
#nullable restore
#line 69 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group row");
            __builder.AddMarkupContent(38, "<label class=\"col-6 col-sm-3 col-form-label\">Is show still running?</label>\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col");
#nullable restore
#line 77 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
         if (SelectedShow.RunningStatus == RunningStatus.Ongoing)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>");
#nullable restore
#line 80 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>");
#nullable restore
#line 84 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
 if (SelectedShow.ShowType == ShowType.TVShow || SelectedShow.ShowType == ShowType.Documentary)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group row");
            __builder.AddMarkupContent(45, "<label class=\"col-6 col-sm-3 col-form-label\">Number of seasons:</label>\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col");
            __builder.OpenElement(48, "label");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "readonly", true);
            __builder.AddAttribute(51, "class", "form-control-plaintext");
            __builder.AddContent(52, 
#nullable restore
#line 94 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                                                        SelectedShow.NumSeasonsConfirmed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group row");
            __builder.AddMarkupContent(55, "<label class=\"col-6 col-sm-3 col-form-label\">Latest season available:</label>\r\n        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col");
            __builder.OpenElement(58, "label");
            __builder.AddAttribute(59, "type", "text");
            __builder.AddAttribute(60, "readonly", true);
            __builder.AddAttribute(61, "class", "form-control-plaintext");
            __builder.AddContent(62, 
#nullable restore
#line 102 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                                                        SelectedShow.LatestSeasonAvailable

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group row");
            __builder.AddMarkupContent(65, "<label class=\"col-6 col-sm-3 col-form-label\">Episodes per season:</label>\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col");
            __builder.OpenElement(68, "label");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "readonly", true);
            __builder.AddAttribute(71, "class", "form-control-plaintext");
            __builder.AddContent(72, 
#nullable restore
#line 109 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                                                        SelectedShow.NumEpisodes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 112 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
 if (SelectedShow.ShowType == ShowType.Movie)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group row");
            __builder.AddMarkupContent(75, "<label class=\"col-6 col-sm-3 col-form-label\">Number of movies:</label>\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "readonly", true);
            __builder.AddAttribute(81, "class", "form-control-plaintext");
            __builder.AddContent(82, 
#nullable restore
#line 120 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                                                        SelectedShow.NumMovies

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group row");
            __builder.AddMarkupContent(85, "<label class=\"col-6 col-sm-3 col-form-label\">Latest movie available:</label>\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col");
            __builder.OpenElement(88, "label");
            __builder.AddAttribute(89, "type", "text");
            __builder.AddAttribute(90, "readonly", true);
            __builder.AddAttribute(91, "class", "form-control-plaintext");
            __builder.AddContent(92, 
#nullable restore
#line 128 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                                                        SelectedShow.LatestMovieAvailable

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group row");
            __builder.AddMarkupContent(95, "<label class=\"col-6 col-sm-3 col-form-label\">Description:</label>\r\n    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col");
            __builder.OpenElement(98, "label");
            __builder.AddAttribute(99, "type", "text");
            __builder.AddAttribute(100, "readonly", true);
            __builder.AddAttribute(101, "class", "form-control-plaintext");
            __builder.AddContent(102, 
#nullable restore
#line 136 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
                                                                    SelectedShow.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "form-group row");
            __builder.AddMarkupContent(106, "<label class=\"col-6 col-sm-3 col-form-label\">Family show?</label>\r\n    ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "col");
#nullable restore
#line 144 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
         if (SelectedShow.AgeRating == AgeRating.FamilyFriendly)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(109, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>");
#nullable restore
#line 147 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(110, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>");
#nullable restore
#line 151 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\ShowDetail.razor"
       
    [Parameter]
    public String Title { get; set; }

    public Show SelectedShow { get; set; } = new Show();

    private Show[] shows;

    private static readonly String baseURL = "https://localhost:5001/Show/";

    protected override async Task OnInitializedAsync()
    {
        shows = await Http.GetFromJsonAsync<Show[]>(baseURL + "all");

        SelectedShow = shows.FirstOrDefault(s => s.Title.ToLower() == Title.ToLower());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
