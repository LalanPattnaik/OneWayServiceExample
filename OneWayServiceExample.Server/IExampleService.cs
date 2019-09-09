using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OneWayServiceExample.Server
{

    [ServiceContract]
    public interface IExampleService
    {
        [OperationContract]
        long DoWork();

        [OperationContract(IsOneWay = true)]
        void DoOneWayWork();

    }
}
