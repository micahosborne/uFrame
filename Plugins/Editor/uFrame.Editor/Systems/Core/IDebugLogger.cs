using System;

namespace Invert.Core
{
    public interface IDebugLogger
    {
        void Log(string message);
        void LogException(Exception ex);
    }
}