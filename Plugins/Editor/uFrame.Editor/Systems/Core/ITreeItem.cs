using System.Collections.Generic;

namespace Invert.Core
{
    public interface ITreeItem : IItem
    {
        IItem ParentItem { get; }
        IEnumerable<IItem> Children { get; }
        bool Expanded { get; set; }
    }
}