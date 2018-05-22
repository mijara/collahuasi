using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public interface ModelPropertiesControl
    {
        Model GenerateModel(string name);

        void Populate(Model model);
    }
}
