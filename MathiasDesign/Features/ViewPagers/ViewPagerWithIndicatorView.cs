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
using Android.Support.V4.View;
using MathiasDesign.Features.Base;
using MathiasDesign.Controls.ViewPagers;
using Android.Graphics;
using MathiasDesign.Controls.Adapters;

namespace MathiasDesign.Features.ViewPagers
{
    [Activity (Label = "ViewPager with indicitor")]
    public class ViewPagerWithIndicatorView : ViewBase
    {
        protected override int ResourceLayoutId => Resource.Layout.ActivityViewPagerWithIndicator;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var fragments = new Android.Support.V4.App.Fragment[]
            {
                new PageFragment(Color.PaleGreen),
                new PageFragment(Color.PaleVioletRed),
                new PageFragment(Color.PaleGoldenrod),
            };

            var titles = CharSequence.ArrayFromStringArray(new[]
            {
                "Page 1",
                "Page 2",
                "Page 3"
            });

            var viewpager = FindViewById<ViewPagerWithIndicator>(Resource.Id.viewpager);
            viewpager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments, titles);
            viewpager.PageSelected += OnPageSelected;
        }

        private void OnPageSelected(object sender, ViewPager.PageSelectedEventArgs e)
        {
        }
    }
}