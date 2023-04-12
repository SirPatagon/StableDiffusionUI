using ReactiveUI;
using Splat;
using System;

namespace StableDiffusionUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        // The Router associated with this Screen.
        // Required by the IScreen interface.
        public RoutingState Router { get; }

        public MainWindowViewModel()
        {
            Router = new RoutingState();
        }

        public void NavigateToFirstScreen()
        {
            Router.NavigateAndReset.Execute(Locator.Current.GetService<ModelSelectionViewModel>());
        }

        public string Greeting => "Welcome to Avalonia!";
    }
}