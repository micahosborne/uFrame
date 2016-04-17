using System.Collections.Generic;
using Invert.Core;

public interface IQuickAccessEvents
{
    void QuickAccessItemsEvents(QuickAccessContext context, List<IItem> items);
}