using System;

namespace Invert.Json
{
    public interface IJsonTypeResolver
    {
        Type FindType(string clrTypeString);
    }
}