namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class SystemNodeDrawer : GenericNodeDrawer<SystemNode,SystemNodeViewModel> {
        
        public SystemNodeDrawer(SystemNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
