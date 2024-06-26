//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a �t� g�n�r� par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apport�es � ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est r�g�n�r�.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Shared
{
    public partial class LifeCycle
    {

        private string _apiResponse;
        List<string> _steps = new List<string>();
        private string? _var = "Valeur Initiale";
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
            //await Task.Delay(15000);
            //_apiResponse = "R�ponse de l'api";
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
            if (firstRender)
            {
                await Task.Delay(5000);
                _apiResponse = "R�ponse de l'api";
                StateHasChanged(); // permet de raflichir sans qu'on click sur le bouton de refresh il faut qu'il soit toujours dans une condition

            }

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
}