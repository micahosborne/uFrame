using System;
using Invert.Core;
using UnityEngine;

public interface IDrawTreeView
{
    void DrawTreeView(Rect bounds, TreeViewModel viewModel, Action<Vector2, IItem> itemClicked,
        Action<Vector2, IItem> itemRightClicked = null);
}