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

namespace MathiasDesign
{
    public class Frame
    {
        public Activity CurrentActivity { get; set; }

        public void NavigateToPage<T>(bool useSingleTop = true, params ActivityFlags[] activityFlags)
        {
            Intent intent = new Intent(CurrentActivity, typeof(T));
            intent.AddFlags(ActivityFlags.NewTask);

            if (useSingleTop)
            {
                intent.AddFlags(ActivityFlags.SingleTop);
            }

            if (activityFlags != null)
            {
                foreach (var flag in activityFlags)
                {
                    intent.AddFlags(flag);
                }
            }

            CurrentActivity.StartActivity(intent);
        }
    }
}