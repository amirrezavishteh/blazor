#pragma checksum "C:\git\Heroku\AP\P8\Client\Pages\Thanks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adbc5e4d80b428225bc14af14afbe1016575612d"
// <auto-generated/>
#pragma warning disable 1591
namespace P8.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/thanks")]
    public partial class Thanks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p><h1>Thanks for your shop</h1></p>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
    .btn {
            background-color: blue;
            color: black;
            text-align: center;
            font-size: 13px;
         }
body {
        background-color: gray;
    }
    th, td {
    padding: 15px;
    text-align: left;
}

    img.watch3{
        width : 600px;
        height : auto;
    }
</style>
<img class=""watch3"" src=""/images/rolexshop.jpg"">
");
            __builder.AddMarkupContent(2, "<p><p>Our watch has the most stylish brand watches in the world \r\n    with the best prices available in the market</p></p>\r\n");
            __builder.AddMarkupContent(3, "<p>Your watchs arrive within 3 days</p>\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn");
            __builder.AddAttribute(6, "type", "submit");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\git\Heroku\AP\P8\Client\Pages\Thanks.razor"
                                              handels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "confirm");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\git\Heroku\AP\P8\Client\Pages\Thanks.razor"
      
    public void handels(){
        NavManager.NavigateTo("/successpage");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
