#pragma checksum "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6154b94af6cf2cba53a13577ddf815eb923a420b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication2.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using WebApplication2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using WebApplication2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dashboard-wrapper-div");
            __builder.AddAttribute(2, "b-4c5d1eq6ma");
            __builder.AddMarkupContent(3, "<div class=\"upper-panel\" b-4c5d1eq6ma><h1 b-4c5d1eq6ma>Dashboard</h1></div>");
#nullable restore
#line 13 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
     if (!WatchlistVisible)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "searcher-tab");
            __builder.AddAttribute(6, "b-4c5d1eq6ma");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "searcher-tab__autocomplete");
            __builder.AddAttribute(9, "b-4c5d1eq6ma");
            __builder.AddMarkupContent(10, "<label b-4c5d1eq6ma>Company symbol</label>");
#nullable restore
#line 19 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                 if (ErrorOccured)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"not-found\" b-4c5d1eq6ma>Ticker not found!</div>");
#nullable restore
#line 22 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfAutoComplete<string, TickerDetailsDTO>>(12);
            __builder.AddAttribute(13, "Query", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Data.Query>(
#nullable restore
#line 23 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                 Query

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "PopupHeight", "auto");
            __builder.AddAttribute(15, "PopupWidth", "700px");
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                                                                        InputChangeHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteEvents<string, TickerDetailsDTO>>(18);
                __builder2.AddAttribute(19, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TickerDetailsDTO>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TickerDetailsDTO>>(this, 
#nullable restore
#line 24 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                              ValueChangeHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteFieldSettings>(21);
                __builder2.AddAttribute(22, "Value", "ShortCode");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(24);
                __builder2.AddAttribute(25, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                        GetUrlToSendRequestTo()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 27 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                            Syncfusion.Blazor.Adaptors.WebApiAdaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "CrossDomain", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteTemplates<TickerDetailsDTO>>(29);
                __builder2.AddAttribute(30, "ItemTemplate", (Microsoft.AspNetCore.Components.RenderFragment<TickerDetailsDTO>)((context) => (__builder3) => {
                    __builder3.OpenElement(31, "span");
                    __builder3.AddAttribute(32, "b-4c5d1eq6ma");
                    __builder3.OpenElement(33, "span");
                    __builder3.AddAttribute(34, "b-4c5d1eq6ma");
                    __builder3.AddContent(35, 
#nullable restore
#line 30 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                          (context as TickerDetailsDTO).Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.OpenElement(36, "span");
                    __builder3.AddAttribute(37, "b-4c5d1eq6ma");
                    __builder3.AddContent(38, 
#nullable restore
#line 30 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                            (context as TickerDetailsDTO).CountryCode

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                               SearchHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "b-4c5d1eq6ma");
            __builder.AddContent(43, "SEARCH");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                               WatchlistButtonClickHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "b-4c5d1eq6ma");
            __builder.AddContent(48, "WATCHLIST");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
         if (TickerDetails == null || TickerPrices == null || DailyOpenClose == null || TickerNews == null)
        {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<p b-4c5d1eq6ma> No data to load yet</p>");
#nullable restore
#line 42 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebApplication2.Client.Shared.TickerData>(50);
            __builder.AddAttribute(51, "TickerDetails", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TickerSimpleDTO>(
#nullable restore
#line 45 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                       TickerDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "TickerNews", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyList<TickerNewsDTO>>(
#nullable restore
#line 45 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                  TickerNews

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "TickerPrices", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TickerPricesDTO>(
#nullable restore
#line 45 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                            TickerPrices

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "DailyOpenClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DailyOpenCloseDTO>(
#nullable restore
#line 45 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                                                          DailyOpenClose

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 46 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                           CloseWatchlistHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "b-4c5d1eq6ma");
            __builder.AddContent(58, "Close Watchlist");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<TickerSimpleDTO>>(60);
            __builder.AddAttribute(61, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TickerSimpleDTO>>(
#nullable restore
#line 51 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                      Watchlist

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(65);
                __builder2.AddAttribute(66, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(68);
                __builder2.AddAttribute(69, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 53 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                        5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(71);
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(73);
                    __builder3.AddAttribute(74, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 55 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "HeaderText", "Logo");
                    __builder3.AddAttribute(76, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 58 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                           
                            var ticker = (context as TickerSimpleDTO);

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(77, "img");
                        __builder4.AddAttribute(78, "class", "ticker-logo-watchlist");
                        __builder4.AddAttribute(79, "src", 
#nullable restore
#line 60 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                                                     ticker.IconUrl

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(80, "alt", "No logo image provided");
                        __builder4.AddAttribute(81, "b-4c5d1eq6ma");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(83);
                    __builder3.AddAttribute(84, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                   nameof(TickerSimpleDTO.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 66 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "HeaderText", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(88);
                    __builder3.AddAttribute(89, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                   nameof(TickerSimpleDTO.Shortcode)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 70 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "HeaderText", "Short code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(93);
                    __builder3.AddAttribute(94, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                   nameof(TickerSimpleDTO.Market)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 74 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "HeaderText", "Market");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(98);
                    __builder3.AddAttribute(99, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 77 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                   nameof(TickerSimpleDTO.CountryCode)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 78 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "HeaderText", "Country Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(103);
                    __builder3.AddAttribute(104, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(105, "<button class=\"delete-row-button\" b-4c5d1eq6ma>DELETE</button>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 88 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n\r\n}\r\n\r\n\r\n");
            __builder.AddMarkupContent(107, "<style b-4c5d1eq6ma>\r\n    .upper-panel {\r\n        display: inline-flex;\r\n        gap: 5%;\r\n        padding: 20px;\r\n        width: 100%;\r\n    }\r\n\r\n    .not-found {\r\n        border: 0.2rem solid;\r\n        background-color: #f85454;\r\n        border-radius: 10px;\r\n        border-color: red;\r\n        color: red;\r\n    }\r\n\r\n    .logged-user {\r\n        margin: 10px;\r\n        border-radius: 10px;\r\n        border-color: cornflowerblue;\r\n    }\r\n\r\n    .upper-panel > h1 {\r\n        color: cornflowerblue;\r\n    }\r\n\r\n    .delete-row-button {\r\n        background-color: red;\r\n        border-radius: 7px;\r\n\r\n    }\r\n\r\n    .dashboard-wrapper-div button {\r\n        background-color: cornflowerblue;\r\n        color: white;\r\n        border: none;\r\n        width: 15%;\r\n        border-radius: 5px;\r\n        font: bolder;\r\n    }\r\n\r\n    .ticker-logo-watchlist {\r\n        width: 50px;\r\n        height: 50px\r\n    }\r\n\r\n    .dashboard-wrapper-div {\r\n        color: cornflowerblue;\r\n        font-size: 1.2rem;\r\n    }\r\n\r\n    .searcher-tab {\r\n        width: 100%;\r\n        display: inline-flex;\r\n        gap: 2%;\r\n    }\r\n\r\n    .searcher-tab__autocomplete {\r\n        width: 40%;\r\n        display: block;\r\n    }\r\n\r\n    .item-data {\r\n        display: inline-block;\r\n    }\r\n\r\n    .e-dropdownbase .e-list-item.e-item-focus, .e-dropdownbase .e-list-item.e-active, .e-dropdownbase .e-list-item.e-active.e-hover, .e-dropdownbase .e-list-item.e-hover {\r\n        color: white;\r\n        background: cornflowerblue;\r\n        font: bold;\r\n    }\r\n\r\n    .template-item-last-item {\r\n        right: 15px;\r\n        position: absolute;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\Mich\Desktop\saveapbd\s22126APBDProjekt\WebApplication2\Client\Shared\Dashboard.razor"
       
    private string TickerValue { get; set; } = "";
    private bool WatchlistVisible { get; set; } = false;
    private bool ErrorOccured { get; set; } = false;
    private string WatchlistUrl { get; set; }

    private TickerSimpleDTO TickerDetails;
    private DailyOpenCloseDTO DailyOpenClose;
    private TickerPricesDTO TickerPrices;
    private TickerNewsDTO[] TickerNews;
    private TickerSimpleDTO[] Watchlist;
    private CommonDateNotationConverter _converter = new CommonDateNotationConverter();

    public Query Query = new Query(); // new Query().Where("match", "equal", TickerValue).RequiresCount();


    private string GetUrlToSendRequestTo()
    {
        return Navigator.BaseUri + "Tickers";
    }

    private void InputChangeHandler(ChangeEventArgs args)
    {
        Query = new Query().AddParams("match", args.Value);
        TickerValue = args.Value.ToString();
        ErrorOccured = false;
    }

    private void ValueChangeHandler(ChangeEventArgs<string, TickerDetailsDTO> args)
    {
        TickerValue = args.Value;
        ErrorOccured = false;
    }

    private async Task WatchlistButtonClickHandler()
    {
        WatchlistVisible = !WatchlistVisible;
        if(WatchlistVisible)
        {
            Watchlist = await Http.GetFromJsonAsync<TickerSimpleDTO[]>(WatchlistUrl);
            }
    }

    private async Task SearchHandler()
    {
        string threeMonthsAgo = _converter.FormatDateTimeToApiFriendlyFormat(DateTime.Now.AddMonths(-3));
        string yesterdaysDateFormatted = _converter.FormatDateTimeToApiFriendlyFormat(DateTime.Now.AddDays(-1));

        try
        {
            TickerDetails = await Http.GetFromJsonAsync<TickerSimpleDTO>($"Stocks/{TickerValue}");
            if (TickerDetails != null && TickerDetails.Shortcode.Equals(TickerValue))
            {
                DailyOpenClose = await Http.GetFromJsonAsync<DailyOpenCloseDTO>($"Stocks/{TickerValue}/{yesterdaysDateFormatted}");
                TickerPrices = await Http.GetFromJsonAsync<TickerPricesDTO>($"Stocks/{TickerValue}/Prizes/{threeMonthsAgo}");
                TickerNews = await Http.GetFromJsonAsync<TickerNewsDTO[]>($"Stocks/{TickerValue}/News/5");
            }
        }
        catch (Exception e)
        {
            ErrorOccured = true;
        }
    }

    private void CloseWatchlistHandler()
    {
        WatchlistVisible = false;
    }

    protected override async Task OnParametersSetAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var email = authState.User.Identity.Name;
        var url = $"ApplicationUsers/{email}/Watchlist";
        await Http.PostAsJsonAsync<TickerSimpleDTO>(Navigator.BaseUri + url, null);
        WatchlistUrl = url;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
