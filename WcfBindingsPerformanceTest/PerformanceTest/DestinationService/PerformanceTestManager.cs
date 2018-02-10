using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Common;
using Common.Enums;

namespace DestinationService
{
    public class PerformanceTestManager
    {
        private readonly PerformanceTestHelpers _performanceTestHelpers = new PerformanceTestHelpers();

        internal DestinationTestResponse PerofrmTestBasedOnStrategy(TestingStrategy testingStrategy, DestinationTestResponse response)
        {
            switch (testingStrategy)
            {
                case TestingStrategy.SmallPackage:
                case TestingStrategy.LargePackage:
                case TestingStrategy.VeryLargePackage:
                    return ExecuteSizeRelatedStrategy(response, testingStrategy);
            }
            return response;
        }

        private DestinationTestResponse ExecuteSizeRelatedStrategy(DestinationTestResponse response, TestingStrategy testingStrategy)
        {
            response.PayloadBytes = _performanceTestHelpers
                .GenerateRandomPaylad(_performanceTestHelpers.GetTestPayloadSizeForStrategy(testingStrategy));

            return response;
        }
    }
}