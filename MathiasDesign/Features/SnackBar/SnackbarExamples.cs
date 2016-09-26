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
using Android.Support.Design.Widget;
using MathiasDesign.Common;
using Android.Graphics;

namespace MathiasDesign.Features.SnackBar
{
    [Activity(Label = "Snackbar")]
    public class SnackbarExamples : ViewBase
    {
        private CoordinatorLayout coordinatorLayout;

        protected override int ResourceLayoutId => Resource.Layout.ActivitySnackbarExamples;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            coordinatorLayout = FindViewById<CoordinatorLayout>(Resource.Id.coordinatorLayout);
            var fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            var btnSimpleSnackBar = FindViewById<Button>(Resource.Id.btnSimpleSnackbar);
            var btnActionCallback = FindViewById<Button>(Resource.Id.btnActionCallback);
            var btnCustomView = FindViewById<Button>(Resource.Id.btnCustomSnackbar);

            btnSimpleSnackBar.Click += OnSimpleButtonClicked;
            btnActionCallback.Click += OnActionCallbackClicked;
            btnCustomView.Click += OnCustomViewClicked;
        }

        private void OnSimpleButtonClicked(object sender, EventArgs e)
        {
            var snackBar = Snackbar.Make(coordinatorLayout, "This is a simple snackar", Snackbar.LengthLong);
            snackBar.Show();
        }

        private void OnActionCallbackClicked(object sender, EventArgs e)
        {
            var snackBar = Snackbar.Make(coordinatorLayout, "Message is deleted", Snackbar.LengthLong);

            var listener = new SimpleOnClickListener(snackBar);
            listener.Clicked += OnSnackBarClicked;

            snackBar.SetAction("Undo", listener);
            snackBar.Show();
        }

        private void OnSnackBarClicked(object sender, EventArgs e)
        {
            var snackbar = Snackbar.Make(coordinatorLayout, "Message is restored", Snackbar.LengthLong);
            snackbar.Show();
        }

        private void OnCustomViewClicked(object sender, EventArgs e)
        {
            var snackBar = Snackbar.Make(coordinatorLayout, "No internet connection", Snackbar.LengthLong);

            var listener = new SimpleOnClickListener(snackBar);
            listener.Clicked += OnCustomSnackBarClicked;

            snackBar.SetAction("Undo", listener);
            snackBar.Show();
        }

        private void OnCustomSnackBarClicked(object sender, EventArgs e)
        {
            var snackbar = sender as Snackbar;
            snackbar.SetActionTextColor(Color.Red);

            var view = snackbar.View;
            var textView = view.FindViewById<TextView>(Resource.Id.snackbar_text);
            textView.SetTextColor(Color.Yellow);

            snackbar.Show();
        }
    }
}