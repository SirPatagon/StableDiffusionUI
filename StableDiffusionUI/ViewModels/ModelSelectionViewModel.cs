using Avalonia.Threading;
using ReactiveUI;
using Splat;
using StableDiffusionUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StableDiffusionUI.ViewModels
{
    public class ModelSelectionViewModel : ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment => "ModelSelection";
        public IScreen HostScreen { get; }
        public string[] Models { get; }
        public ReactiveCommand<string, Unit> GoNext { get; set; }

        private Func<GeneratorViewModel> fCreateGeneratorVM;

        public ModelSelectionViewModel(IModelService modelService, Func<GeneratorViewModel> createGeneratorVM, IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
            Models = modelService.GetModelNames();
            fCreateGeneratorVM = createGeneratorVM;
                //GoNext = ReactiveCommand.Create<string, Unit>(
                //    (model) =>
                //    {                    
                //        var vm = createGeneratorVM();
                //        vm.SelectedModel = ""; 
                //        Dispatcher.UIThread.InvokeAsync(() =>
                //        {
                //            NavigateNext()
                //        });
                //        return Unit.Default;
                //    }
                //);
        }

        public void NavigateNext()
        {
            HostScreen.Router.Navigate.Execute(fCreateGeneratorVM());
        }
    }
}
