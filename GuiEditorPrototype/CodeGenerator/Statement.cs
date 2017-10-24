using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiEditorPrototype.CodeGenerator
{
    public class Statement : CodeWrapper
    {
        private Expression expression { get; }
        public virtual string CodeStr()
        {
            return expression + ";\n";
        }
    }
}
