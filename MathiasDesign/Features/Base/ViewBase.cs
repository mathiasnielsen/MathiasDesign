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

namespace MathiasDesign.Features.Base
{
    public abstract class ViewBase : AppCompatActivity
    {
        protected abstract int ResourceLayoutId { get; }

        protected override void OnCreate(Bundle bundle)
        {
            var app = ApplicationContext as App;
            app.Frame.CurrentActivity = this;

            base.OnCreate(bundle);

            SetContentView(ResourceLayoutId);
        }
    }
}