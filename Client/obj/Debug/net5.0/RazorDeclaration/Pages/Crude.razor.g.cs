// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\git\Heroku\AP\P8\Client\Pages\Crude.razor"
using P8.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crude")]
    public partial class Crude : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\git\Heroku\AP\P8\Client\Pages\Crude.razor"
      
    Clothe clothe=new Clothe();
    int removeId;
    public void Add(){
        HttpClient ht=new HttpClient();
        ht.PostAsJsonAsync("https://e99522221.herokuapp.com/api/Clothe/addNewClotheToDb",clothe);
        StateHasChanged();
    }
    public void delete(){
        HttpClient ht=new HttpClient();
        ht.DeleteAsync($"https://e99522221.herokuapp.com/api/Clothe/removeClotheFromDb?Id={removeId}");
        StateHasChanged();
    }
    public void get(){
        NavManager.NavigateTo("/shop");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
