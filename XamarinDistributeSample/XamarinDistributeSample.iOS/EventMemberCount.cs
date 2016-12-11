using System;
using System.Collections.Generic;
using System.Text;

using XamarinDistributeSample.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinDistributeSample.iOS.EventMemberCount))]

namespace XamarinDistributeSample.iOS
{
    public class EventMemberCount : IEventMemberCount
    {
        public void TrackCustomEvent(string eventName)
        {
            //throw new NotImplementedException();
        }

        public void TrackUserMetric()
        {
        }
    }
}
