#pragma checksum "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8abf051706e948647b83b33c122b769fdbc9077"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
using Assignment_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
           [Authorize(Policy = "SecurityLevel2")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                  _adult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                          AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.AddMarkupContent(9, "<div> &nbsp;</div>\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row ");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.AddMarkupContent(16, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">First Name:</p></div>\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-5");
                __builder2.AddContent(19, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                                         _adult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.FirstName = __value, _adult.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.AddMarkupContent(27, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">Last Name:</p></div>\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-5");
                __builder2.AddContent(30, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "type", "text");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                                          _adult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.LastName = __value, _adult.LastName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.AddMarkupContent(39, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __Blazor.Assignment_2.Pages.AddAdult.TypeInference.CreateInputSelect_0(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 23 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                           _adult.HairColor

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.HairColor = __value, _adult.HairColor)), 50, () => _adult.HairColor, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.AddMarkupContent(53, "<option disabled selected>Select Available Hair Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(54, "<option id=\"blond\" value=\"Blond\">Blond</option>\r\n                    ");
                    __builder3.AddMarkupContent(55, "<option id=\"red\" value=\"Red\">Red</option>\r\n                    ");
                    __builder3.AddMarkupContent(56, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(57, "<option id=\"black\" value=\"Black\">Black</option>\r\n                    ");
                    __builder3.AddMarkupContent(58, "<option id=\"white\" value=\"White\">White</option>\r\n                    ");
                    __builder3.AddMarkupContent(59, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(60, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(61, "<option class=\"green\" value=\"Green\">Green</option>\r\n                    ");
                    __builder3.AddMarkupContent(62, "<option id=\"leverpostej\" value=\"Leverpostej\">Leverpostej</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(63, "   \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col");
                __builder2.AddMarkupContent(67, "\r\n                ");
                __Blazor.Assignment_2.Pages.AddAdult.TypeInference.CreateInputSelect_1(__builder2, 68, 69, "form-control", 70, 
#nullable restore
#line 37 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                          _adult.EyeColor

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.EyeColor = __value, _adult.EyeColor)), 72, () => _adult.EyeColor, 73, (__builder3) => {
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                    __builder3.AddMarkupContent(75, "<option disabled selected>Select Available Eye Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(76, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(77, "<option id=\"amber\" value=\"Amber\">Amber</option>\r\n                    ");
                    __builder3.AddMarkupContent(78, "<option id=\"hazel\" value=\"Hazel\">Hazel</option>\r\n                    ");
                    __builder3.AddMarkupContent(79, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(80, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(81, "<option class=\"green\" value=\"Green\">Green</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(82, "       \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.AddMarkupContent(85, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "row");
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.AddMarkupContent(89, "<div class=\"col-1\">\r\n                <label class=\"my-1 mx-4\">Age:</label>\r\n            </div>\r\n            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-5");
                __builder2.AddMarkupContent(92, "\r\n                ");
                __Blazor.Assignment_2.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 93, 94, "form-control", 95, 
#nullable restore
#line 54 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                          _adult.Age

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Age = __value, _adult.Age)), 97, () => _adult.Age);
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.AddMarkupContent(100, "<div class=\"col-1\">\r\n                <label class=\"my-1 mr-2\">Weight:</label>\r\n            </div>\r\n            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "col-5");
                __builder2.AddMarkupContent(103, "\r\n                ");
                __Blazor.Assignment_2.Pages.AddAdult.TypeInference.CreateInputNumber_3(__builder2, 104, 105, "1", 106, "form-control", 107, 
#nullable restore
#line 60 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                   _adult.Weight

#line default
#line hidden
#nullable disable
                , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Weight = __value, _adult.Weight)), 109, () => _adult.Weight);
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n        ");
                __builder2.AddMarkupContent(113, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "row");
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.AddMarkupContent(117, "<div class=\"col-1\"><label class=\"my-1 mx-4\">Height:</label></div>\r\n            ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col-5");
                __Blazor.Assignment_2.Pages.AddAdult.TypeInference.CreateInputNumber_4(__builder2, 120, 121, "form-control", 122, 
#nullable restore
#line 66 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                         _adult.Height

#line default
#line hidden
#nullable disable
                , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Height = __value, _adult.Height)), 124, () => _adult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.AddMarkupContent(126, "<div class=\"col-2\"><label>Select gender:</label></div>\r\n");
#nullable restore
#line 68 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
             foreach (var item in new string[] { "Male","Female"})
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(127, "                        ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-check col-2");
                __builder2.AddMarkupContent(130, "\r\n                          ");
                __builder2.OpenElement(131, "input");
                __builder2.AddAttribute(132, "type", "radio");
                __builder2.AddAttribute(133, "name", "technology");
                __builder2.AddAttribute(134, "id", 
#nullable restore
#line 71 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                     item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(135, "value", 
#nullable restore
#line 71 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                                   item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                                                     RadioSelection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "checked", 
#nullable restore
#line 71 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                                                                               RadioValue.Equals(item,StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                          ");
                __builder2.OpenElement(139, "label");
                __builder2.AddAttribute(140, "for", 
#nullable restore
#line 72 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                       item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(141, 
#nullable restore
#line 72 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                              item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n");
#nullable restore
#line 74 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(144, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n        ");
                __builder2.OpenElement(146, "div");
                __builder2.AddMarkupContent(147, "\r\n            ");
                __builder2.AddMarkupContent(148, "<div> &nbsp;</div>\r\n            ");
                __builder2.OpenElement(149, "div");
                __builder2.AddAttribute(150, "class", "row");
                __builder2.AddMarkupContent(151, "\r\n                ");
                __builder2.AddMarkupContent(152, "<div class=\"col-1\"><label>Job Title:</label></div>\r\n                ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "col-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(155);
                __builder2.AddAttribute(156, "class", "form-control");
                __builder2.AddAttribute(157, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                            _adult.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(158, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.JobTitle = __value, _adult.JobTitle))));
                __builder2.AddAttribute(159, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.JobTitle));
                __builder2.CloseComponent();
                __builder2.AddContent(160, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                ");
                __builder2.OpenElement(162, "div");
                __builder2.AddAttribute(163, "class", "col-3");
                __builder2.AddMarkupContent(164, "\r\n                    ");
                __builder2.OpenElement(165, "button");
                __builder2.AddAttribute(166, "class", "btn btn-primary mb-2 button1");
                __builder2.AddAttribute(167, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
                                                                            OnSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(168, "type", "submit");
                __builder2.AddContent(169, "Create");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\Ceslov\RiderProjects\Assignment 2\Assignment 2\Pages\AddAdult.razor"
           private Adult _adult = new Adult();


    private async Task AddNewAdult()
    {
       await FileContext.AddAdultAsync(_adult);
        NavigationManager.NavigateTo("/AdultList");
    }
    

    string RadioValue = "";
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
        _adult.Sex = RadioValue;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudService FileContext { get; set; }
    }
}
namespace __Blazor.Assignment_2.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
