using System.Collections;

namespace Invert.Core
{
    public interface ITaskHandler
    {
        void BeginTask(IEnumerator task);
        void BeginBackgroundTask(IEnumerator task);
    }
}