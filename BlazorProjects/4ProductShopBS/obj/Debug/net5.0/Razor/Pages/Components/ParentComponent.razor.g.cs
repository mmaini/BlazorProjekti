#pragma checksum "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01f90184897e907b990029f690e387424396299d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/parentComponent")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Parent Child Component</h1>\r\n\r\n");
            __builder.OpenComponent<_4ProductShopBS.Pages.Components.ChildComponent>(1);
            __builder.AddAttribute(2, "OnClickMethod", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ParentComponent.razor"
                                ShowMessage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Title", "Naslov iz parent komponente");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    Ovo je tekst upisan između ChildComponent tagova\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "p");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ParentComponent.razor"
       messageText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\DOKUMENTACIJA\FAX\PROJEKTI\BlazorProjects\BlazorProjects\4ProductShopBS\Pages\Components\ParentComponent.razor"
       

    private string messageText;

    private void ShowMessage()
    {
        messageText = "Pozdrav iz parenta";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
