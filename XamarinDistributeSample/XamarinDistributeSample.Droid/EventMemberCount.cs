using System;
using XamarinDistributeSample.Interface;
using HockeyApp;

[assembly:Xamarin.Forms.Dependency(typeof(XamarinDistributeSample.Droid.EventMemberCount))]

namespace XamarinDistributeSample.Droid
{
    public class EventMemberCount : IEventMemberCount
    {
        public void TrackCustomEvent(string eventName)
        {
            //throw new NotImplementedException();
        }
    }
}