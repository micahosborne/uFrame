namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class CollectionsChildItem : CollectionsChildItemBase, IMemberInfo, IDescriptorItem
    {
        public override Type Type
        {
            get { return base.Type ?? typeof(int); }
        }
        public override string RelatedTypeName
        {
            get
            {
                if (Type == uFrameECS.EntityComponentType)
                {
                    return typeof(int).Name;
                }
                return base.RelatedTypeName;
            }
        }

        public IEnumerable<DescriptorNode> Descriptors
        {
            get
            {
                foreach (var item in this.Repository.All<DescriptorNode>())
                {
                    if (this[item.Identifier])
                    {
                        yield return item;
                    }
                }
            }
        }
    }
    
    public partial interface ICollectionsConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
