using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiEditorPrototype.CodeGenerator
{
    public class Operator : CodeUnit
    {
        public override string CodeStr()
        {
            return " " + rawString + " ";
        }
    }
}
