using Invert.Data;

namespace Invert.Core.GraphDesigner
{
    public class DeleteCommand : Command, IFileSyncCommand
    {
        public IDataRecord[] Item { get; set; }
    }
}