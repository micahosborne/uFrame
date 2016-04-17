namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class CodeActionNodeDrawer : GenericNodeDrawer<CodeActionNode,CodeActionNodeViewModel> {
        
        public CodeActionNodeDrawer(CodeActionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
