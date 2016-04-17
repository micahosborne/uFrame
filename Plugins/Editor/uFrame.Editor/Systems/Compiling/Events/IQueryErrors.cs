using System.Collections.Generic;

namespace Invert.Core.GraphDesigner
{
    public interface IQueryErrors
    {
        void QueryErrors(List<ErrorInfo> errorInfo);
    }
}