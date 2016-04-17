namespace Invert.Core
{
    public interface ICommandProgressEvent
    {
        void Progress(ICommand command, string message, float progress);
    }
}