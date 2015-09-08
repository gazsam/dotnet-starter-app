using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dotnet_starter_app
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWorker" in both code and config file together.
    [ServiceContract]
    public interface IWorker
    {
        [OperationContract]
        void DoWork();
    }
}
