using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public interface IKeyboardEvent
    {
        bool KeyEvent(KeyCode keyCode, ModifierKeyState state);
    }
}