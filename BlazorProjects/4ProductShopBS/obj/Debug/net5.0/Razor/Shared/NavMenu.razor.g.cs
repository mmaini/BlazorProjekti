#pragma checksum "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d6c21115de6b10a6dab1485ef4dee0a2d2d79e"
// <auto-generated/>
#pragma warning disable 1591
namespace _4ProductShopBS.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using _4ProductShopBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using _4ProductShopBS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using _4ProductShopBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using _4ProductShopBS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\_Imports.razor"
using _4ProductShopBS.Pages.Components;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-tbc0r01wvb");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-tbc0r01wvb>4ProductShopBS</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-tbc0r01wvb");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-tbc0r01wvb></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-tbc0r01wvb");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-tbc0r01wvb");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-tbc0r01wvb");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-tbc0r01wvb></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item px-3");
                __builder2.AddAttribute(31, "b-tbc0r01wvb");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
                __builder2.AddAttribute(33, "class", "nav-link");
                __builder2.AddAttribute(34, "href", "category");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-tbc0r01wvb></span> Kategorija\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddAttribute(40, "b-tbc0r01wvb");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", "nav-link");
                __builder2.AddAttribute(43, "href", "product");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-tbc0r01wvb></span> Proizvod\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(46, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(47, "li");
                __builder2.AddAttribute(48, "class", "nav-item px-3");
                __builder2.AddAttribute(49, "b-tbc0r01wvb");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
                __builder2.AddAttribute(51, "class", "nav-link");
                __builder2.AddAttribute(52, "href", "learnBlazor");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(54, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-tbc0r01wvb></span> Learn Blazor\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenElement(56, "li");
                __builder2.AddAttribute(57, "class", "nav-item px-3");
                __builder2.AddAttribute(58, "b-tbc0r01wvb");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
                __builder2.AddAttribute(60, "class", "nav-link");
                __builder2.AddAttribute(61, "href", "learnRouting");
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(63, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-tbc0r01wvb></span> Learn Routing\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenElement(65, "li");
                __builder2.AddAttribute(66, "class", "nav-item px-3");
                __builder2.AddAttribute(67, "b-tbc0r01wvb");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
                __builder2.AddAttribute(69, "class", "nav-link");
                __builder2.AddAttribute(70, "href", "querystringrouting?param1=prvi&param2=drugi");
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(72, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-tbc0r01wvb></span> QueryString Routing\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.OpenElement(74, "li");
                __builder2.AddAttribute(75, "class", "nav-item px-3");
                __builder2.AddAttribute(76, "b-tbc0r01wvb");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
                __builder2.AddAttribute(78, "class", "nav-link");
                __builder2.AddAttribute(79, "href", "parentComponent");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(81, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-tbc0r01wvb></span> Parent-Child\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
