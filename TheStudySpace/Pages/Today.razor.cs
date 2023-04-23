using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TheStudySpace.Pages
{
    public partial class Today
    {
        private bool collapseNavMenu = true;
        string elementId = "collapsible";

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync(
                "collapse",
                elementId);
        }
    }
}
