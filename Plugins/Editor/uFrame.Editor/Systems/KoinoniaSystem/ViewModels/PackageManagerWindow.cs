using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invert.Core.GraphDesigner.Unity.WindowsPlugin;
using Invert.Data;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.ViewModels
{
    public class PackageManagerWindow : WindowViewModel
    {
        private IRepository _repository;

        public IRepository Repository
        {
            get { return _repository ?? (_repository = InvertApplication.Container.Resolve<IRepository>()); }
            set { _repository = value; }
        }

    }
}
