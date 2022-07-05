using NUnit.Framework;
using System;

namespace TrafficControl.Test
{
    public class Test
    {
        [Test]
        public void WhentraficStart_ThenStatusGrean()
        {
            var Nextstatus = new SignalController();
            Nextstatus.HandleCustomTrafficStatusChanege(TrafficStatus.Off, g);

            Assert.IsFalse(result, "1 should not be prime");
        }

    }
}
