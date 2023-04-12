using StableDiffusionUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusionUI.Services
{
    internal class ModelService : IModelService
    {
        public string[] GetModelNames()
        {
            return Directory.GetDirectories("models");
        }
    }
}
