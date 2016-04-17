using System;

namespace Invert.Core
{
    public interface IEventManager
    {
        Action AddListener(object listener);
        void Signal(Action<object> obj);
    }
}