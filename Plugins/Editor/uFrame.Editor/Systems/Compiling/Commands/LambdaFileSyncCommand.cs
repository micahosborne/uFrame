using System;
using System.Reflection;
using System.Text;

namespace Invert.Core.GraphDesigner
{
    public class LambdaFileSyncCommand : LambdaCommand, IFileSyncCommand
    {
        public LambdaFileSyncCommand(string title, Action action) : base(title, action)
        {
        }
    }
}
