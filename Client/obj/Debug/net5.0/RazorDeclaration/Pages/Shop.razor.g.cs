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
#line 3 "C:\git\Heroku\AP\P8\Client\Pages\Shop.razor"
using P8.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\Heroku\AP\P8\Client\Pages\Shop.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shop")]
    public partial class Shop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\git\Heroku\AP\P8\Client\Pages\Shop.razor"
 
    protected async override Task OnInitializedAsync()
    {
        await BringAllItems();
    }
    public string rootAddress = "https://e99522221.herokuapp.com/";
    List<Clothe> clothes=new List<Clothe>();
    public async Task BringAllItems()
    {
        HttpClient client = new HttpClient();
        clothes = await client.GetFromJsonAsync<List<Clothe>>(rootAddress + "api/clothe/getAllClotheInDb");
        StateHasChanged();
    }
        int n=0;

    public void AddToCart(Clothe cloth)
    {
        if(Cart.clothes.Contains(cloth))
        {
            
            cloth.Number++;
        }
        else{
            cloth.Number++;
            Cart.clothes.Add(cloth);
        }
    }
    public void deleteFromCart(Clothe cloth)
    {
        if(Cart.clothes.Contains(cloth))
        {
            cloth.Number--;
        }
        
    }
    int i=0;

    public void ret()
    {
        if(i>0)
            NavManager.NavigateTo("/Confirm"); 
    }
    
    public async Task update(){
        i++;
        HttpClient ht=new HttpClient();
        
        foreach(var item in Cart.clothes)
                { 
                    item.leftint -= item.Number;
                    await ht.PutAsJsonAsync("https://e99522221.herokuapp.com/api/Clothe/UpdateClotheInDB", item);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\git\Heroku\AP\P8\Client\Pages\Shop.razor"
                                                                                                                     
                }
        await BringAllItems();
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
