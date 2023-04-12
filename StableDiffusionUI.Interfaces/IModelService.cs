using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusionUI.Interfaces
{
    public interface IModelService
    {
        string[] GetModelNames();
    }
}
