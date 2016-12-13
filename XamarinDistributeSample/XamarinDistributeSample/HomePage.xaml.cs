using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinDistributeSample.Interface;

namespace XamarinDistributeSample
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public void Button_MemberList_Clicked(object sender, EventArgs e)
        {

            var detailPage = new Page.MemberListPage();
            Navigation.PushAsync(detailPage);
        }

        public void Button_Crash_Clicked(object sender, EventArgs e)
        {
            IEventMemberCount eventCount = DependencyService.Get<IEventMemberCount>(DependencyFetchTarget.NewInstance);
            eventCount.TrackUserMetric();
        }
    }
}
