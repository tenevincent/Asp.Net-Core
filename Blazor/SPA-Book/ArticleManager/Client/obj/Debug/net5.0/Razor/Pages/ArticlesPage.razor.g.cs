#pragma checksum "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b9854cd335e2b021b5688242353e909395d7dc"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h2>Article</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mt-3");
#nullable restore
#line 6 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
     if (!string.IsNullOrEmpty(error))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "alert alert-danger");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
             error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
     if (currentArticle == null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ArticleManager.Client.Components.ArticleList>(6);
            __builder.AddAttribute(7, "ArticleListItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ArticleManager.Client.Models.ArticleListItem[]>(
#nullable restore
#line 15 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                                       articleListItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnAddClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                                 AddArticle

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "OnEditClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ArticleManager.Client.Models.ArticleListItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ArticleManager.Client.Models.ArticleListItem>(this, 
#nullable restore
#line 17 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                                  EditArticle

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "OnDeleteClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ArticleManager.Client.Models.ArticleListItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ArticleManager.Client.Models.ArticleListItem>(this, 
#nullable restore
#line 18 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                                    DeleteArticle

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ArticleManager.Client.Components.Article>(11);
            __builder.AddAttribute(12, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ArticleManager.Client.Models.ArticleItem>(
#nullable restore
#line 23 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                       currentArticle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnSaveClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ArticleManager.Client.Models.ArticleItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ArticleManager.Client.Models.ArticleItem>(this, 
#nullable restore
#line 24 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                              SaveArticle

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "OnCancelClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 25 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
                                ShowList

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Pages\ArticlesPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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