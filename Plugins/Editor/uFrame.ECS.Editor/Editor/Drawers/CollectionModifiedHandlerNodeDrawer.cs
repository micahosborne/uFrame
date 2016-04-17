namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class CollectionModifiedHandlerNodeDrawer : GenericNodeDrawer<CollectionModifiedHandlerNode,CollectionModifiedHandlerNodeViewModel> {
        
        public CollectionModifiedHandlerNodeDrawer(CollectionModifiedHandlerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
