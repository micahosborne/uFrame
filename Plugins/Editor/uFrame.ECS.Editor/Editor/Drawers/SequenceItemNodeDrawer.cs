using UnityEditor;
using UnityEngine;

namespace Invert.uFrame.ECS
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;


    public class SequenceItemNodeDrawer : GenericNodeDrawer<SequenceItemNode, SequenceItemNodeViewModel>
    {

        public SequenceItemNodeDrawer(SequenceItemNodeViewModel viewModel) :
            base(viewModel)
        {
        }

        private float _animationTime = 0;
        private DateTime _lastUpdate = DateTime.Now;
        public override void Draw(IPlatformDrawer platform, float scale)
        {
            base.Draw(platform, scale);
            if (EditorApplication.isPaused)
            {
                if (NodeViewModel.GraphItem.Identifier != DebugSystem.CurrentBreakId)
                {
                    var adjustedBounds = new Rect(Bounds.x - 9, Bounds.y + 1, Bounds.width + 19, Bounds.height + 9);
                    platform.DrawStretchBox(adjustedBounds, CachedStyles.BoxHighlighter5, 20);
                }
                else
                {
                    var adjustedBounds = new Rect(Bounds.x - 9, Bounds.y + 1, Bounds.width + 19, Bounds.height + 9);
                    platform.DrawStretchBox(adjustedBounds, CachedStyles.BoxHighlighter3, 20);
                }
            }

            var breakpointItemRect = new Rect().WithSize(24, 24).InnerAlignWithUpperRight(Bounds).Translate(16, -16);
            var deltaTime = (DateTime.Now - _lastUpdate).TotalMilliseconds;
            _lastUpdate = DateTime.Now;


            if (EditorApplication.isPaused && NodeViewModel.GraphItem.Identifier == DebugSystem.CurrentBreakId)
            {
                _animationTime += (float)deltaTime;
                var offset = 8 * Mathf.Cos((_animationTime * 5f) / 1000);
                breakpointItemRect = breakpointItemRect.Translate(offset, -offset);
                //Apply animation to breakpoing item Rect
                platform.DrawImage(breakpointItemRect, "CurrentBreakpointIcon", true);
            }
            else
            {
                if (NodeViewModel.IsBreakpoint)
                {
                    platform.DrawImage(breakpointItemRect, "BreakpointIcon", true);
                }
                _animationTime = 0;


            }
         
        }
    }
}
