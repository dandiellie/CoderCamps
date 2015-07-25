using FourLayerIdentity.Domain.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourLayerIdentity.Infrastructure.Persistence.Repositories;

namespace FourLayerIdentity.Services
{
    public class ServicesDependencies : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository>().To<GenericRepository>();
        }
    }
}
