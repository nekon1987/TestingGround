using System;
using Common.Enums;

namespace Common
{
    public class PerformanceTestHelpers
    {
        public byte[] GenerateRandomPaylad(int size)
        {
            Random random = new Random();
            byte[] seedBuffer = new byte[size];
            int randomWindow = random.Next(0, size);
            byte[] buffer = new byte[size];

            Buffer.BlockCopy(seedBuffer, randomWindow, buffer, 0, size - randomWindow);
            Buffer.BlockCopy(seedBuffer, 0, buffer, size - randomWindow, randomWindow);

            return buffer;
        }

        public byte[] GenerateRandomPayladWithSizeStrategy(TestingStrategy strategy)
        {
            return null;
            // return GenerateRandomPaylad(GetTestPayloadSizeForStrategy(strategy));
        }

        public int GetTestPayloadSizeForStrategy(TestingStrategy strategy)
        {
            switch (strategy)
            {
                case TestingStrategy.SmallPackage: return Constants.PayloadSize.Size1_MB;
                case TestingStrategy.LargePackage: return Constants.PayloadSize.Size10_MB;
                case TestingStrategy.VeryLargePackage: return Constants.PayloadSize.Size100_MB;
            }

            return Constants.PayloadSize.Size1_KB;
        }
    }
}