namespace Invert.Json
{
    public interface IJsonObject
    {
        void Serialize(JSONClass cls);
        void Deserialize(JSONClass cls);
    }
}