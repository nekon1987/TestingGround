using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Common;
using Common.Enums;

namespace SourceService
{
    [ServiceContract]
    public interface ISourceService
    {
        [OperationContract]
        SourceTestResponse GetDataViaEndpoint(SourceTestRequest request);
    }

    [DataContract]
    public class SourceTestRequest
    {
        [DataMember]
        public int SleepTimeMs { get; set; }

        [DataMember]
        public int AttemptsNumber { get; set; }
        
        [DataMember]
        public TestingStrategy TestingStrategy { get; set; }

        [DataMember]
        public EndpointName EndpointName { get; set; }

    }

    [DataContract]
    public class SourceTestResponse
    {
        [DataMember]
        public string Message { get; set; } = "n/a";
    }
}
