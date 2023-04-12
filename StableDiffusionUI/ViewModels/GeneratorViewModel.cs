using ReactiveUI;
using Splat;
using StableDiffusionUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusionUI.ViewModels
{
    public class GeneratorViewModel : ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment => "Generator";
        public IScreen HostScreen { get; }
        public string SelectedModel { get; set; }

        public GeneratorViewModel(IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }
    }
}
