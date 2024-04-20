
using Microsoft.AspNetCore.Components;
using System.Runtime.ExceptionServices;

namespace BlazorApp.Server.Components.Pages;
public partial class Home
{
    private string _apiResponse; 
    List<string> _steps = new List<string>();
    protected override void OnInitialized()
    {
        _steps.Add(nameof(OnInitialized));
        Console.WriteLine("OnInitialized -DEBUT");
        base.OnInitialized();
        Console.WriteLine("OnInitialized -FIN");

    }
    protected override async Task OnInitializedAsync()
    {
        _steps.Add(nameof(OnInitializedAsync));
        Console.WriteLine("OnInitializedAsync -DEBUT");
        await base.OnInitializedAsync();
        await Task.Delay(15000);
        _apiResponse = "Réponse de l'api";
        Console.WriteLine("OnInitializedAsync -FIN");
    }
    protected override void OnParametersSet()
    {
        _steps.Add(nameof(OnParametersSet));
        Console.WriteLine("OnParametersSet -DEBUT");
        base.OnParametersSet();
        Console.WriteLine("OnParametersSet -FIN");
    }
    protected override async Task OnParametersSetAsync()
    {
        _steps.Add(nameof(OnParametersSetAsync));
        Console.WriteLine("OnParametersSetAsync -DEBUT");
        await base.OnParametersSetAsync();
        Console.WriteLine("OnParametersSetAsync -FIN");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        _steps.Add(nameof(OnAfterRender));
        Console.WriteLine($"OnAfterRender -DEBUT (First ? {firstRender})");
        base.OnAfterRender(firstRender);
        Console.WriteLine($"OnAfterRender -FIN (First ? {firstRender})");

    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        _steps.Add(nameof(OnAfterRenderAsync));
        Console.WriteLine($"OnAfterRenderAsync -DEBUT (First ? {firstRender})");
        await base.OnAfterRenderAsync(firstRender);
        Console.WriteLine($"OnAfterRenderAsync -FIN (First ? {firstRender})");

    }

    protected override bool ShouldRender()
    {
        _steps.Add(nameof(ShouldRender));
        Console.WriteLine($"ShouldRender -DEBUT");
        Console.WriteLine($"ShouldRender -FIN ");
        return base.ShouldRender();
    }


}