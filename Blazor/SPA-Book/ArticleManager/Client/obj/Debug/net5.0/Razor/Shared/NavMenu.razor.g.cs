#pragma checksum "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2cd9939f22d851b24bc10bcc6ad008cda6230c1"
// <auto-generated/>
#pragma warning disable 1591
namespace ArticleManager.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using ArticleManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using ArticleManager.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using ArticleManager.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using ArticleManager.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\_Imports.razor"
using ArticleManager.Client.Services;

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
            __builder.AddAttribute(2, "b-qxk35xoe1u");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-qxk35xoe1u>ArticleManager</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-qxk35xoe1u");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-qxk35xoe1u></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 28 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-qxk35xoe1u");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-qxk35xoe1u");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-qxk35xoe1u");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 32 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-qxk35xoe1u></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
         foreach (var item in MenuItems)
        {
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item" + " px-3" + "  " + (
#nullable restore
#line 43 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                        item.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-qxk35xoe1u");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 44 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                                 item.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                                                     e => OnMenuItemClick.InvokeAsync(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(34, "span");
                __builder2.AddAttribute(35, "class", 
#nullable restore
#line 45 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                  item.Icon

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(36, "aria-hidden", "true");
                __builder2.AddAttribute(37, "b-qxk35xoe1u");
                __builder2.CloseElement();
                __builder2.AddContent(38, " ");
                __builder2.AddContent(39, 
#nullable restore
#line 45 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
                                                                         item.Caption

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Shared\NavMenu.razor"
       


    [Parameter]
    public EventCallback<MenuItem> OnMenuItemClick { get; set; }

    [Parameter]
    public MenuItem[] MenuItems { get; set; }


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
