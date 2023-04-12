using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using StableDiffusionUI.ViewModels;

namespace StableDiffusionUI.Views
{
    public partial class Generator : ReactiveUserControl<GeneratorViewModel>, IViewFor<GeneratorViewModel>
    {
        public Generator()
        {
            InitializeComponent();
        }

        object IViewFor.ViewModel { get => DataContext; set => DataContext = value; }
    }
}
