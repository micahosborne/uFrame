using System.ComponentModel;

namespace Invert.Core.GraphDesigner.Unity.LogSystem
{
    public class InfiniteLoopCommand : ICommand, IBackgroundCommand
    {
        public string Title { get;  set; }

        public BackgroundWorker Worker { get; set; }
    }
}