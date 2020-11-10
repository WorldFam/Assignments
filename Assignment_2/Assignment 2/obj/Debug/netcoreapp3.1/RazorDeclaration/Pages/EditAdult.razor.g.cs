#pragma checksum "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543132107a9a8822e1799ca0324c66c381994f33"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Assignment_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Assignment_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\EditAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\EditAdult.razor"
using Assignment_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\EditAdult.razor"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult/{value}")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\EditAdult.razor"
       
    private Adult _adultItem = new Adult();
    

    protected override async Task OnParametersSetAsync()
    {
        var stringId = value;
        int Id = int.Parse(stringId);
        _adultItem = await FileContext.GetAdultByIdAsync(Id);
    }
    
    private async Task EditAdultAsync()
    {
        await FileContext.UpdateAdultAsync(_adultItem);
        NavigationManager.NavigateTo("/AdultList");
    }
    
    [Parameter]
     public  string value { get; set; }
    
    string RadioValue = "" ;
    void RadioSelection(ChangeEventArgs args)
    {
        RadioValue = args.Value.ToString();
        if (RadioValue.Equals("Female"))
        {
            RadioValue = "F";
        }
        else if (RadioValue.Equals("Male"))
        {
            RadioValue = "M";
        }
    }

    void OnSubmit()
    {
        _adultItem.Sex = RadioValue;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudService FileContext { get; set; }
    }
}
#pragma warning restore 1591
