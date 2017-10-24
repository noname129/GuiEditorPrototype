using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiEditorPrototype.CodeGenerator
{
    class Block : CodeWrapper
    {
        private CodeUnit foretext;
        private List<Statement> statements;

        public virtual string CodeStr()
        {
            string retval = foretext.CodeStr() + " {\n";
            foreach (Statement statement in statements)
            {
                retval += statement.CodeStr();
            }
            retval += "}\n";
            return retval;
        }
    }
}
