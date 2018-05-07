using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quartz.Impl
{
    [Serializable]
    public class JobDetailRemoteImpl : JobDetailImpl
    {
        public JobDetailRemoteImpl(string name, string typename)
            : this(name, null, typename)
        {
        }
        public JobDetailRemoteImpl(string name, string group, string typename)
        {
            Name = name;
            Group = group;
            jobTypename = typename;
        }
        public JobDetailRemoteImpl(string name, string group, string typename, bool isDurable, bool requestsRecovery)
        {
            Name = name;
            Group = group;
            jobTypename = typename;
            Durable = isDurable;
            RequestsRecovery = requestsRecovery;
        }
        string jobTypename;
        public string JobTypeName { get { return jobTypename; } }
    }
}
