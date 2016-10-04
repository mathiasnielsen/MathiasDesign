using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using MathiasDesign.Features.Base;
using Android.Support.V4.Widget;
using MathiasDesign.Core.Features.Home;

namespace MathiasDesign.Features.Home
{
    [Activity(Label = "Home")]
    public class HomeView : ViewBase
    {
        private Android.Support.V7.App.ActionBarDrawerToggle drawerToggle;

        protected override int ResourceLayoutId => Resource.Layout.ActivityHome;

        protected override void OnCreate(Bundle bundle)
        {
            var viewModel = new HomeViewModel();

            base.OnCreate(bundle);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            // Set the drawer toggle as the DrawerListener 
            var drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerlayout);
            drawerToggle = new Android.Support.V7.App.ActionBarDrawerToggle(
                this,
                drawerLayout,
                toolbar,
                Resource.String.DrawerOpen,
                Resource.String.DrawerClosed);

            drawerLayout.AddDrawerListener(drawerToggle);

            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            drawerToggle.SyncState();
        }
    }
}