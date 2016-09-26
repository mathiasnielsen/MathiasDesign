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
using MathiasDesign.Core.Managers;
using Android.Support.Design.Widget;

namespace MathiasDesign.Managers
{
    public class NotificationManager : INotificationManager
    {
        private Activity activity;

        public NotificationManager(Activity activity)
        {
            this.activity = activity;
        }

        public void MakeNotification()
        {
            ////var snackBar = Snackbar.Make(activity.FindViewById<CoordinatorLayout>(Resource.)
        }
    }
}