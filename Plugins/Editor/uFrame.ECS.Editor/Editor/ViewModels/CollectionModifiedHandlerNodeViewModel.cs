using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class CollectionModifiedHandlerNodeViewModel : CollectionModifiedHandlerNodeViewModelBase {
        
        public CollectionModifiedHandlerNodeViewModel(CollectionModifiedHandlerNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }

        public override bool AutoAddProperties
        {
            get { return false; }
        }

        protected override void CreateContent()
        {
            base.CreateContent();
            if (IsVisible(SectionVisibility.WhenNodeIsNotFilter))
            {
                var propertySelection = new InputOutputViewModel()
                {
                    DataObject = PropertyChangedNode.CollectionIn,
                    Name = "Collection",
                    IsInput = true,
                    IsOutput = false,
                    IsNewLine = true,
                    AllowSelection = true
                };
                ContentItems.Add(propertySelection);
                AddPropertyFields();
            }
           
        }

        public CollectionModifiedHandlerNode PropertyChangedNode
        {
            get { return GraphItemObject as CollectionModifiedHandlerNode; }
        }
    }
}
