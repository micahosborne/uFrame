using System.Collections.Generic;
using Invert.Data;

namespace Invert.Core.GraphDesigner
{
    public interface IConnectableProvider : IDataRecord
    {
        IEnumerable<IConnectable> Connectables { get; }
    }
}