using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DryIoc;
using Splat.DryIoc;
using StableDiffusionUI.ViewModels;
using StableDiffusionUI.Views;
using StableDiffusionUI.Services;

namespace StableDiffusionUI
{
    public partial class App : Application
    {
        public override void Initialize() => AvaloniaXamlLoader.Load(this);

        public override void OnFrameworkInitializationCompleted()
        {
            var container = new Container()
                .With(c => c.WithAutoConcreteTypeResolution());

            container.RegisterServices();
            container.RegisterViewsAndViewModels();
            container.UseDryIocDependencyResolver();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = container.Resolve<MainWindow>();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}