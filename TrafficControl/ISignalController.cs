using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrafficControl
{
    public interface ISignalController
    {
        public TrafficStatus TrafficStatusChanege(TrafficStatus status);
    }
}
