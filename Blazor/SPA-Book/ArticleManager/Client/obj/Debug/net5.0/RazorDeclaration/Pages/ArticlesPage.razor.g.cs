// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ArticleManager.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/articles")]
    public partial class ArticlesPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
       
    private ArticleListItem[] articleListItems;
    private ArticleItem currentArticle;
    private string error;

    protected override async Task OnInitializedAsync()
    {
        await ShowList();
    }

    public async Task ShowList()
    {
        articleListItems = await service.GetList();
        this.currentArticle = null;
    }

    public async Task AddArticle()
    {
        this.currentArticle = await service.GetNew();
    }

    public async Task EditArticle(ArticleListItem item)
    {
        this.currentArticle = await service.Get(item.Id);
    }

    public async Task SaveArticle(ArticleItem item)
    {
        try
        {
            if (currentArticle.Id == 0)
            {
                await service.Create(currentArticle);
            }
            else
            {
                await service.Update(currentArticle);
            }
            await this.ShowList();
        }
        catch (Exception ex)
        {
            this.error = ex.Message;
        }
    }

    public async Task DeleteArticle(ArticleListItem item)
    {
        try
        {
            await service.Delete(item.Id);
            await this.ShowList();
        }
        catch (Exception ex)
        {
            this.error = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICRUDService<ArticleListItem, ArticleItem> service { get; set; }
    }
}
#pragma warning restore 1591
