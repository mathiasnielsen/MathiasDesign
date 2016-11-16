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
using MathiasDesign.Features.Base;

namespace MathiasDesign.Features.Layouts
{
    [Activity(Label = "CoordinatorLayout")]
    public class CoordinatorLayoutView : ViewBase
    {
        protected override int ResourceLayoutId => Resource.Layout.ActivityCoordinatorLayout;

        protected override void OnInitializeUIElements()
        {
            base.OnInitializeUIElements();
        }
    }
}