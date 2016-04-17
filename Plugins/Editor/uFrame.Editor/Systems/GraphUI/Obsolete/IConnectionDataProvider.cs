using System;
using System.Collections.Generic;
using Invert.Core.GraphDesigner;

[Obsolete]
public interface IConnectionDataProvider
{
    IEnumerable<ConnectionData> Connections { get; }
}