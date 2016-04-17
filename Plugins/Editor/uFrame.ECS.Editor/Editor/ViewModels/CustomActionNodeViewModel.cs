using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class CustomActionNodeViewModel : CustomActionNodeViewModelBase {
        
        public CustomActionNodeViewModel(CustomActionNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }

        protected override void CreateContent()
        {
            base.CreateContent();
      
        }

        public override IEnumerable<string> Tags
        {
            get
            {
                if (CustomActionNode.CodeAction)
                {
                    yield return "Code Action";
                }
            }
        }

        public CustomActionNode CustomActionNode
        {
            get
            {
                return DataObject as CustomActionNode;
            }
        }


        protected override void CreateActionContent()
        {
            if (IsVisible(SectionVisibility.WhenNodeIsFilter))
            {
                CreateActionIns();
                CreateActionOuts();
            }
            else
            {
                CreateContentByConfiguration(NodeConfig.GraphItemConfigurations, GraphItem);
            }
        }
    }
}
