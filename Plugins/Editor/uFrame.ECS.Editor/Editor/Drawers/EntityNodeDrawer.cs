namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class EntityNodeDrawer : GenericNodeDrawer<EntityNode,EntityNodeViewModel> {
        
        public EntityNodeDrawer(EntityNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
