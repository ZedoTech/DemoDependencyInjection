using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDependencyInjection.Providers
{
    public interface IDataProvider
    {
        void WriteLog();
    }
}
