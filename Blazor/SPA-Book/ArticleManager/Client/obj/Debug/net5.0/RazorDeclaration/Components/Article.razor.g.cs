// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ArticleManager.Client.Components
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
    public partial class Article : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
       
    [Parameter]
    public ArticleItem Item { get; set; }

    [Parameter]
    public EventCallback<ArticleItem> OnSaveClick { get; set; }
    [Parameter]
    public EventCallback OnCancelClick { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
