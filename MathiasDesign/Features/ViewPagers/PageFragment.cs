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
using Android.Graphics;
using MathiasDesign.Features.Base;

namespace MathiasDesign.Features.ViewPagers
{
    public class PageFragment : FragmentBase
    {
        private Color backgroundColor;

        public PageFragment(Color color)
        {
            backgroundColor = color;
        }

        protected override int ResourceLayoutId => Resource.Layout.FragmentColorPage;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            View.SetBackgroundColor(backgroundColor);
        }
    }
}