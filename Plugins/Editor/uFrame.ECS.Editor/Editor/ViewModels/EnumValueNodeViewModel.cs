using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class EnumValueNodeViewModel : EnumValueNodeViewModelBase {
        
        public EnumValueNodeViewModel(EnumValueNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }

        public EnumValueNode EnumValueNode
        {
            get { return DataObject as EnumValueNode; }
        }

        public override IEnumerable<string> Tags
        {
            get { yield break; }
        }

        protected override void CreateContent()
        {
            base.CreateContent();
            //if (EnumValueNode.EnumType != null)
            //{
            //    ContentItems.Add(new PropertyFieldViewModel()
            //    {
            //        InspectorType = InspectorType.Auto,
            //        Type = EnumValueNode.EnumType,
            //        DiagramViewModel = DiagramViewModel,
            //        NodeViewModel = this,
            //        Getter = () => Enum.ToObject(EnumValueNode.EnumType,EnumValueNode.Value),
            //        Setter = _=>EnumValueNode.Value = (int)_,
            //        Name = "Value"
            //    });
            //}
        }
    }
}
