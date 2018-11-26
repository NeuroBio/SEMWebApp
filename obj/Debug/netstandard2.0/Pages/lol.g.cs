#pragma checksum "D:\Documents\C#\SEMWebApp\Pages\lol.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "472610cb96ded145e7c944f85cb3124c573d9039"
// <auto-generated/>
#pragma warning disable 1591
namespace SEMWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using SEMWebApp;
    using SEMWebApp.Shared;
    using System.Threading;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/manual-refresh")]
    public class lol : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, Count);
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "button");
            builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(StartCountdown));
            builder.AddContent(5, "Start Countdown");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 10 "D:\Documents\C#\SEMWebApp\Pages\lol.cshtml"
            
    private int Count { get; set; } = 10;

    void StartCountdown()
    {
        var timer = new Timer(new TimerCallback(_ =>
        {
            if (Count > 0)
            {
                Count--;

            // Note that the following line is necessary because otherwise
            // Blazor would not recognize the state change and not refresh the UI
            this.StateHasChanged();
            }
        }), null, 1000, 1000);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
