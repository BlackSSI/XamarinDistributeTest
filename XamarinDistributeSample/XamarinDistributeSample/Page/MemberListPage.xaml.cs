﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinDistributeSample.Data;
using XamarinDistributeSample.Model;
using XamarinDistributeSample.ViewModel;
using XamarinDistributeSample.Interface;

using Microsoft.Azure.Mobile.Analytics;


namespace XamarinDistributeSample.Page
{
    public partial class MemberListPage : ContentPage
    {
        public MemberListPage()
        {
            InitializeComponent();

            var list = new MemberList();
            _members = list.CreateList();

            _vm = new MemberListViewModel(_members);
            this.BindingContext = _vm;
        }
        MemberListViewModel _vm;
        Member _member;

        ObservableCollection<Member> _members;
        void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            _member = (Member)e.SelectedItem;

            Analytics.TrackEvent(_member.UserCounterName);

            var detailPage = new Page.MemberContentsPage(_member);
            this.Navigation.PushAsync(detailPage);
        }

        void ShowMessage()
        {
            MessagingCenter.Send(this, "Push!");
        }
    }
}
