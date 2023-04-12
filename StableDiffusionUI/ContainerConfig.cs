using DryIoc;
using DryIoc.ImTools;
using ReactiveUI;
using StableDiffusionUI.ViewModels;
using StableDiffusionUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusionUI
{
    internal static class ContainerConfig
    {
        public static void RegisterViewsAndViewModels(this IContainer container)
        {
            typeof(App).Assembly.GetTypes().ForEach(type =>
            {
                if (type == typeof(MainWindowViewModel))
                    return;

                var inter = type.GetInterfaces();
                if (inter.Any())
                {
                    if (inter.Any(i => i == typeof(IReactiveObject)))
                    {
                        container.Register(type);
                        return;
                    }

                    var iViewFor = inter.FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IViewFor<>));
                    if (iViewFor != null)
                    {
                        container.Register(iViewFor, type, made: Made.Of(FactoryMethod.ConstructorWithResolvableArguments));
                        return;
                    }
                }
            });

            var mw = new MainWindowViewModel();
            container.RegisterInstance(typeof(IScreen), mw);
            container.RegisterInstance(typeof(MainWindowViewModel), mw);

        }
    }
}
