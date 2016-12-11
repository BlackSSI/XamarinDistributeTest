using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDistributeSample.Interface
{
    public interface IEventMemberCount
    {
        void TrackUserMetric();

        void TrackCustomEvent(string eventName);
    }
}
