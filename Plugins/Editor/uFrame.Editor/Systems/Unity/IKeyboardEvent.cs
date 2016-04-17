using UnityEngine;

namespace Invert.Core.GraphDesigner.Unity
{
    public interface IKeyboardEvent
    {
        bool KeyEvent(KeyCode keyCode, ModifierKeyState state);
    }
}