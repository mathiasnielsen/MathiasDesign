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

namespace MathiasDesign.Features.Base
{
    public abstract class FragmentBase : Android.Support.V4.App.Fragment
    {
        protected abstract int ResourceLayoutId { get; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}