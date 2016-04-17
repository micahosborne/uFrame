using System.ComponentModel;

namespace Invert.Core
{
    public interface IBackgroundCommand : ICommand
    {
        BackgroundWorker Worker { get; set; }
    }
}