using System;
using Invert.Core.GraphDesigner.Systems.GraphUI.api;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Systems.GraphUI
{
    public interface IDrawActionDialog
    {
        void DrawActionDialog(IPlatformDrawer platform, Rect bounds, ActionItem item, Action cancel = null);
    }
}