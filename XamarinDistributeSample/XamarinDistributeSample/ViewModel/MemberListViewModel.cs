using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XamarinDistributeSample.Model;

namespace XamarinDistributeSample.ViewModel
{
    class MemberListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Member> Members { private set; get; }

        public MemberListViewModel(ObservableCollection<Member> members)
        {
            Members = members;
        }
    }
}
