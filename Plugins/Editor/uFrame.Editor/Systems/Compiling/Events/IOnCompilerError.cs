namespace Invert.Core.GraphDesigner
{
    public interface IOnCompilerError
    {
        void Error(ErrorInfo info);
    }
}