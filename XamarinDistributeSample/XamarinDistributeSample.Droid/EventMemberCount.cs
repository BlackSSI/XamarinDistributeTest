﻿using System;
using XamarinDistributeSample.Interface;
using Microsoft.Azure.Mobile.Analytics;

[assembly:Xamarin.Forms.Dependency(typeof(XamarinDistributeSample.Droid.EventMemberCount))]

namespace XamarinDistributeSample.Droid
{
    public class EventMemberCount : IEventMemberCount
    {
        public void TrackCustomEvent(string eventName)
        {
        }

        public void TrackUserMetric()
        {
        }
    }
}