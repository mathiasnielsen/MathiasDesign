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
    public class SimpleOnClickListener : Java.Lang.Object, View.IOnClickListener
    {
        private Snackbar snackbar;

        public event EventHandler Clicked;

        public SimpleOnClickListener(Snackbar snackbar)
        {
            this.snackbar = snackbar;
        }

        public void OnClick(View view)
        {
            Clicked?.Invoke(snackbar, null);
        }
    }
}