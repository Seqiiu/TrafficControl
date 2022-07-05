using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrafficControl
{

    public class SignalController : ISignalController
    {

        private TrafficStatus _ActualStatus = TrafficStatus.Off;

        public  TrafficStatus TrafficStatusChanege(TrafficStatus status)
        {
            return status.Next();
        }
         public void  HandleCustomTrafficStatusChanege(TrafficStatus status, EventArgs a)
        {
             _ActualStatus= status.Next();
        }
        ~SignalController()
        {
            _ActualStatus = TrafficStatus.Off;
        }
    }
}
