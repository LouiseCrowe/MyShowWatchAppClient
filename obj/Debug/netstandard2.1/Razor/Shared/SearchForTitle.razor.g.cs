#pragma checksum "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1286cee3abd24b8cfcd9c31ba04de644744e985"
// <auto-generated/>
#pragma warning disable 1591
namespace MyShowWatch.Client.Shared
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
#line 1 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class SearchForTitle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "input-group");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "input", true);
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "Search by title");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                                             Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "input-group-append");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                  Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
 if (found)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "h1");
            __builder.AddAttribute(17, "class", "page-title");
            __builder.AddContent(18, "Details for ");
            __builder.AddContent(19, 
#nullable restore
#line 17 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                        searchResult.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group row");
            __builder.AddMarkupContent(23, "<label class=\"col-sm-4 col-form-label\">Type of Show:</label>\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-sm-8");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "readonly", true);
            __builder.AddAttribute(29, "class", "form-control-plaintext");
            __builder.AddContent(30, 
#nullable restore
#line 21 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                        searchResult.ShowType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group row");
            __builder.AddMarkupContent(33, "<label class=\"col-sm-4 col-form-label\">Is this show available?</label>\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-sm-8");
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "readonly", true);
            __builder.AddAttribute(39, "class", "form-control-plaintext");
            __builder.AddContent(40, 
#nullable restore
#line 28 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                        searchResult.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group row");
            __builder.AddMarkupContent(44, "<label class=\"col-sm-4 col-form-label\">Watched already?</label>\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-sm-8");
#nullable restore
#line 34 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
             if (searchResult.IsWatched)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<label type=\"text\" readonly class=\"form-control-plaintext\">You\'ve seen this one!</label>");
#nullable restore
#line 37 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "<label type=\"text\" readonly class=\"form-control-plaintext\">You\'ve still got this to look forward to!</label>");
#nullable restore
#line 41 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group row");
            __builder.AddMarkupContent(52, "<label class=\"col-sm-4 col-form-label\">Release Date:</label>\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-sm-8");
#nullable restore
#line 47 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
             if (searchResult.ReleaseDate == null && searchResult.Status == Status.NoReleaseDate)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<label type=\"text\" readonly class=\"form-control-plaintext\">Still waiting for the release date!</label>");
#nullable restore
#line 50 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "label");
            __builder.AddAttribute(57, "type", "text");
            __builder.AddAttribute(58, "readonly", true);
            __builder.AddAttribute(59, "class", "form-control-plaintext");
            __builder.AddContent(60, 
#nullable restore
#line 53 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                            searchResult.ReleaseDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 54 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group row");
            __builder.AddMarkupContent(63, "<label class=\"col-sm-4 col-form-label\">For the kids too?</label>\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-sm-8");
#nullable restore
#line 62 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
             if (searchResult.IsKidFriendly)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>");
#nullable restore
#line 65 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>");
#nullable restore
#line 69 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group row");
            __builder.AddMarkupContent(70, "<label class=\"col-sm-4 col-form-label\">Number of seasons:</label>\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col-sm-8");
            __builder.OpenElement(73, "label");
            __builder.AddAttribute(74, "type", "text");
            __builder.AddAttribute(75, "readonly", true);
            __builder.AddAttribute(76, "class", "form-control-plaintext");
            __builder.AddContent(77, 
#nullable restore
#line 76 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                        searchResult.NumSeasonsConfirmed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group row");
            __builder.AddMarkupContent(81, "<label class=\"col-sm-4 col-form-label\">Latest season available:</label>\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-sm-8");
            __builder.OpenElement(84, "label");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "readonly", true);
            __builder.AddAttribute(87, "class", "form-control-plaintext");
            __builder.AddContent(88, 
#nullable restore
#line 82 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                        searchResult.LatestSeasonAvailable

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "form-group row");
            __builder.AddMarkupContent(92, "<label class=\"col-sm-4 col-form-label\">Number of Episodes:</label>\r\n        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-sm-8");
            __builder.OpenElement(95, "label");
            __builder.AddAttribute(96, "type", "text");
            __builder.AddAttribute(97, "readonly", true);
            __builder.AddAttribute(98, "class", "form-control-plaintext");
            __builder.AddContent(99, 
#nullable restore
#line 88 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                        searchResult.NumEpisodes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group row");
            __builder.AddMarkupContent(102, "<label class=\"col-sm-4 col-form-label\">Description:</label>\r\n        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-sm-8");
            __builder.OpenElement(105, "label");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "readonly", true);
            __builder.AddAttribute(108, "class", "form-control-plaintext");
            __builder.AddContent(109, 
#nullable restore
#line 95 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
                                                                        searchResult.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 98 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, 
#nullable restore
#line 100 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
 errormessage

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\BLAZOR\CA3MyShowWatch\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
      

    private static readonly String baseURL = "https://localhost:5001/Show/Search/";


    [Parameter]
    public String Title { get; set; }

    private Show searchResult;

    private bool found;

    private string errormessage;


    public async Task Search()
    {
        try
        {
            searchResult = await Http.GetFromJsonAsync<Show>($"{baseURL}{Title}");

            found = true;
            errormessage = String.Empty;
        }
        catch (Exception e)
        {
            found = false;
            errormessage = e.Message;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
