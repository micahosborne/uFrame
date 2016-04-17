using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public interface IShowSelectionMenu
    {
        void ShowSelectionMenu(SelectionMenu menu, Vector2? position = null, bool useWindow = false);
    }
}