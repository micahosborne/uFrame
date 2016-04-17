namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ModuleNodeDrawer : GenericNodeDrawer<ModuleNode,ModuleNodeViewModel> {
        
        public ModuleNodeDrawer(ModuleNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
