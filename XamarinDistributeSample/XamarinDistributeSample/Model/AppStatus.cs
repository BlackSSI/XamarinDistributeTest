using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDistributeSample.Model
{
    public class AppStatus
    {
        public NavigationPage _NavPage;

        public Xamarin.Forms.Page GetMainPage()
        {
            var mainPage = new HomePage();

            _NavPage = new NavigationPage(mainPage);

            return _NavPage;
        }
    }
}
