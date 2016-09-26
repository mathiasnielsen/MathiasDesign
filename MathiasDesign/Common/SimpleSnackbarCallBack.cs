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
using Android.Support.Design.Widget;

namespace MathiasDesign.Common
{
    public class SimpleSnackbarCallBack : Snackbar.Callback
    {
        public event EventHandler<int> Dissmissed;

        public override void OnDismissed(Snackbar snackbar, int evt)
        {
            base.OnDismissed(snackbar, evt);
            Dissmissed?.Invoke(snackbar, evt);
        }
    }
}