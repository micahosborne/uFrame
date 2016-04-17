using System;
using Invert.Data;
using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public interface IGraphItem : IItem, IDataRecord
    {
        string Label { get; }
        bool IsValid { get; }


    }

     
}