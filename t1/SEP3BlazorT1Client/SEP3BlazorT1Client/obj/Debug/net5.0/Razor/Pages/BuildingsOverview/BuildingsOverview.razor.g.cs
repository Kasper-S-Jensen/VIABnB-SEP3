#pragma checksum "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef130f9abfa358a1e366b5a62ecfdce877cacb3c"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3BlazorT1Client.Pages.BuildingsOverview
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using SEP3BlazorT1Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using SEP3BlazorT1Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
using SEP3BlazorT1Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BuildingsOverview")]
    public partial class BuildingsOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
            .demo-mat-card {
                max-width: 400px;
                padding-top: 5px;
                margin-top: 6px;
            }
 
            .demo-mat-card-content {
                padding: 1rem;
            }
 
            .demo-mat-card-clean-margin {
                margin: 0px;
            }
  </style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mat-layout-grid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mat-layout-grid-inner");
#nullable restore
#line 25 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
         foreach (var residence in Residences)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mat-layout-grid-cell");
            __builder.OpenComponent<MatBlazor.MatCard>(7);
            __builder.AddAttribute(8, "class", "demo-mat-card");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatCardContent>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatCardMedia>(12);
                    __builder3.AddAttribute(13, "Wide", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ImageUrl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
                                                                        residence.photo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n                                    ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "demo-mat-card-content");
                    __builder3.OpenComponent<MatBlazor.MatHeadline6>(18);
                    __builder3.AddAttribute(19, "class", "demo-mat-card-clean-margin");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(21, "\r\n                                            Unique stays\r\n                                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n                                        ");
                    __builder3.OpenComponent<MatBlazor.MatSubtitle2>(23);
                    __builder3.AddAttribute(24, "class", "demo-mat-card-clean-margin");
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(26, 
#nullable restore
#line 36 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
                                             residence.Address.ToString()

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(27, "\r\n                \r\n                                    ");
                    __builder3.OpenComponent<MatBlazor.MatBody2>(28);
                    __builder3.AddAttribute(29, "class", "demo-mat-card-content demo-mat-card-clean-margin");
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, 
#nullable restore
#line 41 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
                                         residence.Description

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenComponent<MatBlazor.MatCardActions>(33);
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatButton>(35);
                    __builder3.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
                                                          () => residence.IsAvailable = true

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(38, "Ready for rent");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
       

    Residence[] Residences = new[]
    {
        new Residence
        {
            Id = 1,
            Address = new Address()
            {
                Id = 1,
                StreetName = "Sally",
                HouseNumber = "2",
                CityName = "Horsens",
                StreetNumber = "3b",
                ZipCode = 8700,
            },
            Description = "beautiful house full of cats!",
            Type = "villa",
            AverageRating = 2,
            IsAvailable = false,
            PricePerNight = 1000,
            Rules = new List<Rule>(),
            Facilities = new List<Facility>(),
            photo = "https://static.dezeen.com/uploads/2020/02/house-in-the-landscape-niko-arcjitect-architecture-residential-russia-houses-khurtin_dezeen_2364_hero-852x479.jpg"
        },

        new Residence
        {
            Id = 2,
            Address = new Address()
            {
                Id = 2,
                StreetName = "Reshee",
                HouseNumber = "B",
                CityName = "Horsens",
                StreetNumber = "A1",
                ZipCode = 8700,
            },
            Description = "amazing house full of flowers and books",
            Type = "house",
            AverageRating = 1,
            IsAvailable = false,
            PricePerNight = 1000,
            Rules = new List<Rule>(),
            Facilities = new List<Facility>(),
            photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQyXb58B6PUsT9t0EfH8zKpl_An5h0ssJhZnw&usqp=CAU"
        },
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
