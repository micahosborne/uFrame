namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;


    public class GroupNodeDrawer : GenericNodeDrawer<GroupNode, GroupNodeViewModel>
    {
        
        public GroupNodeDrawer(GroupNodeViewModel viewModel) : 
                base(viewModel) {
        }
   
    }
}
