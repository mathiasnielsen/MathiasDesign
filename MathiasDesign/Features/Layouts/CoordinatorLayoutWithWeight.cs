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
    [Activity(Label = "CoordinatorLayout with weight")]
    public class CoordinatorLayoutWithWeight : ViewBase
    {
        protected override int ResourceLayoutId
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}