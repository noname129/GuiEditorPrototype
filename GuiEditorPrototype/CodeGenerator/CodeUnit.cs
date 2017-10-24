using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiEditorPrototype.CodeGenerator
{
    public abstract class CodeUnit : CodeWrapper
    {
        protected string rawString { get; set; } = "";

        public virtual string CodeStr()
        {
            return rawString;
        }
    }
}
