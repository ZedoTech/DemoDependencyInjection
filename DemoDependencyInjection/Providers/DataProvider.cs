using DemoDependencyInjection.CustomServices;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDependencyInjection.Providers
{
    public class DataProvider : IDataProvider
    {
        private readonly ILogger<DataProvider> _logger;
        public DataProvider(ILogger<DataProvider> logger)
        {
            _logger = logger;
        }
        public void WriteLog()
        {
            _logger.LogError("WriteLog", "Test", "123");
        }
    }
}
