using System.Collections.Generic;
using Invert.Core.GraphDesigner;
using Invert.Data;
using UnityEditor;

namespace Invert.Core.GraphDesigner
{
    public interface ICommandUI
    {
        void AddCommand(ICommand command);
        void Go();
        
        void GoBottom();
    }
}