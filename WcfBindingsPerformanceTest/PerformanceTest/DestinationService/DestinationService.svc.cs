using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace DestinationService
{
    public class DestinationService : IDestinationService
    {
        private readonly PerformanceTestManager _performanceTestManager = new PerformanceTestManager();

        public DestinationTestResponse GetData(DestinationTestRequest request)
        {
            if (request.SleepTimeMs > 0)
                Thread.Sleep(request.SleepTimeMs);
            
            var response = new DestinationTestResponse()
            {
                Message = "Done"
            };

            response = _performanceTestManager.PerofrmTestBasedOnStrategy(request.TestingStrategy, response);

            return response;
        }
    }
}
