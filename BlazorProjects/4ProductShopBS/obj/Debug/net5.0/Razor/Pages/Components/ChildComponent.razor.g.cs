#pragma checksum "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457b0c90cfa2021eab455ef705773dbccda570c5"
// <auto-generated/>
#pragma warning disable 1591
namespace _4ProductShopBS.Pages.Components
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
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "panel panel-default");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "panel-heading alert alert-info");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ChildComponent.razor"
                                                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "panel-body alert alert-success");
            __builder.AddContent(8, 
#nullable restore
#line 3 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ChildComponent.razor"
                                                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-danger");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ChildComponent.razor"
                                             OnClickMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n        Klikni me\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ChildComponent.razor"
       
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    //RenderFramegment predstavlja komadić UI kojeg je potrebno izrenderirati
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    //EventCallback je mehanizam kojim se neka metoda "prijavi" da se izvrši nakon nekog događaja, u ovom slučaju klik na button
    public EventCallback OnClickMethod { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591