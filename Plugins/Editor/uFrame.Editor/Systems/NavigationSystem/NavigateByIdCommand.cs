namespace Invert.Core.GraphDesigner
{
    public class NavigateByIdCommand : Command
    {
        public string Identifier { get; set; }
        public string FilterId { get; set; }
    }
}