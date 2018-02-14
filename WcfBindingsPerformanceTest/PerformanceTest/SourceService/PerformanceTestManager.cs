using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Common;
using DestinationService;

namespace SourceService
{
    internal class PerformanceTestManager
    {
        private readonly PerformanceTestHelpers _performanceTestHelpers = new PerformanceTestHelpers();
        
        internal TimeSpan TestGetDataForEndpoint(SourceTestRequest request)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (var i = 0; i < request.AttemptsNumber; i++)
            {
                    DestinationServiceClient dest = new DestinationServiceClient(request.EndpointName.ToString());
                //DestinationServiceClient dest = new DestinationServiceClient("BasicHttpsBinding_IDestinationService");
             
                var response = dest.GetData(new DestinationTestRequest()
                {
                    SleepTimeMs = request.SleepTimeMs,
                    TestingStrategy = request.TestingStrategy,
                    PayloadBytes = _performanceTestHelpers.GenerateRandomPayladWithSizeStrategy(request.TestingStrategy)
                });
                dest.Close();
            }

            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}