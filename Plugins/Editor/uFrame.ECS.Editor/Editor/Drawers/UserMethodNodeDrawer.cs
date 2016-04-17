namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class UserMethodNodeDrawer : GenericNodeDrawer<UserMethodNode,UserMethodNodeViewModel> {
        
        public UserMethodNodeDrawer(UserMethodNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
