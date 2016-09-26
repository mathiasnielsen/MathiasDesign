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
using System.Threading.Tasks;
using MathiasDesign.Common;

namespace MathiasDesign.Managers
{
    public class NotificationManager : INotificationManager
    {
        private Activity activity;
        private TaskCompletionSource<bool> popupTask;

        private SimpleSnackbarCallBack callback;
        private SimpleOnClickListener listener;

        public NotificationManager(Activity activity)
        {
            this.activity = activity;
        }

        public void MakeNotification(string message)
        {
            var coordinatorLayout = activity.FindViewById<CoordinatorLayout>(Resource.Id.coordinatorLayout);
            var snackBar = Snackbar.Make(coordinatorLayout, message, Snackbar.LengthLong);
            snackBar.Show();
        }

        public Task<bool> MakeNotificationAsync(string message)
        {
            popupTask = new TaskCompletionSource<bool>();

            var coordinatorLayout = activity.FindViewById<CoordinatorLayout>(Resource.Id.coordinatorLayout);
            var snackBar = Snackbar.Make(coordinatorLayout, message, Snackbar.LengthLong);

            callback = new SimpleSnackbarCallBack();
            callback.Dissmissed += OnSnackbarDissmiss;
            snackBar.SetCallback(callback);

            listener = new SimpleOnClickListener(snackBar);
            listener.Clicked += OnClicked;
            snackBar.SetAction("OK", listener);

            snackBar.Show();

            return popupTask.Task;
        }

        private void OnSnackbarDissmiss(object sender, int dissmissType)
        {
            callback.Dissmissed -= OnSnackbarDissmiss;
            listener.Clicked -= OnClicked;

            if (dissmissType != Snackbar.Callback.DismissEventAction)
            {
                popupTask.TrySetResult(false);
            }
        }

        private void OnClicked(object sender, EventArgs e)
        {
            popupTask.TrySetResult(true);
        }
    }
}