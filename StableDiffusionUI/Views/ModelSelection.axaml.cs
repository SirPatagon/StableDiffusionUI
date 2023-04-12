using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;
using StableDiffusionUI.ViewModels;
using System;

namespace StableDiffusionUI.Views
{
    public partial class ModelSelection : ReactiveUserControl<ModelSelectionViewModel>, IViewFor<ModelSelectionViewModel>
    {
        public ModelSelection()
        {
            InitializeComponent();
        }

        object IViewFor.ViewModel { get => DataContext; set => DataContext = value; }

        public void ONClick(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateNext();
        }
    }
}
