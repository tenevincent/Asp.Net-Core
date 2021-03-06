#pragma checksum "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72bc7f00c3608ba2307a70652215eb4252fa04b5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                  Item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                         e => OnSaveClick.InvokeAsync(Item)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label for=\"category\">Category: </label>\r\n        ");
                __Blazor.ArticleManager.Client.Components.Article.TypeInference.CreateInputSelect_0(__builder2, 11, 12, "category", 13, "form-control", 14, 
#nullable restore
#line 7 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                                Item.CategoryId

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.CategoryId = __value, Item.CategoryId)), 16, () => Item.CategoryId, 17, (__builder3) => {
#nullable restore
#line 8 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
             foreach (var category in Item.Categories)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(18, "option");
                    __builder3.AddAttribute(19, "value", 
#nullable restore
#line 10 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                category.Value

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(20, 
#nullable restore
#line 10 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                                 category.Label

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 11 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __Blazor.ArticleManager.Client.Components.Article.TypeInference.CreateValidationMessage_1(__builder2, 22, 23, 
#nullable restore
#line 13 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                  () => Item.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label for=\"name\">Title: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "name");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                          Item.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.Title = __value, Item.Title))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Item.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __Blazor.ArticleManager.Client.Components.Article.TypeInference.CreateValidationMessage_2(__builder2, 35, 36, 
#nullable restore
#line 19 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                  () => Item.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label for=\"content\">Content: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(41);
                __builder2.AddAttribute(42, "id", "content");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                                 Item.Content

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.Content = __value, Item.Content))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Item.Content));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.AddMarkupContent(48, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "type", "button");
                __builder2.AddAttribute(51, "class", "btn btn-warning");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\DevGit\Asp.Net Core\Blazor\SPA-Book\ArticleManager\Client\Components\Article.razor"
                                                            OnCancelClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(53, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.ArticleManager.Client.Components.Article
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
