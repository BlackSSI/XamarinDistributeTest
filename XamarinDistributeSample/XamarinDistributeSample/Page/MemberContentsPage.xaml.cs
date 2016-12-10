using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinDistributeSample.Model;
using XamarinDistributeSample.ViewModel;

namespace XamarinDistributeSample.Page
{
    public partial class MemberContentsPage : ContentPage
    {
        MemberContentsViewModel _vm;

        public Member TargetMember { set; get; }

        public MemberContentsPage(Member member)
        {
            InitializeComponent();


            //var contents = new ObservableCollection<MemberContent>();
            //contents.Add(new MemberContent { FullName = member.FullName, UserId=member.UserId });

            //var ps = new PlusService();

            //var uas = new UserActivities(ps, member.UserId);
            //var contents = uas.ActivitiesList;

            //_vm = new MemberContentsViewModel(contents);
            //this.BindingContext = _vm;
        }
    }
}
