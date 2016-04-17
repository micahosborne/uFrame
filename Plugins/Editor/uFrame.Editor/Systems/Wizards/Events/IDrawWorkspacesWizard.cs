using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Systems.Wizards.api
{
    public interface IDrawWorkspacesWizard
    {
        void DrawWorkspacesWizard(IPlatformDrawer platform, Rect bounds);
    }
}
