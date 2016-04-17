namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class NullNodeDrawer : GenericNodeDrawer<NullNode,NullNodeViewModel> {
        
        public NullNodeDrawer(NullNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
