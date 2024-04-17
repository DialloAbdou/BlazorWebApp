
using Microsoft.AspNetCore.Components;
using System.Runtime.ExceptionServices;

namespace BlazorApp.Server.Components.Pages;
public partial class Home
{

    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized -DEBUT");
        base.OnInitialized();
        Console.WriteLine("OnInitialized -FIN");

    }
    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("OnInitializedAsync -DEBUT");
        await base.OnInitializedAsync();
        Console.WriteLine("OnInitializedAsync -FIN");
    }
    protected override void OnParametersSet()
    {
        Console.WriteLine("OnParametersSet -DEBUT");
        base.OnParametersSet();
        Console.WriteLine("OnParametersSet -FIN");
    }
    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("OnParametersSetAsync -DEBUT");
        await base.OnParametersSetAsync();
        Console.WriteLine("OnParametersSetAsync -FIN");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine( $"OnAfterRender -DEBUT (First ? {firstRender})");
        base.OnAfterRender(firstRender);
        Console.WriteLine($"OnAfterRender -FIN (First ? {firstRender})");

    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine($"OnAfterRenderAsync -DEBUT (First ? {firstRender})");
        await  base.OnAfterRenderAsync(firstRender);
        Console.WriteLine($"OnAfterRenderAsync -FIN (First ? {firstRender})");

    }

    protected override bool ShouldRender()
    {
        Console.WriteLine($"ShouldRender -DEBUT");
        Console.WriteLine($"ShouldRender -FIN ");
        return base.ShouldRender();
    }


}