using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using StableDiffusionUI.ViewModels;
using System;

namespace StableDiffusionUI.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>, IViewFor<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(MainWindowViewModel viewModel) : this()
        {
            ViewModel = viewModel;
            ViewModel.NavigateToFirstScreen();
        }

        object IViewFor.ViewModel
        {
            get => DataContext;
            set => DataContext = value;
        }
    }
}