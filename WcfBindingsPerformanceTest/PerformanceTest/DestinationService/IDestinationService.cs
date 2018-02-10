using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Common;
using Common.Enums;

namespace DestinationService
{
    [ServiceContract]
    public interface IDestinationService
    {
        [OperationContract]
        DestinationTestResponse GetData(DestinationTestRequest composite);
    }

    [DataContract]
    public class DestinationTestRequest
    {
        [DataMember]
        public int SleepTimeMs { get; set; } = 5;
        [DataMember]
        public byte[] PayloadBytes { get; set; }
        [DataMember]
        public TestingStrategy TestingStrategy { get; set; }
    }

    [DataContract]
    public class DestinationTestResponse
    {
        [DataMember]
        public string Message { get; set; } = "n/a";
        [DataMember]
        public byte[] PayloadBytes { get; set; }
    }
}
