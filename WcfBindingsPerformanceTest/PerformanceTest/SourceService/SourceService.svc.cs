using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SourceService
{
    public class SourceService : ISourceService
    {
        private readonly PerformanceTestManager _performanceTestManager = new PerformanceTestManager();

        public SourceTestResponse GetDataViaEndpoint(SourceTestRequest request)
        {
            return new SourceTestResponse()
            {
                Message = _performanceTestManager.TestGetDataForEndpoint(request).ToString()
            };
        }
    }
}
