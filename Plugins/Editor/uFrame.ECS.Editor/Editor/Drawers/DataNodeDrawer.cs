namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class DataNodeDrawer : GenericNodeDrawer<DataNode,DataNodeViewModel> {
        
        public DataNodeDrawer(DataNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
