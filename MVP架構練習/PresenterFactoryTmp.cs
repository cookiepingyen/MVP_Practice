using IOCServiceCollection;
using Microsoft.Extensions.DependencyInjection;
using MVP架構練習.Contracts;
using MVP架構練習.Presentser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習
{
    public class PresenterFactoryTmp
    {
        public TPresenter Create<TPresenter, TView>(TView view)
        {
            ServiceProvider provider = Program.provider;
            provider._services.dictiontry.TryGetValue(typeof(TPresenter), out ServiceDescriptor descriptor);
            return (TPresenter)Activator.CreateInstance(descriptor.ImplementationType, view);
        }
    }
}
