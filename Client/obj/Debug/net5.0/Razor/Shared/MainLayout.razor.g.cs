#pragma checksum "C:\git\Heroku\AP\P8\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b63b1533eba6bb6d0f9f714df1e2ff87ae3b74"
// <auto-generated/>
#pragma warning disable 1591
namespace P8.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using P8.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using P8.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\git\Heroku\AP\P8\Client\_Imports.razor"
using P8.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-p4iroexwvh");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-p4iroexwvh");
            __builder.OpenComponent<P8.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-p4iroexwvh");
            __builder.AddMarkupContent(11, @"<div class=""top-row px-4"" b-p4iroexwvh><a href=""/confirm"" target=""_blank"" class=""ml-md-auto"" b-p4iroexwvh>Cart</a>
        <a herf=""/confirm"" style=""text-decoration: none; width: 150px; color: black"" b-p4iroexwvh><span class=""oi oi-cart"" style=""font-size:40px; margin-right: 20px; margin-top: 0px; float:left"" b-p4iroexwvh></span>
        <div b-p4iroexwvh><p style=""margin-bottom: 0px; float: left;margin-top: 1px;"" b-p4iroexwvh></p></div></a></div>
        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-p4iroexwvh");
            __builder.AddContent(15, 
#nullable restore
#line 20 "C:\git\Heroku\AP\P8\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
