using System.Collections.Generic;

namespace Invert.Core.GraphDesigner
{
    public interface IDocumentationProvider
    {
        void GetDocumentation(IDocumentationBuilder node);
        void GetPages(List<DocumentationPage> rootPages);

    }
}