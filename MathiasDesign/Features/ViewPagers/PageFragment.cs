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

namespace MathiasDesign.Features.ViewPagers
{
    public class PageFragment : Android.Support.V4.App.Fragment
    {
        private Color backgroundColor;

        public PageFragment(Color color)
        {
            backgroundColor = color;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            View.SetBackgroundColor(backgroundColor);
        }
    }
}