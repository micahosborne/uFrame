namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ActionGroupNodeDrawer : GenericNodeDrawer<ActionGroupNode,ActionGroupNodeViewModel> {
        
        public ActionGroupNodeDrawer(ActionGroupNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
