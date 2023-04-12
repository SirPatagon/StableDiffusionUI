using DryIoc;
using StableDiffusionUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusionUI.Services
{
    public static class ContainerConfig
    {
        public static void RegisterServices(this IContainer container)
        {
            container.Register(typeof(IModelService), typeof(ModelService));
        }
    }
}
