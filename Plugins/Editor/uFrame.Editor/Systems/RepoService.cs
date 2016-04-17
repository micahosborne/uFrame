using Invert.Data;
using Invert.IOC;

namespace Invert.Core.GraphDesigner
{
    public class RepoService : DiagramPlugin
    {
        
        public IRepository Repository
        {
            get { return Container.Resolve<IRepository>(); }
        }

        public override void Initialize(UFrameContainer container)
        {
            base.Initialize(container);

        }

        public override void Loaded(UFrameContainer container)
        {
            base.Loaded(container);
        }
    }
}